using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GForgeDocWindow.Dialogs {
    public partial class BackgroundWorkerDialog : Form {
        public BackgroundWorkerDialog(string whyWeAreWaiting, DoWorkEventHandler work) {
            InitializeComponent();
            this.Text = whyWeAreWaiting; // Show in title bar
            backgroundWorker1.DoWork += work; // Event handler to be called in context of new thread.
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            label1.Text = "Cancelling...";
            backgroundWorker1.CancelAsync(); // Tell worker to abort.
            btnCancel.Enabled = false;
        }

        private void Progress_Load(object sender, EventArgs e) {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = e.UserState as string;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            Close();
        }
    }
}
