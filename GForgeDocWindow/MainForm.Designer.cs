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
            this.CheckOutButton = new System.Windows.Forms.ToolStripButton();
            this.SyncButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangedLabel = new System.Windows.Forms.ToolStripLabel();
            this.GForgeActiveLabel = new System.Windows.Forms.ToolStripLabel();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.LocationText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.LocationLabel = new System.Windows.Forms.ToolStripLabel();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.NavStrip = new System.Windows.Forms.ToolStrip();
            this.ActionStrip = new System.Windows.Forms.ToolStrip();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.AllowDrop = true;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 54);
            this.Browser.Name = "Browser";
            this.Browser.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
            this.Browser.Size = new System.Drawing.Size(515, 355);
            this.Browser.TabIndex = 2;
            this.Browser.ItemsChanged += new System.EventHandler(this.Browser_ItemsChanged);
            this.Browser.NavigationComplete += new System.EventHandler<Microsoft.WindowsAPICodePack.Controls.NavigationCompleteEventArgs>(this.Browser_NavigationComplete);
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
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(23, 22);
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(23, 22);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton.Text = "toolStripButton3";
            // 
            // LocationText
            // 
            this.LocationText.AutoSize = false;
            this.LocationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationText.MaxLength = 1024;
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(100, 23);
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
            // LocationLabel
            // 
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(59, 22);
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
            this.pnlTop.Size = new System.Drawing.Size(515, 54);
            this.pnlTop.TabIndex = 3;
            // 
            // NavStrip
            // 
            this.NavStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavStrip.Location = new System.Drawing.Point(0, 0);
            this.NavStrip.Name = "NavStrip";
            this.NavStrip.Size = new System.Drawing.Size(515, 27);
            this.NavStrip.TabIndex = 0;
            this.NavStrip.Text = "toolStrip1";
            // 
            // ActionStrip
            // 
            this.ActionStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionStrip.Location = new System.Drawing.Point(0, 27);
            this.ActionStrip.Name = "ActionStrip";
            this.ActionStrip.Size = new System.Drawing.Size(515, 27);
            this.ActionStrip.TabIndex = 1;
            this.ActionStrip.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 409);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.pnlTop);
            this.Name = "MainForm";
            this.Text = "GForge Document Sync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser Browser;
        private System.Windows.Forms.ToolStripButton CheckOutButton;
        private System.Windows.Forms.ToolStripButton SyncButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ChangedLabel;
        private System.Windows.Forms.ToolStripLabel GForgeActiveLabel;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripLabel LocationLabel;
        private System.Windows.Forms.ToolStripTextBox LocationText;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.ToolStrip NavStrip;
        private System.Windows.Forms.ToolStrip ActionStrip;


    }
}

