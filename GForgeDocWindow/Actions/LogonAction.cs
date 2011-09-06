using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GForgeDocWindow.Util;

namespace GForgeDocWindow.Actions {
    public partial class LogonAction : ActionDialogBase {

        public string UserID { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public GForgeProxy Proxy { get; private set; }
        public string Error { get; set; }

        public LogonAction() : base() { }

        public LogonAction(string url, string userID, string password) : this() {
            this.Url = url;
            this.UserID = userID;
            this.Password = password;
        }

        protected override void DoAction() {
            try {
                if (this.Cancelled) {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    return;
                }
                this.SetStatus(string.Format(@"Contacting the GForge server at {0}", this.Url));
                this.Proxy = new GForgeProxy(this.Url, this.UserID);

                if (this.Cancelled) {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    return;
                }

                this.SetStatus(string.Format(@"Logging in as {0}", this.UserID));
                string token = this.Proxy.login(this.UserID, this.Password);

                if (this.Cancelled) {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    return;
                }

                this.Proxy.Token = token;
                this.SetStatus(string.Format(@"Success! Logged in as {0}", this.UserID));

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            } catch (Exception ex) {
                this.Error = ex.Message;
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

    }
}
