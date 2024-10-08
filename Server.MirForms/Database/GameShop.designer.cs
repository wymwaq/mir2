namespace Server
{
    partial class GameShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameShop));
            GameShopListBox = new ListBox();
            label14 = new Label();
            GoldPrice_textbox = new TextBox();
            label21 = new Label();
            GPPrice_textbox = new TextBox();
            label29 = new Label();
            ItemDetails_gb = new GroupBox();
            GoldOnlyBox = new CheckBox();
            CreditOnlyBox = new CheckBox();
            label6 = new Label();
            Count_textbox = new TextBox();
            LeftinStock_label = new Label();
            label3 = new Label();
            label5 = new Label();
            TotalSold_label = new Label();
            TopItem_checkbox = new CheckBox();
            DealofDay_checkbox = new CheckBox();
            Individual_checkbox = new CheckBox();
            label1 = new Label();
            Stock_textbox = new TextBox();
            Category_textbox = new TextBox();
            label4 = new Label();
            Class_combo = new ComboBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            CredxGold_textbox = new TextBox();
            ServerLog_button = new Button();
            Remove_button = new Button();
            ClassFilter_lb = new ComboBox();
            SectionFilter_lb = new ComboBox();
            CategoryFilter_lb = new ComboBox();
            ResetFilter_button = new Button();
            ItemDetails_gb.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // GameShopListBox
            // 
            GameShopListBox.FormattingEnabled = true;
            resources.ApplyResources(GameShopListBox, "GameShopListBox");
            GameShopListBox.Name = "GameShopListBox";
            GameShopListBox.SelectionMode = SelectionMode.MultiExtended;
            GameShopListBox.SelectedIndexChanged += GameShopListBox_SelectedIndexChanged;
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // GoldPrice_textbox
            // 
            resources.ApplyResources(GoldPrice_textbox, "GoldPrice_textbox");
            GoldPrice_textbox.Name = "GoldPrice_textbox";
            GoldPrice_textbox.TextChanged += GoldPrice_textbox_TextChanged;
            // 
            // label21
            // 
            resources.ApplyResources(label21, "label21");
            label21.Name = "label21";
            // 
            // GPPrice_textbox
            // 
            resources.ApplyResources(GPPrice_textbox, "GPPrice_textbox");
            GPPrice_textbox.Name = "GPPrice_textbox";
            GPPrice_textbox.TextChanged += GPPrice_textbox_TextChanged;
            // 
            // label29
            // 
            resources.ApplyResources(label29, "label29");
            label29.Name = "label29";
            // 
            // ItemDetails_gb
            // 
            ItemDetails_gb.BackColor = Color.White;
            ItemDetails_gb.Controls.Add(GoldOnlyBox);
            ItemDetails_gb.Controls.Add(CreditOnlyBox);
            ItemDetails_gb.Controls.Add(label6);
            ItemDetails_gb.Controls.Add(Count_textbox);
            ItemDetails_gb.Controls.Add(LeftinStock_label);
            ItemDetails_gb.Controls.Add(label3);
            ItemDetails_gb.Controls.Add(label5);
            ItemDetails_gb.Controls.Add(TotalSold_label);
            ItemDetails_gb.Controls.Add(TopItem_checkbox);
            ItemDetails_gb.Controls.Add(DealofDay_checkbox);
            ItemDetails_gb.Controls.Add(Individual_checkbox);
            ItemDetails_gb.Controls.Add(label1);
            ItemDetails_gb.Controls.Add(Stock_textbox);
            ItemDetails_gb.Controls.Add(GoldPrice_textbox);
            ItemDetails_gb.Controls.Add(label14);
            ItemDetails_gb.Controls.Add(label21);
            ItemDetails_gb.Controls.Add(Category_textbox);
            ItemDetails_gb.Controls.Add(GPPrice_textbox);
            ItemDetails_gb.Controls.Add(label4);
            ItemDetails_gb.Controls.Add(label29);
            ItemDetails_gb.Controls.Add(Class_combo);
            resources.ApplyResources(ItemDetails_gb, "ItemDetails_gb");
            ItemDetails_gb.Name = "ItemDetails_gb";
            ItemDetails_gb.TabStop = false;
            // 
            // GoldOnlyBox
            // 
            resources.ApplyResources(GoldOnlyBox, "GoldOnlyBox");
            GoldOnlyBox.Name = "GoldOnlyBox";
            GoldOnlyBox.UseVisualStyleBackColor = true;
            GoldOnlyBox.CheckedChanged += GoldOnlyBox_CheckedChanged;
            // 
            // CreditOnlyBox
            // 
            resources.ApplyResources(CreditOnlyBox, "CreditOnlyBox");
            CreditOnlyBox.Name = "CreditOnlyBox";
            CreditOnlyBox.UseVisualStyleBackColor = true;
            CreditOnlyBox.CheckedChanged += CreditOnly_CheckedChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // Count_textbox
            // 
            resources.ApplyResources(Count_textbox, "Count_textbox");
            Count_textbox.Name = "Count_textbox";
            Count_textbox.TextChanged += Count_textbox_TextChanged;
            // 
            // LeftinStock_label
            // 
            resources.ApplyResources(LeftinStock_label, "LeftinStock_label");
            LeftinStock_label.Name = "LeftinStock_label";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // TotalSold_label
            // 
            resources.ApplyResources(TotalSold_label, "TotalSold_label");
            TotalSold_label.Name = "TotalSold_label";
            // 
            // TopItem_checkbox
            // 
            resources.ApplyResources(TopItem_checkbox, "TopItem_checkbox");
            TopItem_checkbox.Name = "TopItem_checkbox";
            TopItem_checkbox.UseVisualStyleBackColor = true;
            TopItem_checkbox.CheckedChanged += TopItem_checkbox_CheckedChanged;
            // 
            // DealofDay_checkbox
            // 
            resources.ApplyResources(DealofDay_checkbox, "DealofDay_checkbox");
            DealofDay_checkbox.Name = "DealofDay_checkbox";
            DealofDay_checkbox.UseVisualStyleBackColor = true;
            DealofDay_checkbox.CheckedChanged += DealofDay_checkbox_CheckedChanged;
            // 
            // Individual_checkbox
            // 
            resources.ApplyResources(Individual_checkbox, "Individual_checkbox");
            Individual_checkbox.Name = "Individual_checkbox";
            Individual_checkbox.UseVisualStyleBackColor = true;
            Individual_checkbox.CheckedChanged += Individual_checkbox_CheckedChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // Stock_textbox
            // 
            resources.ApplyResources(Stock_textbox, "Stock_textbox");
            Stock_textbox.Name = "Stock_textbox";
            Stock_textbox.TextChanged += Stock_textbox_TextChanged;
            // 
            // Category_textbox
            // 
            resources.ApplyResources(Category_textbox, "Category_textbox");
            Category_textbox.Name = "Category_textbox";
            Category_textbox.TextChanged += Category_textbox_TextChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
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
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(CredxGold_textbox);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // CredxGold_textbox
            // 
            resources.ApplyResources(CredxGold_textbox, "CredxGold_textbox");
            CredxGold_textbox.Name = "CredxGold_textbox";
            CredxGold_textbox.TextChanged += CredxGold_textbox_TextChanged;
            // 
            // ServerLog_button
            // 
            resources.ApplyResources(ServerLog_button, "ServerLog_button");
            ServerLog_button.Name = "ServerLog_button";
            ServerLog_button.UseVisualStyleBackColor = true;
            ServerLog_button.Click += ServerLog_button_Click;
            // 
            // Remove_button
            // 
            resources.ApplyResources(Remove_button, "Remove_button");
            Remove_button.Name = "Remove_button";
            Remove_button.UseVisualStyleBackColor = true;
            Remove_button.Click += Remove_button_Click;
            // 
            // ClassFilter_lb
            // 
            ClassFilter_lb.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassFilter_lb.FormattingEnabled = true;
            resources.ApplyResources(ClassFilter_lb, "ClassFilter_lb");
            ClassFilter_lb.Name = "ClassFilter_lb";
            ClassFilter_lb.SelectedIndexChanged += ClassFilter_lb_SelectedIndexChanged;
            // 
            // SectionFilter_lb
            // 
            SectionFilter_lb.DropDownStyle = ComboBoxStyle.DropDownList;
            SectionFilter_lb.FormattingEnabled = true;
            SectionFilter_lb.Items.AddRange(new object[] { resources.GetString("SectionFilter_lb.Items"), resources.GetString("SectionFilter_lb.Items1"), resources.GetString("SectionFilter_lb.Items2"), resources.GetString("SectionFilter_lb.Items3") });
            resources.ApplyResources(SectionFilter_lb, "SectionFilter_lb");
            SectionFilter_lb.Name = "SectionFilter_lb";
            SectionFilter_lb.SelectedIndexChanged += SectionFilter_lb_SelectedIndexChanged;
            // 
            // CategoryFilter_lb
            // 
            CategoryFilter_lb.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryFilter_lb.FormattingEnabled = true;
            resources.ApplyResources(CategoryFilter_lb, "CategoryFilter_lb");
            CategoryFilter_lb.Name = "CategoryFilter_lb";
            CategoryFilter_lb.SelectedIndexChanged += CategoryFilter_lb_SelectedIndexChanged;
            // 
            // ResetFilter_button
            // 
            resources.ApplyResources(ResetFilter_button, "ResetFilter_button");
            ResetFilter_button.Name = "ResetFilter_button";
            ResetFilter_button.UseVisualStyleBackColor = true;
            ResetFilter_button.Click += ResetFilter_button_Click;
            // 
            // GameShop
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ServerLog_button);
            Controls.Add(ResetFilter_button);
            Controls.Add(CategoryFilter_lb);
            Controls.Add(SectionFilter_lb);
            Controls.Add(ClassFilter_lb);
            Controls.Add(Remove_button);
            Controls.Add(groupBox3);
            Controls.Add(ItemDetails_gb);
            Controls.Add(GameShopListBox);
            Name = "GameShop";
            FormClosed += GameShop_FormClosed;
            Load += GameShop_Load;
            ItemDetails_gb.ResumeLayout(false);
            ItemDetails_gb.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox GameShopListBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox GoldPrice_textbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox GPPrice_textbox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox ItemDetails_gb;
        private System.Windows.Forms.ComboBox Class_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox DealofDay_checkbox;
        private System.Windows.Forms.CheckBox TopItem_checkbox;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.TextBox Category_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Individual_checkbox;
        private System.Windows.Forms.TextBox Stock_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CredxGold_textbox;
        private System.Windows.Forms.Label TotalSold_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LeftinStock_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Count_textbox;
        private System.Windows.Forms.ComboBox ClassFilter_lb;
        private System.Windows.Forms.ComboBox SectionFilter_lb;
        private System.Windows.Forms.ComboBox CategoryFilter_lb;
        private System.Windows.Forms.Button ResetFilter_button;
        private System.Windows.Forms.Button ServerLog_button;
        private System.Windows.Forms.CheckBox GoldOnlyBox;
        private System.Windows.Forms.CheckBox CreditOnlyBox;
    }
}