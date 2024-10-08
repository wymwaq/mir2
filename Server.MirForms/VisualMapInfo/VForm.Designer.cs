namespace Server.MirForms.VisualMapInfo
{
    partial class VForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VForm));
            Tool = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            EndFocus = new ToolStripButton();
            FocusBreak = new ToolStripSeparator();
            SelectButton = new ToolStripButton();
            AddButton = new ToolStripButton();
            MoveButton = new ToolStripButton();
            ResizeButton = new ToolStripButton();
            splitter1 = new Splitter();
            tabPage2 = new TabPage();
            RespawnPanel = new Panel();
            toolStrip3 = new ToolStrip();
            RespawnsRemoveSelected = new ToolStripButton();
            ResapwnsHideRegion = new ToolStripButton();
            ResapwnsShowRegion = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            ResapwnsFocusRegion = new ToolStripButton();
            RespawnsFilter = new ComboBox();
            RespawnTools = new ToolStrip();
            RespawnsSelectAll = new ToolStripButton();
            RespawnsSelectNone = new ToolStripButton();
            RespawnsInvertSelection = new ToolStripButton();
            tabPage4 = new TabPage();
            MiningPanel = new Panel();
            MiningFilter = new ComboBox();
            toolStrip2 = new ToolStrip();
            MiningSelectAll = new ToolStripButton();
            MiningSelectNone = new ToolStripButton();
            MiningInvertSelection = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            MiningRemoveSelected = new ToolStripButton();
            MiningHideRegion = new ToolStripButton();
            MiningShowRegion = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            MiningFocusRegion = new ToolStripButton();
            RegionTabs = new TabControl();
            statusStrip1 = new StatusStrip();
            MapDetailsLabel = new ToolStripStatusLabel();
            mapContainer1 = new MirForms.Control.MapContainer();
            MapImage = new PictureBox();
            Tool.SuspendLayout();
            tabPage2.SuspendLayout();
            toolStrip3.SuspendLayout();
            RespawnTools.SuspendLayout();
            tabPage4.SuspendLayout();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            RegionTabs.SuspendLayout();
            statusStrip1.SuspendLayout();
            mapContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MapImage).BeginInit();
            SuspendLayout();
            // 
            // Tool
            // 
            resources.ApplyResources(Tool, "Tool");
            Tool.GripStyle = ToolStripGripStyle.Hidden;
            Tool.ImageScalingSize = new Size(28, 28);
            Tool.Items.AddRange(new ToolStripItem[] { toolStripLabel1, EndFocus, FocusBreak, SelectButton, AddButton, MoveButton, ResizeButton });
            Tool.Name = "Tool";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(toolStripLabel1, "toolStripLabel1");
            // 
            // EndFocus
            // 
            resources.ApplyResources(EndFocus, "EndFocus");
            EndFocus.DisplayStyle = ToolStripItemDisplayStyle.Image;
            EndFocus.Name = "EndFocus";
            EndFocus.Click += EndFocus_Click;
            // 
            // FocusBreak
            // 
            FocusBreak.Name = "FocusBreak";
            resources.ApplyResources(FocusBreak, "FocusBreak");
            // 
            // SelectButton
            // 
            resources.ApplyResources(SelectButton, "SelectButton");
            SelectButton.Checked = true;
            SelectButton.CheckOnClick = true;
            SelectButton.CheckState = CheckState.Checked;
            SelectButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SelectButton.Name = "SelectButton";
            SelectButton.Click += ToolSelectedChanged;
            // 
            // AddButton
            // 
            resources.ApplyResources(AddButton, "AddButton");
            AddButton.CheckOnClick = true;
            AddButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AddButton.Name = "AddButton";
            AddButton.Click += ToolSelectedChanged;
            // 
            // MoveButton
            // 
            resources.ApplyResources(MoveButton, "MoveButton");
            MoveButton.CheckOnClick = true;
            MoveButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MoveButton.Name = "MoveButton";
            MoveButton.Click += ToolSelectedChanged;
            // 
            // ResizeButton
            // 
            resources.ApplyResources(ResizeButton, "ResizeButton");
            ResizeButton.CheckOnClick = true;
            ResizeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ResizeButton.Name = "ResizeButton";
            ResizeButton.Click += ToolSelectedChanged;
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(splitter1, "splitter1");
            splitter1.Name = "splitter1";
            splitter1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(RespawnPanel);
            tabPage2.Controls.Add(toolStrip3);
            tabPage2.Controls.Add(RespawnsFilter);
            tabPage2.Controls.Add(RespawnTools);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // RespawnPanel
            // 
            resources.ApplyResources(RespawnPanel, "RespawnPanel");
            RespawnPanel.Name = "RespawnPanel";
            // 
            // toolStrip3
            // 
            resources.ApplyResources(toolStrip3, "toolStrip3");
            toolStrip3.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip3.Items.AddRange(new ToolStripItem[] { RespawnsRemoveSelected, ResapwnsHideRegion, ResapwnsShowRegion, toolStripSeparator2, ResapwnsFocusRegion });
            toolStrip3.Name = "toolStrip3";
            toolStrip3.RenderMode = ToolStripRenderMode.Professional;
            // 
            // RespawnsRemoveSelected
            // 
            RespawnsRemoveSelected.Alignment = ToolStripItemAlignment.Right;
            RespawnsRemoveSelected.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(RespawnsRemoveSelected, "RespawnsRemoveSelected");
            RespawnsRemoveSelected.Name = "RespawnsRemoveSelected";
            RespawnsRemoveSelected.Click += RespawnsRemoveSelected_Click;
            // 
            // ResapwnsHideRegion
            // 
            ResapwnsHideRegion.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(ResapwnsHideRegion, "ResapwnsHideRegion");
            ResapwnsHideRegion.Name = "ResapwnsHideRegion";
            ResapwnsHideRegion.Click += ResapwnsHideRegion_Click;
            // 
            // ResapwnsShowRegion
            // 
            ResapwnsShowRegion.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(ResapwnsShowRegion, "ResapwnsShowRegion");
            ResapwnsShowRegion.Name = "ResapwnsShowRegion";
            ResapwnsShowRegion.Click += ResapwnsShowRegion_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // ResapwnsFocusRegion
            // 
            ResapwnsFocusRegion.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(ResapwnsFocusRegion, "ResapwnsFocusRegion");
            ResapwnsFocusRegion.Name = "ResapwnsFocusRegion";
            ResapwnsFocusRegion.Click += ResapwnsFocusRegion_Click;
            // 
            // RespawnsFilter
            // 
            resources.ApplyResources(RespawnsFilter, "RespawnsFilter");
            RespawnsFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            RespawnsFilter.FormattingEnabled = true;
            RespawnsFilter.Name = "RespawnsFilter";
            RespawnsFilter.SelectedIndexChanged += RespawnsFilter_SelectedIndexChanged;
            // 
            // RespawnTools
            // 
            RespawnTools.GripStyle = ToolStripGripStyle.Hidden;
            RespawnTools.Items.AddRange(new ToolStripItem[] { RespawnsSelectAll, RespawnsSelectNone, RespawnsInvertSelection });
            resources.ApplyResources(RespawnTools, "RespawnTools");
            RespawnTools.Name = "RespawnTools";
            RespawnTools.RenderMode = ToolStripRenderMode.Professional;
            // 
            // RespawnsSelectAll
            // 
            RespawnsSelectAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(RespawnsSelectAll, "RespawnsSelectAll");
            RespawnsSelectAll.Name = "RespawnsSelectAll";
            RespawnsSelectAll.Click += RespawnsSelectAll_Click;
            // 
            // RespawnsSelectNone
            // 
            RespawnsSelectNone.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(RespawnsSelectNone, "RespawnsSelectNone");
            RespawnsSelectNone.Name = "RespawnsSelectNone";
            RespawnsSelectNone.Click += RespawnsSelectNone_Click;
            // 
            // RespawnsInvertSelection
            // 
            RespawnsInvertSelection.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(RespawnsInvertSelection, "RespawnsInvertSelection");
            RespawnsInvertSelection.Name = "RespawnsInvertSelection";
            RespawnsInvertSelection.Click += RespawnsInvertSelection_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(MiningPanel);
            tabPage4.Controls.Add(MiningFilter);
            tabPage4.Controls.Add(toolStrip2);
            tabPage4.Controls.Add(toolStrip1);
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // MiningPanel
            // 
            resources.ApplyResources(MiningPanel, "MiningPanel");
            MiningPanel.Name = "MiningPanel";
            // 
            // MiningFilter
            // 
            resources.ApplyResources(MiningFilter, "MiningFilter");
            MiningFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            MiningFilter.FormattingEnabled = true;
            MiningFilter.Name = "MiningFilter";
            MiningFilter.SelectedIndexChanged += MiningFilter_SelectedIndexChanged;
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { MiningSelectAll, MiningSelectNone, MiningInvertSelection });
            resources.ApplyResources(toolStrip2, "toolStrip2");
            toolStrip2.Name = "toolStrip2";
            // 
            // MiningSelectAll
            // 
            MiningSelectAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(MiningSelectAll, "MiningSelectAll");
            MiningSelectAll.Name = "MiningSelectAll";
            MiningSelectAll.Click += MiningSelectAll_Click;
            // 
            // MiningSelectNone
            // 
            MiningSelectNone.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(MiningSelectNone, "MiningSelectNone");
            MiningSelectNone.Name = "MiningSelectNone";
            MiningSelectNone.Click += MiningSelectNone_Click;
            // 
            // MiningInvertSelection
            // 
            MiningInvertSelection.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(MiningInvertSelection, "MiningInvertSelection");
            MiningInvertSelection.Name = "MiningInvertSelection";
            MiningInvertSelection.Click += MiningInvertSelection_Click;
            // 
            // toolStrip1
            // 
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { MiningRemoveSelected, MiningHideRegion, MiningShowRegion, toolStripSeparator1, MiningFocusRegion });
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            // 
            // MiningRemoveSelected
            // 
            MiningRemoveSelected.Alignment = ToolStripItemAlignment.Right;
            MiningRemoveSelected.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(MiningRemoveSelected, "MiningRemoveSelected");
            MiningRemoveSelected.Name = "MiningRemoveSelected";
            MiningRemoveSelected.Click += MiningRemoveSelected_Click;
            // 
            // MiningHideRegion
            // 
            MiningHideRegion.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(MiningHideRegion, "MiningHideRegion");
            MiningHideRegion.Name = "MiningHideRegion";
            MiningHideRegion.Click += MiningHideRegion_Click;
            // 
            // MiningShowRegion
            // 
            MiningShowRegion.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(MiningShowRegion, "MiningShowRegion");
            MiningShowRegion.Name = "MiningShowRegion";
            MiningShowRegion.Click += MiningShowRegion_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // MiningFocusRegion
            // 
            MiningFocusRegion.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(MiningFocusRegion, "MiningFocusRegion");
            MiningFocusRegion.Name = "MiningFocusRegion";
            MiningFocusRegion.Click += MiningFocusRegion_Click;
            // 
            // RegionTabs
            // 
            RegionTabs.Controls.Add(tabPage4);
            RegionTabs.Controls.Add(tabPage2);
            resources.ApplyResources(RegionTabs, "RegionTabs");
            RegionTabs.Multiline = true;
            RegionTabs.Name = "RegionTabs";
            RegionTabs.SelectedIndex = 0;
            RegionTabs.SizeMode = TabSizeMode.FillToRight;
            RegionTabs.SelectedIndexChanged += RegionTabs_SelectedIndexChanged;
            RegionTabs.Selecting += RegionTabs_Selecting;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { MapDetailsLabel });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // MapDetailsLabel
            // 
            MapDetailsLabel.BorderSides = ToolStripStatusLabelBorderSides.Right;
            MapDetailsLabel.BorderStyle = Border3DStyle.Sunken;
            MapDetailsLabel.Name = "MapDetailsLabel";
            resources.ApplyResources(MapDetailsLabel, "MapDetailsLabel");
            // 
            // mapContainer1
            // 
            resources.ApplyResources(mapContainer1, "mapContainer1");
            mapContainer1.Controls.Add(MapImage);
            mapContainer1.Name = "mapContainer1";
            // 
            // MapImage
            // 
            resources.ApplyResources(MapImage, "MapImage");
            MapImage.Name = "MapImage";
            MapImage.TabStop = false;
            MapImage.Click += MapImage_Click;
            MapImage.MouseDown += MapImage_MouseDown;
            // 
            // VForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mapContainer1);
            Controls.Add(splitter1);
            Controls.Add(RegionTabs);
            Controls.Add(Tool);
            Controls.Add(statusStrip1);
            DoubleBuffered = true;
            Name = "VForm";
            FormClosing += VForm_FormClosing;
            Load += VForm_Load;
            Tool.ResumeLayout(false);
            Tool.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            RespawnTools.ResumeLayout(false);
            RespawnTools.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            RegionTabs.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mapContainer1.ResumeLayout(false);
            mapContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MapImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripButton SelectButton;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton MoveButton;
        private System.Windows.Forms.ToolStripButton ResizeButton;
        private Server.MirForms.Control.MapContainer mapContainer1;
        private System.Windows.Forms.PictureBox MapImage;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel RespawnPanel;
        private System.Windows.Forms.ToolStrip RespawnTools;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel MiningPanel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton MiningSelectAll;
        private System.Windows.Forms.ToolStripButton MiningSelectNone;
        private System.Windows.Forms.TabControl RegionTabs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MiningRemoveSelected;
        private System.Windows.Forms.ToolStripButton MiningHideRegion;
        private System.Windows.Forms.ToolStripButton MiningShowRegion;
        private System.Windows.Forms.ToolStripButton MiningFocusRegion;
        private System.Windows.Forms.ToolStripButton MiningInvertSelection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox MiningFilter;
        private System.Windows.Forms.ToolStripButton EndFocus;
        private System.Windows.Forms.ToolStripSeparator FocusBreak;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MapDetailsLabel;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton RespawnsRemoveSelected;
        private System.Windows.Forms.ToolStripButton ResapwnsHideRegion;
        private System.Windows.Forms.ToolStripButton ResapwnsShowRegion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ResapwnsFocusRegion;
        private System.Windows.Forms.ComboBox RespawnsFilter;
        private System.Windows.Forms.ToolStripButton RespawnsInvertSelection;
        private System.Windows.Forms.ToolStripButton RespawnsSelectAll;
        private System.Windows.Forms.ToolStripButton RespawnsSelectNone;
    }
}