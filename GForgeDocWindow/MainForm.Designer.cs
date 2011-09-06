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
            this.MainContainer = new System.Windows.Forms.ToolStripContainer();
            this.Browser = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.CheckOutButton = new System.Windows.Forms.ToolStripButton();
            this.SyncButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangedLabel = new System.Windows.Forms.ToolStripLabel();
            this.GForgeActiveLabel = new System.Windows.Forms.ToolStripLabel();
            this.MainContainer.ContentPanel.SuspendLayout();
            this.MainContainer.TopToolStripPanel.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.TopToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.BottomToolStripPanelVisible = false;
            // 
            // MainContainer.ContentPanel
            // 
            this.MainContainer.ContentPanel.Controls.Add(this.Browser);
            this.MainContainer.ContentPanel.Size = new System.Drawing.Size(515, 384);
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.LeftToolStripPanelVisible = false;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.RightToolStripPanelVisible = false;
            this.MainContainer.Size = new System.Drawing.Size(515, 409);
            this.MainContainer.TabIndex = 3;
            this.MainContainer.Text = "toolStripContainer1";
            // 
            // MainContainer.TopToolStripPanel
            // 
            this.MainContainer.TopToolStripPanel.Controls.Add(this.TopToolStrip);
            // 
            // Browser
            // 
            this.Browser.AllowDrop = true;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.Name = "Browser";
            this.Browser.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
            this.Browser.Size = new System.Drawing.Size(515, 384);
            this.Browser.TabIndex = 2;
            this.Browser.ItemsChanged += new System.EventHandler(this.Browser_ItemsChanged);
            this.Browser.NavigationComplete += new System.EventHandler<Microsoft.WindowsAPICodePack.Controls.NavigationCompleteEventArgs>(this.Browser_NavigationComplete);
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckOutButton,
            this.SyncButton,
            this.toolStripSeparator1,
            this.ChangedLabel,
            this.GForgeActiveLabel});
            this.TopToolStrip.Location = new System.Drawing.Point(3, 0);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(255, 25);
            this.TopToolStrip.TabIndex = 1;
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CheckOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(76, 22);
            this.CheckOutButton.Text = "Check Out...";
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // SyncButton
            // 
            this.SyncButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SyncButton.Image = ((System.Drawing.Image)(resources.GetObject("SyncButton.Image")));
            this.SyncButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(45, 22);
            this.SyncButton.Text = "Sync...";
            this.SyncButton.ToolTipText = "Sync Repository with GForge";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ChangedLabel
            // 
            this.ChangedLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ChangedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ChangedLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ChangedLabel.Name = "ChangedLabel";
            this.ChangedLabel.Size = new System.Drawing.Size(62, 22);
            this.ChangedLabel.Text = "CHANGES";
            // 
            // GForgeActiveLabel
            // 
            this.GForgeActiveLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.GForgeActiveLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GForgeActiveLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GForgeActiveLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GForgeActiveLabel.Name = "GForgeActiveLabel";
            this.GForgeActiveLabel.Size = new System.Drawing.Size(54, 22);
            this.GForgeActiveLabel.Text = "GFORGE";
            this.GForgeActiveLabel.ToolTipText = "This folder is synchronized to a GForge Project.  Click to visit the Document Man" +
    "ager for the project.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 409);
            this.Controls.Add(this.MainContainer);
            this.Name = "MainForm";
            this.Text = "GForge Document Sync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainContainer.ContentPanel.ResumeLayout(false);
            this.MainContainer.TopToolStripPanel.ResumeLayout(false);
            this.MainContainer.TopToolStripPanel.PerformLayout();
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer MainContainer;
        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser Browser;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripButton CheckOutButton;
        private System.Windows.Forms.ToolStripButton SyncButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ChangedLabel;
        private System.Windows.Forms.ToolStripLabel GForgeActiveLabel;


    }
}

