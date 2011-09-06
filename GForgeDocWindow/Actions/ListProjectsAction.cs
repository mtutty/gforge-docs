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
    public partial class ListProjectsAction : ActionDialogBase {

        public GForgeProxy Proxy { get; private set; }
        public string Error { get; set; }
        public IList<Project> Projects { get; private set; }

        public ListProjectsAction() {
            InitializeComponent();
        }

        public ListProjectsAction(GForgeProxy proxy) : this() {
            this.Proxy = proxy;
        }

        protected override void DoAction() {
            try {
                if (this.Cancelled) {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    return;
                }

                string msg = string.Format(@"Retrieving the list of projects for {0}", this.Proxy.UserID);
                this.SetStatus(msg);
                this.Projects = this.Proxy.getUserProjects(this.Proxy.Token, this.Proxy.UnixName);

                if (this.Cancelled) {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    return;
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            } catch (Exception ex) {
                this.Error = ex.Message;
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }
    }
}
