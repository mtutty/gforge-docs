using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GForgeDocWindow.Util;

namespace GForgeDocWindow.Dialogs {
    public partial class CheckoutDialog : Form {

        public string BasePath { get; protected set; }
        public string SelectedPath { get; protected set; }
        public IList<Project> Projects { get; protected set; }

        public CheckoutDialog() {
            InitializeComponent();
        }

        public CheckoutDialog(IList<Project> projects, string basePath) : this() {
            this.BasePath = basePath;
            this.Projects = projects;
            this.CurrentFolder.Text = string.Format(@"Current Folder: {0}", this.BasePath);
        }

        private void CustomName_CheckedChanged(object sender, EventArgs e) {
            this.CustomPath.Enabled = (this.CustomName.Checked);
        }

    }
}
