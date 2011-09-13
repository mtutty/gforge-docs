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

        private BackgroundWorker backgroundWorker1 = null;

        public BackgroundWorkerDialog(string whyWeAreWaiting, BackgroundWorker worker) {
            InitializeComponent();
            this.Text = whyWeAreWaiting; // Show in title bar
            backgroundWorker1 = worker;
            if (backgroundWorker1 == null) throw new ArgumentNullException(@"The Background Worker Dialog requires a valid worker object");
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            label1.Text = "Cancelling...";
            backgroundWorker1.CancelAsync(); // Tell worker to abort.
            btnCancel.Enabled = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            label1.Text = e.UserState as string;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            Close();
        }

        private void BackgroundWorkerDialog_Shown(object sender, EventArgs e) {
            try {
                Image img = Image.FromStream(GForgeDocWindow.Properties.Resources.ResourceManager.GetStream(@"wait_animated.gif"));
                //ImageAnimator.Animate(img, 
            } catch (Exception ex) {
                Console.Write(ex.Message);
                this.picWaitImage.Visible = false;
            }
            this.Refresh();
            Application.DoEvents();
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
