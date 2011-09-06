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
    public partial class SelectProjectDialog : Form {

        public Project SelectedProject { get; set; }

        public SelectProjectDialog(IList<Project> projects) {
            InitializeComponent();
            FillList(projects);
        }

        private void FillList(IList<Project> projects) {
            this.ProjectList.Items.Clear();

            this.ProjectList.DisplayMember = @"project_name";
            this.ProjectList.ValueMember = @"project_id";
            foreach (Project p in projects) {
                this.ProjectList.Items.Add(p);
            }
            this.ProjectList.Sorted = true;
        }

        private void SelectProjectDialog_Validating(object sender, CancelEventArgs e) {
            SelectedProject = this.ProjectList.SelectedItem as Project;
            if (SelectedProject == null) {
                MessageBox.Show(this, this.Text, @"You must select a GForge Project from the list.  Click Cancel if you want to quit without selecting a Project.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Cancel = true;
            }
        }

    }
}
