namespace Server.Account
{
    partial class CharacterInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterInfoForm));
            CharactersList = new ListView();
            IndexHeader = new ColumnHeader();
            NameHeader = new ColumnHeader();
            AccountNameHeader = new ColumnHeader();
            CharacterCountLabel = new Label();
            RefreshButton = new Button();
            FindPlayerLabel = new Label();
            FilterPlayerTextBox = new TextBox();
            FilterItemTextBox = new TextBox();
            label1 = new Label();
            MatchFilterCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // CharactersList
            // 
            CharactersList.Columns.AddRange(new ColumnHeader[] { IndexHeader, NameHeader, AccountNameHeader });
            CharactersList.FullRowSelect = true;
            CharactersList.GridLines = true;
            resources.ApplyResources(CharactersList, "CharactersList");
            CharactersList.Name = "CharactersList";
            CharactersList.UseCompatibleStateImageBehavior = false;
            CharactersList.View = View.Details;
            // 
            // IndexHeader
            // 
            resources.ApplyResources(IndexHeader, "IndexHeader");
            // 
            // NameHeader
            // 
            resources.ApplyResources(NameHeader, "NameHeader");
            // 
            // AccountNameHeader
            // 
            resources.ApplyResources(AccountNameHeader, "AccountNameHeader");
            // 
            // CharacterCountLabel
            // 
            resources.ApplyResources(CharacterCountLabel, "CharacterCountLabel");
            CharacterCountLabel.Name = "CharacterCountLabel";
            // 
            // RefreshButton
            // 
            resources.ApplyResources(RefreshButton, "RefreshButton");
            RefreshButton.Name = "RefreshButton";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // FindPlayerLabel
            // 
            resources.ApplyResources(FindPlayerLabel, "FindPlayerLabel");
            FindPlayerLabel.Name = "FindPlayerLabel";
            // 
            // FilterPlayerTextBox
            // 
            resources.ApplyResources(FilterPlayerTextBox, "FilterPlayerTextBox");
            FilterPlayerTextBox.Name = "FilterPlayerTextBox";
            // 
            // FilterItemTextBox
            // 
            resources.ApplyResources(FilterItemTextBox, "FilterItemTextBox");
            FilterItemTextBox.Name = "FilterItemTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // MatchFilterCheckBox
            // 
            resources.ApplyResources(MatchFilterCheckBox, "MatchFilterCheckBox");
            MatchFilterCheckBox.Name = "MatchFilterCheckBox";
            MatchFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // CharacterInfoForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MatchFilterCheckBox);
            Controls.Add(FilterItemTextBox);
            Controls.Add(label1);
            Controls.Add(FilterPlayerTextBox);
            Controls.Add(FindPlayerLabel);
            Controls.Add(RefreshButton);
            Controls.Add(CharacterCountLabel);
            Controls.Add(CharactersList);
            Name = "CharacterInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView CharactersList;
        private ColumnHeader IndexHeader;
        private ColumnHeader NameHeader;
        private Label CharacterCountLabel;
        private Button RefreshButton;
        private Label FindPlayerLabel;
        private TextBox FilterPlayerTextBox;
        private TextBox FilterItemTextBox;
        private Label label1;
        private CheckBox MatchFilterCheckBox;
        private ColumnHeader AccountNameHeader;
    }
}