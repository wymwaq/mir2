using Server.MirDatabase;
using Server.MirEnvir;

namespace Server
{
    public partial class MagicInfoForm : Form
    {

        public Envir Envir => SMain.EditEnvir;

        private MagicInfo _selectedMagicInfo;

        public MagicInfoForm()
        {
            InitializeComponent();
            for (int i = 0; i < Envir.MagicInfoList.Count; i++)
                MagiclistBox.Items.Add(Envir.MagicInfoList[i]);
            UpdateMagicForm();
        }

        private void UpdateMagicForm(byte field = 0)
        {
             _selectedMagicInfo = (MagicInfo)MagiclistBox.SelectedItem;

             lblBookValid.BackColor = SystemColors.Window;

             if (_selectedMagicInfo == null)
             {
                 tabControl1.Enabled = false;
                 lblBookValid.Text = "Searching";
                 lblSelected.Text = "Selected Skill: none";
                 lblDamageExample.Text = "";
                 lblDamageExplained.Text = "";
                 txtSkillIcon.Text = "0";
                 txtSkillLvl1Points.Text = "0";
                 txtSkillLvl1Req.Text = "0";
                 txtSkillLvl2Points.Text = "0";
                 txtSkillLvl2Req.Text = "0";
                 txtSkillLvl3Points.Text = "0";
                 txtSkillLvl3Req.Text = "0";
                 txtMPBase.Text = "0";
                 txtMPIncrease.Text = "0";
                 txtDelayBase.Text = "0";
                 txtDelayReduction.Text = "0";
                 txtDmgBaseMin.Text = "0";
                 txtDmgBaseMax.Text = "0";
                 txtDmgBonusMin.Text = "0";
                 txtDmgBonusMax.Text = "0";
             }
             else
             {
                 tabControl1.Enabled = true;
                 lblSelected.Text = "Selected Skill: " + _selectedMagicInfo.ToString();
                 lblDamageExample.Text =
                     $"Damage @ Skill level 0: {GetMinPower(0):000}-{GetMaxPower(0):000}   |||   level 1: {GetMinPower(1):000}-{GetMaxPower(1):000}   |||   level 2: {GetMinPower(2):000}-{GetMaxPower(2):000}   |||   level 3: {GetMinPower(3):000}-{GetMaxPower(3):000}";
                 lblDamageExplained.Text =
                     $"Damage: {{Random(minstat-maxstat) + [<(random({_selectedMagicInfo.MPowerBase}-{_selectedMagicInfo.MPowerBase + _selectedMagicInfo.MPowerBonus})/4) X (skill level +1)> + random<{_selectedMagicInfo.PowerBase}-{_selectedMagicInfo.PowerBonus + _selectedMagicInfo.PowerBase}>]}}  X  {{{_selectedMagicInfo.MultiplierBase} + (skill level * {_selectedMagicInfo.MultiplierBonus})}}";
                 txtSkillIcon.Text = _selectedMagicInfo.Icon.ToString();
                 txtSkillLvl1Points.Text = _selectedMagicInfo.Need1.ToString();
                 txtSkillLvl1Req.Text = _selectedMagicInfo.Level1.ToString();
                 txtSkillLvl2Points.Text = _selectedMagicInfo.Need2.ToString();
                 txtSkillLvl2Req.Text = _selectedMagicInfo.Level2.ToString();
                 txtSkillLvl3Points.Text = _selectedMagicInfo.Need3.ToString();
                 txtSkillLvl3Req.Text = _selectedMagicInfo.Level3.ToString();
                 txtMPBase.Text = _selectedMagicInfo.BaseCost.ToString();
                 txtMPIncrease.Text = _selectedMagicInfo.LevelCost.ToString();
                 txtDelayBase.Text = _selectedMagicInfo.DelayBase.ToString();
                 txtDelayReduction.Text = _selectedMagicInfo.DelayReduction.ToString();
                 txtDmgBaseMin.Text = _selectedMagicInfo.PowerBase.ToString();
                 txtDmgBaseMax.Text = (_selectedMagicInfo.PowerBase + _selectedMagicInfo.PowerBonus).ToString();
                 txtDmgBonusMin.Text = _selectedMagicInfo.MPowerBase.ToString();
                 txtDmgBonusMax.Text = (_selectedMagicInfo.MPowerBase + _selectedMagicInfo.MPowerBonus).ToString();
                 if (field != 1)
                    txtDmgMultBase.Text = _selectedMagicInfo.MultiplierBase.ToString();
                 if (field != 2)
                 txtDmgMultBoost.Text = _selectedMagicInfo.MultiplierBonus.ToString();
                 txtRange.Text = _selectedMagicInfo.Range.ToString();
                 ItemInfo Book = Envir.GetBook((short)_selectedMagicInfo.Spell);
                 if (Book != null)
                 {
                     lblBookValid.Text = Book.Name;
                 }
                 else
                 {
                     lblBookValid.Text = "No book found";
                     lblBookValid.BackColor = Color.Red;
                 }
                this.textBoxName.Text = _selectedMagicInfo.Name;
             }
        }

