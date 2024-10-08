
namespace Server
{
    partial class ChangePasswordDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordDialog));
            PasswordTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(PasswordTextBox, "PasswordTextBox");
            PasswordTextBox.Name = "PasswordTextBox";
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            resources.ApplyResources(okButton, "okButton");
            okButton.Name = "okButton";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            resources.ApplyResources(cancelButton, "cancelButton");
            cancelButton.Name = "cancelButton";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordDialog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(PasswordTextBox);
            Name = "ChangePasswordDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox PasswordTextBox;
    }
}