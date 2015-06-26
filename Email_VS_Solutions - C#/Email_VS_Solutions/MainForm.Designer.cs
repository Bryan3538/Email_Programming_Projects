namespace Email_VS_Solutions
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.badFilesTextBox = new System.Windows.Forms.TextBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyExtensionsButton = new System.Windows.Forms.Button();
            this.rescanProjectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.currentProjectLabel = new System.Windows.Forms.Label();
            this.currentProjectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.backupButton = new System.Windows.Forms.Button();
            this.emailableButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backupDirectoryLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // badFilesTextBox
            // 
            this.badFilesTextBox.Location = new System.Drawing.Point(12, 86);
            this.badFilesTextBox.Name = "badFilesTextBox";
            this.badFilesTextBox.ReadOnly = true;
            this.badFilesTextBox.Size = new System.Drawing.Size(100, 20);
            this.badFilesTextBox.TabIndex = 0;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(140, 539);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(133, 23);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scan Project Folder...";
            this.currentProjectToolTip.SetToolTip(this.scanButton, "Select a project and scan for un-emailable file types.");
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 120);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // modifyExtensionsButton
            // 
            this.modifyExtensionsButton.Location = new System.Drawing.Point(12, 539);
            this.modifyExtensionsButton.Name = "modifyExtensionsButton";
            this.modifyExtensionsButton.Size = new System.Drawing.Size(122, 23);
            this.modifyExtensionsButton.TabIndex = 3;
            this.modifyExtensionsButton.Text = "Extensions List...";
            this.currentProjectToolTip.SetToolTip(this.modifyExtensionsButton, "Modify the extensions that the program looks for.");
            this.modifyExtensionsButton.UseVisualStyleBackColor = true;
            this.modifyExtensionsButton.Click += new System.EventHandler(this.modifyExtensionsButton_Click);
            // 
            // rescanProjectButton
            // 
            this.rescanProjectButton.Location = new System.Drawing.Point(12, 568);
            this.rescanProjectButton.Name = "rescanProjectButton";
            this.rescanProjectButton.Size = new System.Drawing.Size(122, 23);
            this.rescanProjectButton.TabIndex = 4;
            this.rescanProjectButton.Text = "Rescan Project";
            this.currentProjectToolTip.SetToolTip(this.rescanProjectButton, "Rescan the current project directory for un-emailable file types.");
            this.rescanProjectButton.UseVisualStyleBackColor = true;
            this.rescanProjectButton.Click += new System.EventHandler(this.rescanProjectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Project Directory: ";
            // 
            // currentProjectLabel
            // 
            this.currentProjectLabel.AutoSize = true;
            this.currentProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProjectLabel.Location = new System.Drawing.Point(511, 544);
            this.currentProjectLabel.MaximumSize = new System.Drawing.Size(415, 13);
            this.currentProjectLabel.MinimumSize = new System.Drawing.Size(415, 13);
            this.currentProjectLabel.Name = "currentProjectLabel";
            this.currentProjectLabel.Size = new System.Drawing.Size(415, 13);
            this.currentProjectLabel.TabIndex = 6;
            this.currentProjectLabel.Text = "None";
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(140, 568);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(133, 23);
            this.backupButton.TabIndex = 8;
            this.backupButton.Text = "Backup Project To...";
            this.currentProjectToolTip.SetToolTip(this.backupButton, "Create a backup copy of the currently selected project.");
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupDirectory);
            // 
            // emailableButton
            // 
            this.emailableButton.Location = new System.Drawing.Point(279, 539);
            this.emailableButton.Name = "emailableButton";
            this.emailableButton.Size = new System.Drawing.Size(101, 23);
            this.emailableButton.TabIndex = 11;
            this.emailableButton.Text = "Make Emailable";
            this.currentProjectToolTip.SetToolTip(this.emailableButton, "Modify the un-emailable files in the current project directory to make the projec" +
        "t emailable.");
            this.emailableButton.UseVisualStyleBackColor = true;
            this.emailableButton.Click += new System.EventHandler(this.emailableButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(279, 568);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(101, 23);
            this.restoreButton.TabIndex = 12;
            this.restoreButton.Text = "Restore Project";
            this.currentProjectToolTip.SetToolTip(this.restoreButton, "Restore the files modified by this program in the \'Make Emailable\' operation.");
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(935, 568);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Project Backup Directory:";
            // 
            // backupDirectoryLabel
            // 
            this.backupDirectoryLabel.AutoSize = true;
            this.backupDirectoryLabel.Location = new System.Drawing.Point(511, 573);
            this.backupDirectoryLabel.Name = "backupDirectoryLabel";
            this.backupDirectoryLabel.Size = new System.Drawing.Size(33, 13);
            this.backupDirectoryLabel.TabIndex = 10;
            this.backupDirectoryLabel.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(621, 9);
            this.label4.MaximumSize = new System.Drawing.Size(1000, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 120);
            this.label4.TabIndex = 13;
            this.label4.Text = "Restoring Insctructions:\r\n1. Refer to 1 and 2 in the Emailing Instructions.\r\n2. B" +
    "ackup the project before modifying it (Optional).\r\n3. Click the Restore Project " +
    "button.\r\n\r\n ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.emailableButton);
            this.Controls.Add(this.backupDirectoryLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.currentProjectLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rescanProjectButton);
            this.Controls.Add(this.modifyExtensionsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.badFilesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Project Email Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox badFilesTextBox;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifyExtensionsButton;
        private System.Windows.Forms.Button rescanProjectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentProjectLabel;
        private System.Windows.Forms.ToolTip currentProjectToolTip;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label backupDirectoryLabel;
        private System.Windows.Forms.Button emailableButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Label label4;
    }
}

