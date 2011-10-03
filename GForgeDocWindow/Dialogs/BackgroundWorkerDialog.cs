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
        private Image img = null;

        public static DialogResult Run(string whyWeAreWaiting, BackgroundWorker worker, IWin32Window owner) {
            return new BackgroundWorkerDialog(whyWeAreWaiting, worker).ShowDialog(owner);
        }

        public BackgroundWorkerDialog(string whyWeAreWaiting, BackgroundWorker worker) {
            InitializeComponent();
            this.Text = whyWeAreWaiting; // Show in title bar

            backgroundWorker1 = worker;
            if (backgroundWorker1 == null) throw new ArgumentNullException(@"The Background Worker Dialog requires a valid worker object");
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            
            try {
                this.img = GForgeDocWindow.Properties.Resources.wait_animated;
                this.picWaitImage.Size = img.Size;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            label1.Text = "Cancelling...";
            backgroundWorker1.CancelAsync();
            btnCancel.Enabled = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            label1.Text = e.UserState as string;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Error != null) 
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            else if (e.Cancelled) 
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void AnimateWaitImage(object sender, EventArgs e) {
            this.picWaitImage.Invalidate();
        }

        void picWaitImage_Paint(object sender, PaintEventArgs e) {
            ImageAnimator.UpdateFrames();
            e.Graphics.Clear(this.picWaitImage.BackColor);
            e.Graphics.DrawImage(img, new Point(0, 0));
        }

        private void BackgroundWorkerDialog_Shown(object sender, EventArgs e) {
            if (this.img != null) {
                this.picWaitImage.Paint += new PaintEventHandler(picWaitImage_Paint);
                ImageAnimator.Animate(this.img, new EventHandler(this.AnimateWaitImage));
            } else {
                this.picWaitImage.Visible = false;
            }
            this.Refresh();
            Application.DoEvents();
            backgroundWorker1.RunWorkerAsync();
        }

    }
}
