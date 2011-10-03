using System;
using System.Collections.Generic;

using GForgeDocWindow.Util;
using System.ComponentModel;
using System.Net;

namespace GForgeDocWindow.Actions {
    public class DownloadProjectWorker : BackgroundWorkerBase {

        private GForgeProxy proxy;
        private LocalFileService lfs;
        private int project_id;
        private string targetFolder;

        public DownloadProjectWorker() : base() { }

        public DownloadProjectWorker(LocalFileService lfs, GForgeProxy proxy, int project_id, string targetFolder)
            : this() {
            this.lfs = lfs;
            this.proxy = proxy;
            this.project_id = project_id;
            this.targetFolder = targetFolder;
        }

        public override void Work() {
            this.lfs.EnsureFolderExists(this.targetFolder);

            if (!this.CheckProgress(@"Retrieving the list of folders for this project...")) return;

            DocmanFolder[] folders = this.proxy.getDocmanFolders(this.proxy.Token, this.project_id);
            IList<DocmanFolder> rootFolders = this.proxy.BuildFolderTree(folders);

            this.Increment = 100 / folders.Length;

            this.SyncFolders(rootFolders, this.targetFolder);
        }

        private void SyncFolders(IList<DocmanFolder> folders, string basePath) {

            foreach (DocmanFolder folder in folders) {
                if (!this.IncrementProgress(@"Retrieving content for {0}...", folder.folder_name)) return;
                this.SyncFolder(folder, basePath);
            }

            LocalFileService.SyncFolderInfo sync = lfs.GetFolderInfo(basePath);
            if (sync == null) {
                sync = new LocalFileService.SyncFolderInfo(this.proxy.ServerURL, this.project_id.ToString(), @"0", DateTime.Now);
            }
            this.lfs.WriteFolderInfo(sync, basePath);

        }

        // RMT: Data references go: project_id -> docman_folder_id ->docman_file_id -> docman_file_version_id -> filesystem ref_id
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
                if (!this.CheckProgress(@"Checking file {0} of {1} ({2})...", i+1, files.Length, file.description))  return;

                try {
                    DocmanFileVersion[] versions = this.proxy.getDocmanFileVersions(this.proxy.Token, file.docman_file_id);
                    if (versions.Length > 0) {
                        Array.Sort(versions, (ver1, ver2) => ver1.version_number.CompareTo(ver2.version_number));
                        DocmanFileVersion version = versions[versions.Length - 1];

                        DateTime lastChanged = DateTime.Parse(version.create_date);
                        string localFile = lfs.BuildPath(folderPath, version.filename);
                        if (lfs.IsRemoteFileUpdated(localFile, lastChanged)) {
                            if (!this.CheckProgress(@"Checking file {0} of {1} ({2}), updating local copy...", i+1, files.Length, this.lfs.TrimPath(file.description, 20))) return;

                            UpdateLocalFile(version.docman_file_version_id, localFile, lastChanged);
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
            Filesystem[] files = this.proxy.getFilesystems(this.proxy.Token, GForgeProxy.FILESYS_SECTION_DOCMAN, docId);
            if (files.Length > 0) {
                //FilesystemData data = this.proxy.getFilesystemData(this.proxy.Token, file.filesystem_id);
                //this.lfs.WriteFile(destinationFile, data.file_data, lastChanged);
                Filesystem file = files[0];
                this.lfs.DownloadFile(this.proxy.ServerURL + file.download_url, destinationFile, this.proxy.Token, lastChanged);
            }
        }

    }
}
