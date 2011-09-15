﻿using System;
using System.IO;

namespace GForgeDocWindow.Util {
    public class LocalFileService {
        public class SpecialNames {
            public const string StateFolder = @".gfdocs";
            public const string RepositoryFile = @"repository";
            public const string ForgeHost = @"host";
            public const string ForgeProjectID = @"project";
            public const string ForgeFolderID = @"folder";
            public const string Delimiter = @"=";
        }

        public class SyncFolderInfo {
            public string Host { get; set; }
            public string ProjectID { get; set; }
            public string FolderID { get; set; }
            public DateTime? LastSync { get; set; }
        }

        public bool IsSyncedFolder(string path) {
            if (Directory.Exists(path) == false) return false;
            if (Directory.Exists(StateFolderFor(path)) == false) return false;
            if (File.Exists(RepositoryFileFor(path)) == false) return false;
            return true;
        }

        public string StateFolderFor(string path) {
            return Path.Combine(path, SpecialNames.StateFolder);
        }

        public string RepositoryFileFor(string path) {
            return Path.Combine(StateFolderFor(path), SpecialNames.RepositoryFile);
        }

        public SyncFolderInfo GetFolderInfo(string path) {
            if (IsSyncedFolder(path) == false) return null;
            string repoFile = RepositoryFileFor(path);
            SyncFolderInfo ret = new SyncFolderInfo() {
                LastSync = File.GetLastWriteTime(repoFile)
            };
            string[] contents = File.ReadAllLines(repoFile);
            foreach (string line in contents) {
                if (line.StartsWith(SpecialNames.ForgeHost)) {
                    ret.Host = RepoValue(SpecialNames.ForgeHost, line);
                } else if (line.StartsWith(SpecialNames.ForgeProjectID)) {
                    ret.Host = RepoValue(SpecialNames.ForgeProjectID, line);
                } else if (line.StartsWith(SpecialNames.ForgeFolderID)) {
                    ret.Host = RepoValue(SpecialNames.ForgeFolderID, line);
                }
            }
            return ret;
        }

        public void WriteFolderInfo(SyncFolderInfo info, string path) {
            if (IsSyncedFolder(path) == false) {
                Directory.CreateDirectory(StateFolderFor(path)).Attributes = FileAttributes.Hidden;
            }
            File.WriteAllLines(RepositoryFileFor(path), CreateRepoLines(info));
            File.SetLastWriteTime(RepositoryFileFor(path), DateTime.Now);
        }

        public bool HasChanges(string location, bool recursive) {
            if (IsSyncedFolder(location)) {
                DateTime repoDate = File.GetLastWriteTime(RepositoryFileFor(location));
                foreach (string fileName in Directory.EnumerateFiles(location)) {
                    if (IsFileUpdated(fileName, repoDate)) return true;
                }
                if (recursive) {
                    foreach (string dirName in Directory.EnumerateDirectories(location)) {
                        if (HasChangesInternal(dirName, recursive)) return true;
                    }
                }
            }
            return false;
        }

        private bool IsFileUpdated(string fileName, DateTime baseline) {
            if (File.GetLastWriteTime(fileName) > baseline ||
                File.GetCreationTime(fileName) > baseline) {
                return true;
            }
            return false;
        }

        private bool HasChangesInternal(string location, bool recursive) {
            if (IsSyncedFolder(location)) {
                DateTime repoDate = File.GetLastWriteTime(RepositoryFileFor(location));
                foreach (string fileName in Directory.EnumerateFiles(location)) {
                    if (IsFileUpdated(fileName, repoDate)) return true;
                }
                if (recursive) {
                    foreach (string dirName in Directory.EnumerateDirectories(location)) {
                        if (HasChangesInternal(dirName, recursive)) return true;
                    }
                }
                return false;
            }
            // RMT return true here since this is the child of a synced folder
            // If this folder is not synced, it's new and needs to be added
            return true;
        }

        private string[] CreateRepoLines(SyncFolderInfo info) {
            return new string[] {
                RepoLine(SpecialNames.ForgeHost, info.Host),
                RepoLine(SpecialNames.ForgeProjectID, info.ProjectID),
                RepoLine(SpecialNames.ForgeFolderID, info.FolderID)
            };
        }

        private string RepoLine(string key, string value) {
            return string.Format(@"{0}{1}", RepoKeyPrefix(key), value);
        }

        private string RepoKeyPrefix(string key) {
            return string.Format(@"{0}{1}", key, SpecialNames.Delimiter);
        }

        private string RepoValue(string key, string line) {
            return line.Replace(RepoKeyPrefix(key), @"").Trim();
        }
    }
}