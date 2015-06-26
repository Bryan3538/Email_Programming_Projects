namespace Email_VS_Solutions
{
    partial class ExtensionModificationForm
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
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.extensionsListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(12, 39);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(98, 20);
            this.addTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(116, 37);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(52, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // extensionsListBox
            // 
            this.extensionsListBox.FormattingEnabled = true;
            this.extensionsListBox.Location = new System.Drawing.Point(12, 66);
            this.extensionsListBox.Name = "extensionsListBox";
            this.extensionsListBox.Size = new System.Drawing.Size(156, 186);
            this.extensionsListBox.TabIndex = 2;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 258);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(156, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add/Remove Extensions";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 287);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(93, 287);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ExtensionModificationForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 320);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.extensionsListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExtensionModificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Remove Extensions";
            this.Load += new System.EventHandler(this.ExtensionModificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox extensionsListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}