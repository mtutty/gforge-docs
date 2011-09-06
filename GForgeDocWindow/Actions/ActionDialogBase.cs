using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GForgeDocWindow.Actions {
    public partial class ActionDialogBase : Form {

        public bool Cancelled { get; set; }

        public ActionDialogBase() {
            InitializeComponent();
        }

        protected virtual void DoAction() {
            return;
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.Cancelled = true;
        }

        protected void SetStatus(string status) {
            if (status != this.StatusLabel.Text) {
                this.StatusLabel.Text = status;
                this.Refresh();
            }
        }

        private void ActionDialogBase_Shown(object sender, EventArgs e) {
            this.DoAction();
        }
    }
}
