namespace Server.Systems
{
    partial class GuildItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuildItemForm));
            GuildItemListView = new ListView();
            indexHeader = new ColumnHeader();
            PlaceHeader = new ColumnHeader();
            nameHeader = new ColumnHeader();
            countHeader = new ColumnHeader();
            DuraHeader = new ColumnHeader();
            MemberListView = new ListView();
            Members = new ColumnHeader();
            Rank = new ColumnHeader();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // GuildItemListView
            // 
            GuildItemListView.Columns.AddRange(new ColumnHeader[] { indexHeader, PlaceHeader, nameHeader, countHeader, DuraHeader });
            GuildItemListView.GridLines = true;
            resources.ApplyResources(GuildItemListView, "GuildItemListView");
            GuildItemListView.Name = "GuildItemListView";
            GuildItemListView.UseCompatibleStateImageBehavior = false;
            GuildItemListView.View = View.Details;
            // 
            // indexHeader
            // 
            resources.ApplyResources(indexHeader, "indexHeader");
            // 
            // PlaceHeader
            // 
            resources.ApplyResources(PlaceHeader, "PlaceHeader");
            // 
            // nameHeader
            // 
            resources.ApplyResources(nameHeader, "nameHeader");
            // 
            // countHeader
            // 
            resources.ApplyResources(countHeader, "countHeader");
            // 
            // DuraHeader
            // 
            resources.ApplyResources(DuraHeader, "DuraHeader");
            // 
            // MemberListView
            // 
            MemberListView.Columns.AddRange(new ColumnHeader[] { Members, Rank });
            MemberListView.GridLines = true;
            resources.ApplyResources(MemberListView, "MemberListView");
            MemberListView.Name = "MemberListView";
            MemberListView.Scrollable = false;
            MemberListView.UseCompatibleStateImageBehavior = false;
            MemberListView.View = View.Details;
            // 
            // Members
            // 
            resources.ApplyResources(Members, "Members");
            // 
            // Rank
            // 
            resources.ApplyResources(Rank, "Rank");
            // 
            // DeleteButton
            // 
            resources.ApplyResources(DeleteButton, "DeleteButton");
            DeleteButton.Name = "DeleteButton";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // GuildItemForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteButton);
            Controls.Add(MemberListView);
            Controls.Add(GuildItemListView);
            Name = "GuildItemForm";
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader indexHeader;
        private ColumnHeader PlaceHeader;
        private ColumnHeader nameHeader;
        private ColumnHeader countHeader;
        private ColumnHeader DuraHeader;
        private ColumnHeader Members;
        private ColumnHeader Rank;
        private Button DeleteButton;
        public ListView GuildItemListView;
        public ListView MemberListView;
    }
}