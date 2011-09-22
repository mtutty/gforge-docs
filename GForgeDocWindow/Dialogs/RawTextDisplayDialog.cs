using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GForgeDocWindow.Dialogs {
    public partial class RawTextDisplayDialog : Form {

        public RawTextDisplayDialog(string text) : this() {
            this.DisplayText.Text = text;
        }

        public RawTextDisplayDialog() {
            InitializeComponent();
        }

        public static void Show(IWin32Window owner, string text) {
            RawTextDisplayDialog dlg = new RawTextDisplayDialog(text);
            dlg.ShowDialog(owner);
        }
    }
}
