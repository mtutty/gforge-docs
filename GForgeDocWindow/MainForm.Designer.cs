namespace GForgeDocWindow {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Browser = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LocationText = new System.Windows.Forms.ToolStripTextBox();
            this.LocationLabel = new System.Windows.Forms.ToolStripLabel();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.NavStrip = new System.Windows.Forms.ToolStrip();
            this.NavBackButton = new System.Windows.Forms.ToolStripButton();
            this.NavForwardButton = new System.Windows.Forms.ToolStripButton();
            this.NavRefreshButton = new System.Windows.Forms.ToolStripButton();
            this.NavGoButton = new System.Windows.Forms.ToolStripButton();
            this.ActionStrip = new System.Windows.Forms.ToolStrip();
            this.CheckOutButton = new System.Windows.Forms.ToolStripButton();
            this.SyncButton = new System.Windows.Forms.ToolStripButton();
            this.GForgeActiveLabel = new System.Windows.Forms.ToolStripLabel();
            this.ChangedLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LocationBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlTop.SuspendLayout();
            this.NavStrip.SuspendLayout();
            this.ActionStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.AllowDrop = true;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 54);
            this.Browser.Name = "Browser";
            this.Browser.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
            this.Browser.Size = new System.Drawing.Size(524, 388);
            this.Browser.TabIndex = 2;
            this.Browser.ItemsChanged += new System.EventHandler(this.Browser_ItemsChanged);
            this.Browser.NavigationComplete += new System.EventHandler<Microsoft.WindowsAPICodePack.Controls.NavigationCompleteEventArgs>(this.Browser_NavigationComplete);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // LocationText
            // 
            this.LocationText.AutoSize = false;
            this.LocationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationText.MaxLength = 1024;
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(320, 23);
            // 
            // LocationLabel
            // 
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(59, 24);
            this.LocationLabel.Text = "Location: ";
            // 
            // pnlTop
            // 
            this.pnlTop.ColumnCount = 1;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTop.Controls.Add(this.NavStrip, 0, 0);
            this.pnlTop.Controls.Add(this.ActionStrip, 0, 1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 2;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTop.Size = new System.Drawing.Size(524, 54);
            this.pnlTop.TabIndex = 3;
            // 
            // NavStrip
            // 
            this.NavStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NavBackButton,
            this.NavForwardButton,
            this.toolStripSeparator1,
            this.NavRefreshButton,
            this.LocationLabel,
            this.LocationText,
            this.NavGoButton});
            this.NavStrip.Location = new System.Drawing.Point(0, 0);
            this.NavStrip.Name = "NavStrip";
            this.NavStrip.Size = new System.Drawing.Size(524, 27);
            this.NavStrip.TabIndex = 0;
            this.NavStrip.Text = "toolStrip1";
            // 
            // NavBackButton
            // 
            this.NavBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavBackButton.Image = global::GForgeDocWindow.Properties.Resources.back_16;
            this.NavBackButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NavBackButton.Name = "NavBackButton";
            this.NavBackButton.Size = new System.Drawing.Size(23, 24);
            this.NavBackButton.Text = "toolStripButton1";
            this.NavBackButton.Click += new System.EventHandler(this.NavBackButton_Click);
            // 
            // NavForwardButton
            // 
            this.NavForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavForwardButton.Image = global::GForgeDocWindow.Properties.Resources.forward_16;
            this.NavForwardButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NavForwardButton.Name = "NavForwardButton";
            this.NavForwardButton.Size = new System.Drawing.Size(23, 24);
            this.NavForwardButton.Text = "toolStripButton2";
            // 
            // NavRefreshButton
            // 
            this.NavRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavRefreshButton.Image = global::GForgeDocWindow.Properties.Resources.refresh_16;
            this.NavRefreshButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NavRefreshButton.Name = "NavRefreshButton";
            this.NavRefreshButton.Size = new System.Drawing.Size(23, 24);
            this.NavRefreshButton.Text = "toolStripButton3";
            // 
            // NavGoButton
            // 
            this.NavGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavGoButton.Image = global::GForgeDocWindow.Properties.Resources.Go;
            this.NavGoButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NavGoButton.Name = "NavGoButton";
            this.NavGoButton.Size = new System.Drawing.Size(23, 24);
            this.NavGoButton.Text = "toolStripButton5";
            this.NavGoButton.Click += new System.EventHandler(this.NavGoButton_Click);
            // 
            // ActionStrip
            // 
            this.ActionStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckOutButton,
            this.SyncButton,
            this.GForgeActiveLabel,
            this.ChangedLabel});
            this.ActionStrip.Location = new System.Drawing.Point(0, 27);
            this.ActionStrip.Name = "ActionStrip";
            this.ActionStrip.Size = new System.Drawing.Size(524, 27);
            this.ActionStrip.TabIndex = 1;
            this.ActionStrip.Text = "toolStrip1";
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Image = global::GForgeDocWindow.Properties.Resources.checkout_16;
            this.CheckOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(83, 24);
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.ToolTipText = "Set up a local copy of a GForge docs folder (and its contents)";
            // 
            // SyncButton
            // 
            this.SyncButton.Image = global::GForgeDocWindow.Properties.Resources.sync_16;
            this.SyncButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(78, 24);
            this.SyncButton.Text = "Sync Files";
            this.SyncButton.ToolTipText = "Sync the current directory (and its contents) with corresponding GForge Docs fold" +
    "er";
            // 
            // GForgeActiveLabel
            // 
            this.GForgeActiveLabel.Image = global::GForgeDocWindow.Properties.Resources.gforge_g;
            this.GForgeActiveLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GForgeActiveLabel.Name = "GForgeActiveLabel";
            this.GForgeActiveLabel.Size = new System.Drawing.Size(85, 24);
            this.GForgeActiveLabel.Text = "(no project)";
            this.GForgeActiveLabel.ToolTipText = "This folder is not linked to a GForge Docs folder";
            // 
            // ChangedLabel
            // 
            this.ChangedLabel.Name = "ChangedLabel";
            this.ChangedLabel.Size = new System.Drawing.Size(55, 24);
            this.ChangedLabel.Text = "CHANGE";
            this.ChangedLabel.ToolTipText = "This folder (or its children) has local changes to submit";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 24);
            this.toolStripLabel1.Text = "Location:";
            // 
            // LocationBox
            // 
            this.LocationBox.AutoSize = false;
            this.LocationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationBox.MaxLength = 1024;
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(300, 23);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 442);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 480);
            this.Name = "MainForm";
            this.Text = "GForge Document Sync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.NavStrip.ResumeLayout(false);
            this.NavStrip.PerformLayout();
            this.ActionStrip.ResumeLayout(false);
            this.ActionStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser Browser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel LocationLabel;
        private System.Windows.Forms.ToolStripTextBox LocationText;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.ToolStrip NavStrip;
        private System.Windows.Forms.ToolStrip ActionStrip;
        private System.Windows.Forms.ToolStripButton NavForwardButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton NavRefreshButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox LocationBox;
        private System.Windows.Forms.ToolStripButton NavGoButton;
        private System.Windows.Forms.ToolStripButton CheckOutButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton SyncButton;
        private System.Windows.Forms.ToolStripLabel GForgeActiveLabel;
        private System.Windows.Forms.ToolStripLabel ChangedLabel;
        private System.Windows.Forms.ToolStripButton NavBackButton;


    }
}

