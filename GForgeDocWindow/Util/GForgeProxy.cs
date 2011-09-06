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


    }
}
