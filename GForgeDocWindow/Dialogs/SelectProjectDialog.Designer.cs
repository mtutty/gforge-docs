namespace GForgeDocWindow.Dialogs {
    partial class SelectProjectDialog {
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
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvProjects = new System.Windows.Forms.ListView();
            this.imlImages = new System.Windows.Forms.ImageList(this.components);
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterText = new System.Windows.Forms.TextBox();
            this.ProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(2, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(424, 33);
            this.TopPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(422, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Select GForge Project";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.CancelBtn);
            this.ButtonPanel.Controls.Add(this.OKButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(2, 296);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(424, 62);
            this.ButtonPanel.TabIndex = 2;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(321, 17);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(89, 33);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(226, 17);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(89, 33);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "&OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvProjects);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 63);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(424, 233);
            this.panel1.TabIndex = 3;
            // 
            // lvProjects
            // 
            this.lvProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectName});
            this.lvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProjects.FullRowSelect = true;
            this.lvProjects.HideSelection = false;
            this.lvProjects.Location = new System.Drawing.Point(8, 8);
            this.lvProjects.MultiSelect = false;
            this.lvProjects.Name = "lvProjects";
            this.lvProjects.ShowGroups = false;
            this.lvProjects.Size = new System.Drawing.Size(408, 217);
            this.lvProjects.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvProjects.TabIndex = 0;
            this.lvProjects.UseCompatibleStateImageBehavior = false;
            this.lvProjects.View = System.Windows.Forms.View.Details;
            // 
            // imlImages
            // 
            this.imlImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlImages.ImageSize = new System.Drawing.Size(16, 16);
            this.imlImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.FilterText);
            this.FilterPanel.Controls.Add(this.FilterLabel);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(2, 33);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(424, 30);
            this.FilterPanel.TabIndex = 4;
            // 
            // FilterLabel
            // 
            this.FilterLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterLabel.Location = new System.Drawing.Point(0, 0);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.FilterLabel.Size = new System.Drawing.Size(91, 30);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Filter this list:";
            this.FilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilterText
            // 
            this.FilterText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterText.Location = new System.Drawing.Point(87, 3);
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(223, 22);
            this.FilterText.TabIndex = 1;
            this.FilterText.TextChanged += new System.EventHandler(this.FilterText_TextChanged);
            // 
            // ProjectName
            // 
            this.ProjectName.Text = "Project Name";
            this.ProjectName.Width = 380;
            // 
            // SelectProjectDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(428, 358);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectProjectDialog";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GForge Document Manager";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SelectProjectDialog_Validating);
            this.TopPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvProjects;
        private System.Windows.Forms.ImageList imlImages;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.TextBox FilterText;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.ColumnHeader ProjectName;
    }
}