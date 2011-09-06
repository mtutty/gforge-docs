using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GForgeDocWindow.Dialogs {
    public partial class LogonDialog : Form {
        public LogonDialog() {
            InitializeComponent();
            this.txtServerURL.Text = Properties.Settings.Default.GForgeHost;
            this.txtUserID.Text = Properties.Settings.Default.GForgeUserID;
        }

        public string ServerURL { get { return this.txtServerURL.Text; } }
        public string UserID { get { return this.txtUserID.Text; } }
        public string Password { get { return this.txtPassword.Text; } }

        private void LogonDialog_Shown(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(this.txtServerURL.Text)) {
                this.txtServerURL.Focus();
            } else if (string.IsNullOrEmpty(this.txtUserID.Text)) {
                this.txtUserID.Focus();
            } else if (string.IsNullOrEmpty(this.txtPassword.Text)) {
                this.txtPassword.Focus();
            }
        }
    }
}
