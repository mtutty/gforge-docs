using System;
using System.Collections.Generic;

using GForgeDocWindow.Util;
using System.ComponentModel;
using System.Net;

namespace GForgeDocWindow.Actions {
    public class DownloadProjectWorker : BackgroundWorker {

        private GForgeProxy proxy;
        private LocalFileService lfs;
        private int project_id;
        private string targetFolder;
        private int percentComplete = 0;
        private int increment = 1;

        public string Error { get; set; }

        public DownloadProjectWorker()
            : base() {
            this.DoWork += new DoWorkEventHandler(DownloadProjectWorker_DoWork);
            this.WorkerReportsProgress = true;
        }

        public DownloadProjectWorker(LocalFileService lfs, GForgeProxy proxy, int project_id, string targetFolder)
            : this() {
            this.lfs = lfs;
            this.proxy = proxy;
            this.project_id = project_id;
            this.targetFolder = targetFolder;
        }

        public void DownloadProjectWorker_DoWork(object sender, DoWorkEventArgs e) {
            try {
                this.lfs.EnsureFolderExists(this.targetFolder);

                if (! this.CheckProgress(@"Retrieving the list of folders for this project...")) {
                    return;
                }
                DocmanFolder[] folders = this.proxy.getDocmanFolders(this.proxy.Token, this.project_id);
                IList<DocmanFolder> rootFolders = BuildFolderTree(folders);

                this.increment = 100 / folders.Length;

                this.SyncFolders(rootFolders, this.targetFolder);
            } catch (Exception ex) {
                this.Error = ex.Message;
                throw;
            }
        }

        private IList<DocmanFolder> BuildFolderTree(DocmanFolder[] folders) {

            Dictionary<int, DocmanFolder> sortingHat = new Dictionary<int, DocmanFolder>();
            IList<DocmanFolder> ret = new List<DocmanFolder>();

            // Rip through once, building a keyed listing for future reference
            foreach (DocmanFolder fld in folders) {
                sortingHat.Add(fld.docman_folder_id, fld);
            }

            // Go through again, adding children to parent listings
            foreach (DocmanFolder fld in folders) {
                // If it's a root folder, add to the ret collection
                if (fld.parent_folder_id == 0) {
                    ret.Add(fld);
                } else {
                    DocmanFolder parent = sortingHat[fld.parent_folder_id];
                    if (parent == null) 
                        throw new InvalidOperationException(string.Format(@"Folder {0} (id {1}) references a non-existent parent folder {2}", fld.folder_name, fld.docman_folder_id, fld.parent_folder_id));
                    parent.ChildFolders.Add(fld);
                }
            }

            return ret;
        }

        private bool CheckProgress(string template, params object[] values) {
            return CheckProgress(string.Format(template, values));
        }

        private bool CheckProgress(string msg) {
            this.ReportProgress(this.percentComplete, msg);
            return (this.CancellationPending == false);
        }

        private bool IncrementProgress(string template, params object[] values) {
            return IncrementProgress(string.Format(template, values));
        }

        private bool IncrementProgress(string msg) {
            this.percentComplete += this.increment;
            this.ReportProgress(this.percentComplete, msg);
            return (this.CancellationPending == false);
        }

        private void SyncFolders(IList<DocmanFolder> folders, string basePath) {

            foreach (DocmanFolder folder in folders) {
                if (!this.IncrementProgress(@"Retrieving content for {0}...", folder.folder_name)) {
                    return;
                }
                this.SyncFolder(folder, basePath);
            }
        }

        private void SyncFolder(DocmanFolder folder, string basePath) {
            string folderPath = lfs.BuildPath(basePath, folder.folder_name);
            this.lfs.EnsureFolderExists(folderPath);
            LocalFileService.SyncFolderInfo sync = lfs.GetFolderInfo(folderPath);
            if (sync == null) {
                sync = new LocalFileService.SyncFolderInfo(this.proxy.ServerURL, folder.project_id.ToString(), folder.docman_folder_id.ToString(), null);
            }

            DocmanFile[] files = this.proxy.getDocmanFiles(this.proxy.Token, folder.docman_folder_id);
            for (int i = 0; i < files.Length; i++) {
                DocmanFile file = files[i];
                if (! this.CheckProgress(@"Checking file {0} of {1} ({2})...", i, files.Length, file.description)) {
                    return;
                }
                try {
                    DocmanFileVersion[] versions = this.proxy.getDocmanFileVersions(this.proxy.Token, file.docman_file_id);
                    if (versions.Length > 0) {
                        Array.Sort(versions, (ver1, ver2) => ver1.version_number.CompareTo(ver2.version_number));
                        DocmanFileVersion version = versions[versions.Length - 1];

                        DateTime lastChanged = DateTime.Parse(version.create_date);
                        string localFile = lfs.BuildPath(folderPath, version.filename);

                        if (lfs.IsRemoteFileUpdated(localFile, lastChanged)) {
                            if (! this.CheckProgress(@"Checking file {0} of {1} ({2}), updating local copy...", i, files.Length, file.description)) {
                                return;
                            }
                            UpdateLocalFile(version.docman_file_id, localFile, lastChanged);
                        }
                    }

                } catch (Exception ex) {
                    this.Error += string.Format("{0}\\{1}: {2}\n", folderPath, file.description, ex.Message);
                }
            }
            // Child folder sync
            this.SyncFolders(folder.ChildFolders, folderPath);

            sync.LastSync = DateTime.Now;
            lfs.WriteFolderInfo(sync, folderPath);
        }

        public void UpdateLocalFile(int docId, string destinationFile, DateTime lastChanged) {
            Filesystem file = this.proxy.getFilesystem(this.proxy.Token, docId);
            lfs.DownloadFile(file.download_url, destinationFile, lastChanged);
        }

    }
}
