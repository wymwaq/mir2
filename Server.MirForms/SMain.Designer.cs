using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Server
{
    partial class SMain
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SMain));
            MainTabs = new TabControl();
            tabPage1 = new TabPage();
            LogTextBox = new TextBox();
            tabPage2 = new TabPage();
            DebugLogTextBox = new TextBox();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            GlobalMessageButton = new Button();
            GlobalMessageTextBox = new TextBox();
            ChatLogTextBox = new TextBox();
            tabPage4 = new TabPage();
            PlayersOnlineListView = new CustomFormControl.ListViewNF();
            indexHeader = new ColumnHeader();
            nameHeader = new ColumnHeader();
            levelHeader = new ColumnHeader();
            classHeader = new ColumnHeader();
            genderHeader = new ColumnHeader();
            tabPage5 = new TabPage();
            GuildListView = new CustomFormControl.ListViewNF();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            StatusBar = new StatusStrip();
            PlayersLabel = new ToolStripStatusLabel();
            MonsterLabel = new ToolStripStatusLabel();
            ConnectionsLabel = new ToolStripStatusLabel();
            BlockedIPsLabel = new ToolStripStatusLabel();
            CycleDelayLabel = new ToolStripStatusLabel();
            MainMenu = new MenuStrip();
            controlToolStripMenuItem = new ToolStripMenuItem();
            startServerToolStripMenuItem = new ToolStripMenuItem();
            stopServerToolStripMenuItem = new ToolStripMenuItem();
            rebootServerToolStripMenuItem = new ToolStripMenuItem();
            clearBlockedIPsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            toolStripSeparator1 = new ToolStripSeparator();
            closeServerToolStripMenuItem = new ToolStripMenuItem();
            reloadToolStripMenuItem = new ToolStripMenuItem();
            nPCsToolStripMenuItem = new ToolStripMenuItem();
            dropsToolStripMenuItem = new ToolStripMenuItem();
            lineMessageToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            databaseFormsToolStripMenuItem = new ToolStripMenuItem();
            mapInfoToolStripMenuItem = new ToolStripMenuItem();
            itemInfoToolStripMenuItem = new ToolStripMenuItem();
            monsterInfoToolStripMenuItem = new ToolStripMenuItem();
            itemNEWToolStripMenuItem = new ToolStripMenuItem();
            monsterExperimentalToolStripMenuItem = new ToolStripMenuItem();
            nPCInfoToolStripMenuItem = new ToolStripMenuItem();
            questInfoToolStripMenuItem = new ToolStripMenuItem();
            magicInfoToolStripMenuItem = new ToolStripMenuItem();
            gameshopToolStripMenuItem = new ToolStripMenuItem();
            recipeToolStripMenuItem = new ToolStripMenuItem();
            configToolStripMenuItem1 = new ToolStripMenuItem();
            serverToolStripMenuItem = new ToolStripMenuItem();
            balanceToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            dragonSystemToolStripMenuItem = new ToolStripMenuItem();
            miningToolStripMenuItem = new ToolStripMenuItem();
            guildsToolStripMenuItem = new ToolStripMenuItem();
            fishingToolStripMenuItem = new ToolStripMenuItem();
            mailToolStripMenuItem = new ToolStripMenuItem();
            goodsToolStripMenuItem = new ToolStripMenuItem();
            refiningToolStripMenuItem = new ToolStripMenuItem();
            relationshipToolStripMenuItem = new ToolStripMenuItem();
            mentorToolStripMenuItem = new ToolStripMenuItem();
            gemToolStripMenuItem = new ToolStripMenuItem();
            conquestToolStripMenuItem = new ToolStripMenuItem();
            respawnsToolStripMenuItem = new ToolStripMenuItem();
            heroesToolStripMenuItem = new ToolStripMenuItem();
            monsterTunerToolStripMenuItem = new ToolStripMenuItem();
            dropBuilderToolStripMenuItem = new ToolStripMenuItem();
            CharacterToolStripMenuItem = new ToolStripMenuItem();
            UpTimeLabel = new ToolStripTextBox();
            InterfaceTimer = new Timer(components);
            MainTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            StatusBar.SuspendLayout();
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabs
            // 
            MainTabs.Controls.Add(tabPage1);
            MainTabs.Controls.Add(tabPage2);
            MainTabs.Controls.Add(tabPage3);
            MainTabs.Controls.Add(tabPage4);
            MainTabs.Controls.Add(tabPage5);
            resources.ApplyResources(MainTabs, "MainTabs");
            MainTabs.Name = "MainTabs";
            MainTabs.SelectedIndex = 0;
            MainTabs.SelectedIndexChanged += MainTabs_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(LogTextBox);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            resources.ApplyResources(LogTextBox, "LogTextBox");
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(DebugLogTextBox);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DebugLogTextBox
            // 
            resources.ApplyResources(DebugLogTextBox, "DebugLogTextBox");
            DebugLogTextBox.Name = "DebugLogTextBox";
            DebugLogTextBox.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(ChatLogTextBox);
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Name = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GlobalMessageButton);
            groupBox1.Controls.Add(GlobalMessageTextBox);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // GlobalMessageButton
            // 
            resources.ApplyResources(GlobalMessageButton, "GlobalMessageButton");
            GlobalMessageButton.Name = "GlobalMessageButton";
            GlobalMessageButton.UseVisualStyleBackColor = true;
            GlobalMessageButton.Click += GlobalMessageButton_Click;
            // 
            // GlobalMessageTextBox
            // 
            resources.ApplyResources(GlobalMessageTextBox, "GlobalMessageTextBox");
            GlobalMessageTextBox.Name = "GlobalMessageTextBox";
            // 
            // ChatLogTextBox
            // 
            resources.ApplyResources(ChatLogTextBox, "ChatLogTextBox");
            ChatLogTextBox.Name = "ChatLogTextBox";
            ChatLogTextBox.ReadOnly = true;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.Control;
            tabPage4.Controls.Add(PlayersOnlineListView);
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            // 
            // PlayersOnlineListView
            // 
            PlayersOnlineListView.Activation = ItemActivation.OneClick;
            PlayersOnlineListView.BackColor = SystemColors.Window;
            PlayersOnlineListView.Columns.AddRange(new ColumnHeader[] { indexHeader, nameHeader, levelHeader, classHeader, genderHeader });
            resources.ApplyResources(PlayersOnlineListView, "PlayersOnlineListView");
            PlayersOnlineListView.FullRowSelect = true;
            PlayersOnlineListView.GridLines = true;
            PlayersOnlineListView.Name = "PlayersOnlineListView";
            PlayersOnlineListView.Sorting = SortOrder.Ascending;
            PlayersOnlineListView.UseCompatibleStateImageBehavior = false;
            PlayersOnlineListView.View = View.Details;
            PlayersOnlineListView.ColumnWidthChanging += PlayersOnlineListView_ColumnWidthChanging;
            PlayersOnlineListView.DoubleClick += PlayersOnlineListView_DoubleClick;
            // 
            // indexHeader
            // 
            resources.ApplyResources(indexHeader, "indexHeader");
            // 
            // nameHeader
            // 
            resources.ApplyResources(nameHeader, "nameHeader");
            // 
            // levelHeader
            // 
            resources.ApplyResources(levelHeader, "levelHeader");
            // 
            // classHeader
            // 
            resources.ApplyResources(classHeader, "classHeader");
            // 
            // genderHeader
            // 
            resources.ApplyResources(genderHeader, "genderHeader");
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(GuildListView);
            resources.ApplyResources(tabPage5, "tabPage5");
            tabPage5.Name = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // GuildListView
            // 
            GuildListView.Activation = ItemActivation.OneClick;
            GuildListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            resources.ApplyResources(GuildListView, "GuildListView");
            GuildListView.FullRowSelect = true;
            GuildListView.GridLines = true;
            GuildListView.Name = "GuildListView";
            GuildListView.UseCompatibleStateImageBehavior = false;
            GuildListView.View = View.Details;
            GuildListView.DoubleClick += GuildListView_DoubleClick;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(columnHeader6, "columnHeader6");
            // 
            // StatusBar
            // 
            StatusBar.Items.AddRange(new ToolStripItem[] { PlayersLabel, MonsterLabel, ConnectionsLabel, BlockedIPsLabel, CycleDelayLabel });
            resources.ApplyResources(StatusBar, "StatusBar");
            StatusBar.Name = "StatusBar";
            StatusBar.SizingGrip = false;
            // 
            // PlayersLabel
            // 
            PlayersLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            PlayersLabel.Name = "PlayersLabel";
            resources.ApplyResources(PlayersLabel, "PlayersLabel");
            // 
            // MonsterLabel
            // 
            MonsterLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            MonsterLabel.Name = "MonsterLabel";
            resources.ApplyResources(MonsterLabel, "MonsterLabel");
            // 
            // ConnectionsLabel
            // 
            ConnectionsLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            ConnectionsLabel.Name = "ConnectionsLabel";
            resources.ApplyResources(ConnectionsLabel, "ConnectionsLabel");
            // 
            // BlockedIPsLabel
            // 
            BlockedIPsLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            BlockedIPsLabel.Name = "BlockedIPsLabel";
            resources.ApplyResources(BlockedIPsLabel, "BlockedIPsLabel");
            // 
            // CycleDelayLabel
            // 
            CycleDelayLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            CycleDelayLabel.Name = "CycleDelayLabel";
            resources.ApplyResources(CycleDelayLabel, "CycleDelayLabel");
            // 
            // MainMenu
            // 
            MainMenu.BackColor = Color.Transparent;
            MainMenu.Items.AddRange(new ToolStripItem[] { controlToolStripMenuItem, accountToolStripMenuItem, databaseFormsToolStripMenuItem, configToolStripMenuItem1, CharacterToolStripMenuItem, UpTimeLabel });
            resources.ApplyResources(MainMenu, "MainMenu");
            MainMenu.Name = "MainMenu";
            // 
            // controlToolStripMenuItem
            // 
            controlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startServerToolStripMenuItem, stopServerToolStripMenuItem, rebootServerToolStripMenuItem, clearBlockedIPsToolStripMenuItem, toolStripMenuItem1, toolStripSeparator1, closeServerToolStripMenuItem, reloadToolStripMenuItem });
            controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            resources.ApplyResources(controlToolStripMenuItem, "controlToolStripMenuItem");
            // 
            // startServerToolStripMenuItem
            // 
            startServerToolStripMenuItem.Name = "startServerToolStripMenuItem";
            resources.ApplyResources(startServerToolStripMenuItem, "startServerToolStripMenuItem");
            startServerToolStripMenuItem.Click += startServerToolStripMenuItem_Click;
            // 
            // stopServerToolStripMenuItem
            // 
            stopServerToolStripMenuItem.Name = "stopServerToolStripMenuItem";
            resources.ApplyResources(stopServerToolStripMenuItem, "stopServerToolStripMenuItem");
            stopServerToolStripMenuItem.Click += stopServerToolStripMenuItem_Click;
            // 
            // rebootServerToolStripMenuItem
            // 
            rebootServerToolStripMenuItem.Name = "rebootServerToolStripMenuItem";
            resources.ApplyResources(rebootServerToolStripMenuItem, "rebootServerToolStripMenuItem");
            rebootServerToolStripMenuItem.Click += rebootServerToolStripMenuItem_Click;
            // 
            // clearBlockedIPsToolStripMenuItem
            // 
            clearBlockedIPsToolStripMenuItem.Name = "clearBlockedIPsToolStripMenuItem";
            resources.ApplyResources(clearBlockedIPsToolStripMenuItem, "clearBlockedIPsToolStripMenuItem");
            clearBlockedIPsToolStripMenuItem.Click += clearBlockedIPsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // closeServerToolStripMenuItem
            // 
            closeServerToolStripMenuItem.Name = "closeServerToolStripMenuItem";
            resources.ApplyResources(closeServerToolStripMenuItem, "closeServerToolStripMenuItem");
            closeServerToolStripMenuItem.Click += closeServerToolStripMenuItem_Click;
            // 
            // reloadToolStripMenuItem
            // 
            reloadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nPCsToolStripMenuItem, dropsToolStripMenuItem, lineMessageToolStripMenuItem });
            reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            resources.ApplyResources(reloadToolStripMenuItem, "reloadToolStripMenuItem");
            // 
            // nPCsToolStripMenuItem
            // 
            nPCsToolStripMenuItem.Name = "nPCsToolStripMenuItem";
            resources.ApplyResources(nPCsToolStripMenuItem, "nPCsToolStripMenuItem");
            nPCsToolStripMenuItem.Click += nPCsToolStripMenuItem_Click;
            // 
            // dropsToolStripMenuItem
            // 
            dropsToolStripMenuItem.Name = "dropsToolStripMenuItem";
            resources.ApplyResources(dropsToolStripMenuItem, "dropsToolStripMenuItem");
            dropsToolStripMenuItem.Click += dropsToolStripMenuItem_Click;
            // 
            // lineMessageToolStripMenuItem
            // 
            lineMessageToolStripMenuItem.Name = "lineMessageToolStripMenuItem";
            resources.ApplyResources(lineMessageToolStripMenuItem, "lineMessageToolStripMenuItem");
            lineMessageToolStripMenuItem.Click += lineMessageToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            resources.ApplyResources(accountToolStripMenuItem, "accountToolStripMenuItem");
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // databaseFormsToolStripMenuItem
            // 
            databaseFormsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mapInfoToolStripMenuItem, itemInfoToolStripMenuItem, monsterInfoToolStripMenuItem, itemNEWToolStripMenuItem, monsterExperimentalToolStripMenuItem, nPCInfoToolStripMenuItem, questInfoToolStripMenuItem, magicInfoToolStripMenuItem, gameshopToolStripMenuItem, recipeToolStripMenuItem });
            databaseFormsToolStripMenuItem.Name = "databaseFormsToolStripMenuItem";
            resources.ApplyResources(databaseFormsToolStripMenuItem, "databaseFormsToolStripMenuItem");
            // 
            // mapInfoToolStripMenuItem
            // 
            mapInfoToolStripMenuItem.Name = "mapInfoToolStripMenuItem";
            resources.ApplyResources(mapInfoToolStripMenuItem, "mapInfoToolStripMenuItem");
            mapInfoToolStripMenuItem.Click += mapInfoToolStripMenuItem_Click;
            // 
            // itemInfoToolStripMenuItem
            // 
            itemInfoToolStripMenuItem.Name = "itemInfoToolStripMenuItem";
            resources.ApplyResources(itemInfoToolStripMenuItem, "itemInfoToolStripMenuItem");
            itemInfoToolStripMenuItem.Click += itemInfoToolStripMenuItem_Click;
            // 
            // monsterInfoToolStripMenuItem
            // 
            monsterInfoToolStripMenuItem.Name = "monsterInfoToolStripMenuItem";
            resources.ApplyResources(monsterInfoToolStripMenuItem, "monsterInfoToolStripMenuItem");
            monsterInfoToolStripMenuItem.Click += monsterInfoToolStripMenuItem_Click;
            // 
            // itemNEWToolStripMenuItem
            // 
            itemNEWToolStripMenuItem.Name = "itemNEWToolStripMenuItem";
            resources.ApplyResources(itemNEWToolStripMenuItem, "itemNEWToolStripMenuItem");
            itemNEWToolStripMenuItem.Click += itemNEWToolStripMenuItem_Click;
            // 
            // monsterExperimentalToolStripMenuItem
            // 
            monsterExperimentalToolStripMenuItem.Name = "monsterExperimentalToolStripMenuItem";
            resources.ApplyResources(monsterExperimentalToolStripMenuItem, "monsterExperimentalToolStripMenuItem");
            monsterExperimentalToolStripMenuItem.Click += monsterExperimentalToolStripMenuItem_Click;
            // 
            // nPCInfoToolStripMenuItem
            // 
            nPCInfoToolStripMenuItem.Name = "nPCInfoToolStripMenuItem";
            resources.ApplyResources(nPCInfoToolStripMenuItem, "nPCInfoToolStripMenuItem");
            nPCInfoToolStripMenuItem.Click += nPCInfoToolStripMenuItem_Click;
            // 
            // questInfoToolStripMenuItem
            // 
            questInfoToolStripMenuItem.Name = "questInfoToolStripMenuItem";
            resources.ApplyResources(questInfoToolStripMenuItem, "questInfoToolStripMenuItem");
            questInfoToolStripMenuItem.Click += questInfoToolStripMenuItem_Click;
            // 
            // magicInfoToolStripMenuItem
            // 
            magicInfoToolStripMenuItem.Name = "magicInfoToolStripMenuItem";
            resources.ApplyResources(magicInfoToolStripMenuItem, "magicInfoToolStripMenuItem");
            magicInfoToolStripMenuItem.Click += magicInfoToolStripMenuItem_Click;
            // 
            // gameshopToolStripMenuItem
            // 
            gameshopToolStripMenuItem.Name = "gameshopToolStripMenuItem";
            resources.ApplyResources(gameshopToolStripMenuItem, "gameshopToolStripMenuItem");
            gameshopToolStripMenuItem.Click += gameshopToolStripMenuItem_Click;
            // 
            // recipeToolStripMenuItem
            // 
            recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            resources.ApplyResources(recipeToolStripMenuItem, "recipeToolStripMenuItem");
            recipeToolStripMenuItem.Click += recipeToolStripMenuItem_Click;
            // 
            // configToolStripMenuItem1
            // 
            configToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { serverToolStripMenuItem, balanceToolStripMenuItem, systemToolStripMenuItem, monsterTunerToolStripMenuItem, dropBuilderToolStripMenuItem });
            configToolStripMenuItem1.Name = "configToolStripMenuItem1";
            resources.ApplyResources(configToolStripMenuItem1, "configToolStripMenuItem1");
            // 
            // serverToolStripMenuItem
            // 
            serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            resources.ApplyResources(serverToolStripMenuItem, "serverToolStripMenuItem");
            serverToolStripMenuItem.Click += serverToolStripMenuItem_Click;
            // 
            // balanceToolStripMenuItem
            // 
            balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            resources.ApplyResources(balanceToolStripMenuItem, "balanceToolStripMenuItem");
            balanceToolStripMenuItem.Click += balanceToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dragonSystemToolStripMenuItem, miningToolStripMenuItem, guildsToolStripMenuItem, fishingToolStripMenuItem, mailToolStripMenuItem, goodsToolStripMenuItem, refiningToolStripMenuItem, relationshipToolStripMenuItem, mentorToolStripMenuItem, gemToolStripMenuItem, conquestToolStripMenuItem, respawnsToolStripMenuItem, heroesToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            resources.ApplyResources(systemToolStripMenuItem, "systemToolStripMenuItem");
            // 
            // dragonSystemToolStripMenuItem
            // 
            dragonSystemToolStripMenuItem.Name = "dragonSystemToolStripMenuItem";
            resources.ApplyResources(dragonSystemToolStripMenuItem, "dragonSystemToolStripMenuItem");
            dragonSystemToolStripMenuItem.Click += dragonSystemToolStripMenuItem_Click;
            // 
            // miningToolStripMenuItem
            // 
            miningToolStripMenuItem.Name = "miningToolStripMenuItem";
            resources.ApplyResources(miningToolStripMenuItem, "miningToolStripMenuItem");
            miningToolStripMenuItem.Click += miningToolStripMenuItem_Click;
            // 
            // guildsToolStripMenuItem
            // 
            guildsToolStripMenuItem.Name = "guildsToolStripMenuItem";
            resources.ApplyResources(guildsToolStripMenuItem, "guildsToolStripMenuItem");
            guildsToolStripMenuItem.Click += guildsToolStripMenuItem_Click;
            // 
            // fishingToolStripMenuItem
            // 
            fishingToolStripMenuItem.Name = "fishingToolStripMenuItem";
            resources.ApplyResources(fishingToolStripMenuItem, "fishingToolStripMenuItem");
            fishingToolStripMenuItem.Click += fishingToolStripMenuItem_Click;
            // 
            // mailToolStripMenuItem
            // 
            mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            resources.ApplyResources(mailToolStripMenuItem, "mailToolStripMenuItem");
            mailToolStripMenuItem.Click += mailToolStripMenuItem_Click;
            // 
            // goodsToolStripMenuItem
            // 
            goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            resources.ApplyResources(goodsToolStripMenuItem, "goodsToolStripMenuItem");
            goodsToolStripMenuItem.Click += goodsToolStripMenuItem_Click;
            // 
            // refiningToolStripMenuItem
            // 
            refiningToolStripMenuItem.Name = "refiningToolStripMenuItem";
            resources.ApplyResources(refiningToolStripMenuItem, "refiningToolStripMenuItem");
            refiningToolStripMenuItem.Click += refiningToolStripMenuItem_Click;
            // 
            // relationshipToolStripMenuItem
            // 
            relationshipToolStripMenuItem.Name = "relationshipToolStripMenuItem";
            resources.ApplyResources(relationshipToolStripMenuItem, "relationshipToolStripMenuItem");
            relationshipToolStripMenuItem.Click += relationshipToolStripMenuItem_Click;
            // 
            // mentorToolStripMenuItem
            // 
            mentorToolStripMenuItem.Name = "mentorToolStripMenuItem";
            resources.ApplyResources(mentorToolStripMenuItem, "mentorToolStripMenuItem");
            mentorToolStripMenuItem.Click += mentorToolStripMenuItem_Click;
            // 
            // gemToolStripMenuItem
            // 
            gemToolStripMenuItem.Name = "gemToolStripMenuItem";
            resources.ApplyResources(gemToolStripMenuItem, "gemToolStripMenuItem");
            gemToolStripMenuItem.Click += gemToolStripMenuItem_Click;
            // 
            // conquestToolStripMenuItem
            // 
            conquestToolStripMenuItem.Name = "conquestToolStripMenuItem";
            resources.ApplyResources(conquestToolStripMenuItem, "conquestToolStripMenuItem");
            conquestToolStripMenuItem.Click += conquestToolStripMenuItem_Click;
            // 
            // respawnsToolStripMenuItem
            // 
            respawnsToolStripMenuItem.Name = "respawnsToolStripMenuItem";
            resources.ApplyResources(respawnsToolStripMenuItem, "respawnsToolStripMenuItem");
            respawnsToolStripMenuItem.Click += respawnsToolStripMenuItem_Click;
            // 
            // heroesToolStripMenuItem
            // 
            heroesToolStripMenuItem.Name = "heroesToolStripMenuItem";
            resources.ApplyResources(heroesToolStripMenuItem, "heroesToolStripMenuItem");
            heroesToolStripMenuItem.Click += heroesToolStripMenuItem_Click;
            // 
            // monsterTunerToolStripMenuItem
            // 
            monsterTunerToolStripMenuItem.Name = "monsterTunerToolStripMenuItem";
            resources.ApplyResources(monsterTunerToolStripMenuItem, "monsterTunerToolStripMenuItem");
            monsterTunerToolStripMenuItem.Click += monsterTunerToolStripMenuItem_Click;
            // 
            // dropBuilderToolStripMenuItem
            // 
            dropBuilderToolStripMenuItem.Name = "dropBuilderToolStripMenuItem";
            resources.ApplyResources(dropBuilderToolStripMenuItem, "dropBuilderToolStripMenuItem");
            dropBuilderToolStripMenuItem.Click += dropBuilderToolStripMenuItem_Click;
            // 
            // CharacterToolStripMenuItem
            // 
            CharacterToolStripMenuItem.Name = "CharacterToolStripMenuItem";
            resources.ApplyResources(CharacterToolStripMenuItem, "CharacterToolStripMenuItem");
            CharacterToolStripMenuItem.Click += CharacterToolStripMenuItem_Click;
            // 
            // UpTimeLabel
            // 
            UpTimeLabel.Alignment = ToolStripItemAlignment.Right;
            UpTimeLabel.BorderStyle = BorderStyle.None;
            UpTimeLabel.Name = "UpTimeLabel";
            UpTimeLabel.ReadOnly = true;
            resources.ApplyResources(UpTimeLabel, "UpTimeLabel");
            // 
            // InterfaceTimer
            // 
            InterfaceTimer.Enabled = true;
            InterfaceTimer.Tick += InterfaceTimer_Tick;
            // 
            // SMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTabs);
            Controls.Add(StatusBar);
            Controls.Add(MainMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SMain";
            FormClosing += SMain_FormClosing;
            Load += SMain_Load;
            MainTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            StatusBar.ResumeLayout(false);
            StatusBar.PerformLayout();
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl MainTabs;
        private TabPage tabPage1;
        private TextBox LogTextBox;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel PlayersLabel;
        private ToolStripStatusLabel MonsterLabel;
        private ToolStripStatusLabel ConnectionsLabel;
        private MenuStrip MainMenu;
        private ToolStripMenuItem controlToolStripMenuItem;
        private ToolStripMenuItem startServerToolStripMenuItem;
        private ToolStripMenuItem stopServerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem closeServerToolStripMenuItem;
        private Timer InterfaceTimer;
        private TabPage tabPage2;
        private TextBox DebugLogTextBox;
        private TabPage tabPage3;
        private TextBox ChatLogTextBox;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem databaseFormsToolStripMenuItem;
        private ToolStripMenuItem mapInfoToolStripMenuItem;
        private ToolStripMenuItem itemInfoToolStripMenuItem;
        private ToolStripMenuItem monsterInfoToolStripMenuItem;
        private ToolStripMenuItem nPCInfoToolStripMenuItem;
        private ToolStripMenuItem questInfoToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem1;
        private ToolStripMenuItem serverToolStripMenuItem;
        private ToolStripMenuItem balanceToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem dragonSystemToolStripMenuItem;
        private ToolStripMenuItem guildsToolStripMenuItem;
        private ToolStripMenuItem miningToolStripMenuItem;
        private ToolStripMenuItem fishingToolStripMenuItem;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private Button GlobalMessageButton;
        private TextBox GlobalMessageTextBox;
        private CustomFormControl.ListViewNF PlayersOnlineListView;
        private ColumnHeader nameHeader;
        private ColumnHeader levelHeader;
        private ColumnHeader classHeader;
        private ColumnHeader genderHeader;
        private ColumnHeader indexHeader;
        private ToolStripMenuItem mailToolStripMenuItem;
        private ToolStripMenuItem goodsToolStripMenuItem;
        private ToolStripStatusLabel CycleDelayLabel;
        private ToolStripMenuItem magicInfoToolStripMenuItem;
        private ToolStripMenuItem refiningToolStripMenuItem;
        private ToolStripMenuItem relationshipToolStripMenuItem;
        private ToolStripMenuItem mentorToolStripMenuItem;
        private ToolStripMenuItem gameshopToolStripMenuItem;
        private ToolStripMenuItem gemToolStripMenuItem;
        private ToolStripMenuItem conquestToolStripMenuItem;
        private ToolStripMenuItem rebootServerToolStripMenuItem;
        private ToolStripMenuItem respawnsToolStripMenuItem;
        private ToolStripMenuItem monsterTunerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem itemNEWToolStripMenuItem;
        private ToolStripMenuItem monsterExperimentalToolStripMenuItem;
        private ToolStripMenuItem dropBuilderToolStripMenuItem;
        private ToolStripStatusLabel BlockedIPsLabel;
        private ToolStripMenuItem clearBlockedIPsToolStripMenuItem;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private ToolStripMenuItem nPCsToolStripMenuItem;
        private ToolStripMenuItem dropsToolStripMenuItem;
        private ToolStripMenuItem lineMessageToolStripMenuItem;
        private TabPage tabPage5;
        private CustomFormControl.ListViewNF GuildListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ToolStripTextBox UpTimeLabel;
        private ToolStripMenuItem heroesToolStripMenuItem;
        private ToolStripMenuItem CharacterToolStripMenuItem;
        private ToolStripMenuItem recipeToolStripMenuItem;
    }
}

