
namespace Server.Database
{
    partial class MonsterInfoFormNew
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonsterInfoFormNew));
            monsterInfoGridView = new DataGridView();
            Modified = new DataGridViewCheckBoxColumn();
            MonsterIndex = new DataGridViewTextBoxColumn();
            MonsterName = new DataGridViewTextBoxColumn();
            MonsterImage = new DataGridViewComboBoxColumn();
            MonsterAI = new DataGridViewTextBoxColumn();
            MonsterEffect = new DataGridViewTextBoxColumn();
            MonsterLevel = new DataGridViewTextBoxColumn();
            MonsterLight = new DataGridViewTextBoxColumn();
            MonsterAttackSpeed = new DataGridViewTextBoxColumn();
            MonsterMoveSpeed = new DataGridViewTextBoxColumn();
            MonsterViewRange = new DataGridViewTextBoxColumn();
            MonsterCoolEye = new DataGridViewTextBoxColumn();
            MonsterExperience = new DataGridViewTextBoxColumn();
            MonsterCanPush = new DataGridViewCheckBoxColumn();
            MonsterAutoRev = new DataGridViewCheckBoxColumn();
            MonsterUndead = new DataGridViewCheckBoxColumn();
            MonsterCanTame = new DataGridViewCheckBoxColumn();
            MonsterDropPath = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            btnExport = new Button();
            btnImport = new Button();
            groupView = new GroupBox();
            rbtnViewAll = new RadioButton();
            rbtnViewBasic = new RadioButton();
            lblSearch = new Label();
            txtSearch = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)monsterInfoGridView).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupView.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // monsterInfoGridView
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            monsterInfoGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            monsterInfoGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            monsterInfoGridView.Columns.AddRange(new DataGridViewColumn[] { Modified, MonsterIndex, MonsterName, MonsterImage, MonsterAI, MonsterEffect, MonsterLevel, MonsterLight, MonsterAttackSpeed, MonsterMoveSpeed, MonsterViewRange, MonsterCoolEye, MonsterExperience, MonsterCanPush, MonsterAutoRev, MonsterUndead, MonsterCanTame, MonsterDropPath });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            monsterInfoGridView.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(monsterInfoGridView, "monsterInfoGridView");
            monsterInfoGridView.Name = "monsterInfoGridView";
            monsterInfoGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            monsterInfoGridView.CellValidating += monsterInfoGridView_CellValidating;
            monsterInfoGridView.DataError += monsterInfoGridView_DataError;
            monsterInfoGridView.DefaultValuesNeeded += monsterInfoGridView_DefaultValuesNeeded;
            monsterInfoGridView.UserDeletingRow += monsterInfoGridView_UserDeletingRow;
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
            // MonsterIndex
            // 
            MonsterIndex.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MonsterIndex.DataPropertyName = "MonsterIndex";
            MonsterIndex.Frozen = true;
            resources.ApplyResources(MonsterIndex, "MonsterIndex");
            MonsterIndex.Name = "MonsterIndex";
            MonsterIndex.ReadOnly = true;
            // 
            // MonsterName
            // 
            MonsterName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MonsterName.DataPropertyName = "MonsterName";
            MonsterName.Frozen = true;
            resources.ApplyResources(MonsterName, "MonsterName");
            MonsterName.Name = "MonsterName";
            // 
            // MonsterImage
            // 
            MonsterImage.DataPropertyName = "MonsterImage";
            resources.ApplyResources(MonsterImage, "MonsterImage");
            MonsterImage.Name = "MonsterImage";
            MonsterImage.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MonsterAI
            // 
            MonsterAI.DataPropertyName = "MonsterAI";
            resources.ApplyResources(MonsterAI, "MonsterAI");
            MonsterAI.Name = "MonsterAI";
            // 
            // MonsterEffect
            // 
            MonsterEffect.DataPropertyName = "MonsterEffect";
            resources.ApplyResources(MonsterEffect, "MonsterEffect");
            MonsterEffect.Name = "MonsterEffect";
            // 
            // MonsterLevel
            // 
            MonsterLevel.DataPropertyName = "MonsterLevel";
            resources.ApplyResources(MonsterLevel, "MonsterLevel");
            MonsterLevel.Name = "MonsterLevel";
            // 
            // MonsterLight
            // 
            MonsterLight.DataPropertyName = "MonsterLight";
            resources.ApplyResources(MonsterLight, "MonsterLight");
            MonsterLight.Name = "MonsterLight";
            // 
            // MonsterAttackSpeed
            // 
            MonsterAttackSpeed.DataPropertyName = "MonsterAttackSpeed";
            resources.ApplyResources(MonsterAttackSpeed, "MonsterAttackSpeed");
            MonsterAttackSpeed.Name = "MonsterAttackSpeed";
            // 
            // MonsterMoveSpeed
            // 
            MonsterMoveSpeed.DataPropertyName = "MonsterMoveSpeed";
            resources.ApplyResources(MonsterMoveSpeed, "MonsterMoveSpeed");
            MonsterMoveSpeed.Name = "MonsterMoveSpeed";
            // 
            // MonsterViewRange
            // 
            MonsterViewRange.DataPropertyName = "MonsterViewRange";
            resources.ApplyResources(MonsterViewRange, "MonsterViewRange");
            MonsterViewRange.Name = "MonsterViewRange";
            // 
            // MonsterCoolEye
            // 
            MonsterCoolEye.DataPropertyName = "MonsterCoolEye";
            resources.ApplyResources(MonsterCoolEye, "MonsterCoolEye");
            MonsterCoolEye.Name = "MonsterCoolEye";
            // 
            // MonsterExperience
            // 
            MonsterExperience.DataPropertyName = "MonsterExperience";
            resources.ApplyResources(MonsterExperience, "MonsterExperience");
            MonsterExperience.Name = "MonsterExperience";
            // 
            // MonsterCanPush
            // 
            MonsterCanPush.DataPropertyName = "MonsterCanPush";
            resources.ApplyResources(MonsterCanPush, "MonsterCanPush");
            MonsterCanPush.Name = "MonsterCanPush";
            MonsterCanPush.Resizable = DataGridViewTriState.True;
            MonsterCanPush.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MonsterAutoRev
            // 
            MonsterAutoRev.DataPropertyName = "MonsterAutoRev";
            resources.ApplyResources(MonsterAutoRev, "MonsterAutoRev");
            MonsterAutoRev.Name = "MonsterAutoRev";
            MonsterAutoRev.Resizable = DataGridViewTriState.True;
            MonsterAutoRev.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MonsterUndead
            // 
            MonsterUndead.DataPropertyName = "MonsterUndead";
            resources.ApplyResources(MonsterUndead, "MonsterUndead");
            MonsterUndead.Name = "MonsterUndead";
            MonsterUndead.Resizable = DataGridViewTriState.True;
            MonsterUndead.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MonsterCanTame
            // 
            MonsterCanTame.DataPropertyName = "MonsterCanTame";
            resources.ApplyResources(MonsterCanTame, "MonsterCanTame");
            MonsterCanTame.Name = "MonsterCanTame";
            MonsterCanTame.Resizable = DataGridViewTriState.True;
            MonsterCanTame.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MonsterDropPath
            // 
            MonsterDropPath.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MonsterDropPath.DataPropertyName = "MonsterDropPath";
            resources.ApplyResources(MonsterDropPath, "MonsterDropPath");
            MonsterDropPath.Name = "MonsterDropPath";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExport);
            panel3.Controls.Add(btnImport);
            panel3.Controls.Add(groupView);
            panel3.Controls.Add(lblSearch);
            panel3.Controls.Add(txtSearch);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
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
            // groupView
            // 
            groupView.Controls.Add(rbtnViewAll);
            groupView.Controls.Add(rbtnViewBasic);
            resources.ApplyResources(groupView, "groupView");
            groupView.Name = "groupView";
            groupView.TabStop = false;
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
            // rbtnViewBasic
            // 
            resources.ApplyResources(rbtnViewBasic, "rbtnViewBasic");
            rbtnViewBasic.Name = "rbtnViewBasic";
            rbtnViewBasic.UseVisualStyleBackColor = true;
            rbtnViewBasic.CheckedChanged += rbtnViewBasic_CheckedChanged;
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
            panel2.Controls.Add(monsterInfoGridView);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // MonsterInfoFormNew
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MonsterInfoFormNew";
            FormClosed += monsterInfoFormNew_FormClosed;
            ((System.ComponentModel.ISupportInitialize)monsterInfoGridView).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupView.ResumeLayout(false);
            groupView.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView monsterInfoGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupView;
        private System.Windows.Forms.RadioButton rbtnViewAll;
        private System.Windows.Forms.RadioButton rbtnViewBasic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modified;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterName;
        private System.Windows.Forms.DataGridViewComboBoxColumn MonsterImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterEffect;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterLight;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterAttackSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterMoveSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterViewRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterCoolEye;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterExperience;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MonsterCanPush;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MonsterAutoRev;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MonsterUndead;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MonsterCanTame;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterDropPath;
    }
}