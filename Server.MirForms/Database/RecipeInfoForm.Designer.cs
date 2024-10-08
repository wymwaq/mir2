namespace Server.Database
{
    partial class RecipeInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeInfoForm));
            RecipeList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RecipeGroupBox = new GroupBox();
            GoldTextBox = new TextBox();
            ChanceTextBox = new TextBox();
            CraftAmountTextBox = new TextBox();
            ItemTextBox = new TextBox();
            label6 = new Label();
            ToolsGroupBox = new GroupBox();
            ToolTextBox = new TextBox();
            IngredientsGroupBox = new GroupBox();
            IngredientName4TextBox = new TextBox();
            IngredientName3TextBox = new TextBox();
            IngredientName2TextBox = new TextBox();
            IngredientName1TextBox = new TextBox();
            label7 = new Label();
            label5 = new Label();
            IngredientAmount4TextBox = new TextBox();
            IngredientAmount3TextBox = new TextBox();
            IngredientAmount2TextBox = new TextBox();
            IngredientAmount1TextBox = new TextBox();
            NewRecipeButton = new Button();
            RecipeGroupBox.SuspendLayout();
            ToolsGroupBox.SuspendLayout();
            IngredientsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RecipeList
            // 
            RecipeList.FormattingEnabled = true;
            resources.ApplyResources(RecipeList, "RecipeList");
            RecipeList.Name = "RecipeList";
            RecipeList.SelectedIndexChanged += RecipeList_SelectedIndexChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // RecipeGroupBox
            // 
            RecipeGroupBox.Controls.Add(GoldTextBox);
            RecipeGroupBox.Controls.Add(ChanceTextBox);
            RecipeGroupBox.Controls.Add(CraftAmountTextBox);
            RecipeGroupBox.Controls.Add(ItemTextBox);
            RecipeGroupBox.Controls.Add(label6);
            RecipeGroupBox.Controls.Add(label1);
            RecipeGroupBox.Controls.Add(label2);
            RecipeGroupBox.Controls.Add(label3);
            resources.ApplyResources(RecipeGroupBox, "RecipeGroupBox");
            RecipeGroupBox.Name = "RecipeGroupBox";
            RecipeGroupBox.TabStop = false;
            // 
            // GoldTextBox
            // 
            resources.ApplyResources(GoldTextBox, "GoldTextBox");
            GoldTextBox.Name = "GoldTextBox";
            // 
            // ChanceTextBox
            // 
            resources.ApplyResources(ChanceTextBox, "ChanceTextBox");
            ChanceTextBox.Name = "ChanceTextBox";
            // 
            // CraftAmountTextBox
            // 
            resources.ApplyResources(CraftAmountTextBox, "CraftAmountTextBox");
            CraftAmountTextBox.Name = "CraftAmountTextBox";
            // 
            // ItemTextBox
            // 
            resources.ApplyResources(ItemTextBox, "ItemTextBox");
            ItemTextBox.Name = "ItemTextBox";
            ItemTextBox.TextChanged += ItemTextBox_TextChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // ToolsGroupBox
            // 
            ToolsGroupBox.Controls.Add(ToolTextBox);
            ToolsGroupBox.Controls.Add(label4);
            resources.ApplyResources(ToolsGroupBox, "ToolsGroupBox");
            ToolsGroupBox.Name = "ToolsGroupBox";
            ToolsGroupBox.TabStop = false;
            // 
            // ToolTextBox
            // 
            resources.ApplyResources(ToolTextBox, "ToolTextBox");
            ToolTextBox.Name = "ToolTextBox";
            // 
            // IngredientsGroupBox
            // 
            IngredientsGroupBox.Controls.Add(IngredientName4TextBox);
            IngredientsGroupBox.Controls.Add(IngredientName3TextBox);
            IngredientsGroupBox.Controls.Add(IngredientName2TextBox);
            IngredientsGroupBox.Controls.Add(IngredientName1TextBox);
            IngredientsGroupBox.Controls.Add(label7);
            IngredientsGroupBox.Controls.Add(label5);
            IngredientsGroupBox.Controls.Add(IngredientAmount4TextBox);
            IngredientsGroupBox.Controls.Add(IngredientAmount3TextBox);
            IngredientsGroupBox.Controls.Add(IngredientAmount2TextBox);
            IngredientsGroupBox.Controls.Add(IngredientAmount1TextBox);
            resources.ApplyResources(IngredientsGroupBox, "IngredientsGroupBox");
            IngredientsGroupBox.Name = "IngredientsGroupBox";
            IngredientsGroupBox.TabStop = false;
            // 
            // IngredientName4TextBox
            // 
            resources.ApplyResources(IngredientName4TextBox, "IngredientName4TextBox");
            IngredientName4TextBox.Name = "IngredientName4TextBox";
            // 
            // IngredientName3TextBox
            // 
            resources.ApplyResources(IngredientName3TextBox, "IngredientName3TextBox");
            IngredientName3TextBox.Name = "IngredientName3TextBox";
            // 
            // IngredientName2TextBox
            // 
            resources.ApplyResources(IngredientName2TextBox, "IngredientName2TextBox");
            IngredientName2TextBox.Name = "IngredientName2TextBox";
            // 
            // IngredientName1TextBox
            // 
            resources.ApplyResources(IngredientName1TextBox, "IngredientName1TextBox");
            IngredientName1TextBox.Name = "IngredientName1TextBox";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // IngredientAmount4TextBox
            // 
            resources.ApplyResources(IngredientAmount4TextBox, "IngredientAmount4TextBox");
            IngredientAmount4TextBox.Name = "IngredientAmount4TextBox";
            // 
            // IngredientAmount3TextBox
            // 
            resources.ApplyResources(IngredientAmount3TextBox, "IngredientAmount3TextBox");
            IngredientAmount3TextBox.Name = "IngredientAmount3TextBox";
            // 
            // IngredientAmount2TextBox
            // 
            resources.ApplyResources(IngredientAmount2TextBox, "IngredientAmount2TextBox");
            IngredientAmount2TextBox.Name = "IngredientAmount2TextBox";
            // 
            // IngredientAmount1TextBox
            // 
            resources.ApplyResources(IngredientAmount1TextBox, "IngredientAmount1TextBox");
            IngredientAmount1TextBox.Name = "IngredientAmount1TextBox";
            // 
            // NewRecipeButton
            // 
            resources.ApplyResources(NewRecipeButton, "NewRecipeButton");
            NewRecipeButton.Name = "NewRecipeButton";
            NewRecipeButton.UseVisualStyleBackColor = true;
            NewRecipeButton.Click += NewRecipeButton_Click;
            // 
            // RecipeInfoForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NewRecipeButton);
            Controls.Add(IngredientsGroupBox);
            Controls.Add(ToolsGroupBox);
            Controls.Add(RecipeGroupBox);
            Controls.Add(RecipeList);
            Name = "RecipeInfoForm";
            FormClosing += RecipeInfoForm_FormClosing;
            RecipeGroupBox.ResumeLayout(false);
            RecipeGroupBox.PerformLayout();
            ToolsGroupBox.ResumeLayout(false);
            ToolsGroupBox.PerformLayout();
            IngredientsGroupBox.ResumeLayout(false);
            IngredientsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox RecipeList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox RecipeGroupBox;
        private GroupBox ToolsGroupBox;
        private GroupBox IngredientsGroupBox;
        private Label label5;
        private TextBox IngredientAmount4TextBox;
        private TextBox IngredientAmount3TextBox;
        private TextBox IngredientAmount2TextBox;
        private TextBox IngredientAmount1TextBox;
        private Label label6;
        private TextBox GoldTextBox;
        private TextBox ChanceTextBox;
        private TextBox CraftAmountTextBox;
        private TextBox ItemTextBox;
        private Label label7;
        private TextBox ToolTextBox;
        private TextBox IngredientName4TextBox;
        private TextBox IngredientName3TextBox;
        private TextBox IngredientName2TextBox;
        private TextBox IngredientName1TextBox;
        private Button NewRecipeButton;
    }
}