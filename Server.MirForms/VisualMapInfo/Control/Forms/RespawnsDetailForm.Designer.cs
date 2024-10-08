namespace Server.MirForms.VisualMapInfo.Control.Forms
{
    partial class RespawnsDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RespawnsDetailForm));
            Spread = new TextBox();
            label3 = new Label();
            Y = new TextBox();
            label2 = new Label();
            DoneButton = new Button();
            X = new TextBox();
            label1 = new Label();
            Delay = new TextBox();
            label4 = new Label();
            Count = new TextBox();
            label5 = new Label();
            label6 = new Label();
            RoutePath = new TextBox();
            label7 = new Label();
            Direction = new TextBox();
            label8 = new Label();
            RDelay = new TextBox();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // Spread
            // 
            resources.ApplyResources(Spread, "Spread");
            Spread.Name = "Spread";
            Spread.KeyPress += Chk;
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
            Y.KeyPress += Chk;
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
            X.KeyPress += Chk;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // Delay
            // 
            resources.ApplyResources(Delay, "Delay");
            Delay.Name = "Delay";
            Delay.KeyPress += Chk;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // Count
            // 
            resources.ApplyResources(Count, "Count");
            Count.Name = "Count";
            Count.KeyPress += Chk;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // RoutePath
            // 
            resources.ApplyResources(RoutePath, "RoutePath");
            RoutePath.Name = "RoutePath";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // Direction
            // 
            resources.ApplyResources(Direction, "Direction");
            Direction.Name = "Direction";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // RDelay
            // 
            resources.ApplyResources(RDelay, "RDelay");
            RDelay.Name = "RDelay";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // RespawnsDetailForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(RDelay);
            Controls.Add(label8);
            Controls.Add(Direction);
            Controls.Add(label7);
            Controls.Add(RoutePath);
            Controls.Add(label6);
            Controls.Add(Delay);
            Controls.Add(label4);
            Controls.Add(Count);
            Controls.Add(label5);
            Controls.Add(Spread);
            Controls.Add(label3);
            Controls.Add(Y);
            Controls.Add(label2);
            Controls.Add(DoneButton);
            Controls.Add(X);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "RespawnsDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.TextBox Spread;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DoneButton;
        public System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Delay;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox RoutePath;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox Direction;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox RDelay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}