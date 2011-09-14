using System;
using System.Collections.Generic;

using GForgeDocWindow.Util;
using System.ComponentModel;

namespace GForgeDocWindow.Actions {
    public class ListProjectsWorker : BackgroundWorker {

        public GForgeProxy Proxy { get; private set; }
        public IList<Project> Projects { get; private set; }
        public string Error { get; set; }

        public ListProjectsWorker() : base() {
            this.DoWork += new DoWorkEventHandler(ListProjectsWorker_DoWork);
            this.WorkerReportsProgress = true;
        }

        public ListProjectsWorker(GForgeProxy proxy)
            : this() {
                this.Proxy = proxy;
        }

        public void ListProjectsWorker_DoWork(object sender, DoWorkEventArgs e) {
            try {
                if (this.CancellationPending) {
                    return;
                }

                this.ReportProgress(10, string.Format(@"Retrieving the list of projects for {0}", this.Proxy.UserID));
                this.Projects = this.Proxy.getUserProjects(this.Proxy.Token, this.Proxy.UnixName);

                if (this.CancellationPending) {
                    return;
                }

            } catch (Exception ex) {
                this.Error = ex.Message;
                throw;
            }
        }

    }
}
