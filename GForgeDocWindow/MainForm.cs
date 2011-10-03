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

        private const int MaxHistory = 20;
        private StringHistoryList history = new StringHistoryList(MaxHistory);

        public MainForm(string startPath) {
            InitializeComponent();

            if (string.IsNullOrEmpty(startPath) ||
                !Directory.Exists(startPath)) {
                startPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            if (Directory.Exists(startPath)) {
                currentLocation = ShellFileSystemFolder.FromFolderPath(startPath);
            } else {
                currentLocation = ShellFileSystemFolder.FromFolderPath(Application.StartupPath);
                string msg = string.Format(@"Sorry, the path you requested ({0}) does not exist.  Starting in {1} instead.", startPath, currentLocation.Name);
                MessageBox.Show(msg, @"Invalid Starting Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (currentLocation != null)
                this.Browser.Navigate(currentLocation);
        }

        public MainForm() : this(Properties.Settings.Default.CurrentLocation) { }

        private void Browser_ItemsChanged(object sender, EventArgs e) {
            SetToolBarStatus(currentLocation.ParsingName);
        }

        private void Browser_NavigationComplete(object sender, Microsoft.WindowsAPICodePack.Controls.NavigationCompleteEventArgs e) {
            currentLocation = e.NewLocation;

            string locationText = currentLocation.ParsingName;
            this.history.AddHistory(locationText);
            SetToolBarStatus(locationText);
            this.LocationText.Text = locationText;
            this.Text = @"GForge Document Manager - " + locationText;
        }

        private void Browser_SelectionChanged(object sender, EventArgs e) {
            if (this.Browser.SelectedItems.Count > 0)
                SetToolBarStatus(this.Browser.SelectedItems[0].ParsingName);
            else
                SetToolBarStatus(this.currentLocation.ParsingName);
        }

        /*
         * In case they go away, this goes in the designer file
            this.NavStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.NavBackButton,
                this.NavForwardButton,
                this.toolStripSeparator1,
                this.NavRefreshButton,
                this.LocationLabel,
                this.LocationText,
                this.NavGoButton
            });
        */

        /*
         * In case they go away, this goes in the designer file
            this.ActionStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.CheckOutButton,
                this.SyncButton,
                this.GForgeActiveLabel,
                this.ChangedLabel
            });
         
         */

        private void SetToolBarStatus(string location) {
            try {
                this.ActionStrip.SuspendLayout();
                LocalFileService.SyncFolderInfo fld = lfs.GetFolderInfo(location);
                if (fld != null) {
                    this.CheckOutButton.Enabled = false;
                    this.SyncButton.Enabled = true;

                    this.GForgeActiveLabel.Enabled = true;
                    this.GForgeActiveLabel.ToolTipText = @"This folder syncs to a GForge Docs folder";

                    this.ChangedLabel.Enabled = lfs.HasChanges(location, true);
                } else {
                    this.CheckOutButton.Enabled = true;
                    this.SyncButton.Enabled = false;

                    this.GForgeActiveLabel.Enabled = true;
                    this.GForgeActiveLabel.ToolTipText = @"This folder does not sync to a GForge Docs folder";

                    this.ChangedLabel.Enabled = false;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);

                this.SyncButton.Enabled = false;
                this.CheckOutButton.Enabled = false;
                this.GForgeActiveLabel.Enabled = false;
                this.ChangedLabel.Enabled = false;

            } finally {
                this.ActionStrip.ResumeLayout();
            }


            try {
                this.NavStrip.SuspendLayout();

                this.NavBackButton.Enabled = this.history.CanGoBack;
                this.NavForwardButton.Enabled = this.history.CanGoForward;

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);

            } finally {
                this.NavStrip.ResumeLayout();
            }

        }

        private void CheckOutButton_Click(object sender, EventArgs e) {
            if (CheckProjectList()) {
                CheckoutDialog dialog = new CheckoutDialog(this.projects, this.currentLocation.ParsingName);
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                    DownloadProjectWorker dpw = new DownloadProjectWorker(this.lfs, this.proxy, dialog.SelectedProject.project_id, Path.Combine(dialog.BasePath, dialog.SelectedPath));
                    switch (BackgroundWorkerDialog.Run(@"Sync Project Docs", dpw, this)) {
                        case System.Windows.Forms.DialogResult.OK:
                            break;
                        case System.Windows.Forms.DialogResult.Cancel:
                            string msg = @"The sync process was canceled.  Some folders and files may be missing or out-of-date.";
                            MessageBox.Show(this, msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            break;
                        case System.Windows.Forms.DialogResult.Abort:
                            break;
                    }
                    if (string.IsNullOrEmpty(dpw.Error) == false) {
                        RawTextDisplayDialog.Show(this, dpw.Error);
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

        private void MainForm_Shown(object sender, EventArgs e) {
            // Nothing
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                Properties.Settings.Default.CurrentLocation = this.currentLocation.ParsingName;
                Properties.Settings.Default.Save();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        void MainForm_Resize(object sender, System.EventArgs e) {
            //Nothing
            SetSpringSize(sender, e);
        }

        void MainForm_ResizeEnd(object sender, System.EventArgs e) {
            //SetSpringSize(sender, e);
        }

        private void SetSpringSize(object sender, EventArgs e) {
            Console.WriteLine(@"Resize start");
            // Spring location text box to their max size
            int width = this.NavStrip.DisplayRectangle.Width - 48; // a little extra padding to prevent the overflow indicator
            Console.WriteLine(@"Resize initial width is {0}", width);
            foreach (ToolStripItem tsi in NavStrip.Items) {
                Console.WriteLine(@"Resize found child {0}", tsi.Name);
                if (!(tsi == this.LocationText)) {
                    width -= tsi.Width;
                    width -= tsi.Margin.Horizontal;
                }
                Console.WriteLine(@"Resize updated width is {0}", width);
            }
            int newWidth = Math.Max(0, width - this.LocationText.Margin.Horizontal);
            Console.WriteLine(@"Resize, setting location width to {0}", newWidth);
            this.LocationText.Width = newWidth;
            Console.WriteLine(@"Resize end");
        }

        private void NavigateTo(string location) {
            if (Directory.Exists(location)) {
                this.Browser.Navigate(ShellFileSystemFolder.FromFolderPath(location));
            } else {
                this.LocationText.Text = this.currentLocation.ParsingName;
            }
        }

        private void NavBackButton_Click(object sender, EventArgs e) {
            this.NavigateTo(this.history.GoBack());
        }

        private void NavForwardButton_Click(object sender, EventArgs e) {
            this.NavigateTo(this.history.GoForward());
        }

        private void NavGoButton_Click(object sender, EventArgs e) {
            this.NavigateTo(this.LocationText.Text);
        }

        private void NavRefreshButton_Click(object sender, EventArgs e) {
            this.NavigateTo(this.currentLocation.ParsingName);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (this.LocationText.Focused && e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                e.Handled = true;
                this.NavigateTo(this.LocationText.Text);
            }

        }

        private void SyncButton_Click(object sender, EventArgs e) {
            // TODO:  Implement sync for existing folders
        }

    }
}
