namespace Server.MirForms.VisualMapInfo.Control.Forms
{
    partial class MiningDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiningDetailForm));
            Range = new TextBox();
            label3 = new Label();
            Y = new TextBox();
            label2 = new Label();
            DoneButton = new Button();
            X = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Range
            // 
            resources.ApplyResources(Range, "Range");
            Range.Name = "Range";
            Range.KeyPress += Insert;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // Y
            // 
            resources.ApplyResources(Y, "Y");
            Y.Name = "Y";
            Y.KeyPress += Insert;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // DoneButton
            // 
            resources.ApplyResources(DoneButton, "DoneButton");
            DoneButton.Name = "DoneButton";
            DoneButton.UseVisualStyleBackColor = true;
            DoneButton.Click += DoneButton_Click;
            // 
            // X
            // 
            resources.ApplyResources(X, "X");
            X.Name = "X";
            X.KeyPress += Insert;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // MiningDetailForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Range);
            Controls.Add(label3);
            Controls.Add(Y);
            Controls.Add(label2);
            Controls.Add(DoneButton);
            Controls.Add(X);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "MiningDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.TextBox Range;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DoneButton;
        public System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label1;
    }
}