using System;
using System.Collections.Generic;

using GForgeDocWindow.Util;
using System.ComponentModel;

namespace GForgeDocWindow.Actions {
    public class DownloadProjectWorker : BackgroundWorker {

        private GForgeProxy proxy;
        private LocalFileService lfs;
        private int project_id;
        private string targetFolder;
        private int percentComplete = 0;

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

                if (! this.CheckProgress(0, @"Retrieving the list of folders for this project...")) {
                    return;
                }
                DocmanFolder[] folders = this.proxy.getDocmanFolders(this.proxy.Token, this.project_id);

                int increment = 100 / folders.Length;
                int parentID = 0;
                this.percentComplete = 0;
                // TODO Order these flat records into a tree so we can process them
                foreach (DocmanFolder folder in folders) {
                    if (! this.CheckProgress(this.percentComplete, @"Retrieving content for {0}...", folder.folder_name)) {
                        return;
                    }
                    this.SyncFolder(folder, this.targetFolder);
                    this.percentComplete += increment;
                }

            } catch (Exception ex) {
                this.Error = ex.Message;
                throw;
            }
        }

        private bool CheckProgress(int percentComplete, string template, params object[] values) {
            return CheckProgress(percentComplete, string.Format(template, values));
        }

        private bool CheckProgress(int percentComplete, string msg) {
            this.ReportProgress(this.percentComplete, msg);
            return (this.CancellationPending == false);
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
                if (! this.CheckProgress(this.percentComplete, @"Checking file {0} of {1} ({2})...", i, files.Length, file.description)) {
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
                            if (! this.CheckProgress(this.percentComplete, @"Checking file {0} of {1} ({2}), updating local copy...", i, files.Length, file.description)) {
                                return;
                            }
                            UpdateLocalFile(version.docman_file_id, localFile, lastChanged);
                        }
                    }

                } catch (Exception ex) {
                    this.Error += string.Format("{0}\\{1}: {2}\n", folderPath, file.description, ex.Message);
                }
            }
            sync.LastSync = DateTime.Now;
            lfs.WriteFolderInfo(sync, folderPath);
        }

        public void UpdateLocalFile(int docId, string destinationFile, DateTime lastChanged) {
            FilesystemData data = this.proxy.getFilesystemData(this.proxy.Token, docId);
            lfs.WriteFile(destinationFile, data.file_data, lastChanged);
        }

    }
}
