
namespace Server.Database
{
    partial class ItemInfoFormNew
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInfoFormNew));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            itemInfoGridView = new DataGridView();
            Modified = new DataGridViewCheckBoxColumn();
            ItemIndex = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            ItemType = new DataGridViewComboBoxColumn();
            ItemGrade = new DataGridViewComboBoxColumn();
            ItemRequiredType = new DataGridViewComboBoxColumn();
            ItemRequiredGender = new DataGridViewComboBoxColumn();
            ItemRequiredClass = new DataGridViewComboBoxColumn();
            ItemSet = new DataGridViewComboBoxColumn();
            ItemRandomStatsId = new DataGridViewTextBoxColumn();
            ItemRequiredAmount = new DataGridViewTextBoxColumn();
            ItemImage = new DataGridViewTextBoxColumn();
            ItemShape = new DataGridViewTextBoxColumn();
            ItemEffect = new DataGridViewTextBoxColumn();
            ItemStackSize = new DataGridViewTextBoxColumn();
            ItemSlots = new DataGridViewTextBoxColumn();
            ItemWeight = new DataGridViewTextBoxColumn();
            ItemLightRange = new DataGridViewTextBoxColumn();
            ItemLightIntensity = new DataGridViewTextBoxColumn();
            ItemDurability = new DataGridViewTextBoxColumn();
            ItemPrice = new DataGridViewTextBoxColumn();
            ItemToolTip = new DataGridViewTextBoxColumn();
            StartItem = new DataGridViewCheckBoxColumn();
            NeedIdentify = new DataGridViewCheckBoxColumn();
            ShowGroupPickup = new DataGridViewCheckBoxColumn();
            GlobalDropNotify = new DataGridViewCheckBoxColumn();
            ClassBased = new DataGridViewCheckBoxColumn();
            LevelBased = new DataGridViewCheckBoxColumn();
            CanMine = new DataGridViewCheckBoxColumn();
            CanFastRun = new DataGridViewCheckBoxColumn();
            CanAwakening = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            Gameshop_button = new Button();
            btnExport = new Button();
            btnImport = new Button();
            lblFilterType = new Label();
            groupView = new GroupBox();
            rBtnViewSpecial = new RadioButton();
            rbtnViewAll = new RadioButton();
            rbtnViewBinding = new RadioButton();
            rbtnViewBasic = new RadioButton();
            rbtnViewStats = new RadioButton();
            drpFilterType = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)itemInfoGridView).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupView.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // itemInfoGridView
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            itemInfoGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            itemInfoGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemInfoGridView.Columns.AddRange(new DataGridViewColumn[] { Modified, ItemIndex, ItemName, ItemType, ItemGrade, ItemRequiredType, ItemRequiredGender, ItemRequiredClass, ItemSet, ItemRandomStatsId, ItemRequiredAmount, ItemImage, ItemShape, ItemEffect, ItemStackSize, ItemSlots, ItemWeight, ItemLightRange, ItemLightIntensity, ItemDurability, ItemPrice, ItemToolTip, StartItem, NeedIdentify, ShowGroupPickup, GlobalDropNotify, ClassBased, LevelBased, CanMine, CanFastRun, CanAwakening });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            itemInfoGridView.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(itemInfoGridView, "itemInfoGridView");
            itemInfoGridView.Name = "itemInfoGridView";
            itemInfoGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            itemInfoGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemInfoGridView.CurrentCellDirtyStateChanged += CurrentCellDirtyStateChanged;
            itemInfoGridView.DataError += itemInfoGridView_DataError;
            itemInfoGridView.DefaultValuesNeeded += itemInfoGridView_DefaultValuesNeeded;
            itemInfoGridView.UserDeletingRow += itemInfoGridView_UserDeletingRow;
            // 
            // Modified
            // 
            Modified.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Modified.DataPropertyName = "Modified";
            Modified.Frozen = true;
            resources.ApplyResources(Modified, "Modified");
            Modified.Name = "Modified";
            Modified.ReadOnly = true;
            // 
            // ItemIndex
            // 
            ItemIndex.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ItemIndex.DataPropertyName = "ItemIndex";
            ItemIndex.Frozen = true;
            resources.ApplyResources(ItemIndex, "ItemIndex");
            ItemIndex.Name = "ItemIndex";
            ItemIndex.ReadOnly = true;
            // 
            // ItemName
            // 
            ItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ItemName.DataPropertyName = "ItemName";
            ItemName.Frozen = true;
            resources.ApplyResources(ItemName, "ItemName");
            ItemName.Name = "ItemName";
            // 
            // ItemType
            // 
            ItemType.DataPropertyName = "ItemType";
            resources.ApplyResources(ItemType, "ItemType");
            ItemType.Name = "ItemType";
            ItemType.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ItemGrade
            // 
            ItemGrade.DataPropertyName = "ItemGrade";
            resources.ApplyResources(ItemGrade, "ItemGrade");
            ItemGrade.Name = "ItemGrade";
            // 
            // ItemRequiredType
            // 
            ItemRequiredType.DataPropertyName = "ItemRequiredType";
            resources.ApplyResources(ItemRequiredType, "ItemRequiredType");
            ItemRequiredType.Name = "ItemRequiredType";
            // 
            // ItemRequiredGender
            // 
            ItemRequiredGender.DataPropertyName = "ItemRequiredGender";
            resources.ApplyResources(ItemRequiredGender, "ItemRequiredGender");
            ItemRequiredGender.Name = "ItemRequiredGender";
            // 
            // ItemRequiredClass
            // 
            ItemRequiredClass.DataPropertyName = "ItemRequiredClass";
            resources.ApplyResources(ItemRequiredClass, "ItemRequiredClass");
            ItemRequiredClass.Name = "ItemRequiredClass";
            // 
            // ItemSet
            // 
            ItemSet.DataPropertyName = "ItemSet";
            resources.ApplyResources(ItemSet, "ItemSet");
            ItemSet.Name = "ItemSet";
            // 
            // ItemRandomStatsId
            // 
            ItemRandomStatsId.DataPropertyName = "ItemRandomStatsId";
            resources.ApplyResources(ItemRandomStatsId, "ItemRandomStatsId");
            ItemRandomStatsId.Name = "ItemRandomStatsId";
            // 
            // ItemRequiredAmount
            // 
            ItemRequiredAmount.DataPropertyName = "ItemRequiredAmount";
            resources.ApplyResources(ItemRequiredAmount, "ItemRequiredAmount");
            ItemRequiredAmount.Name = "ItemRequiredAmount";
            // 
            // ItemImage
            // 
            ItemImage.DataPropertyName = "ItemImage";
            resources.ApplyResources(ItemImage, "ItemImage");
            ItemImage.Name = "ItemImage";
            // 
            // ItemShape
            // 
            ItemShape.DataPropertyName = "ItemShape";
            resources.ApplyResources(ItemShape, "ItemShape");
            ItemShape.Name = "ItemShape";
            // 
            // ItemEffect
            // 
            ItemEffect.DataPropertyName = "ItemEffect";
            resources.ApplyResources(ItemEffect, "ItemEffect");
            ItemEffect.Name = "ItemEffect";
            // 
            // ItemStackSize
            // 
            ItemStackSize.DataPropertyName = "ItemStackSize";
            resources.ApplyResources(ItemStackSize, "ItemStackSize");
            ItemStackSize.Name = "ItemStackSize";
            // 
            // ItemSlots
            // 
            ItemSlots.DataPropertyName = "ItemSlots";
            resources.ApplyResources(ItemSlots, "ItemSlots");
            ItemSlots.Name = "ItemSlots";
            // 
            // ItemWeight
            // 
            ItemWeight.DataPropertyName = "ItemWeight";
            resources.ApplyResources(ItemWeight, "ItemWeight");
            ItemWeight.Name = "ItemWeight";
            // 
            // ItemLightRange
            // 
            ItemLightRange.DataPropertyName = "ItemLightRange";
            resources.ApplyResources(ItemLightRange, "ItemLightRange");
            ItemLightRange.Name = "ItemLightRange";
            // 
            // ItemLightIntensity
            // 
            ItemLightIntensity.DataPropertyName = "ItemLightIntensity";
            resources.ApplyResources(ItemLightIntensity, "ItemLightIntensity");
            ItemLightIntensity.Name = "ItemLightIntensity";
            // 
            // ItemDurability
            // 
            ItemDurability.DataPropertyName = "ItemDurability";
            resources.ApplyResources(ItemDurability, "ItemDurability");
            ItemDurability.Name = "ItemDurability";
            // 
            // ItemPrice
            // 
            ItemPrice.DataPropertyName = "ItemPrice";
            resources.ApplyResources(ItemPrice, "ItemPrice");
            ItemPrice.Name = "ItemPrice";
            // 
            // ItemToolTip
            // 
            ItemToolTip.DataPropertyName = "ItemToolTip";
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ItemToolTip.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(ItemToolTip, "ItemToolTip");
            ItemToolTip.Name = "ItemToolTip";
            // 
            // StartItem
            // 
            StartItem.DataPropertyName = "StartItem";
            resources.ApplyResources(StartItem, "StartItem");
            StartItem.Name = "StartItem";
            StartItem.Resizable = DataGridViewTriState.True;
            // 
            // NeedIdentify
            // 
            NeedIdentify.DataPropertyName = "NeedIdentify";
            resources.ApplyResources(NeedIdentify, "NeedIdentify");
            NeedIdentify.Name = "NeedIdentify";
            // 
            // ShowGroupPickup
            // 
            ShowGroupPickup.DataPropertyName = "ShowGroupPickup";
            resources.ApplyResources(ShowGroupPickup, "ShowGroupPickup");
            ShowGroupPickup.Name = "ShowGroupPickup";
            // 
            // GlobalDropNotify
            // 
            GlobalDropNotify.DataPropertyName = "GlobalDropNotify";
            resources.ApplyResources(GlobalDropNotify, "GlobalDropNotify");
            GlobalDropNotify.Name = "GlobalDropNotify";
            // 
            // ClassBased
            // 
            ClassBased.DataPropertyName = "ClassBased";
            resources.ApplyResources(ClassBased, "ClassBased");
            ClassBased.Name = "ClassBased";
            // 
            // LevelBased
            // 
            LevelBased.DataPropertyName = "LevelBased";
            resources.ApplyResources(LevelBased, "LevelBased");
            LevelBased.Name = "LevelBased";
            // 
            // CanMine
            // 
            CanMine.DataPropertyName = "CanMine";
            resources.ApplyResources(CanMine, "CanMine");
            CanMine.Name = "CanMine";
            // 
            // CanFastRun
            // 
            CanFastRun.DataPropertyName = "CanFastRun";
            resources.ApplyResources(CanFastRun, "CanFastRun");
            CanFastRun.Name = "CanFastRun";
            // 
            // CanAwakening
            // 
            CanAwakening.DataPropertyName = "CanAwakening";
            resources.ApplyResources(CanAwakening, "CanAwakening");
            CanAwakening.Name = "CanAwakening";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel3
            // 
            panel3.Controls.Add(Gameshop_button);
            panel3.Controls.Add(btnExport);
            panel3.Controls.Add(btnImport);
            panel3.Controls.Add(lblFilterType);
            panel3.Controls.Add(groupView);
            panel3.Controls.Add(drpFilterType);
            panel3.Controls.Add(lblSearch);
            panel3.Controls.Add(txtSearch);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // Gameshop_button
            // 
            resources.ApplyResources(Gameshop_button, "Gameshop_button");
            Gameshop_button.Name = "Gameshop_button";
            Gameshop_button.UseVisualStyleBackColor = true;
            Gameshop_button.Click += Gameshop_button_Click;
            // 
            // btnExport
            // 
            resources.ApplyResources(btnExport, "btnExport");
            btnExport.Name = "btnExport";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            resources.ApplyResources(btnImport, "btnImport");
            btnImport.Name = "btnImport";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // lblFilterType
            // 
            resources.ApplyResources(lblFilterType, "lblFilterType");
            lblFilterType.Name = "lblFilterType";
            // 
            // groupView
            // 
            groupView.Controls.Add(rBtnViewSpecial);
            groupView.Controls.Add(rbtnViewAll);
            groupView.Controls.Add(rbtnViewBinding);
            groupView.Controls.Add(rbtnViewBasic);
            groupView.Controls.Add(rbtnViewStats);
            resources.ApplyResources(groupView, "groupView");
            groupView.Name = "groupView";
            groupView.TabStop = false;
            // 
            // rBtnViewSpecial
            // 
            resources.ApplyResources(rBtnViewSpecial, "rBtnViewSpecial");
            rBtnViewSpecial.Name = "rBtnViewSpecial";
            rBtnViewSpecial.TabStop = true;
            rBtnViewSpecial.UseVisualStyleBackColor = true;
            rBtnViewSpecial.CheckedChanged += rBtnViewSpecial_CheckedChanged;
            // 
            // rbtnViewAll
            // 
            resources.ApplyResources(rbtnViewAll, "rbtnViewAll");
            rbtnViewAll.Checked = true;
            rbtnViewAll.Name = "rbtnViewAll";
            rbtnViewAll.TabStop = true;
            rbtnViewAll.UseVisualStyleBackColor = true;
            rbtnViewAll.CheckedChanged += rbtnViewAll_CheckedChanged;
            // 
            // rbtnViewBinding
            // 
            resources.ApplyResources(rbtnViewBinding, "rbtnViewBinding");
            rbtnViewBinding.Name = "rbtnViewBinding";
            rbtnViewBinding.TabStop = true;
            rbtnViewBinding.UseVisualStyleBackColor = true;
            rbtnViewBinding.CheckedChanged += rbtnViewBinding_CheckedChanged;
            // 
            // rbtnViewBasic
            // 
            resources.ApplyResources(rbtnViewBasic, "rbtnViewBasic");
            rbtnViewBasic.Name = "rbtnViewBasic";
            rbtnViewBasic.TabStop = true;
            rbtnViewBasic.UseVisualStyleBackColor = true;
            rbtnViewBasic.CheckedChanged += rbtnViewBasic_CheckedChanged;
            // 
            // rbtnViewStats
            // 
            resources.ApplyResources(rbtnViewStats, "rbtnViewStats");
            rbtnViewStats.Name = "rbtnViewStats";
            rbtnViewStats.TabStop = true;
            rbtnViewStats.UseVisualStyleBackColor = true;
            rbtnViewStats.CheckedChanged += rbtnViewStats_CheckedChanged;
            // 
            // drpFilterType
            // 
            drpFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            drpFilterType.FormattingEnabled = true;
            resources.ApplyResources(drpFilterType, "drpFilterType");
            drpFilterType.Name = "drpFilterType";
            drpFilterType.SelectedIndexChanged += drpFilterType_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            resources.ApplyResources(lblSearch, "lblSearch");
            lblSearch.Name = "lblSearch";
            // 
            // txtSearch
            // 
            resources.ApplyResources(txtSearch, "txtSearch");
            txtSearch.Name = "txtSearch";
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(itemInfoGridView);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // ItemInfoFormNew
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ItemInfoFormNew";
            FormClosing += ItemInfoFormNew_FormClosing;
            ((System.ComponentModel.ISupportInitialize)itemInfoGridView).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupView.ResumeLayout(false);
            groupView.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView itemInfoGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupView;
        private System.Windows.Forms.RadioButton rbtnViewAll;
        private System.Windows.Forms.RadioButton rbtnViewBinding;
        private System.Windows.Forms.RadioButton rbtnViewBasic;
        private System.Windows.Forms.RadioButton rbtnViewStats;
        private System.Windows.Forms.RadioButton rBtnViewSpecial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.ComboBox drpFilterType;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button Gameshop_button;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modified;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemGrade;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemRequiredType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemRequiredGender;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemRequiredClass;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRandomStatsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRequiredAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemShape;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemEffect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemStackSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemLightRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemLightIntensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDurability;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemToolTip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StartItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NeedIdentify;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ShowGroupPickup;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GlobalDropNotify;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClassBased;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LevelBased;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CanMine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CanFastRun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CanAwakening;
    }
}