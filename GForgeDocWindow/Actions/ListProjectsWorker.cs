using System;
using System.Collections.Generic;

using GForgeDocWindow.Util;
using System.ComponentModel;

namespace GForgeDocWindow.Actions {
    public class ListProjectsWorker : BackgroundWorkerBase {

        public GForgeProxy Proxy { get; private set; }
        public IList<Project> Projects { get; private set; }

        public ListProjectsWorker() : base() { }

        public ListProjectsWorker(GForgeProxy proxy)
            : this() {
            this.Proxy = proxy;
        }

        public override void Work() {
            if (!this.CheckProgress(10, @"Retrieving the list of projects for {0}", this.Proxy.UserID)) return;
            this.Projects = this.Proxy.getUserProjects(this.Proxy.Token, this.Proxy.UnixName);
            if (!this.CheckProgress(90, @"Retrieved the list of projects for {0}", this.Proxy.UserID)) return;
        }

    }
}
