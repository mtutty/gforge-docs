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
            this.LocationSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LocationText = new GForgeDocWindow.Util.ToolStripSpringTextBox();
            this.LocationLabel = new System.Windows.Forms.ToolStripLabel();
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
            this.LocationBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.NavStrip.SuspendLayout();
            this.ActionStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.AllowDrop = true;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.Name = "Browser";
            this.Browser.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
            this.Browser.Size = new System.Drawing.Size(524, 392);
            this.Browser.TabIndex = 2;
            this.Browser.SelectionChanged += new System.EventHandler(this.Browser_SelectionChanged);
            this.Browser.ItemsChanged += new System.EventHandler(this.Browser_ItemsChanged);
            this.Browser.NavigationComplete += new System.EventHandler<Microsoft.WindowsAPICodePack.Controls.NavigationCompleteEventArgs>(this.Browser_NavigationComplete);
            // 
            // LocationSeparator1
            // 
            this.LocationSeparator1.Name = "LocationSeparator1";
            this.LocationSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.LocationLabel.Size = new System.Drawing.Size(59, 22);
            this.LocationLabel.Text = "Location: ";
            // 
            // NavStrip
            // 
            this.NavStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.NavStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NavBackButton,
            this.NavForwardButton,
            this.LocationSeparator1,
            this.NavRefreshButton,
            this.LocationLabel,
            this.LocationText,
            this.NavGoButton});
            this.NavStrip.Location = new System.Drawing.Point(0, 0);
            this.NavStrip.Name = "NavStrip";
            this.NavStrip.Size = new System.Drawing.Size(524, 25);
            this.NavStrip.Stretch = true;
            this.NavStrip.TabIndex = 0;
            this.NavStrip.Text = "toolStrip1";
            // 
            // NavBackButton
            // 
            this.NavBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavBackButton.Image = global::GForgeDocWindow.Properties.Resources.back_16;
            this.NavBackButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NavBackButton.Name = "NavBackButton";
            this.NavBackButton.Size = new System.Drawing.Size(23, 22);
            this.NavBackButton.Text = "toolStripButton1";
            this.NavBackButton.Click += new System.EventHandler(this.NavBackButton_Click);
            // 
            // NavForwardButton
            // 
            this.NavForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavForwardButton.Image = global::GForgeDocWindow.Properties.Resources.forward_16;
            this.NavForwardButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NavForwardButton.Name = "NavForwardButton";
            this.NavForwardButton.Size = new System.Drawing.Size(23, 22);
            this.NavForwardButton.Text = "toolStripButton2";
            this.NavForwardButton.Click += new System.EventHandler(this.NavForwardButton_Click);
            // 
            // NavRefreshButton
            // 
            this.NavRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavRefreshButton.Image = global::GForgeDocWindow.Properties.Resources.refresh_16;
            this.NavRefreshButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NavRefreshButton.Name = "NavRefreshButton";
            this.NavRefreshButton.Size = new System.Drawing.Size(23, 22);
            this.NavRefreshButton.Text = "toolStripButton3";
            this.NavRefreshButton.Click += new System.EventHandler(this.NavRefreshButton_Click);
            // 
            // NavGoButton
            // 
            this.NavGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavGoButton.Image = global::GForgeDocWindow.Properties.Resources.Go;
            this.NavGoButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NavGoButton.Name = "NavGoButton";
            this.NavGoButton.Size = new System.Drawing.Size(23, 22);
            this.NavGoButton.Text = "toolStripButton5";
            this.NavGoButton.Click += new System.EventHandler(this.NavGoButton_Click);
            // 
            // ActionStrip
            // 
            this.ActionStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ActionStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckOutButton,
            this.SyncButton,
            this.GForgeActiveLabel,
            this.ChangedLabel});
            this.ActionStrip.Location = new System.Drawing.Point(0, 25);
            this.ActionStrip.Name = "ActionStrip";
            this.ActionStrip.Size = new System.Drawing.Size(524, 25);
            this.ActionStrip.Stretch = true;
            this.ActionStrip.TabIndex = 1;
            this.ActionStrip.Text = "toolStrip1";
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Image = global::GForgeDocWindow.Properties.Resources.checkout_16;
            this.CheckOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(83, 22);
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.ToolTipText = "Set up a local copy of a GForge docs folder (and its contents)";
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // SyncButton
            // 
            this.SyncButton.Image = global::GForgeDocWindow.Properties.Resources.sync_16;
            this.SyncButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(78, 22);
            this.SyncButton.Text = "Sync Files";
            this.SyncButton.ToolTipText = "Sync the current directory (and its contents) with corresponding GForge Docs fold" +
    "er";
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // GForgeActiveLabel
            // 
            this.GForgeActiveLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GForgeActiveLabel.Image = global::GForgeDocWindow.Properties.Resources.gforge_g;
            this.GForgeActiveLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GForgeActiveLabel.Name = "GForgeActiveLabel";
            this.GForgeActiveLabel.Size = new System.Drawing.Size(51, 22);
            this.GForgeActiveLabel.Text = "GFORGE";
            this.GForgeActiveLabel.ToolTipText = "This folder is not linked to a GForge Docs folder";
            // 
            // ChangedLabel
            // 
            this.ChangedLabel.Name = "ChangedLabel";
            this.ChangedLabel.Size = new System.Drawing.Size(55, 22);
            this.ChangedLabel.Text = "CHANGE";
            this.ChangedLabel.ToolTipText = "This folder (or its children) has local changes to submit";
            // 
            // LocationBox
            // 
            this.LocationBox.AutoSize = false;
            this.LocationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationBox.MaxLength = 1024;
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(300, 23);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Browser);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(524, 392);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(524, 442);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.NavStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.ActionStrip);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 442);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(540, 480);
            this.Name = "MainForm";
            this.Text = "GForge Document Sync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.NavStrip.ResumeLayout(false);
            this.NavStrip.PerformLayout();
            this.ActionStrip.ResumeLayout(false);
            this.ActionStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser Browser;
        private System.Windows.Forms.ToolStripSeparator LocationSeparator1;
        private System.Windows.Forms.ToolStripLabel LocationLabel;
        private System.Windows.Forms.ToolStrip NavStrip;
        private System.Windows.Forms.ToolStrip ActionStrip;
        private System.Windows.Forms.ToolStripButton NavForwardButton;
        private System.Windows.Forms.ToolStripButton NavRefreshButton;
        private System.Windows.Forms.ToolStripTextBox LocationBox;
        private System.Windows.Forms.ToolStripButton NavGoButton;
        private System.Windows.Forms.ToolStripButton CheckOutButton;
        private System.Windows.Forms.ToolStripButton SyncButton;
        private System.Windows.Forms.ToolStripLabel GForgeActiveLabel;
        private System.Windows.Forms.ToolStripLabel ChangedLabel;
        private System.Windows.Forms.ToolStripButton NavBackButton;
        private Util.ToolStripSpringTextBox LocationText;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;


    }
}

