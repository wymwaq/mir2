namespace Server
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            SaveButton = new Button();
            configTabs = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label11 = new Label();
            DBVersionLabel = new Label();
            ServerVersionLabel = new Label();
            label10 = new Label();
            RelogDelayTextBox = new TextBox();
            label7 = new Label();
            VersionCheckBox = new CheckBox();
            VPathBrowseButton = new Button();
            VPathTextBox = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            StartHTTPCheckBox = new CheckBox();
            label15 = new Label();
            HTTPTrustedIPAddressTextBox = new TextBox();
            label14 = new Label();
            HTTPIPAddressTextBox = new TextBox();
            label13 = new Label();
            MaxUserTextBox = new TextBox();
            label5 = new Label();
            TimeOutTextBox = new TextBox();
            label4 = new Label();
            PortTextBox = new TextBox();
            label3 = new Label();
            IPAddressTextBox = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            label9 = new Label();
            label8 = new Label();
            Resolution_textbox = new TextBox();
            AllowArcherCheckBox = new CheckBox();
            AllowAssassinCheckBox = new CheckBox();
            StartGameCheckBox = new CheckBox();
            DCharacterCheckBox = new CheckBox();
            NCharacterCheckBox = new CheckBox();
            LoginCheckBox = new CheckBox();
            PasswordCheckBox = new CheckBox();
            AccountCheckBox = new CheckBox();
            tabPage4 = new TabPage();
            label12 = new Label();
            SaveDelayTextBox = new TextBox();
            label6 = new Label();
            tabPage5 = new TabPage();
            label16 = new Label();
            lineMessageTimeTextBox = new TextBox();
            label17 = new Label();
            gameMasterEffect_CheckBox = new CheckBox();
            SafeZoneHealingCheckBox = new CheckBox();
            SafeZoneBorderCheckBox = new CheckBox();
            VPathDialog = new OpenFileDialog();
            configTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButton
            // 
            resources.ApplyResources(SaveButton, "SaveButton");
            SaveButton.Name = "SaveButton";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // configTabs
            // 
            configTabs.Controls.Add(tabPage1);
            configTabs.Controls.Add(tabPage2);
            configTabs.Controls.Add(tabPage3);
            configTabs.Controls.Add(tabPage4);
            configTabs.Controls.Add(tabPage5);
            resources.ApplyResources(configTabs, "configTabs");
            configTabs.Name = "configTabs";
            configTabs.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(RelogDelayTextBox);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(VersionCheckBox);
            tabPage1.Controls.Add(VPathBrowseButton);
            tabPage1.Controls.Add(VPathTextBox);
            tabPage1.Controls.Add(label1);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(DBVersionLabel);
            groupBox1.Controls.Add(ServerVersionLabel);
            groupBox1.Controls.Add(label10);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // DBVersionLabel
            // 
            resources.ApplyResources(DBVersionLabel, "DBVersionLabel");
            DBVersionLabel.Name = "DBVersionLabel";
            // 
            // ServerVersionLabel
            // 
            resources.ApplyResources(ServerVersionLabel, "ServerVersionLabel");
            ServerVersionLabel.Name = "ServerVersionLabel";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // RelogDelayTextBox
            // 
            resources.ApplyResources(RelogDelayTextBox, "RelogDelayTextBox");
            RelogDelayTextBox.Name = "RelogDelayTextBox";
            RelogDelayTextBox.TextChanged += CheckUShort;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // VersionCheckBox
            // 
            resources.ApplyResources(VersionCheckBox, "VersionCheckBox");
            VersionCheckBox.Name = "VersionCheckBox";
            VersionCheckBox.UseVisualStyleBackColor = true;
            // 
            // VPathBrowseButton
            // 
            resources.ApplyResources(VPathBrowseButton, "VPathBrowseButton");
            VPathBrowseButton.Name = "VPathBrowseButton";
            VPathBrowseButton.UseVisualStyleBackColor = true;
            VPathBrowseButton.Click += VPathBrowseButton_Click;
            // 
            // VPathTextBox
            // 
            resources.ApplyResources(VPathTextBox, "VPathTextBox");
            VPathTextBox.Name = "VPathTextBox";
            VPathTextBox.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(StartHTTPCheckBox);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(HTTPTrustedIPAddressTextBox);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(HTTPIPAddressTextBox);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(MaxUserTextBox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(TimeOutTextBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(PortTextBox);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(IPAddressTextBox);
            tabPage2.Controls.Add(label2);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // StartHTTPCheckBox
            // 
            resources.ApplyResources(StartHTTPCheckBox, "StartHTTPCheckBox");
            StartHTTPCheckBox.Name = "StartHTTPCheckBox";
            StartHTTPCheckBox.UseVisualStyleBackColor = true;
            StartHTTPCheckBox.CheckedChanged += StartHTTPCheckBox_CheckedChanged;
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // HTTPTrustedIPAddressTextBox
            // 
            resources.ApplyResources(HTTPTrustedIPAddressTextBox, "HTTPTrustedIPAddressTextBox");
            HTTPTrustedIPAddressTextBox.Name = "HTTPTrustedIPAddressTextBox";
            HTTPTrustedIPAddressTextBox.TextChanged += HTTPTrustedIPAddressTextBox_TextChanged;
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // HTTPIPAddressTextBox
            // 
            resources.ApplyResources(HTTPIPAddressTextBox, "HTTPIPAddressTextBox");
            HTTPIPAddressTextBox.Name = "HTTPIPAddressTextBox";
            HTTPIPAddressTextBox.TextChanged += HTTPIPAddressTextBox_TextChanged;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // MaxUserTextBox
            // 
            resources.ApplyResources(MaxUserTextBox, "MaxUserTextBox");
            MaxUserTextBox.Name = "MaxUserTextBox";
            MaxUserTextBox.TextChanged += CheckUShort;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // TimeOutTextBox
            // 
            resources.ApplyResources(TimeOutTextBox, "TimeOutTextBox");
            TimeOutTextBox.Name = "TimeOutTextBox";
            TimeOutTextBox.TextChanged += CheckUShort;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // PortTextBox
            // 
            resources.ApplyResources(PortTextBox, "PortTextBox");
            PortTextBox.Name = "PortTextBox";
            PortTextBox.TextChanged += CheckUShort;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // IPAddressTextBox
            // 
            resources.ApplyResources(IPAddressTextBox, "IPAddressTextBox");
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.TextChanged += IPAddressCheck;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(Resolution_textbox);
            tabPage3.Controls.Add(AllowArcherCheckBox);
            tabPage3.Controls.Add(AllowAssassinCheckBox);
            tabPage3.Controls.Add(StartGameCheckBox);
            tabPage3.Controls.Add(DCharacterCheckBox);
            tabPage3.Controls.Add(NCharacterCheckBox);
            tabPage3.Controls.Add(LoginCheckBox);
            tabPage3.Controls.Add(PasswordCheckBox);
            tabPage3.Controls.Add(AccountCheckBox);
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Name = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // Resolution_textbox
            // 
            resources.ApplyResources(Resolution_textbox, "Resolution_textbox");
            Resolution_textbox.Name = "Resolution_textbox";
            Resolution_textbox.TextChanged += Resolution_textbox_TextChanged;
            // 
            // AllowArcherCheckBox
            // 
            resources.ApplyResources(AllowArcherCheckBox, "AllowArcherCheckBox");
            AllowArcherCheckBox.Name = "AllowArcherCheckBox";
            AllowArcherCheckBox.UseVisualStyleBackColor = true;
            // 
            // AllowAssassinCheckBox
            // 
            resources.ApplyResources(AllowAssassinCheckBox, "AllowAssassinCheckBox");
            AllowAssassinCheckBox.Name = "AllowAssassinCheckBox";
            AllowAssassinCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartGameCheckBox
            // 
            resources.ApplyResources(StartGameCheckBox, "StartGameCheckBox");
            StartGameCheckBox.Name = "StartGameCheckBox";
            StartGameCheckBox.UseVisualStyleBackColor = true;
            // 
            // DCharacterCheckBox
            // 
            resources.ApplyResources(DCharacterCheckBox, "DCharacterCheckBox");
            DCharacterCheckBox.Name = "DCharacterCheckBox";
            DCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // NCharacterCheckBox
            // 
            resources.ApplyResources(NCharacterCheckBox, "NCharacterCheckBox");
            NCharacterCheckBox.Name = "NCharacterCheckBox";
            NCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginCheckBox
            // 
            resources.ApplyResources(LoginCheckBox, "LoginCheckBox");
            LoginCheckBox.Name = "LoginCheckBox";
            LoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordCheckBox
            // 
            resources.ApplyResources(PasswordCheckBox, "PasswordCheckBox");
            PasswordCheckBox.Name = "PasswordCheckBox";
            PasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // AccountCheckBox
            // 
            resources.ApplyResources(AccountCheckBox, "AccountCheckBox");
            AccountCheckBox.Name = "AccountCheckBox";
            AccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(SaveDelayTextBox);
            tabPage4.Controls.Add(label6);
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // SaveDelayTextBox
            // 
            resources.ApplyResources(SaveDelayTextBox, "SaveDelayTextBox");
            SaveDelayTextBox.Name = "SaveDelayTextBox";
            SaveDelayTextBox.TextChanged += CheckUShort;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label16);
            tabPage5.Controls.Add(lineMessageTimeTextBox);
            tabPage5.Controls.Add(label17);
            tabPage5.Controls.Add(gameMasterEffect_CheckBox);
            tabPage5.Controls.Add(SafeZoneHealingCheckBox);
            tabPage5.Controls.Add(SafeZoneBorderCheckBox);
            resources.ApplyResources(tabPage5, "tabPage5");
            tabPage5.Name = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            // 
            // lineMessageTimeTextBox
            // 
            resources.ApplyResources(lineMessageTimeTextBox, "lineMessageTimeTextBox");
            lineMessageTimeTextBox.Name = "lineMessageTimeTextBox";
            // 
            // label17
            // 
            resources.ApplyResources(label17, "label17");
            label17.Name = "label17";
            // 
            // gameMasterEffect_CheckBox
            // 
            resources.ApplyResources(gameMasterEffect_CheckBox, "gameMasterEffect_CheckBox");
            gameMasterEffect_CheckBox.Name = "gameMasterEffect_CheckBox";
            gameMasterEffect_CheckBox.UseVisualStyleBackColor = true;
            // 
            // SafeZoneHealingCheckBox
            // 
            resources.ApplyResources(SafeZoneHealingCheckBox, "SafeZoneHealingCheckBox");
            SafeZoneHealingCheckBox.Name = "SafeZoneHealingCheckBox";
            SafeZoneHealingCheckBox.UseVisualStyleBackColor = true;
            SafeZoneHealingCheckBox.CheckedChanged += SafeZoneHealingCheckBox_CheckedChanged;
            // 
            // SafeZoneBorderCheckBox
            // 
            resources.ApplyResources(SafeZoneBorderCheckBox, "SafeZoneBorderCheckBox");
            SafeZoneBorderCheckBox.Name = "SafeZoneBorderCheckBox";
            SafeZoneBorderCheckBox.UseVisualStyleBackColor = true;
            SafeZoneBorderCheckBox.CheckedChanged += SafeZoneBorderCheckBox_CheckedChanged;
            // 
            // VPathDialog
            // 
            VPathDialog.FileName = "Mir2.Exe";
            resources.ApplyResources(VPathDialog, "VPathDialog");
            VPathDialog.Multiselect = true;
            // 
            // ConfigForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(configTabs);
            Name = "ConfigForm";
            FormClosed += ConfigForm_FormClosed;
            configTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TabControl configTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox RelogDelayTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox VersionCheckBox;
        private System.Windows.Forms.Button VPathBrowseButton;
        private System.Windows.Forms.TextBox VPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox MaxUserTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeOutTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog VPathDialog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox StartGameCheckBox;
        private System.Windows.Forms.CheckBox DCharacterCheckBox;
        private System.Windows.Forms.CheckBox NCharacterCheckBox;
        private System.Windows.Forms.CheckBox LoginCheckBox;
        private System.Windows.Forms.CheckBox PasswordCheckBox;
        private System.Windows.Forms.CheckBox AccountCheckBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox SaveDelayTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox SafeZoneBorderCheckBox;
        private System.Windows.Forms.CheckBox SafeZoneHealingCheckBox;
        private System.Windows.Forms.CheckBox AllowArcherCheckBox;
        private System.Windows.Forms.CheckBox AllowAssassinCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Resolution_textbox;
        private System.Windows.Forms.Label ServerVersionLabel;
        private System.Windows.Forms.Label DBVersionLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox gameMasterEffect_CheckBox;
        private System.Windows.Forms.TextBox HTTPIPAddressTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox HTTPTrustedIPAddressTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox StartHTTPCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox lineMessageTimeTextBox;
        private System.Windows.Forms.Label label17;
    }
}