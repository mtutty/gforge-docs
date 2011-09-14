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

        private IList<Project> projects = null;
        public Project SelectedProject { get; set; }

        public SelectProjectDialog(IList<Project> projects) {
            InitializeComponent();
            this.projects = projects;
            FillList();
        }

        private void FillList() {
            this.lvProjects.SuspendLayout();
            this.lvProjects.Items.Clear();

            IEnumerable<Project> listToShow = null;
            if (this.FilterText.Text.Length == 0) {
                listToShow = this.projects;
            } else if (this.FilterText.Text.Length < 3) {
              listToShow  = this.projects.Where<Project>(p => p.project_name.ToLower().StartsWith(this.FilterText.Text.ToLower()));
            } else {
                listToShow = this.projects.Where<Project>(p => p.project_name.ToLower().Contains(this.FilterText.Text.ToLower()));
            }

            foreach (Project p in listToShow) {
                ListViewItem item = new ListViewItem(p.project_name);
                item.Tag = p;
                this.lvProjects.Items.Add(item);
            }
            this.lvProjects.ResumeLayout();
        }

        private void SelectProjectDialog_Validating(object sender, CancelEventArgs e) {
            SelectedProject = null;
            if (this.lvProjects.SelectedItems.Count > 0) {
                SelectedProject = this.lvProjects.SelectedItems[0].Tag as Project;
            }
            if (SelectedProject == null) {
                MessageBox.Show(this, this.Text, @"You must select a GForge Project from the list.  Click Cancel if you want to quit without selecting a Project.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Cancel = true;
            }
        }

        private void FilterText_TextChanged(object sender, EventArgs e) {
            FillList();
        }

    }
}