        private int GetMaxPower(byte level)
        {
            if (_selectedMagicInfo == null) return 0;
            return (int)Math.Round((((_selectedMagicInfo.MPowerBase + _selectedMagicInfo.MPowerBonus) / 4F) * (level + 1) + (_selectedMagicInfo.PowerBase + _selectedMagicInfo.PowerBonus))* (_selectedMagicInfo.MultiplierBase + (level * _selectedMagicInfo.MultiplierBonus)));
        }
        private int GetMinPower(byte level)
        {
            if (_selectedMagicInfo == null) return 0;
            return (int)Math.Round(((_selectedMagicInfo.MPowerBase / 4F) * (level + 1) + _selectedMagicInfo.PowerBase) * (_selectedMagicInfo.MultiplierBase + (level * _selectedMagicInfo.MultiplierBonus)));
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicInfoForm));
            MagiclistBox = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label24 = new Label();
            label23 = new Label();
            textBoxName = new TextBox();
            lblDamageExample = new Label();
            lblDamageExplained = new Label();
            lblSelected = new Label();
            panel4 = new Panel();
            txtDmgMultBoost = new TextBox();
            txtDmgMultBase = new TextBox();
            label21 = new Label();
            label22 = new Label();
            txtDmgBonusMax = new TextBox();
            txtDmgBonusMin = new TextBox();
            label18 = new Label();
            label19 = new Label();
            txtDmgBaseMax = new TextBox();
            txtDmgBaseMin = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            panel3 = new Panel();
            label20 = new Label();
            txtRange = new TextBox();
            txtDelayReduction = new TextBox();
            txtDelayBase = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            txtMPIncrease = new TextBox();
            txtMPBase = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            txtSkillLvl3Points = new TextBox();
            txtSkillLvl2Points = new TextBox();
            txtSkillLvl1Points = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSkillLvl3Req = new TextBox();
            txtSkillLvl2Req = new TextBox();
            txtSkillLvl1Req = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSkillIcon = new TextBox();
            label1 = new Label();
            lblBookValid = new Label();
            toolTip1 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MagiclistBox
            // 
            resources.ApplyResources(MagiclistBox, "MagiclistBox");
            MagiclistBox.FormattingEnabled = true;
            MagiclistBox.Name = "MagiclistBox";
            MagiclistBox.SelectedIndexChanged += MagiclistBox_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(textBoxName);
            tabPage1.Controls.Add(lblDamageExample);
            tabPage1.Controls.Add(lblDamageExplained);
            tabPage1.Controls.Add(lblSelected);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(txtSkillIcon);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lblBookValid);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            resources.ApplyResources(label24, "label24");
            label24.Name = "label24";
            // 
            // label23
            // 
            resources.ApplyResources(label23, "label23");
            label23.Name = "label23";
            // 
            // textBoxName
            // 
            resources.ApplyResources(textBoxName, "textBoxName");
            textBoxName.Name = "textBoxName";
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // lblDamageExample
            // 
            resources.ApplyResources(lblDamageExample, "lblDamageExample");
            lblDamageExample.Name = "lblDamageExample";
            // 
            // lblDamageExplained
            // 
            resources.ApplyResources(lblDamageExplained, "lblDamageExplained");
            lblDamageExplained.Name = "lblDamageExplained";
            // 
            // lblSelected
            // 
            resources.ApplyResources(lblSelected, "lblSelected");
            lblSelected.Name = "lblSelected";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtDmgMultBoost);
            panel4.Controls.Add(txtDmgMultBase);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(txtDmgBonusMax);
            panel4.Controls.Add(txtDmgBonusMin);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(txtDmgBaseMax);
            panel4.Controls.Add(txtDmgBaseMin);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // txtDmgMultBoost
            // 
            resources.ApplyResources(txtDmgMultBoost, "txtDmgMultBoost");
            txtDmgMultBoost.Name = "txtDmgMultBoost";
            toolTip1.SetToolTip(txtDmgMultBoost, resources.GetString("txtDmgMultBoost.ToolTip"));
            txtDmgMultBoost.TextChanged += txtDmgMultBoost_TextChanged;
            // 
            // txtDmgMultBase
            // 
            resources.ApplyResources(txtDmgMultBase, "txtDmgMultBase");
            txtDmgMultBase.Name = "txtDmgMultBase";
            toolTip1.SetToolTip(txtDmgMultBase, resources.GetString("txtDmgMultBase.ToolTip"));
            txtDmgMultBase.TextChanged += txtDmgMultBase_TextChanged;
            // 
            // label21
            // 
            resources.ApplyResources(label21, "label21");
            label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(label22, "label22");
            label22.Name = "label22";
            // 
            // txtDmgBonusMax
            // 
            resources.ApplyResources(txtDmgBonusMax, "txtDmgBonusMax");
            txtDmgBonusMax.Name = "txtDmgBonusMax";
            toolTip1.SetToolTip(txtDmgBonusMax, resources.GetString("txtDmgBonusMax.ToolTip"));
            txtDmgBonusMax.TextChanged += txtDmgBonusMax_TextChanged;
            // 
            // txtDmgBonusMin
            // 
            resources.ApplyResources(txtDmgBonusMin, "txtDmgBonusMin");
            txtDmgBonusMin.Name = "txtDmgBonusMin";
            toolTip1.SetToolTip(txtDmgBonusMin, resources.GetString("txtDmgBonusMin.ToolTip"));
            txtDmgBonusMin.TextChanged += txtDmgBonusMin_TextChanged;
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(label19, "label19");
            label19.Name = "label19";
            // 
            // txtDmgBaseMax
            // 
            resources.ApplyResources(txtDmgBaseMax, "txtDmgBaseMax");
            txtDmgBaseMax.Name = "txtDmgBaseMax";
            toolTip1.SetToolTip(txtDmgBaseMax, resources.GetString("txtDmgBaseMax.ToolTip"));
            txtDmgBaseMax.TextChanged += txtDmgBaseMax_TextChanged;
            // 
            // txtDmgBaseMin
            // 
            resources.ApplyResources(txtDmgBaseMin, "txtDmgBaseMin");
            txtDmgBaseMin.Name = "txtDmgBaseMin";
            toolTip1.SetToolTip(txtDmgBaseMin, resources.GetString("txtDmgBaseMin.ToolTip"));
            txtDmgBaseMin.TextChanged += txtDmgBaseMin_TextChanged;
            // 
            // label17
            // 
            resources.ApplyResources(label17, "label17");
            label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label20);
            panel3.Controls.Add(txtRange);
            panel3.Controls.Add(txtDelayReduction);
            panel3.Controls.Add(txtDelayBase);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            toolTip1.SetToolTip(panel3, resources.GetString("panel3.ToolTip"));
            // 
            // label20
            // 
            resources.ApplyResources(label20, "label20");
            label20.Name = "label20";
            // 
            // txtRange
            // 
            resources.ApplyResources(txtRange, "txtRange");
            txtRange.Name = "txtRange";
            txtRange.TextChanged += txtRange_TextChanged;
            // 
            // txtDelayReduction
            // 
            resources.ApplyResources(txtDelayReduction, "txtDelayReduction");
            txtDelayReduction.Name = "txtDelayReduction";
            toolTip1.SetToolTip(txtDelayReduction, resources.GetString("txtDelayReduction.ToolTip"));
            txtDelayReduction.TextChanged += txtDelayReduction_TextChanged;
            // 
            // txtDelayBase
            // 
            resources.ApplyResources(txtDelayBase, "txtDelayBase");
            txtDelayBase.Name = "txtDelayBase";
            toolTip1.SetToolTip(txtDelayBase, resources.GetString("txtDelayBase.ToolTip"));
            txtDelayBase.TextChanged += txtDelayBase_TextChanged;
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtMPIncrease);
            panel2.Controls.Add(txtMPBase);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // txtMPIncrease
            // 
            resources.ApplyResources(txtMPIncrease, "txtMPIncrease");
            txtMPIncrease.Name = "txtMPIncrease";
            toolTip1.SetToolTip(txtMPIncrease, resources.GetString("txtMPIncrease.ToolTip"));
            txtMPIncrease.TextChanged += txtMPIncrease_TextChanged;
            // 
            // txtMPBase
            // 
            resources.ApplyResources(txtMPBase, "txtMPBase");
            txtMPBase.Name = "txtMPBase";
            toolTip1.SetToolTip(txtMPBase, resources.GetString("txtMPBase.ToolTip"));
            txtMPBase.TextChanged += txtMPBase_TextChanged;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtSkillLvl3Points);
            panel1.Controls.Add(txtSkillLvl2Points);
            panel1.Controls.Add(txtSkillLvl1Points);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtSkillLvl3Req);
            panel1.Controls.Add(txtSkillLvl2Req);
            panel1.Controls.Add(txtSkillLvl1Req);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // txtSkillLvl3Points
            // 
            resources.ApplyResources(txtSkillLvl3Points, "txtSkillLvl3Points");
            txtSkillLvl3Points.Name = "txtSkillLvl3Points";
            txtSkillLvl3Points.TextChanged += txtSkillLvl3Points_TextChanged;
            // 
            // txtSkillLvl2Points
            // 
            resources.ApplyResources(txtSkillLvl2Points, "txtSkillLvl2Points");
            txtSkillLvl2Points.Name = "txtSkillLvl2Points";
            txtSkillLvl2Points.TextChanged += txtSkillLvl2Points_TextChanged;
            // 
            // txtSkillLvl1Points
            // 
            resources.ApplyResources(txtSkillLvl1Points, "txtSkillLvl1Points");
            txtSkillLvl1Points.Name = "txtSkillLvl1Points";
            txtSkillLvl1Points.TextChanged += txtSkillLvl1Points_TextChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // txtSkillLvl3Req
            // 
            resources.ApplyResources(txtSkillLvl3Req, "txtSkillLvl3Req");
            txtSkillLvl3Req.Name = "txtSkillLvl3Req";
            txtSkillLvl3Req.TextChanged += txtSkillLvl3Req_TextChanged;
            // 
            // txtSkillLvl2Req
            // 
            resources.ApplyResources(txtSkillLvl2Req, "txtSkillLvl2Req");
            txtSkillLvl2Req.Name = "txtSkillLvl2Req";
            txtSkillLvl2Req.TextChanged += txtSkillLvl2Req_TextChanged;
            // 
            // txtSkillLvl1Req
            // 
            resources.ApplyResources(txtSkillLvl1Req, "txtSkillLvl1Req");
            txtSkillLvl1Req.Name = "txtSkillLvl1Req";
            txtSkillLvl1Req.TextChanged += txtSkillLvl1Req_TextChanged;
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
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // txtSkillIcon
            // 
            resources.ApplyResources(txtSkillIcon, "txtSkillIcon");
            txtSkillIcon.Name = "txtSkillIcon";
            txtSkillIcon.TextChanged += txtSkillIcon_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // lblBookValid
            // 
            resources.ApplyResources(lblBookValid, "lblBookValid");
            lblBookValid.Name = "lblBookValid";
            // 
            // MagicInfoForm
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(tabControl1);
            Controls.Add(MagiclistBox);
            Name = "MagicInfoForm";
            FormClosed += MagicInfoForm_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void MagicInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //do something to save it all
            Envir.SaveDB();
        }

        private void MagiclistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMagicForm();
        }

        private bool IsValid(ref byte input)
        {
            if (!byte.TryParse(ActiveControl.Text, out input))
            {
                ActiveControl.BackColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool IsValid(ref ushort input)
        {
            if (!ushort.TryParse(ActiveControl.Text, out input))
            {
                ActiveControl.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool IsValid(ref uint input)
        {
            if (!uint.TryParse(ActiveControl.Text, out input))
            {
                ActiveControl.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool IsValid(ref float input)
        {
            if (!float.TryParse(ActiveControl.Text, out input))
            {
                ActiveControl.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void txtSkillIcon_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            byte temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.Icon = temp;
        }

        private void txtSkillLvl1Req_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            byte temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.Level1 = temp;
        }

        private void txtSkillLvl2Req_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            byte temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.Level2 = temp;
        }

        private void txtSkillLvl3Req_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            byte temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.Level3 = temp;
        }

        private void txtSkillLvl1Points_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            ushort temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.Need1 = temp;
        }

        private void txtSkillLvl2Points_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            ushort temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.Need2 = temp;
        }

        private void txtSkillLvl3Points_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            ushort temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.Need3 = temp;
        }

        private void txtMPBase_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            byte temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.BaseCost = temp;
        }

        private void txtMPIncrease_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            byte temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.LevelCost = temp;
        }

        private void txtDmgBaseMin_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            ushort temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.PowerBase = temp;
            UpdateMagicForm();
        }

        private void txtDmgBaseMax_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            ushort temp = 0;
            if (!IsValid(ref temp)) return;
            if (temp < _selectedMagicInfo.PowerBase)
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }
            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.PowerBonus =  (ushort)(temp - _selectedMagicInfo.PowerBase);
            UpdateMagicForm();
        }

        private void txtDmgBonusMin_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            ushort temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.MPowerBase = temp;
            UpdateMagicForm();
        }

        private void txtDmgBonusMax_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            ushort temp = 0;
            if (!IsValid(ref temp)) return;
            if (temp < _selectedMagicInfo.MPowerBase)
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.MPowerBonus = (ushort)(temp - _selectedMagicInfo.MPowerBase);
            UpdateMagicForm();
        }

        private void txtDelayBase_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            uint temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.DelayBase = temp;
        }

        private void txtDelayReduction_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            uint temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.DelayReduction = temp;
        }

        private void txtRange_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            byte temp = 0;
            if (!IsValid(ref temp)) return;
            
            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.Range = temp;
        }

        private void txtDmgMultBase_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            float temp = 0;
            if (!IsValid(ref temp)) return;


            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.MultiplierBase = temp;
            UpdateMagicForm(1);
        }

        private void txtDmgMultBoost_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            float temp = 0;
            if (!IsValid(ref temp)) return;

            ActiveControl.BackColor = SystemColors.Window;
            _selectedMagicInfo.MultiplierBonus = temp;
            UpdateMagicForm(2);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            _selectedMagicInfo.Name = ActiveControl.Text;
            UpdateMagicForm();
            if (ActiveControl.Text == "")
            {
                ActiveControl.BackColor = Color.Red;
            }
            else {
                ActiveControl.BackColor = SystemColors.Window;              
            }            
        }
    }
}
