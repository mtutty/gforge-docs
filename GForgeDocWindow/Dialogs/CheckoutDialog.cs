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
        public Project SelectedProject { get; protected set; }
        public IList<Project> Projects { get; protected set; }

        public CheckoutDialog() {
            InitializeComponent();
        }

        public CheckoutDialog(IList<Project> projects, string basePath) : this() {
            this.BasePath = basePath;
            this.Projects = projects;
            this.CurrentFolder.Text = string.Format(@"Current Folder: {0}", this.BasePath);
            this.ProjectList.DisplayMember = @"project_name";
            this.ProjectList.DataSource = this.Projects;
        }

        private void CustomName_CheckedChanged(object sender, EventArgs e) {
            this.CustomPath.Enabled = (this.CustomName.Checked);
        }

        private void ProjectList_SelectedIndexChanged(object sender, EventArgs e) {
            SelectedProject = ProjectList.SelectedItem as Project;
            SetPathOptions();
        }

        private void SetPathOptions() {
            string longName = @"Project Name";
            string shortName = "project";

            if (SelectedProject != null) {
                longName = SelectedProject.project_name;
                shortName = SelectedProject.unix_name;
            }

            this.ProjectName.Text = string.Format(@"Project Name: {0}", longName);
            this.UnixName.Text = string.Format(@"Short Name: {0}", shortName);
        }

        private void CustomPath_Validating(object sender, CancelEventArgs e) {
            if (this.CustomName.Checked &&
                string.IsNullOrWhiteSpace(this.CustomPath.Text)) {
                this.errorProvider1.SetError((Control)sender, @"You must enter a custom path for this option, or choose another option");
                e.Cancel = true;
            }
        }

        private void ProjectList_Validating(object sender, CancelEventArgs e) {
            if (this.ProjectList.SelectedItem == null) {
                this.errorProvider1.SetError((Control)sender, @"You must select a Project from the list.");
                e.Cancel = true;
            }
        }

        private void OKButton_Click(object sender, EventArgs e) {
            this.errorProvider1.Clear();
            if (this.ValidateChildren()) this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private DialogResult ValidateControls(ControlCollection controls) {
            foreach (Control control in this.Controls) {
                // Set focus on control
                if (control.Controls.Count > 0)
                    if (!control.Enabled || !control.CanFocus) continue;
                control.Focus();
                // Validate causes the control's Validating event to be fired,
                // if CausesValidation is True
                if (!Validate()) {
                    return DialogResult.None;
                }
            }
            return DialogResult.OK;
        }

    }
}
