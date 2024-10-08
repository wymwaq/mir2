namespace Server
{
    partial class NPCInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPCInfoForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            NPCPreview = new PictureBox();
            TeleportToCheckBox = new CheckBox();
            label15 = new Label();
            BigMapIconTextBox = new TextBox();
            ShowBigMapCheckBox = new CheckBox();
            label14 = new Label();
            ConquestHidden_combo = new ComboBox();
            label2 = new Label();
            MapComboBox = new ComboBox();
            label11 = new Label();
            OpenNButton = new Button();
            NFileNameTextBox = new TextBox();
            label29 = new Label();
            NRateTextBox = new TextBox();
            ClearHButton = new Button();
            NNameTextBox = new TextBox();
            label13 = new Label();
            NPCIndexTextBox = new TextBox();
            label24 = new Label();
            label1 = new Label();
            NImageTextBox = new TextBox();
            NXTextBox = new TextBox();
            label28 = new Label();
            label30 = new Label();
            NYTextBox = new TextBox();
            tabPage2 = new TabPage();
            ConquestVisible_checkbox = new CheckBox();
            Flag_textbox = new TextBox();
            label12 = new Label();
            label10 = new Label();
            Day_combo = new ComboBox();
            Class_combo = new ComboBox();
            EndMin_num = new NumericUpDown();
            EndHour_combo = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            StartMin_num = new NumericUpDown();
            StartHour_combo = new ComboBox();
            TimeVisible_checkbox = new CheckBox();
            label7 = new Label();
            MaxLev_textbox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            MinLev_textbox = new TextBox();
            RemoveButton = new Button();
            AddButton = new Button();
            NPCInfoListBox = new ListBox();
            PasteMButton = new Button();
            CopyMButton = new Button();
            ExportButton = new Button();
            ImportButton = new Button();
            ExportSelectedButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NPCPreview).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EndMin_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartMin_num).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(NPCPreview);
            tabPage1.Controls.Add(TeleportToCheckBox);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(BigMapIconTextBox);
            tabPage1.Controls.Add(ShowBigMapCheckBox);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(ConquestHidden_combo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(MapComboBox);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(OpenNButton);
            tabPage1.Controls.Add(NFileNameTextBox);
            tabPage1.Controls.Add(label29);
            tabPage1.Controls.Add(NRateTextBox);
            tabPage1.Controls.Add(ClearHButton);
            tabPage1.Controls.Add(NNameTextBox);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(NPCIndexTextBox);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(NImageTextBox);
            tabPage1.Controls.Add(NXTextBox);
            tabPage1.Controls.Add(label28);
            tabPage1.Controls.Add(label30);
            tabPage1.Controls.Add(NYTextBox);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // NPCPreview
            // 
            resources.ApplyResources(NPCPreview, "NPCPreview");
            NPCPreview.Name = "NPCPreview";
            NPCPreview.TabStop = false;
            // 
            // TeleportToCheckBox
            // 
            resources.ApplyResources(TeleportToCheckBox, "TeleportToCheckBox");
            TeleportToCheckBox.Name = "TeleportToCheckBox";
            TeleportToCheckBox.UseVisualStyleBackColor = true;
            TeleportToCheckBox.CheckedChanged += TeleportToCheckBox_CheckedChanged;
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // BigMapIconTextBox
            // 
            resources.ApplyResources(BigMapIconTextBox, "BigMapIconTextBox");
            BigMapIconTextBox.Name = "BigMapIconTextBox";
            BigMapIconTextBox.TextChanged += BigMapIconTextBox_TextChanged;
            // 
            // ShowBigMapCheckBox
            // 
            resources.ApplyResources(ShowBigMapCheckBox, "ShowBigMapCheckBox");
            ShowBigMapCheckBox.Name = "ShowBigMapCheckBox";
            ShowBigMapCheckBox.UseVisualStyleBackColor = true;
            ShowBigMapCheckBox.CheckedChanged += ShowBigMapCheckBox_CheckedChanged;
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // ConquestHidden_combo
            // 
            ConquestHidden_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            ConquestHidden_combo.FormattingEnabled = true;
            ConquestHidden_combo.Items.AddRange(new object[] { resources.GetString("ConquestHidden_combo.Items"), resources.GetString("ConquestHidden_combo.Items1"), resources.GetString("ConquestHidden_combo.Items2"), resources.GetString("ConquestHidden_combo.Items3"), resources.GetString("ConquestHidden_combo.Items4"), resources.GetString("ConquestHidden_combo.Items5") });
            resources.ApplyResources(ConquestHidden_combo, "ConquestHidden_combo");
            ConquestHidden_combo.Name = "ConquestHidden_combo";
            ConquestHidden_combo.SelectedIndexChanged += ConquestHidden_combo_SelectedIndexChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // MapComboBox
            // 
            MapComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MapComboBox.FormattingEnabled = true;
            resources.ApplyResources(MapComboBox, "MapComboBox");
            MapComboBox.Name = "MapComboBox";
            MapComboBox.SelectedIndexChanged += MapComboBox_SelectedIndexChanged;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // OpenNButton
            // 
            resources.ApplyResources(OpenNButton, "OpenNButton");
            OpenNButton.Name = "OpenNButton";
            OpenNButton.UseVisualStyleBackColor = true;
            OpenNButton.Click += OpenNButton_Click;
            // 
            // NFileNameTextBox
            // 
            resources.ApplyResources(NFileNameTextBox, "NFileNameTextBox");
            NFileNameTextBox.Name = "NFileNameTextBox";
            NFileNameTextBox.TextChanged += NFileNameTextBox_TextChanged;
            // 
            // label29
            // 
            resources.ApplyResources(label29, "label29");
            label29.Name = "label29";
            // 
            // NRateTextBox
            // 
            resources.ApplyResources(NRateTextBox, "NRateTextBox");
            NRateTextBox.Name = "NRateTextBox";
            NRateTextBox.TextChanged += NRateTextBox_TextChanged;
            // 
            // ClearHButton
            // 
            resources.ApplyResources(ClearHButton, "ClearHButton");
            ClearHButton.Name = "ClearHButton";
            ClearHButton.UseVisualStyleBackColor = true;
            // 
            // NNameTextBox
            // 
            resources.ApplyResources(NNameTextBox, "NNameTextBox");
            NNameTextBox.Name = "NNameTextBox";
            NNameTextBox.TextChanged += NNameTextBox_TextChanged;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // NPCIndexTextBox
            // 
            resources.ApplyResources(NPCIndexTextBox, "NPCIndexTextBox");
            NPCIndexTextBox.Name = "NPCIndexTextBox";
            NPCIndexTextBox.ReadOnly = true;
            // 
            // label24
            // 
            resources.ApplyResources(label24, "label24");
            label24.Name = "label24";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // NImageTextBox
            // 
            resources.ApplyResources(NImageTextBox, "NImageTextBox");
            NImageTextBox.Name = "NImageTextBox";
            NImageTextBox.TextChanged += NImageTextBox_TextChanged;
            // 
            // NXTextBox
            // 
            resources.ApplyResources(NXTextBox, "NXTextBox");
            NXTextBox.Name = "NXTextBox";
            NXTextBox.TextChanged += NXTextBox_TextChanged;
            // 
            // label28
            // 
            resources.ApplyResources(label28, "label28");
            label28.Name = "label28";
            // 
            // label30
            // 
            resources.ApplyResources(label30, "label30");
            label30.Name = "label30";
            // 
            // NYTextBox
            // 
            resources.ApplyResources(NYTextBox, "NYTextBox");
            NYTextBox.Name = "NYTextBox";
            NYTextBox.TextChanged += NYTextBox_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ConquestVisible_checkbox);
            tabPage2.Controls.Add(Flag_textbox);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(Day_combo);
            tabPage2.Controls.Add(Class_combo);
            tabPage2.Controls.Add(EndMin_num);
            tabPage2.Controls.Add(EndHour_combo);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(StartMin_num);
            tabPage2.Controls.Add(StartHour_combo);
            tabPage2.Controls.Add(TimeVisible_checkbox);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(MaxLev_textbox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(MinLev_textbox);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ConquestVisible_checkbox
            // 
            resources.ApplyResources(ConquestVisible_checkbox, "ConquestVisible_checkbox");
            ConquestVisible_checkbox.Name = "ConquestVisible_checkbox";
            ConquestVisible_checkbox.UseVisualStyleBackColor = true;
            ConquestVisible_checkbox.CheckedChanged += ConquestVisible_checkbox_CheckedChanged;
            // 
            // Flag_textbox
            // 
            resources.ApplyResources(Flag_textbox, "Flag_textbox");
            Flag_textbox.Name = "Flag_textbox";
            Flag_textbox.TextChanged += Flag_textbox_TextChanged;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // Day_combo
            // 
            Day_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            Day_combo.FormattingEnabled = true;
            Day_combo.Items.AddRange(new object[] { resources.GetString("Day_combo.Items"), resources.GetString("Day_combo.Items1"), resources.GetString("Day_combo.Items2"), resources.GetString("Day_combo.Items3"), resources.GetString("Day_combo.Items4"), resources.GetString("Day_combo.Items5"), resources.GetString("Day_combo.Items6"), resources.GetString("Day_combo.Items7") });
            resources.ApplyResources(Day_combo, "Day_combo");
            Day_combo.Name = "Day_combo";
            Day_combo.SelectedIndexChanged += Day_combo_SelectedIndexChanged;
            // 
            // Class_combo
            // 
            Class_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            Class_combo.FormattingEnabled = true;
            Class_combo.Items.AddRange(new object[] { resources.GetString("Class_combo.Items"), resources.GetString("Class_combo.Items1"), resources.GetString("Class_combo.Items2"), resources.GetString("Class_combo.Items3"), resources.GetString("Class_combo.Items4"), resources.GetString("Class_combo.Items5") });
            resources.ApplyResources(Class_combo, "Class_combo");
            Class_combo.Name = "Class_combo";
            Class_combo.SelectedIndexChanged += Class_combo_SelectedIndexChanged;
            // 
            // EndMin_num
            // 
            resources.ApplyResources(EndMin_num, "EndMin_num");
            EndMin_num.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            EndMin_num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EndMin_num.Name = "EndMin_num";
            EndMin_num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            EndMin_num.ValueChanged += EndMin_num_ValueChanged;
            // 
            // EndHour_combo
            // 
            EndHour_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            EndHour_combo.FormattingEnabled = true;
            EndHour_combo.Items.AddRange(new object[] { resources.GetString("EndHour_combo.Items"), resources.GetString("EndHour_combo.Items1"), resources.GetString("EndHour_combo.Items2"), resources.GetString("EndHour_combo.Items3"), resources.GetString("EndHour_combo.Items4"), resources.GetString("EndHour_combo.Items5"), resources.GetString("EndHour_combo.Items6"), resources.GetString("EndHour_combo.Items7"), resources.GetString("EndHour_combo.Items8"), resources.GetString("EndHour_combo.Items9"), resources.GetString("EndHour_combo.Items10"), resources.GetString("EndHour_combo.Items11"), resources.GetString("EndHour_combo.Items12"), resources.GetString("EndHour_combo.Items13"), resources.GetString("EndHour_combo.Items14"), resources.GetString("EndHour_combo.Items15"), resources.GetString("EndHour_combo.Items16"), resources.GetString("EndHour_combo.Items17"), resources.GetString("EndHour_combo.Items18"), resources.GetString("EndHour_combo.Items19"), resources.GetString("EndHour_combo.Items20"), resources.GetString("EndHour_combo.Items21"), resources.GetString("EndHour_combo.Items22"), resources.GetString("EndHour_combo.Items23") });
            resources.ApplyResources(EndHour_combo, "EndHour_combo");
            EndHour_combo.Name = "EndHour_combo";
            EndHour_combo.SelectedIndexChanged += EndHour_combo_SelectedIndexChanged;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // StartMin_num
            // 
            resources.ApplyResources(StartMin_num, "StartMin_num");
            StartMin_num.Maximum = new decimal(new int[] { 58, 0, 0, 0 });
            StartMin_num.Name = "StartMin_num";
            StartMin_num.ValueChanged += StartMin_num_ValueChanged;
            // 
            // StartHour_combo
            // 
            StartHour_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            StartHour_combo.FormattingEnabled = true;
            StartHour_combo.Items.AddRange(new object[] { resources.GetString("StartHour_combo.Items"), resources.GetString("StartHour_combo.Items1"), resources.GetString("StartHour_combo.Items2"), resources.GetString("StartHour_combo.Items3"), resources.GetString("StartHour_combo.Items4"), resources.GetString("StartHour_combo.Items5"), resources.GetString("StartHour_combo.Items6"), resources.GetString("StartHour_combo.Items7"), resources.GetString("StartHour_combo.Items8"), resources.GetString("StartHour_combo.Items9"), resources.GetString("StartHour_combo.Items10"), resources.GetString("StartHour_combo.Items11"), resources.GetString("StartHour_combo.Items12"), resources.GetString("StartHour_combo.Items13"), resources.GetString("StartHour_combo.Items14"), resources.GetString("StartHour_combo.Items15"), resources.GetString("StartHour_combo.Items16"), resources.GetString("StartHour_combo.Items17"), resources.GetString("StartHour_combo.Items18"), resources.GetString("StartHour_combo.Items19"), resources.GetString("StartHour_combo.Items20"), resources.GetString("StartHour_combo.Items21"), resources.GetString("StartHour_combo.Items22"), resources.GetString("StartHour_combo.Items23") });
            resources.ApplyResources(StartHour_combo, "StartHour_combo");
            StartHour_combo.Name = "StartHour_combo";
            StartHour_combo.SelectedIndexChanged += StartHour_combo_SelectedIndexChanged;
            // 
            // TimeVisible_checkbox
            // 
            resources.ApplyResources(TimeVisible_checkbox, "TimeVisible_checkbox");
            TimeVisible_checkbox.Name = "TimeVisible_checkbox";
            TimeVisible_checkbox.UseVisualStyleBackColor = true;
            TimeVisible_checkbox.CheckedChanged += TimeVisible_checkbox_CheckedChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // MaxLev_textbox
            // 
            resources.ApplyResources(MaxLev_textbox, "MaxLev_textbox");
            MaxLev_textbox.Name = "MaxLev_textbox";
            MaxLev_textbox.TextChanged += MaxLev_textbox_TextChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // MinLev_textbox
            // 
            resources.ApplyResources(MinLev_textbox, "MinLev_textbox");
            MinLev_textbox.Name = "MinLev_textbox";
            MinLev_textbox.TextChanged += MinLev_textbox_TextChanged;
            // 
            // RemoveButton
            // 
            resources.ApplyResources(RemoveButton, "RemoveButton");
            RemoveButton.Name = "RemoveButton";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            resources.ApplyResources(AddButton, "AddButton");
            AddButton.Name = "AddButton";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NPCInfoListBox
            // 
            resources.ApplyResources(NPCInfoListBox, "NPCInfoListBox");
            NPCInfoListBox.FormattingEnabled = true;
            NPCInfoListBox.Name = "NPCInfoListBox";
            NPCInfoListBox.SelectionMode = SelectionMode.MultiExtended;
            NPCInfoListBox.SelectedIndexChanged += NPCInfoListBox_SelectedIndexChanged;
            // 
            // PasteMButton
            // 
            resources.ApplyResources(PasteMButton, "PasteMButton");
            PasteMButton.Name = "PasteMButton";
            PasteMButton.UseVisualStyleBackColor = true;
            PasteMButton.Click += PasteMButton_Click;
            // 
            // CopyMButton
            // 
            resources.ApplyResources(CopyMButton, "CopyMButton");
            CopyMButton.Name = "CopyMButton";
            CopyMButton.UseVisualStyleBackColor = true;
            CopyMButton.Click += CopyMButton_Click;
            // 
            // ExportButton
            // 
            resources.ApplyResources(ExportButton, "ExportButton");
            ExportButton.Name = "ExportButton";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportAllButton_Click;
            // 
            // ImportButton
            // 
            resources.ApplyResources(ImportButton, "ImportButton");
            ImportButton.Name = "ImportButton";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // ExportSelectedButton
            // 
            resources.ApplyResources(ExportSelectedButton, "ExportSelectedButton");
            ExportSelectedButton.Name = "ExportSelectedButton";
            ExportSelectedButton.UseVisualStyleBackColor = true;
            ExportSelectedButton.Click += ExportSelected_Click;
            // 
            // NPCInfoForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExportSelectedButton);
            Controls.Add(ImportButton);
            Controls.Add(ExportButton);
            Controls.Add(PasteMButton);
            Controls.Add(CopyMButton);
            Controls.Add(tabControl1);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(NPCInfoListBox);
            Name = "NPCInfoForm";
            FormClosed += NPCInfoForm_FormClosed;
            Load += NPCInfoForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NPCPreview).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EndMin_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartMin_num).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox NPCIndexTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button PasteMButton;
        private System.Windows.Forms.Button CopyMButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportSelectedButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button OpenNButton;
        private System.Windows.Forms.TextBox NFileNameTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox NRateTextBox;
        private System.Windows.Forms.Button ClearHButton;
        private System.Windows.Forms.TextBox NNameTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox NImageTextBox;
        private System.Windows.Forms.TextBox NXTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox NYTextBox;
        private System.Windows.Forms.ListBox NPCInfoListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MapComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinLev_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Day_combo;
        private System.Windows.Forms.ComboBox Class_combo;
        private System.Windows.Forms.NumericUpDown EndMin_num;
        private System.Windows.Forms.ComboBox EndHour_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown StartMin_num;
        private System.Windows.Forms.ComboBox StartHour_combo;
        private System.Windows.Forms.CheckBox TimeVisible_checkbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaxLev_textbox;
        private System.Windows.Forms.TextBox Flag_textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ConquestHidden_combo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox BigMapIconTextBox;
        private System.Windows.Forms.CheckBox ShowBigMapCheckBox;
        private System.Windows.Forms.CheckBox TeleportToCheckBox;
        private CheckBox ConquestVisible_checkbox;
        private PictureBox NPCPreview;
    }
}