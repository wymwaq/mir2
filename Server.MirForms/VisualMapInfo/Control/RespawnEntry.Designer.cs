namespace Server.MirForms.VisualMapInfo.Control
{
    partial class RespawnEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RespawnEntry));
            MonsterComboBox = new ComboBox();
            Details = new Label();
            Selected = new CheckBox();
            Count = new TextBox();
            Delay = new TextBox();
            SuspendLayout();
            // 
            // MonsterComboBox
            // 
            resources.ApplyResources(MonsterComboBox, "MonsterComboBox");
            MonsterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MonsterComboBox.FormattingEnabled = true;
            MonsterComboBox.Name = "MonsterComboBox";
            MonsterComboBox.SelectedIndexChanged += MonsterComboBox_SelectedIndexChanged;
            MonsterComboBox.MouseEnter += Region_MouseEnter;
            MonsterComboBox.MouseLeave += Region_MouseLeave;
            // 
            // Details
            // 
            resources.ApplyResources(Details, "Details");
            Details.Name = "Details";
            Details.DoubleClick += Details_DoubleClick;
            Details.MouseEnter += Region_MouseEnter;
            Details.MouseLeave += Region_MouseLeave;
            // 
            // Selected
            // 
            resources.ApplyResources(Selected, "Selected");
            Selected.Name = "Selected";
            Selected.UseVisualStyleBackColor = true;
            Selected.MouseEnter += Region_MouseEnter;
            Selected.MouseLeave += Region_MouseLeave;
            // 
            // Count
            // 
            resources.ApplyResources(Count, "Count");
            Count.Name = "Count";
            Count.MouseEnter += Region_MouseEnter;
            Count.MouseLeave += Region_MouseLeave;
            // 
            // Delay
            // 
            resources.ApplyResources(Delay, "Delay");
            Delay.Name = "Delay";
            Delay.MouseEnter += Region_MouseEnter;
            Delay.MouseLeave += Region_MouseLeave;
            // 
            // RespawnEntry
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Delay);
            Controls.Add(Count);
            Controls.Add(Selected);
            Controls.Add(Details);
            Controls.Add(MonsterComboBox);
            Name = "RespawnEntry";
            Load += RespawnEntry_Load;
            MouseEnter += Region_MouseEnter;
            MouseLeave += Region_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox MonsterComboBox;
        private System.Windows.Forms.Label Details;
        public System.Windows.Forms.CheckBox Selected;
        public System.Windows.Forms.TextBox Count;
        public System.Windows.Forms.TextBox Delay;
    }
}
