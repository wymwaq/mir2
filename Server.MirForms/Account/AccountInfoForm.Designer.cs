
namespace Server
{
    partial class AccountInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfoForm));
            CreateButton = new Button();
            label1 = new Label();
            FilterTextBox = new TextBox();
            RefreshButton = new Button();
            AccountInfoPanel = new Panel();
            Delaccbtn = new Button();
            CharactersListView = new ListView();
            characterName = new ColumnHeader();
            characterClass = new ColumnHeader();
            characterLevel = new ColumnHeader();
            characterPKPoints = new ColumnHeader();
            characterGuild = new ColumnHeader();
            characterStatus = new ColumnHeader();
            LastIPSearch = new Button();
            CreationIPSearch = new Button();
            PasswordChangeCheckBox = new CheckBox();
            setPasswordButton = new Button();
            AdminCheckBox = new CheckBox();
            PermBanButton = new Button();
            WeekBanButton = new Button();
            DayBanButton = new Button();
            BannedCheckBox = new CheckBox();
            ExpiryDateTextBox = new TextBox();
            label14 = new Label();
            BanReasonTextBox = new TextBox();
            label13 = new Label();
            LastDateTextBox = new TextBox();
            label11 = new Label();
            LastIPTextBox = new TextBox();
            label12 = new Label();
            CreationDateTextBox = new TextBox();
            label9 = new Label();
            CreationIPTextBox = new TextBox();
            label10 = new Label();
            EMailTextBox = new TextBox();
            label8 = new Label();
            AnswerTextBox = new TextBox();
            label7 = new Label();
            QuestionTextBox = new TextBox();
            label6 = new Label();
            BirthDateTextBox = new TextBox();
            label5 = new Label();
            UserNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            AccountIDTextBox = new TextBox();
            label2 = new Label();
            label15 = new Label();
            FilterPlayerTextBox = new TextBox();
            AccountInfoListView = new CustomFormControl.ListViewNF();
            indexHeader = new ColumnHeader();
            accountIDHeader = new ColumnHeader();
            userNameHeader = new ColumnHeader();
            adminHeader = new ColumnHeader();
            bannedHeader = new ColumnHeader();
            banReasonHeader = new ColumnHeader();
            expiryDateHeader = new ColumnHeader();
            Gold = new ColumnHeader();
            GameGold = new ColumnHeader();
            MatchFilterCheckBox = new CheckBox();
            WipeCharButton = new Button();
            ServerGoldTextBox = new TextBox();
            TotalServerGold = new Label();
            ServerCreditTextBox = new TextBox();
            TotalServerCredit = new Label();
            FilterIPTextBox = new TextBox();
            label16 = new Label();
            AccountInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CreateButton
            // 
            resources.ApplyResources(CreateButton, "CreateButton");
            CreateButton.Name = "CreateButton";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // FilterTextBox
            // 
            resources.ApplyResources(FilterTextBox, "FilterTextBox");
            FilterTextBox.Name = "FilterTextBox";
            // 
            // RefreshButton
            // 
            resources.ApplyResources(RefreshButton, "RefreshButton");
            RefreshButton.Name = "RefreshButton";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // AccountInfoPanel
            // 
            resources.ApplyResources(AccountInfoPanel, "AccountInfoPanel");
            AccountInfoPanel.Controls.Add(Delaccbtn);
            AccountInfoPanel.Controls.Add(CharactersListView);
            AccountInfoPanel.Controls.Add(LastIPSearch);
            AccountInfoPanel.Controls.Add(CreationIPSearch);
            AccountInfoPanel.Controls.Add(PasswordChangeCheckBox);
            AccountInfoPanel.Controls.Add(setPasswordButton);
            AccountInfoPanel.Controls.Add(AdminCheckBox);
            AccountInfoPanel.Controls.Add(PermBanButton);
            AccountInfoPanel.Controls.Add(WeekBanButton);
            AccountInfoPanel.Controls.Add(DayBanButton);
            AccountInfoPanel.Controls.Add(BannedCheckBox);
            AccountInfoPanel.Controls.Add(ExpiryDateTextBox);
            AccountInfoPanel.Controls.Add(label14);
            AccountInfoPanel.Controls.Add(BanReasonTextBox);
            AccountInfoPanel.Controls.Add(label13);
            AccountInfoPanel.Controls.Add(LastDateTextBox);
            AccountInfoPanel.Controls.Add(label11);
            AccountInfoPanel.Controls.Add(LastIPTextBox);
            AccountInfoPanel.Controls.Add(label12);
            AccountInfoPanel.Controls.Add(CreationDateTextBox);
            AccountInfoPanel.Controls.Add(label9);
            AccountInfoPanel.Controls.Add(CreationIPTextBox);
            AccountInfoPanel.Controls.Add(label10);
            AccountInfoPanel.Controls.Add(EMailTextBox);
            AccountInfoPanel.Controls.Add(label8);
            AccountInfoPanel.Controls.Add(AnswerTextBox);
            AccountInfoPanel.Controls.Add(label7);
            AccountInfoPanel.Controls.Add(QuestionTextBox);
            AccountInfoPanel.Controls.Add(label6);
            AccountInfoPanel.Controls.Add(BirthDateTextBox);
            AccountInfoPanel.Controls.Add(label5);
            AccountInfoPanel.Controls.Add(UserNameTextBox);
            AccountInfoPanel.Controls.Add(label4);
            AccountInfoPanel.Controls.Add(label3);
            AccountInfoPanel.Controls.Add(AccountIDTextBox);
            AccountInfoPanel.Controls.Add(label2);
            AccountInfoPanel.Name = "AccountInfoPanel";
            // 
            // Delaccbtn
            // 
            resources.ApplyResources(Delaccbtn, "Delaccbtn");
            Delaccbtn.Name = "Delaccbtn";
            Delaccbtn.UseVisualStyleBackColor = true;
            Delaccbtn.Click += Delaccbtn_Click;
            // 
            // CharactersListView
            // 
            CharactersListView.Columns.AddRange(new ColumnHeader[] { characterName, characterClass, characterLevel, characterPKPoints, characterGuild, characterStatus });
            CharactersListView.GridLines = true;
            resources.ApplyResources(CharactersListView, "CharactersListView");
            CharactersListView.Name = "CharactersListView";
            CharactersListView.Scrollable = false;
            CharactersListView.UseCompatibleStateImageBehavior = false;
            CharactersListView.View = View.Details;
            // 
            // characterName
            // 
            resources.ApplyResources(characterName, "characterName");
            // 
            // characterClass
            // 
            resources.ApplyResources(characterClass, "characterClass");
            // 
            // characterLevel
            // 
            resources.ApplyResources(characterLevel, "characterLevel");
            // 
            // characterPKPoints
            // 
            resources.ApplyResources(characterPKPoints, "characterPKPoints");
            // 
            // characterGuild
            // 
            resources.ApplyResources(characterGuild, "characterGuild");
            // 
            // characterStatus
            // 
            resources.ApplyResources(characterStatus, "characterStatus");
            // 
            // LastIPSearch
            // 
            resources.ApplyResources(LastIPSearch, "LastIPSearch");
            LastIPSearch.Name = "LastIPSearch";
            LastIPSearch.UseVisualStyleBackColor = true;
            LastIPSearch.Click += LastIPSearch_Click;
            // 
            // CreationIPSearch
            // 
            resources.ApplyResources(CreationIPSearch, "CreationIPSearch");
            CreationIPSearch.Name = "CreationIPSearch";
            CreationIPSearch.UseVisualStyleBackColor = true;
            CreationIPSearch.Click += CreationIPSearch_Click;
            // 
            // PasswordChangeCheckBox
            // 
            resources.ApplyResources(PasswordChangeCheckBox, "PasswordChangeCheckBox");
            PasswordChangeCheckBox.Name = "PasswordChangeCheckBox";
            PasswordChangeCheckBox.UseVisualStyleBackColor = true;
            PasswordChangeCheckBox.CheckedChanged += PasswordChangeCheckBox_CheckedChanged;
            // 
            // setPasswordButton
            // 
            resources.ApplyResources(setPasswordButton, "setPasswordButton");
            setPasswordButton.Name = "setPasswordButton";
            setPasswordButton.UseVisualStyleBackColor = true;
            setPasswordButton.Click += button1_Click;
            // 
            // AdminCheckBox
            // 
            resources.ApplyResources(AdminCheckBox, "AdminCheckBox");
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.UseVisualStyleBackColor = true;
            AdminCheckBox.CheckedChanged += AdminCheckBox_CheckedChanged;
            // 
            // PermBanButton
            // 
            resources.ApplyResources(PermBanButton, "PermBanButton");
            PermBanButton.Name = "PermBanButton";
            PermBanButton.UseVisualStyleBackColor = true;
            PermBanButton.Click += PermBanButton_Click;
            // 
            // WeekBanButton
            // 
            resources.ApplyResources(WeekBanButton, "WeekBanButton");
            WeekBanButton.Name = "WeekBanButton";
            WeekBanButton.UseVisualStyleBackColor = true;
            WeekBanButton.Click += WeekBanButton_Click;
            // 
            // DayBanButton
            // 
            resources.ApplyResources(DayBanButton, "DayBanButton");
            DayBanButton.Name = "DayBanButton";
            DayBanButton.UseVisualStyleBackColor = true;
            DayBanButton.Click += DayBanButton_Click;
            // 
            // BannedCheckBox
            // 
            resources.ApplyResources(BannedCheckBox, "BannedCheckBox");
            BannedCheckBox.Name = "BannedCheckBox";
            BannedCheckBox.UseVisualStyleBackColor = true;
            BannedCheckBox.CheckedChanged += BannedCheckBox_CheckedChanged;
            // 
            // ExpiryDateTextBox
            // 
            resources.ApplyResources(ExpiryDateTextBox, "ExpiryDateTextBox");
            ExpiryDateTextBox.Name = "ExpiryDateTextBox";
            ExpiryDateTextBox.TextChanged += ExpiryDateTextBox_TextChanged;
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // BanReasonTextBox
            // 
            resources.ApplyResources(BanReasonTextBox, "BanReasonTextBox");
            BanReasonTextBox.Name = "BanReasonTextBox";
            BanReasonTextBox.TextChanged += BanReasonTextBox_TextChanged;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // LastDateTextBox
            // 
            resources.ApplyResources(LastDateTextBox, "LastDateTextBox");
            LastDateTextBox.Name = "LastDateTextBox";
            LastDateTextBox.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // LastIPTextBox
            // 
            resources.ApplyResources(LastIPTextBox, "LastIPTextBox");
            LastIPTextBox.Name = "LastIPTextBox";
            LastIPTextBox.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // CreationDateTextBox
            // 
            resources.ApplyResources(CreationDateTextBox, "CreationDateTextBox");
            CreationDateTextBox.Name = "CreationDateTextBox";
            CreationDateTextBox.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // CreationIPTextBox
            // 
            resources.ApplyResources(CreationIPTextBox, "CreationIPTextBox");
            CreationIPTextBox.Name = "CreationIPTextBox";
            CreationIPTextBox.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // EMailTextBox
            // 
            resources.ApplyResources(EMailTextBox, "EMailTextBox");
            EMailTextBox.Name = "EMailTextBox";
            EMailTextBox.TextChanged += EMailTextBox_TextChanged;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // AnswerTextBox
            // 
            resources.ApplyResources(AnswerTextBox, "AnswerTextBox");
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.TextChanged += AnswerTextBox_TextChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // QuestionTextBox
            // 
            resources.ApplyResources(QuestionTextBox, "QuestionTextBox");
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.TextChanged += QuestionTextBox_TextChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // BirthDateTextBox
            // 
            resources.ApplyResources(BirthDateTextBox, "BirthDateTextBox");
            BirthDateTextBox.Name = "BirthDateTextBox";
            BirthDateTextBox.TextChanged += BirthDateTextBox_TextChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // UserNameTextBox
            // 
            resources.ApplyResources(UserNameTextBox, "UserNameTextBox");
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.TextChanged += UserNameTextBox_TextChanged;
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
            // AccountIDTextBox
            // 
            resources.ApplyResources(AccountIDTextBox, "AccountIDTextBox");
            AccountIDTextBox.Name = "AccountIDTextBox";
            AccountIDTextBox.TextChanged += AccountIDTextBox_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // FilterPlayerTextBox
            // 
            resources.ApplyResources(FilterPlayerTextBox, "FilterPlayerTextBox");
            FilterPlayerTextBox.Name = "FilterPlayerTextBox";
            // 
            // AccountInfoListView
            // 
            AccountInfoListView.AllowColumnReorder = true;
            resources.ApplyResources(AccountInfoListView, "AccountInfoListView");
            AccountInfoListView.Columns.AddRange(new ColumnHeader[] { indexHeader, accountIDHeader, userNameHeader, adminHeader, bannedHeader, banReasonHeader, expiryDateHeader, Gold, GameGold });
            AccountInfoListView.FullRowSelect = true;
            AccountInfoListView.GridLines = true;
            AccountInfoListView.Name = "AccountInfoListView";
            AccountInfoListView.Sorting = SortOrder.Ascending;
            AccountInfoListView.UseCompatibleStateImageBehavior = false;
            AccountInfoListView.View = View.Details;
            AccountInfoListView.SelectedIndexChanged += AccountInfoListView_SelectedIndexChanged;
            // 
            // indexHeader
            // 
            resources.ApplyResources(indexHeader, "indexHeader");
            // 
            // accountIDHeader
            // 
            resources.ApplyResources(accountIDHeader, "accountIDHeader");
            // 
            // userNameHeader
            // 
            resources.ApplyResources(userNameHeader, "userNameHeader");
            // 
            // adminHeader
            // 
            resources.ApplyResources(adminHeader, "adminHeader");
            // 
            // bannedHeader
            // 
            resources.ApplyResources(bannedHeader, "bannedHeader");
            // 
            // banReasonHeader
            // 
            resources.ApplyResources(banReasonHeader, "banReasonHeader");
            // 
            // expiryDateHeader
            // 
            resources.ApplyResources(expiryDateHeader, "expiryDateHeader");
            // 
            // Gold
            // 
            resources.ApplyResources(Gold, "Gold");
            // 
            // GameGold
            // 
            resources.ApplyResources(GameGold, "GameGold");
            // 
            // MatchFilterCheckBox
            // 
            resources.ApplyResources(MatchFilterCheckBox, "MatchFilterCheckBox");
            MatchFilterCheckBox.Name = "MatchFilterCheckBox";
            MatchFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // WipeCharButton
            // 
            resources.ApplyResources(WipeCharButton, "WipeCharButton");
            WipeCharButton.Name = "WipeCharButton";
            WipeCharButton.UseVisualStyleBackColor = true;
            WipeCharButton.Click += WipeCharButton_Click;
            // 
            // ServerGoldTextBox
            // 
            resources.ApplyResources(ServerGoldTextBox, "ServerGoldTextBox");
            ServerGoldTextBox.Name = "ServerGoldTextBox";
            ServerGoldTextBox.ReadOnly = true;
            // 
            // TotalServerGold
            // 
            resources.ApplyResources(TotalServerGold, "TotalServerGold");
            TotalServerGold.Name = "TotalServerGold";
            // 
            // ServerCreditTextBox
            // 
            resources.ApplyResources(ServerCreditTextBox, "ServerCreditTextBox");
            ServerCreditTextBox.Name = "ServerCreditTextBox";
            ServerCreditTextBox.ReadOnly = true;
            // 
            // TotalServerCredit
            // 
            resources.ApplyResources(TotalServerCredit, "TotalServerCredit");
            TotalServerCredit.Name = "TotalServerCredit";
            // 
            // FilterIPTextBox
            // 
            resources.ApplyResources(FilterIPTextBox, "FilterIPTextBox");
            FilterIPTextBox.Name = "FilterIPTextBox";
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            // 
            // AccountInfoForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilterIPTextBox);
            Controls.Add(label16);
            Controls.Add(ServerCreditTextBox);
            Controls.Add(TotalServerCredit);
            Controls.Add(ServerGoldTextBox);
            Controls.Add(TotalServerGold);
            Controls.Add(WipeCharButton);
            Controls.Add(MatchFilterCheckBox);
            Controls.Add(FilterPlayerTextBox);
            Controls.Add(label15);
            Controls.Add(AccountInfoPanel);
            Controls.Add(RefreshButton);
            Controls.Add(FilterTextBox);
            Controls.Add(label1);
            Controls.Add(CreateButton);
            Controls.Add(AccountInfoListView);
            Name = "AccountInfoForm";
            FormClosed += AccountInfoForm_FormClosed;
            AccountInfoPanel.ResumeLayout(false);
            AccountInfoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private CustomFormControl.ListViewNF AccountInfoListView;
        private System.Windows.Forms.ColumnHeader indexHeader;
        private System.Windows.Forms.ColumnHeader accountIDHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.ColumnHeader userNameHeader;
        private System.Windows.Forms.ColumnHeader bannedHeader;
        private System.Windows.Forms.ColumnHeader banReasonHeader;
        private System.Windows.Forms.ColumnHeader expiryDateHeader;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel AccountInfoPanel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BirthDateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EMailTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastDateTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LastIPTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CreationDateTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CreationIPTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ExpiryDateTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox BanReasonTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox BannedCheckBox;
        private System.Windows.Forms.Button PermBanButton;
        private System.Windows.Forms.Button WeekBanButton;
        private System.Windows.Forms.Button DayBanButton;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.ColumnHeader adminHeader;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox FilterPlayerTextBox;
        private System.Windows.Forms.CheckBox MatchFilterCheckBox;
        private System.Windows.Forms.Button WipeCharButton;
        private System.Windows.Forms.Button setPasswordButton;
        private System.Windows.Forms.CheckBox PasswordChangeCheckBox;
        private Button LastIPSearch;
        private Button CreationIPSearch;
        private ListView CharactersListView;
        private ColumnHeader characterName;
        private ColumnHeader characterClass;
        private ColumnHeader characterLevel;
        private ColumnHeader characterPKPoints;
        private ColumnHeader characterGuild;
        private ColumnHeader Gold;
        private ColumnHeader GameGold;
        private ColumnHeader characterStatus;
        private TextBox ServerGoldTextBox;
        private Label TotalServerGold;
        private TextBox ServerCreditTextBox;
        private Label TotalServerCredit;
        private Button Delaccbtn;
        private TextBox FilterIPTextBox;
        private Label label16;
    }
}