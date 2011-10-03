using System;
using System.Collections.Generic;
using System.Text;

namespace GForgeDocWindow.Util {
    public class GForgeProxy : GForgeAPI  {

        public const string FILESYS_SECTION_DOCMAN = @"docmanfileversion";

        public GForgeProxy(string url, string userid) {
            this.ServerURL = url;
            this.UserID = userid;
            this.Url = this.ProxyURL;
        }

        public string ProxyURL {
            get {
                return this.ServerURL + @"/gf/xmlcompatibility/soap5/";
            }
        }

        private string url = string.Empty;

        public string ServerURL {
            get {
                return this.url;
            }

            protected set {
                this.url = value;
                // Remove trailing slash for ease of use later
                if (this.url.EndsWith(@"/"))
                    this.url = this.url.Substring(0, this.url.Length - 1);
            }
        }

        private string userID;

        public string UserID {
            get { return userID; }
            set { userID = value; }
        }

        public string UnixName {
            get {
                string[] pieces = this.UserID.Split('@');
                string ret = string.Empty;
                if (pieces.Length > 0) {
                    ret = pieces[0].Replace(@".", @"");
                    if (ret.Length > 15) ret = ret.Substring(0, 15);
                }
                return ret;
            }
        }

        private string token;

        public string  Token {
            get { return token; }
            set { token = value; }
        }

        public IList<DocmanFolder> BuildFolderTree(DocmanFolder[] folders) {

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

    }
}
