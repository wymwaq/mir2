using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    partial class MapInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MapInfoForm));
            MapTabs = new TabControl();
            tabPage1 = new TabPage();
            label48 = new Label();
            lstParticles = new ListBox();
            MinimapPreview = new PictureBox();
            label11 = new Label();
            MusicTextBox = new TextBox();
            label33 = new Label();
            MineComboBox = new ComboBox();
            label15 = new Label();
            BigMapTextBox = new TextBox();
            LightsComboBox = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            MapIndexTextBox = new TextBox();
            MiniMapTextBox = new TextBox();
            label2 = new Label();
            MapNameTextBox = new TextBox();
            FileNameTextBox = new TextBox();
            label3 = new Label();
            tabPage6 = new TabPage();
            NoReincarnation = new CheckBox();
            NoTownTeleportCheckbox = new CheckBox();
            NoFightCheckbox = new CheckBox();
            NeedBridleCheckbox = new CheckBox();
            NoMountCheckbox = new CheckBox();
            label19 = new Label();
            MapDarkLighttextBox = new TextBox();
            NoNamesCheckbox = new CheckBox();
            NoDropMonsterCheckbox = new CheckBox();
            NoDropPlayerCheckbox = new CheckBox();
            NoThrowItemCheckbox = new CheckBox();
            NoPositionCheckbox = new CheckBox();
            NoDrugCheckbox = new CheckBox();
            NoRecallCheckbox = new CheckBox();
            NoEscapeCheckbox = new CheckBox();
            NoRandomCheckbox = new CheckBox();
            LightningTextbox = new TextBox();
            FireTextbox = new TextBox();
            NoReconnectTextbox = new TextBox();
            LightningCheckbox = new CheckBox();
            FireCheckbox = new CheckBox();
            FightCheckbox = new CheckBox();
            NoReconnectCheckbox = new CheckBox();
            NoTeleportCheckbox = new CheckBox();
            tabPage3 = new TabPage();
            RemoveSZButton = new Button();
            AddSZButton = new Button();
            SafeZoneInfoPanel = new Panel();
            label12 = new Label();
            SZYTextBox = new TextBox();
            label14 = new Label();
            SizeTextBox = new TextBox();
            label17 = new Label();
            SZXTextBox = new TextBox();
            StartPointCheckBox = new CheckBox();
            SafeZoneInfoListBox = new ListBox();
            tabPage2 = new TabPage();
            RPasteButton = new Button();
            RCopyButton = new Button();
            RemoveRButton = new Button();
            AddRButton = new Button();
            RespawnInfoListBox = new ListBox();
            RespawnInfoPanel = new Panel();
            chkrespawnsave = new CheckBox();
            chkRespawnEnableTick = new CheckBox();
            Randomtextbox = new TextBox();
            label23 = new Label();
            label34 = new Label();
            RoutePathTextBox = new TextBox();
            label24 = new Label();
            DirectionTextBox = new TextBox();
            label8 = new Label();
            DelayTextBox = new TextBox();
            label7 = new Label();
            MonsterInfoComboBox = new ComboBox();
            label6 = new Label();
            SpreadTextBox = new TextBox();
            label9 = new Label();
            RYTextBox = new TextBox();
            label10 = new Label();
            CountTextBox = new TextBox();
            label13 = new Label();
            RXTextBox = new TextBox();
            tabPage4 = new TabPage();
            RemoveMButton = new Button();
            AddMButton = new Button();
            MovementInfoPanel = new Panel();
            label26 = new Label();
            BigMapIconTextBox = new TextBox();
            ShowBigMapCheckBox = new CheckBox();
            label25 = new Label();
            ConquestComboBox = new ComboBox();
            NeedMoveMCheckBox = new CheckBox();
            NeedHoleMCheckBox = new CheckBox();
            label22 = new Label();
            DestMapComboBox = new ComboBox();
            label18 = new Label();
            DestYTextBox = new TextBox();
            label21 = new Label();
            DestXTextBox = new TextBox();
            label16 = new Label();
            SourceYTextBox = new TextBox();
            label20 = new Label();
            SourceXTextBox = new TextBox();
            MovementInfoListBox = new ListBox();
            tabPage7 = new TabPage();
            MZDeletebutton = new Button();
            MZAddbutton = new Button();
            MineZonepanel = new Panel();
            label27 = new Label();
            MineZoneComboBox = new ComboBox();
            label30 = new Label();
            MZYtextBox = new TextBox();
            label31 = new Label();
            MZSizetextBox = new TextBox();
            label32 = new Label();
            MZXtextBox = new TextBox();
            MZListlistBox = new ListBox();
            RemoveButton = new Button();
            AddButton = new Button();
            MapInfoListBox = new ListBox();
            PasteMapButton = new Button();
            CopyMapButton = new Button();
            ImportMapInfoButton = new Button();
            ExportMapInfoButton = new Button();
            ImportMongenButton = new Button();
            ExportMongenButton = new Button();
            VisualizerButton = new Button();
            toolTip1 = new ToolTip(components);
            MapTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            ((ISupportInitialize)MinimapPreview).BeginInit();
            tabPage6.SuspendLayout();
            tabPage3.SuspendLayout();
            SafeZoneInfoPanel.SuspendLayout();
            tabPage2.SuspendLayout();
            RespawnInfoPanel.SuspendLayout();
            tabPage4.SuspendLayout();
            MovementInfoPanel.SuspendLayout();
            tabPage7.SuspendLayout();
            MineZonepanel.SuspendLayout();
            SuspendLayout();
            // 
            // MapTabs
            // 
            resources.ApplyResources(MapTabs, "MapTabs");
            MapTabs.Controls.Add(tabPage1);
            MapTabs.Controls.Add(tabPage6);
            MapTabs.Controls.Add(tabPage3);
            MapTabs.Controls.Add(tabPage2);
            MapTabs.Controls.Add(tabPage4);
            MapTabs.Controls.Add(tabPage7);
            MapTabs.Name = "MapTabs";
            MapTabs.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label48);
            tabPage1.Controls.Add(lstParticles);
            tabPage1.Controls.Add(MinimapPreview);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(MusicTextBox);
            tabPage1.Controls.Add(label33);
            tabPage1.Controls.Add(MineComboBox);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(BigMapTextBox);
            tabPage1.Controls.Add(LightsComboBox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(MapIndexTextBox);
            tabPage1.Controls.Add(MiniMapTextBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(MapNameTextBox);
            tabPage1.Controls.Add(FileNameTextBox);
            tabPage1.Controls.Add(label3);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            resources.ApplyResources(label48, "label48");
            label48.Name = "label48";
            // 
            // lstParticles
            // 
            lstParticles.FormattingEnabled = true;
            resources.ApplyResources(lstParticles, "lstParticles");
            lstParticles.Name = "lstParticles";
            lstParticles.SelectionMode = SelectionMode.MultiSimple;
            lstParticles.SelectedIndexChanged += lstParticles_SelectedIndexChanged;
            // 
            // MinimapPreview
            // 
            resources.ApplyResources(MinimapPreview, "MinimapPreview");
            MinimapPreview.Name = "MinimapPreview";
            MinimapPreview.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // MusicTextBox
            // 
            resources.ApplyResources(MusicTextBox, "MusicTextBox");
            MusicTextBox.Name = "MusicTextBox";
            MusicTextBox.TextChanged += MusicTextBox_TextChanged;
            // 
            // label33
            // 
            resources.ApplyResources(label33, "label33");
            label33.Name = "label33";
            // 
            // MineComboBox
            // 
            MineComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MineComboBox.FormattingEnabled = true;
            resources.ApplyResources(MineComboBox, "MineComboBox");
            MineComboBox.Name = "MineComboBox";
            MineComboBox.SelectedIndexChanged += MineComboBox_SelectedIndexChanged;
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // BigMapTextBox
            // 
            resources.ApplyResources(BigMapTextBox, "BigMapTextBox");
            BigMapTextBox.Name = "BigMapTextBox";
            BigMapTextBox.TextChanged += BigMapTextBox_TextChanged;
            // 
            // LightsComboBox
            // 
            LightsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LightsComboBox.FormattingEnabled = true;
            resources.ApplyResources(LightsComboBox, "LightsComboBox");
            LightsComboBox.Name = "LightsComboBox";
            LightsComboBox.SelectedIndexChanged += LightsComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // MapIndexTextBox
            // 
            resources.ApplyResources(MapIndexTextBox, "MapIndexTextBox");
            MapIndexTextBox.Name = "MapIndexTextBox";
            MapIndexTextBox.ReadOnly = true;
            // 
            // MiniMapTextBox
            // 
            resources.ApplyResources(MiniMapTextBox, "MiniMapTextBox");
            MiniMapTextBox.Name = "MiniMapTextBox";
            MiniMapTextBox.TextChanged += MiniMapTextBox_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // MapNameTextBox
            // 
            resources.ApplyResources(MapNameTextBox, "MapNameTextBox");
            MapNameTextBox.Name = "MapNameTextBox";
            MapNameTextBox.TextChanged += MapNameTextBox_TextChanged;
            // 
            // FileNameTextBox
            // 
            resources.ApplyResources(FileNameTextBox, "FileNameTextBox");
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.TextChanged += FileNameTextBox_TextChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(NoReincarnation);
            tabPage6.Controls.Add(NoTownTeleportCheckbox);
            tabPage6.Controls.Add(NoFightCheckbox);
            tabPage6.Controls.Add(NeedBridleCheckbox);
            tabPage6.Controls.Add(NoMountCheckbox);
            tabPage6.Controls.Add(label19);
            tabPage6.Controls.Add(MapDarkLighttextBox);
            tabPage6.Controls.Add(NoNamesCheckbox);
            tabPage6.Controls.Add(NoDropMonsterCheckbox);
            tabPage6.Controls.Add(NoDropPlayerCheckbox);
            tabPage6.Controls.Add(NoThrowItemCheckbox);
            tabPage6.Controls.Add(NoPositionCheckbox);
            tabPage6.Controls.Add(NoDrugCheckbox);
            tabPage6.Controls.Add(NoRecallCheckbox);
            tabPage6.Controls.Add(NoEscapeCheckbox);
            tabPage6.Controls.Add(NoRandomCheckbox);
            tabPage6.Controls.Add(LightningTextbox);
            tabPage6.Controls.Add(FireTextbox);
            tabPage6.Controls.Add(NoReconnectTextbox);
            tabPage6.Controls.Add(LightningCheckbox);
            tabPage6.Controls.Add(FireCheckbox);
            tabPage6.Controls.Add(FightCheckbox);
            tabPage6.Controls.Add(NoReconnectCheckbox);
            tabPage6.Controls.Add(NoTeleportCheckbox);
            resources.ApplyResources(tabPage6, "tabPage6");
            tabPage6.Name = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // NoReincarnation
            // 
            resources.ApplyResources(NoReincarnation, "NoReincarnation");
            NoReincarnation.Name = "NoReincarnation";
            NoReincarnation.UseVisualStyleBackColor = true;
            NoReincarnation.CheckedChanged += NoReincarnation_CheckedChanged;
            // 
            // NoTownTeleportCheckbox
            // 
            resources.ApplyResources(NoTownTeleportCheckbox, "NoTownTeleportCheckbox");
            NoTownTeleportCheckbox.Name = "NoTownTeleportCheckbox";
            NoTownTeleportCheckbox.UseVisualStyleBackColor = true;
            NoTownTeleportCheckbox.CheckedChanged += NoTownTeleportCheckbox_CheckedChanged;
            // 
            // NoFightCheckbox
            // 
            resources.ApplyResources(NoFightCheckbox, "NoFightCheckbox");
            NoFightCheckbox.Name = "NoFightCheckbox";
            NoFightCheckbox.UseVisualStyleBackColor = true;
            NoFightCheckbox.CheckedChanged += NoFightCheckbox_CheckedChanged;
            // 
            // NeedBridleCheckbox
            // 
            resources.ApplyResources(NeedBridleCheckbox, "NeedBridleCheckbox");
            NeedBridleCheckbox.Name = "NeedBridleCheckbox";
            NeedBridleCheckbox.UseVisualStyleBackColor = true;
            NeedBridleCheckbox.CheckedChanged += NeedBridleCheckbox_CheckedChanged;
            // 
            // NoMountCheckbox
            // 
            resources.ApplyResources(NoMountCheckbox, "NoMountCheckbox");
            NoMountCheckbox.Name = "NoMountCheckbox";
            NoMountCheckbox.UseVisualStyleBackColor = true;
            NoMountCheckbox.CheckedChanged += NoMountCheckbox_CheckedChanged;
            // 
            // label19
            // 
            resources.ApplyResources(label19, "label19");
            label19.Name = "label19";
            // 
            // MapDarkLighttextBox
            // 
            resources.ApplyResources(MapDarkLighttextBox, "MapDarkLighttextBox");
            MapDarkLighttextBox.Name = "MapDarkLighttextBox";
            MapDarkLighttextBox.TextChanged += MapDarkLighttextBox_TextChanged;
            // 
            // NoNamesCheckbox
            // 
            resources.ApplyResources(NoNamesCheckbox, "NoNamesCheckbox");
            NoNamesCheckbox.Name = "NoNamesCheckbox";
            NoNamesCheckbox.UseVisualStyleBackColor = true;
            NoNamesCheckbox.CheckedChanged += NoNamesCheckbox_CheckedChanged;
            // 
            // NoDropMonsterCheckbox
            // 
            resources.ApplyResources(NoDropMonsterCheckbox, "NoDropMonsterCheckbox");
            NoDropMonsterCheckbox.Name = "NoDropMonsterCheckbox";
            NoDropMonsterCheckbox.UseVisualStyleBackColor = true;
            NoDropMonsterCheckbox.CheckedChanged += NoDropMonsterCheckbox_CheckedChanged;
            // 
            // NoDropPlayerCheckbox
            // 
            resources.ApplyResources(NoDropPlayerCheckbox, "NoDropPlayerCheckbox");
            NoDropPlayerCheckbox.Name = "NoDropPlayerCheckbox";
            NoDropPlayerCheckbox.UseVisualStyleBackColor = true;
            NoDropPlayerCheckbox.CheckedChanged += NoDropPlayerCheckbox_CheckedChanged;
            // 
            // NoThrowItemCheckbox
            // 
            resources.ApplyResources(NoThrowItemCheckbox, "NoThrowItemCheckbox");
            NoThrowItemCheckbox.Name = "NoThrowItemCheckbox";
            NoThrowItemCheckbox.UseVisualStyleBackColor = true;
            NoThrowItemCheckbox.CheckedChanged += NoThrowItemCheckbox_CheckedChanged;
            // 
            // NoPositionCheckbox
            // 
            resources.ApplyResources(NoPositionCheckbox, "NoPositionCheckbox");
            NoPositionCheckbox.Name = "NoPositionCheckbox";
            NoPositionCheckbox.UseVisualStyleBackColor = true;
            NoPositionCheckbox.CheckedChanged += NoPositionCheckbox_CheckedChanged;
            // 
            // NoDrugCheckbox
            // 
            resources.ApplyResources(NoDrugCheckbox, "NoDrugCheckbox");
            NoDrugCheckbox.Name = "NoDrugCheckbox";
            NoDrugCheckbox.UseVisualStyleBackColor = true;
            NoDrugCheckbox.CheckedChanged += NoDrugCheckbox_CheckedChanged;
            // 
            // NoRecallCheckbox
            // 
            resources.ApplyResources(NoRecallCheckbox, "NoRecallCheckbox");
            NoRecallCheckbox.Name = "NoRecallCheckbox";
            NoRecallCheckbox.UseVisualStyleBackColor = true;
            NoRecallCheckbox.CheckedChanged += NoRecallCheckbox_CheckedChanged;
            // 
            // NoEscapeCheckbox
            // 
            resources.ApplyResources(NoEscapeCheckbox, "NoEscapeCheckbox");
            NoEscapeCheckbox.Name = "NoEscapeCheckbox";
            NoEscapeCheckbox.UseVisualStyleBackColor = true;
            NoEscapeCheckbox.CheckedChanged += NoEscapeCheckbox_CheckedChanged;
            // 
            // NoRandomCheckbox
            // 
            resources.ApplyResources(NoRandomCheckbox, "NoRandomCheckbox");
            NoRandomCheckbox.Name = "NoRandomCheckbox";
            NoRandomCheckbox.UseVisualStyleBackColor = true;
            NoRandomCheckbox.CheckedChanged += NoRandomCheckbox_CheckedChanged;
            // 
            // LightningTextbox
            // 
            resources.ApplyResources(LightningTextbox, "LightningTextbox");
            LightningTextbox.Name = "LightningTextbox";
            LightningTextbox.TextChanged += LightningTextbox_TextChanged;
            // 
            // FireTextbox
            // 
            resources.ApplyResources(FireTextbox, "FireTextbox");
            FireTextbox.Name = "FireTextbox";
            FireTextbox.TextChanged += FireTextbox_TextChanged;
            // 
            // NoReconnectTextbox
            // 
            resources.ApplyResources(NoReconnectTextbox, "NoReconnectTextbox");
            NoReconnectTextbox.Name = "NoReconnectTextbox";
            NoReconnectTextbox.TextChanged += NoReconnectTextbox_TextChanged;
            // 
            // LightningCheckbox
            // 
            resources.ApplyResources(LightningCheckbox, "LightningCheckbox");
            LightningCheckbox.Name = "LightningCheckbox";
            LightningCheckbox.UseVisualStyleBackColor = true;
            LightningCheckbox.CheckedChanged += LightningCheckbox_CheckedChanged;
            // 
            // FireCheckbox
            // 
            resources.ApplyResources(FireCheckbox, "FireCheckbox");
            FireCheckbox.Name = "FireCheckbox";
            FireCheckbox.UseVisualStyleBackColor = true;
            FireCheckbox.CheckStateChanged += FireCheckbox_CheckStateChanged;
            // 
            // FightCheckbox
            // 
            resources.ApplyResources(FightCheckbox, "FightCheckbox");
            FightCheckbox.Name = "FightCheckbox";
            FightCheckbox.UseVisualStyleBackColor = true;
            FightCheckbox.CheckedChanged += FightCheckbox_CheckedChanged;
            // 
            // NoReconnectCheckbox
            // 
            resources.ApplyResources(NoReconnectCheckbox, "NoReconnectCheckbox");
            NoReconnectCheckbox.Name = "NoReconnectCheckbox";
            NoReconnectCheckbox.UseVisualStyleBackColor = true;
            NoReconnectCheckbox.CheckedChanged += NoReconnectCheckbox_CheckedChanged;
            // 
            // NoTeleportCheckbox
            // 
            resources.ApplyResources(NoTeleportCheckbox, "NoTeleportCheckbox");
            NoTeleportCheckbox.Name = "NoTeleportCheckbox";
            NoTeleportCheckbox.UseVisualStyleBackColor = true;
            NoTeleportCheckbox.CheckedChanged += NoTeleportCheckbox_CheckedChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(RemoveSZButton);
            tabPage3.Controls.Add(AddSZButton);
            tabPage3.Controls.Add(SafeZoneInfoPanel);
            tabPage3.Controls.Add(SafeZoneInfoListBox);
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Name = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // RemoveSZButton
            // 
            resources.ApplyResources(RemoveSZButton, "RemoveSZButton");
            RemoveSZButton.Name = "RemoveSZButton";
            RemoveSZButton.UseVisualStyleBackColor = true;
            RemoveSZButton.Click += RemoveSZButton_Click;
            // 
            // AddSZButton
            // 
            resources.ApplyResources(AddSZButton, "AddSZButton");
            AddSZButton.Name = "AddSZButton";
            AddSZButton.UseVisualStyleBackColor = true;
            AddSZButton.Click += AddSZButton_Click;
            // 
            // SafeZoneInfoPanel
            // 
            resources.ApplyResources(SafeZoneInfoPanel, "SafeZoneInfoPanel");
            SafeZoneInfoPanel.Controls.Add(label12);
            SafeZoneInfoPanel.Controls.Add(SZYTextBox);
            SafeZoneInfoPanel.Controls.Add(label14);
            SafeZoneInfoPanel.Controls.Add(SizeTextBox);
            SafeZoneInfoPanel.Controls.Add(label17);
            SafeZoneInfoPanel.Controls.Add(SZXTextBox);
            SafeZoneInfoPanel.Controls.Add(StartPointCheckBox);
            SafeZoneInfoPanel.Name = "SafeZoneInfoPanel";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // SZYTextBox
            // 
            resources.ApplyResources(SZYTextBox, "SZYTextBox");
            SZYTextBox.Name = "SZYTextBox";
            SZYTextBox.TextChanged += SZYTextBox_TextChanged;
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // SizeTextBox
            // 
            resources.ApplyResources(SizeTextBox, "SizeTextBox");
            SizeTextBox.Name = "SizeTextBox";
            SizeTextBox.TextChanged += SizeTextBox_TextChanged;
            // 
            // label17
            // 
            resources.ApplyResources(label17, "label17");
            label17.Name = "label17";
            // 
            // SZXTextBox
            // 
            resources.ApplyResources(SZXTextBox, "SZXTextBox");
            SZXTextBox.Name = "SZXTextBox";
            SZXTextBox.TextChanged += SZXTextBox_TextChanged;
            // 
            // StartPointCheckBox
            // 
            resources.ApplyResources(StartPointCheckBox, "StartPointCheckBox");
            StartPointCheckBox.Name = "StartPointCheckBox";
            StartPointCheckBox.UseVisualStyleBackColor = true;
            StartPointCheckBox.CheckedChanged += StartPointCheckBox_CheckedChanged;
            // 
            // SafeZoneInfoListBox
            // 
            resources.ApplyResources(SafeZoneInfoListBox, "SafeZoneInfoListBox");
            SafeZoneInfoListBox.FormattingEnabled = true;
            SafeZoneInfoListBox.Name = "SafeZoneInfoListBox";
            SafeZoneInfoListBox.SelectionMode = SelectionMode.MultiExtended;
            SafeZoneInfoListBox.SelectedIndexChanged += SafeZoneInfoListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(RPasteButton);
            tabPage2.Controls.Add(RCopyButton);
            tabPage2.Controls.Add(RemoveRButton);
            tabPage2.Controls.Add(AddRButton);
            tabPage2.Controls.Add(RespawnInfoListBox);
            tabPage2.Controls.Add(RespawnInfoPanel);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // RPasteButton
            // 
            resources.ApplyResources(RPasteButton, "RPasteButton");
            RPasteButton.Name = "RPasteButton";
            RPasteButton.UseVisualStyleBackColor = true;
            RPasteButton.Click += RPasteButton_Click;
            // 
            // RCopyButton
            // 
            resources.ApplyResources(RCopyButton, "RCopyButton");
            RCopyButton.Name = "RCopyButton";
            RCopyButton.UseVisualStyleBackColor = true;
            // 
            // RemoveRButton
            // 
            resources.ApplyResources(RemoveRButton, "RemoveRButton");
            RemoveRButton.Name = "RemoveRButton";
            RemoveRButton.UseVisualStyleBackColor = true;
            RemoveRButton.Click += RemoveRButton_Click;
            // 
            // AddRButton
            // 
            resources.ApplyResources(AddRButton, "AddRButton");
            AddRButton.Name = "AddRButton";
            AddRButton.UseVisualStyleBackColor = true;
            AddRButton.Click += AddRButton_Click;
            // 
            // RespawnInfoListBox
            // 
            resources.ApplyResources(RespawnInfoListBox, "RespawnInfoListBox");
            RespawnInfoListBox.FormattingEnabled = true;
            RespawnInfoListBox.Name = "RespawnInfoListBox";
            RespawnInfoListBox.SelectionMode = SelectionMode.MultiExtended;
            RespawnInfoListBox.SelectedIndexChanged += RespawnInfoListBox_SelectedIndexChanged;
            // 
            // RespawnInfoPanel
            // 
            resources.ApplyResources(RespawnInfoPanel, "RespawnInfoPanel");
            RespawnInfoPanel.Controls.Add(chkrespawnsave);
            RespawnInfoPanel.Controls.Add(chkRespawnEnableTick);
            RespawnInfoPanel.Controls.Add(Randomtextbox);
            RespawnInfoPanel.Controls.Add(label23);
            RespawnInfoPanel.Controls.Add(label34);
            RespawnInfoPanel.Controls.Add(RoutePathTextBox);
            RespawnInfoPanel.Controls.Add(label24);
            RespawnInfoPanel.Controls.Add(DirectionTextBox);
            RespawnInfoPanel.Controls.Add(label8);
            RespawnInfoPanel.Controls.Add(DelayTextBox);
            RespawnInfoPanel.Controls.Add(label7);
            RespawnInfoPanel.Controls.Add(MonsterInfoComboBox);
            RespawnInfoPanel.Controls.Add(label6);
            RespawnInfoPanel.Controls.Add(SpreadTextBox);
            RespawnInfoPanel.Controls.Add(label9);
            RespawnInfoPanel.Controls.Add(RYTextBox);
            RespawnInfoPanel.Controls.Add(label10);
            RespawnInfoPanel.Controls.Add(CountTextBox);
            RespawnInfoPanel.Controls.Add(label13);
            RespawnInfoPanel.Controls.Add(RXTextBox);
            RespawnInfoPanel.Name = "RespawnInfoPanel";
            // 
            // chkrespawnsave
            // 
            resources.ApplyResources(chkrespawnsave, "chkrespawnsave");
            chkrespawnsave.Name = "chkrespawnsave";
            chkrespawnsave.UseVisualStyleBackColor = true;
            chkrespawnsave.CheckedChanged += chkrespawnsave_CheckedChanged;
            // 
            // chkRespawnEnableTick
            // 
            resources.ApplyResources(chkRespawnEnableTick, "chkRespawnEnableTick");
            chkRespawnEnableTick.Name = "chkRespawnEnableTick";
            chkRespawnEnableTick.UseVisualStyleBackColor = true;
            chkRespawnEnableTick.CheckedChanged += chkRespawnEnableTick_CheckedChanged;
            // 
            // Randomtextbox
            // 
            resources.ApplyResources(Randomtextbox, "Randomtextbox");
            Randomtextbox.Name = "Randomtextbox";
            toolTip1.SetToolTip(Randomtextbox, resources.GetString("Randomtextbox.ToolTip"));
            Randomtextbox.TextChanged += RandomTextBox_TextChanged;
            // 
            // label23
            // 
            resources.ApplyResources(label23, "label23");
            label23.Name = "label23";
            // 
            // label34
            // 
            resources.ApplyResources(label34, "label34");
            label34.Name = "label34";
            // 
            // RoutePathTextBox
            // 
            resources.ApplyResources(RoutePathTextBox, "RoutePathTextBox");
            RoutePathTextBox.Name = "RoutePathTextBox";
            RoutePathTextBox.TextChanged += RoutePathTextBox_TextChanged;
            // 
            // label24
            // 
            resources.ApplyResources(label24, "label24");
            label24.Name = "label24";
            // 
            // DirectionTextBox
            // 
            resources.ApplyResources(DirectionTextBox, "DirectionTextBox");
            DirectionTextBox.Name = "DirectionTextBox";
            DirectionTextBox.TextChanged += DirectionTextBox_TextChanged;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // DelayTextBox
            // 
            resources.ApplyResources(DelayTextBox, "DelayTextBox");
            DelayTextBox.Name = "DelayTextBox";
            toolTip1.SetToolTip(DelayTextBox, resources.GetString("DelayTextBox.ToolTip"));
            DelayTextBox.TextChanged += DelayTextBox_TextChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // MonsterInfoComboBox
            // 
            MonsterInfoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MonsterInfoComboBox.FormattingEnabled = true;
            resources.ApplyResources(MonsterInfoComboBox, "MonsterInfoComboBox");
            MonsterInfoComboBox.Name = "MonsterInfoComboBox";
            MonsterInfoComboBox.SelectedIndexChanged += MonsterInfoComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // SpreadTextBox
            // 
            resources.ApplyResources(SpreadTextBox, "SpreadTextBox");
            SpreadTextBox.Name = "SpreadTextBox";
            SpreadTextBox.TextChanged += SpreadTextBox_TextChanged;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // RYTextBox
            // 
            resources.ApplyResources(RYTextBox, "RYTextBox");
            RYTextBox.Name = "RYTextBox";
            RYTextBox.TextChanged += RYTextBox_TextChanged;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // CountTextBox
            // 
            resources.ApplyResources(CountTextBox, "CountTextBox");
            CountTextBox.Name = "CountTextBox";
            CountTextBox.TextChanged += CountTextBox_TextChanged;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // RXTextBox
            // 
            resources.ApplyResources(RXTextBox, "RXTextBox");
            RXTextBox.Name = "RXTextBox";
            RXTextBox.TextChanged += RXTextBox_TextChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(RemoveMButton);
            tabPage4.Controls.Add(AddMButton);
            tabPage4.Controls.Add(MovementInfoPanel);
            tabPage4.Controls.Add(MovementInfoListBox);
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // RemoveMButton
            // 
            resources.ApplyResources(RemoveMButton, "RemoveMButton");
            RemoveMButton.Name = "RemoveMButton";
            RemoveMButton.UseVisualStyleBackColor = true;
            RemoveMButton.Click += RemoveMButton_Click;
            // 
            // AddMButton
            // 
            resources.ApplyResources(AddMButton, "AddMButton");
            AddMButton.Name = "AddMButton";
            AddMButton.UseVisualStyleBackColor = true;
            AddMButton.Click += AddMButton_Click;
            // 
            // MovementInfoPanel
            // 
            resources.ApplyResources(MovementInfoPanel, "MovementInfoPanel");
            MovementInfoPanel.Controls.Add(label26);
            MovementInfoPanel.Controls.Add(BigMapIconTextBox);
            MovementInfoPanel.Controls.Add(ShowBigMapCheckBox);
            MovementInfoPanel.Controls.Add(label25);
            MovementInfoPanel.Controls.Add(ConquestComboBox);
            MovementInfoPanel.Controls.Add(NeedMoveMCheckBox);
            MovementInfoPanel.Controls.Add(NeedHoleMCheckBox);
            MovementInfoPanel.Controls.Add(label22);
            MovementInfoPanel.Controls.Add(DestMapComboBox);
            MovementInfoPanel.Controls.Add(label18);
            MovementInfoPanel.Controls.Add(DestYTextBox);
            MovementInfoPanel.Controls.Add(label21);
            MovementInfoPanel.Controls.Add(DestXTextBox);
            MovementInfoPanel.Controls.Add(label16);
            MovementInfoPanel.Controls.Add(SourceYTextBox);
            MovementInfoPanel.Controls.Add(label20);
            MovementInfoPanel.Controls.Add(SourceXTextBox);
            MovementInfoPanel.Name = "MovementInfoPanel";
            // 
            // label26
            // 
            resources.ApplyResources(label26, "label26");
            label26.Name = "label26";
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
            // label25
            // 
            resources.ApplyResources(label25, "label25");
            label25.Name = "label25";
            // 
            // ConquestComboBox
            // 
            ConquestComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ConquestComboBox.FormattingEnabled = true;
            resources.ApplyResources(ConquestComboBox, "ConquestComboBox");
            ConquestComboBox.Name = "ConquestComboBox";
            ConquestComboBox.SelectedIndexChanged += ConquestComboBox_SelectedIndexChanged;
            // 
            // NeedMoveMCheckBox
            // 
            resources.ApplyResources(NeedMoveMCheckBox, "NeedMoveMCheckBox");
            NeedMoveMCheckBox.Name = "NeedMoveMCheckBox";
            NeedMoveMCheckBox.UseVisualStyleBackColor = true;
            NeedMoveMCheckBox.CheckedChanged += NeedScriptMCheckBox_CheckedChanged;
            // 
            // NeedHoleMCheckBox
            // 
            resources.ApplyResources(NeedHoleMCheckBox, "NeedHoleMCheckBox");
            NeedHoleMCheckBox.Name = "NeedHoleMCheckBox";
            NeedHoleMCheckBox.UseVisualStyleBackColor = true;
            NeedHoleMCheckBox.CheckedChanged += NeedHoleMCheckBox_CheckedChanged;
            // 
            // label22
            // 
            resources.ApplyResources(label22, "label22");
            label22.Name = "label22";
            // 
            // DestMapComboBox
            // 
            DestMapComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DestMapComboBox.FormattingEnabled = true;
            resources.ApplyResources(DestMapComboBox, "DestMapComboBox");
            DestMapComboBox.Name = "DestMapComboBox";
            DestMapComboBox.SelectedIndexChanged += DestMapComboBox_SelectedIndexChanged;
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            label18.Name = "label18";
            // 
            // DestYTextBox
            // 
            resources.ApplyResources(DestYTextBox, "DestYTextBox");
            DestYTextBox.Name = "DestYTextBox";
            DestYTextBox.TextChanged += DestYTextBox_TextChanged;
            // 
            // label21
            // 
            resources.ApplyResources(label21, "label21");
            label21.Name = "label21";
            // 
            // DestXTextBox
            // 
            resources.ApplyResources(DestXTextBox, "DestXTextBox");
            DestXTextBox.Name = "DestXTextBox";
            DestXTextBox.TextChanged += DestXTextBox_TextChanged;
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            // 
            // SourceYTextBox
            // 
            resources.ApplyResources(SourceYTextBox, "SourceYTextBox");
            SourceYTextBox.Name = "SourceYTextBox";
            SourceYTextBox.TextChanged += SourceYTextBox_TextChanged;
            // 
            // label20
            // 
            resources.ApplyResources(label20, "label20");
            label20.Name = "label20";
            // 
            // SourceXTextBox
            // 
            resources.ApplyResources(SourceXTextBox, "SourceXTextBox");
            SourceXTextBox.Name = "SourceXTextBox";
            SourceXTextBox.TextChanged += SourceXTextBox_TextChanged;
            // 
            // MovementInfoListBox
            // 
            resources.ApplyResources(MovementInfoListBox, "MovementInfoListBox");
            MovementInfoListBox.FormattingEnabled = true;
            MovementInfoListBox.Name = "MovementInfoListBox";
            MovementInfoListBox.SelectionMode = SelectionMode.MultiExtended;
            MovementInfoListBox.SelectedIndexChanged += MovementInfoListBox_SelectedIndexChanged;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(MZDeletebutton);
            tabPage7.Controls.Add(MZAddbutton);
            tabPage7.Controls.Add(MineZonepanel);
            tabPage7.Controls.Add(MZListlistBox);
            resources.ApplyResources(tabPage7, "tabPage7");
            tabPage7.Name = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // MZDeletebutton
            // 
            resources.ApplyResources(MZDeletebutton, "MZDeletebutton");
            MZDeletebutton.Name = "MZDeletebutton";
            MZDeletebutton.UseVisualStyleBackColor = true;
            MZDeletebutton.Click += MZDeletebutton_Click;
            // 
            // MZAddbutton
            // 
            resources.ApplyResources(MZAddbutton, "MZAddbutton");
            MZAddbutton.Name = "MZAddbutton";
            MZAddbutton.UseVisualStyleBackColor = true;
            MZAddbutton.Click += MZAddbutton_Click;
            // 
            // MineZonepanel
            // 
            resources.ApplyResources(MineZonepanel, "MineZonepanel");
            MineZonepanel.Controls.Add(label27);
            MineZonepanel.Controls.Add(MineZoneComboBox);
            MineZonepanel.Controls.Add(label30);
            MineZonepanel.Controls.Add(MZYtextBox);
            MineZonepanel.Controls.Add(label31);
            MineZonepanel.Controls.Add(MZSizetextBox);
            MineZonepanel.Controls.Add(label32);
            MineZonepanel.Controls.Add(MZXtextBox);
            MineZonepanel.Name = "MineZonepanel";
            // 
            // label27
            // 
            resources.ApplyResources(label27, "label27");
            label27.Name = "label27";
            // 
            // MineZoneComboBox
            // 
            MineZoneComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MineZoneComboBox.FormattingEnabled = true;
            resources.ApplyResources(MineZoneComboBox, "MineZoneComboBox");
            MineZoneComboBox.Name = "MineZoneComboBox";
            MineZoneComboBox.SelectedIndexChanged += MineZoneComboBox_SelectedIndexChanged;
            // 
            // label30
            // 
            resources.ApplyResources(label30, "label30");
            label30.Name = "label30";
            // 
            // MZYtextBox
            // 
            resources.ApplyResources(MZYtextBox, "MZYtextBox");
            MZYtextBox.Name = "MZYtextBox";
            MZYtextBox.TextChanged += MZYtextBox_TextChanged;
            // 
            // label31
            // 
            resources.ApplyResources(label31, "label31");
            label31.Name = "label31";
            // 
            // MZSizetextBox
            // 
            resources.ApplyResources(MZSizetextBox, "MZSizetextBox");
            MZSizetextBox.Name = "MZSizetextBox";
            MZSizetextBox.TextChanged += MZSizetextBox_TextChanged;
            // 
            // label32
            // 
            resources.ApplyResources(label32, "label32");
            label32.Name = "label32";
            // 
            // MZXtextBox
            // 
            resources.ApplyResources(MZXtextBox, "MZXtextBox");
            MZXtextBox.Name = "MZXtextBox";
            MZXtextBox.TextChanged += MZXtextBox_TextChanged;
            // 
            // MZListlistBox
            // 
            resources.ApplyResources(MZListlistBox, "MZListlistBox");
            MZListlistBox.FormattingEnabled = true;
            MZListlistBox.Name = "MZListlistBox";
            MZListlistBox.SelectionMode = SelectionMode.MultiExtended;
            MZListlistBox.SelectedIndexChanged += MZListlistBox_SelectedIndexChanged;
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
            // MapInfoListBox
            // 
            resources.ApplyResources(MapInfoListBox, "MapInfoListBox");
            MapInfoListBox.FormattingEnabled = true;
            MapInfoListBox.Name = "MapInfoListBox";
            MapInfoListBox.SelectionMode = SelectionMode.MultiExtended;
            MapInfoListBox.SelectedIndexChanged += MapInfoListBox_SelectedIndexChanged;
            // 
            // PasteMapButton
            // 
            resources.ApplyResources(PasteMapButton, "PasteMapButton");
            PasteMapButton.Name = "PasteMapButton";
            PasteMapButton.UseVisualStyleBackColor = true;
            PasteMapButton.Click += PasteMapButton_Click;
            // 
            // CopyMapButton
            // 
            resources.ApplyResources(CopyMapButton, "CopyMapButton");
            CopyMapButton.Name = "CopyMapButton";
            CopyMapButton.UseVisualStyleBackColor = true;
            // 
            // ImportMapInfoButton
            // 
            resources.ApplyResources(ImportMapInfoButton, "ImportMapInfoButton");
            ImportMapInfoButton.Name = "ImportMapInfoButton";
            ImportMapInfoButton.UseVisualStyleBackColor = true;
            ImportMapInfoButton.Click += ImportMapInfoButton_Click;
            // 
            // ExportMapInfoButton
            // 
            resources.ApplyResources(ExportMapInfoButton, "ExportMapInfoButton");
            ExportMapInfoButton.Name = "ExportMapInfoButton";
            ExportMapInfoButton.UseVisualStyleBackColor = true;
            ExportMapInfoButton.Click += ExportMapInfoButton_Click;
            // 
            // ImportMongenButton
            // 
            resources.ApplyResources(ImportMongenButton, "ImportMongenButton");
            ImportMongenButton.Name = "ImportMongenButton";
            ImportMongenButton.UseVisualStyleBackColor = true;
            ImportMongenButton.Click += ImportMonGenButton_Click;
            // 
            // ExportMongenButton
            // 
            resources.ApplyResources(ExportMongenButton, "ExportMongenButton");
            ExportMongenButton.Name = "ExportMongenButton";
            ExportMongenButton.UseVisualStyleBackColor = true;
            ExportMongenButton.Click += ExportMonGenButton_Click;
            // 
            // VisualizerButton
            // 
            resources.ApplyResources(VisualizerButton, "VisualizerButton");
            VisualizerButton.Name = "VisualizerButton";
            VisualizerButton.UseVisualStyleBackColor = true;
            VisualizerButton.Click += VisualizerButton_Click;
            // 
            // MapInfoForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(VisualizerButton);
            Controls.Add(ExportMongenButton);
            Controls.Add(ImportMongenButton);
            Controls.Add(ExportMapInfoButton);
            Controls.Add(ImportMapInfoButton);
            Controls.Add(PasteMapButton);
            Controls.Add(CopyMapButton);
            Controls.Add(MapTabs);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(MapInfoListBox);
            Name = "MapInfoForm";
            FormClosed += MapInfoForm_FormClosed;
            MapTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((ISupportInitialize)MinimapPreview).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage3.ResumeLayout(false);
            SafeZoneInfoPanel.ResumeLayout(false);
            SafeZoneInfoPanel.PerformLayout();
            tabPage2.ResumeLayout(false);
            RespawnInfoPanel.ResumeLayout(false);
            RespawnInfoPanel.PerformLayout();
            tabPage4.ResumeLayout(false);
            MovementInfoPanel.ResumeLayout(false);
            MovementInfoPanel.PerformLayout();
            tabPage7.ResumeLayout(false);
            MineZonepanel.ResumeLayout(false);
            MineZonepanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MapTabs;
        private TabPage tabPage3;
        private Button RemoveSZButton;
        private Button AddSZButton;
        private Panel SafeZoneInfoPanel;
        private Label label12;
        private TextBox SZYTextBox;
        private Label label14;
        private TextBox SizeTextBox;
        private Label label17;
        private TextBox SZXTextBox;
        private CheckBox StartPointCheckBox;
        private ListBox SafeZoneInfoListBox;
        private TabPage tabPage2;
        private Button RPasteButton;
        private Button RCopyButton;
        private Button RemoveRButton;
        private Button AddRButton;
        private ListBox RespawnInfoListBox;
        private Panel RespawnInfoPanel;
        private Label label24;
        private TextBox DirectionTextBox;
        private Label label8;
        private TextBox DelayTextBox;
        private Label label7;
        private ComboBox MonsterInfoComboBox;
        private Label label6;
        private TextBox SpreadTextBox;
        private Label label9;
        private TextBox RYTextBox;
        private Label label10;
        private TextBox CountTextBox;
        private Label label13;
        private TextBox RXTextBox;
        private TabPage tabPage4;
        private Button RemoveMButton;
        private Button AddMButton;
        private Panel MovementInfoPanel;
        private Label label22;
        private ComboBox DestMapComboBox;
        private Label label18;
        private TextBox DestYTextBox;
        private Label label21;
        private TextBox DestXTextBox;
        private Label label16;
        private TextBox SourceYTextBox;
        private Label label20;
        private TextBox SourceXTextBox;
        private ListBox MovementInfoListBox;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox MapInfoListBox;
        private Button PasteMapButton;
        private Button CopyMapButton;
        private TabPage tabPage1;
        private Label label15;
        private TextBox BigMapTextBox;
        private ComboBox LightsComboBox;
        private Label label5;
        private Label label1;
        private Label label4;
        private TextBox MapIndexTextBox;
        private TextBox MiniMapTextBox;
        private Label label2;
        private TextBox MapNameTextBox;
        private TextBox FileNameTextBox;
        private Label label3;
        private TabPage tabPage6;
        private CheckBox LightningCheckbox;
        private CheckBox FireCheckbox;
        private CheckBox FightCheckbox;
        private CheckBox NoReconnectCheckbox;
        private CheckBox NoTeleportCheckbox;
        private TextBox LightningTextbox;
        private TextBox FireTextbox;
        private TextBox NoReconnectTextbox;
        private CheckBox NoNamesCheckbox;
        private CheckBox NoDropMonsterCheckbox;
        private CheckBox NoDropPlayerCheckbox;
        private CheckBox NoThrowItemCheckbox;
        private CheckBox NoPositionCheckbox;
        private CheckBox NoDrugCheckbox;
        private CheckBox NoRecallCheckbox;
        private CheckBox NoEscapeCheckbox;
        private CheckBox NoRandomCheckbox;
        private CheckBox NeedHoleMCheckBox;
        private Button ImportMapInfoButton;
        private Button ExportMapInfoButton;
        private Label label19;
        private TextBox MapDarkLighttextBox;
        private TabPage tabPage7;
        private Button MZDeletebutton;
        private Button MZAddbutton;
        private Panel MineZonepanel;
        private Label label30;
        private TextBox MZYtextBox;
        private Label label31;
        private TextBox MZSizetextBox;
        private Label label32;
        private TextBox MZXtextBox;
        private ListBox MZListlistBox;
        private ComboBox MineComboBox;
        private ComboBox MineZoneComboBox;
        private Label label27;
        private Label label33;
        private Button ImportMongenButton;
        private Button ExportMongenButton;
        private Button VisualizerButton;
        private CheckBox NeedBridleCheckbox;
        private CheckBox NoMountCheckbox;
        private Label label34;
        private TextBox RoutePathTextBox;
        private CheckBox NoFightCheckbox;
        private CheckBox NeedMoveMCheckBox;
        private Label label11;
        private TextBox MusicTextBox;
        private Label label23;
        private TextBox Randomtextbox;
        private ToolTip toolTip1;
        private CheckBox chkrespawnsave;
        private CheckBox chkRespawnEnableTick;
        private ComboBox ConquestComboBox;
        private Label label25;
        private CheckBox NoTownTeleportCheckbox;
        private CheckBox NoReincarnation;
        private Label label26;
        private TextBox BigMapIconTextBox;
        private CheckBox ShowBigMapCheckBox;
        private PictureBox MinimapPreview;
        private ListBox lstParticles;
        private Label label48;
    }
}