namespace GForgeDocWindow.Dialogs {
    partial class CheckoutDialog {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomPath = new System.Windows.Forms.TextBox();
            this.CustomName = new System.Windows.Forms.RadioButton();
            this.UnixName = new System.Windows.Forms.RadioButton();
            this.ProjectName = new System.Windows.Forms.RadioButton();
            this.CurrentFolder = new System.Windows.Forms.RadioButton();
            this.ProjectList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ProjectList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(507, 234);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomPath);
            this.groupBox1.Controls.Add(this.CustomName);
            this.groupBox1.Controls.Add(this.UnixName);
            this.groupBox1.Controls.Add(this.ProjectName);
            this.groupBox1.Controls.Add(this.CurrentFolder);
            this.groupBox1.Location = new System.Drawing.Point(15, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Out To...";
            // 
            // CustomPath
            // 
            this.CustomPath.Enabled = false;
            this.CustomPath.Location = new System.Drawing.Point(176, 123);
            this.CustomPath.MaxLength = 255;
            this.CustomPath.Name = "CustomPath";
            this.CustomPath.Size = new System.Drawing.Size(209, 20);
            this.CustomPath.TabIndex = 4;
            this.CustomPath.Validating += new System.ComponentModel.CancelEventHandler(this.CustomPath_Validating);
            // 
            // CustomName
            // 
            this.CustomName.AutoSize = true;
            this.CustomName.Location = new System.Drawing.Point(21, 124);
            this.CustomName.Name = "CustomName";
            this.CustomName.Size = new System.Drawing.Size(149, 17);
            this.CustomName.TabIndex = 3;
            this.CustomName.Text = "New Folder under Current:";
            this.CustomName.UseVisualStyleBackColor = true;
            this.CustomName.CheckedChanged += new System.EventHandler(this.CustomName_CheckedChanged);
            // 
            // UnixName
            // 
            this.UnixName.AutoSize = true;
            this.UnixName.Location = new System.Drawing.Point(21, 91);
            this.UnixName.Name = "UnixName";
            this.UnixName.Size = new System.Drawing.Size(90, 17);
            this.UnixName.TabIndex = 2;
            this.UnixName.Text = "Short Name ()";
            this.UnixName.UseVisualStyleBackColor = true;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Checked = true;
            this.ProjectName.Location = new System.Drawing.Point(21, 58);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(98, 17);
            this.ProjectName.TabIndex = 1;
            this.ProjectName.TabStop = true;
            this.ProjectName.Text = "Project Name ()";
            this.ProjectName.UseVisualStyleBackColor = true;
            // 
            // CurrentFolder
            // 
            this.CurrentFolder.AutoSize = true;
            this.CurrentFolder.Location = new System.Drawing.Point(21, 25);
            this.CurrentFolder.Name = "CurrentFolder";
            this.CurrentFolder.Size = new System.Drawing.Size(100, 17);
            this.CurrentFolder.TabIndex = 0;
            this.CurrentFolder.Text = "Current Folder ()";
            this.CurrentFolder.UseVisualStyleBackColor = true;
            // 
            // ProjectList
            // 
            this.ProjectList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProjectList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectList.FormattingEnabled = true;
            this.ProjectList.Location = new System.Drawing.Point(15, 33);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Size = new System.Drawing.Size(450, 21);
            this.ProjectList.TabIndex = 1;
            this.ProjectList.SelectedIndexChanged += new System.EventHandler(this.ProjectList_SelectedIndexChanged);
            this.ProjectList.Validating += new System.ComponentModel.CancelEventHandler(this.ProjectList_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Project to check out:";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(507, 33);
            this.TopPanel.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(505, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Check Out GForge Docs";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelBtn
            // 
            this.CancelBtn.CausesValidation = false;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(406, 17);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(89, 33);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.CancelBtn);
            this.ButtonPanel.Controls.Add(this.OKButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 267);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(507, 62);
            this.ButtonPanel.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(311, 17);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(89, 33);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "&OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CheckoutDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(507, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ButtonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CheckoutDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GForge Document Sync";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CustomPath;
        private System.Windows.Forms.RadioButton CustomName;
        private System.Windows.Forms.RadioButton UnixName;
        private System.Windows.Forms.RadioButton ProjectName;
        private System.Windows.Forms.RadioButton CurrentFolder;
        private System.Windows.Forms.ComboBox ProjectList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}