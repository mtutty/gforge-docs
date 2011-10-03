using System;
using System.Collections.Generic;

using GForgeDocWindow.Util;
using System.ComponentModel;

namespace GForgeDocWindow.Actions {
    public class LogonActionWorker : BackgroundWorkerBase {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public GForgeProxy Proxy { get; private set; }

        public LogonActionWorker() : base() { }

        public LogonActionWorker(string url, string userID, string password)
            : this() {
            this.Url = url;
            this.UserID = userID;
            this.Password = password;
        }

        public override void Work() {
            if (!this.CheckProgress(10, @"Contacting the GForge server at {0}", this.Url)) return;
            this.Proxy = new GForgeProxy(this.Url, this.UserID);

            if (!this.CheckProgress(15, @"Logging in as {0}", this.UserID)) return;
            string token = this.Proxy.login(this.UserID, this.Password);

            this.Proxy.Token = token;
            if (!this.CheckProgress(90, @"Success! Logged in as {0}", this.UserID)) return;
        }
    }
}
