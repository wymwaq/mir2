namespace Server.MirForms.VisualMapInfo.Control
{
    partial class MineEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineEntry));
            MineComboBox = new ComboBox();
            Details = new Label();
            Selected = new CheckBox();
            SuspendLayout();
            // 
            // MineComboBox
            // 
            MineComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MineComboBox.FormattingEnabled = true;
            resources.ApplyResources(MineComboBox, "MineComboBox");
            MineComboBox.Name = "MineComboBox";
            MineComboBox.SelectedIndexChanged += MineComboBox_SelectedIndexChanged;
            MineComboBox.MouseEnter += Region_MouseEnter;
            // 
            // Details
            // 
            resources.ApplyResources(Details, "Details");
            Details.Name = "Details";
            Details.DoubleClick += Details_DoubleClick;
            Details.MouseEnter += Region_MouseEnter;
            // 
            // Selected
            // 
            resources.ApplyResources(Selected, "Selected");
            Selected.Name = "Selected";
            Selected.UseVisualStyleBackColor = true;
            Selected.MouseEnter += Region_MouseEnter;
            // 
            // MineEntry
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Selected);
            Controls.Add(Details);
            Controls.Add(MineComboBox);
            Name = "MineEntry";
            Load += MineEntry_Load;
            MouseEnter += Region_MouseEnter;
            MouseLeave += Region_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox MineComboBox;
        private System.Windows.Forms.Label Details;
        public System.Windows.Forms.CheckBox Selected;
    }
}
