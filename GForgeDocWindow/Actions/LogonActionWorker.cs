using System;
using System.Collections.Generic;

using GForgeDocWindow.Util;
using System.ComponentModel;

namespace GForgeDocWindow.Actions {
    public class LogonActionWorker : BackgroundWorker {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public GForgeProxy Proxy { get; private set; }
        public string Error { get; set; }

        public LogonActionWorker() : base() {
            this.DoWork += new DoWorkEventHandler(LogonActionWorker_DoWork);
        }

        public LogonActionWorker(string url, string userID, string password)
            : this() {
            this.Url = url;
            this.UserID = userID;
            this.Password = password;
        }

        public void LogonActionWorker_DoWork(object sender, DoWorkEventArgs e) {
            try {
                if (this.CancellationPending) {
                    return;
                }

                this.ReportProgress(10, string.Format(@"Contacting the GForge server at {0}", this.Url));
                this.Proxy = new GForgeProxy(this.Url, this.UserID);

                if (this.CancellationPending) {
                    return;
                }

                this.ReportProgress(15, string.Format(@"Logging in as {0}", this.UserID));
                string token = this.Proxy.login(this.UserID, this.Password);

                if (this.CancellationPending) {
                    return;
                }

                this.Proxy.Token = token;
                this.ReportProgress(90, string.Format(@"Success! Logged in as {0}", this.UserID));

            } catch (Exception ex) {
                this.Error = ex.Message;
            }
        }
    }
}
