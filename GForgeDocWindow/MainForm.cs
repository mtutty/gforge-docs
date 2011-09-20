using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;

using GForgeDocWindow.Util;
using GForgeDocWindow.Actions;
using GForgeDocWindow.Dialogs;

namespace GForgeDocWindow {
    public partial class MainForm : Form {

        private ShellObject currentLocation = null;
        private GForgeProxy proxy = null;
        private IList<Project> projects = null;
        private LocalFileService lfs = new LocalFileService();

        public MainForm(string startPath) {
            InitializeComponent();

            if (Directory.Exists(startPath)) {
                currentLocation = ShellFileSystemFolder.FromFolderPath(startPath);
            } else {
                string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (Directory.Exists(myDocs)) {
                    currentLocation = ShellFileSystemFolder.FromFolderPath(myDocs);
                } else {
                    currentLocation = ShellFileSystemFolder.FromFolderPath(Application.StartupPath);
                }

                string msg = string.Format(@"Sorry, the path you requested ({0}) does not exist.  Starting in {1} instead.", startPath, currentLocation.Name);
                MessageBox.Show(msg, @"Invalid Starting Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (currentLocation != null)
                this.Browser.Navigate(currentLocation);
        }

        public MainForm() : this(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) { }

        private void MainForm_Shown(object sender, EventArgs e) {
            // Nothing
        }

        private void Browser_ItemsChanged(object sender, EventArgs e) {
            Console.WriteLine(string.Format(@"Items Changed in {0}", currentLocation.ParsingName));
        }

        private void Browser_NavigationComplete(object sender, Microsoft.WindowsAPICodePack.Controls.NavigationCompleteEventArgs e) {
            currentLocation = e.NewLocation;
            SetToolBarStatus(currentLocation.ParsingName);
            this.Text = currentLocation.ParsingName;
        }

        private void SetToolBarStatus(string location) {
            try {
                this.TopToolStrip.SuspendLayout();
                this.GForgeActiveLabel.Enabled = lfs.IsSyncedFolder(location);
                if (this.GForgeActiveLabel.Enabled) {
                    this.ChangedLabel.Enabled = lfs.HasChanges(location, true);
                    this.SyncButton.Enabled = true;
                    this.CheckOutButton.Enabled = false;
                } else {
                    this.ChangedLabel.Enabled = false;
                    this.SyncButton.Enabled = false;
                    this.CheckOutButton.Enabled = true;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);

                this.SyncButton.Enabled = false;
                this.CheckOutButton.Enabled = false;
                this.GForgeActiveLabel.Enabled = false;
                this.ChangedLabel.Enabled = false;

            } finally {
                this.TopToolStrip.ResumeLayout();
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e) {
            if (CheckProjectList()) {
                CheckoutDialog dialog = new CheckoutDialog(this.projects, this.currentLocation.ParsingName);
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                    DownloadProjectWorker dpw = new DownloadProjectWorker(this.lfs, this.proxy, dialog.SelectedProject.project_id, Path.Combine(dialog.BasePath, dialog.SelectedPath));
                    switch (BackgroundWorkerDialog.Run(@"Sync Project Docs", dpw, this)) {
                        case System.Windows.Forms.DialogResult.OK:
                            return;
                        case System.Windows.Forms.DialogResult.Cancel:
                            string msg = @"The sync process was canceled.  Some folders and files may be missing or out-of-date.";
                            MessageBox.Show(this, msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        case System.Windows.Forms.DialogResult.Abort:
                            MessageBox.Show(this, dpw.Error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                }
            }
        }

        private bool CheckProjectList() {
            if (CheckLogon()) {
                if (this.projects == null) {
                    System.Windows.Forms.Application.DoEvents();
                    ListProjectsWorker action = new ListProjectsWorker(this.proxy);
                    switch (BackgroundWorkerDialog.Run(@"Project List", action, this)) {
                        case System.Windows.Forms.DialogResult.OK:
                            this.projects = action.Projects;
                            return true;
                        case System.Windows.Forms.DialogResult.Cancel:
                            return false;
                        case System.Windows.Forms.DialogResult.Abort:
                            MessageBox.Show(this, action.Error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                    }
                } else {
                    return true;
                }
            }
            return false;
        }

        private bool CheckLogon() {
            if (this.proxy == null || string.IsNullOrEmpty(this.proxy.Token)) {
                LogonDialog dialog = new LogonDialog();
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    LogonActionWorker law = new LogonActionWorker(dialog.ServerURL, dialog.UserID, dialog.Password);
                    switch (BackgroundWorkerDialog.Run(@"Logging into GForge Server", law, this)) {
                        case System.Windows.Forms.DialogResult.OK:
                            this.proxy = law.Proxy;
                            Properties.Settings.Default.GForgeHost = dialog.ServerURL;
                            Properties.Settings.Default.GForgeUserID = dialog.UserID;
                            return true;
                        case System.Windows.Forms.DialogResult.Cancel:
                            return false;
                        case System.Windows.Forms.DialogResult.Abort:
                            MessageBox.Show(this, law.Error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                    }
                }
                return false;
            }
            return true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                Properties.Settings.Default.Save();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
