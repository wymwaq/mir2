using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace Launcher
{
    partial class AMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMain));
            ActionLabel = new Label();
            SpeedLabel = new Label();
            InterfaceTimer = new System.Windows.Forms.Timer(components);
            Movement_panel = new Panel();
            Name_label = new Label();
            pictureBox1 = new PictureBox();
            Close_pb = new PictureBox();
            Config_pb = new PictureBox();
            Version_label = new Label();
            CurrentFile_label = new Label();
            CurrentPercent_label = new Label();
            TotalPercent_label = new Label();
            Credit_label = new Label();
            ProgTotalEnd_pb = new PictureBox();
            ProgEnd_pb = new PictureBox();
            ProgressCurrent_pb = new PictureBox();
            TotalProg_pb = new PictureBox();
            Launch_pb = new PictureBox();
            Main_browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            Movement_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Config_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProgTotalEnd_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProgEnd_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProgressCurrent_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalProg_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Launch_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Main_browser).BeginInit();
            SuspendLayout();
            // 
            // ActionLabel
            // 
            resources.ApplyResources(ActionLabel, "ActionLabel");
            ActionLabel.BackColor = Color.Transparent;
            ActionLabel.ForeColor = Color.Gray;
            ActionLabel.Name = "ActionLabel";
            ActionLabel.Click += ActionLabel_Click;
            // 
            // SpeedLabel
            // 
            resources.ApplyResources(SpeedLabel, "SpeedLabel");
            SpeedLabel.BackColor = Color.Transparent;
            SpeedLabel.ForeColor = Color.Gray;
            SpeedLabel.Name = "SpeedLabel";
            // 
            // InterfaceTimer
            // 
            InterfaceTimer.Enabled = true;
            InterfaceTimer.Interval = 50;
            InterfaceTimer.Tick += InterfaceTimer_Tick;
            // 
            // Movement_panel
            // 
            resources.ApplyResources(Movement_panel, "Movement_panel");
            Movement_panel.BackColor = Color.Transparent;
            Movement_panel.Controls.Add(Name_label);
            Movement_panel.Controls.Add(pictureBox1);
            Movement_panel.Controls.Add(Close_pb);
            Movement_panel.Controls.Add(Config_pb);
            Movement_panel.Name = "Movement_panel";
            Movement_panel.MouseClick += Movement_panel_MouseClick;
            Movement_panel.MouseDown += Movement_panel_MouseClick;
            Movement_panel.MouseMove += Movement_panel_MouseMove;
            Movement_panel.MouseUp += Movement_panel_MouseUp;
            // 
            // Name_label
            // 
            resources.ApplyResources(Name_label, "Name_label");
            Name_label.BackColor = Color.Transparent;
            Name_label.ForeColor = Color.White;
            Name_label.Image = Client.Resources.Images.server_base;
            Name_label.Name = "Name_label";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Client.Resources.Images.server_base;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // Close_pb
            // 
            resources.ApplyResources(Close_pb, "Close_pb");
            Close_pb.BackColor = Color.Transparent;
            Close_pb.Image = Client.Resources.Images.Cross_Base;
            Close_pb.Name = "Close_pb";
            Close_pb.TabStop = false;
            Close_pb.Click += Close_pb_Click;
            Close_pb.MouseDown += Close_pb_MouseDown;
            Close_pb.MouseEnter += Close_pb_MouseEnter;
            Close_pb.MouseLeave += Close_pb_MouseLeave;
            Close_pb.MouseUp += Close_pb_MouseUp;
            // 
            // Config_pb
            // 
            resources.ApplyResources(Config_pb, "Config_pb");
            Config_pb.BackColor = Color.Transparent;
            Config_pb.Image = Client.Resources.Images.Config_Base;
            Config_pb.Name = "Config_pb";
            Config_pb.TabStop = false;
            Config_pb.Click += Config_pb_Click;
            Config_pb.MouseDown += Config_pb_MouseDown;
            Config_pb.MouseEnter += Config_pb_MouseEnter;
            Config_pb.MouseLeave += Config_pb_MouseLeave;
            Config_pb.MouseUp += Config_pb_MouseUp;
            // 
            // Version_label
            // 
            resources.ApplyResources(Version_label, "Version_label");
            Version_label.BackColor = Color.Transparent;
            Version_label.ForeColor = Color.Gray;
            Version_label.Name = "Version_label";
            // 
            // CurrentFile_label
            // 
            resources.ApplyResources(CurrentFile_label, "CurrentFile_label");
            CurrentFile_label.BackColor = Color.Transparent;
            CurrentFile_label.ForeColor = Color.Gray;
            CurrentFile_label.Name = "CurrentFile_label";
            // 
            // CurrentPercent_label
            // 
            resources.ApplyResources(CurrentPercent_label, "CurrentPercent_label");
            CurrentPercent_label.BackColor = Color.Transparent;
            CurrentPercent_label.ForeColor = Color.Gray;
            CurrentPercent_label.Name = "CurrentPercent_label";
            // 
            // TotalPercent_label
            // 
            resources.ApplyResources(TotalPercent_label, "TotalPercent_label");
            TotalPercent_label.BackColor = Color.Transparent;
            TotalPercent_label.ForeColor = Color.Gray;
            TotalPercent_label.Name = "TotalPercent_label";
            // 
            // Credit_label
            // 
            resources.ApplyResources(Credit_label, "Credit_label");
            Credit_label.BackColor = Color.Transparent;
            Credit_label.ForeColor = Color.Gray;
            Credit_label.Name = "Credit_label";
            Credit_label.Click += Credit_label_Click;
            // 
            // ProgTotalEnd_pb
            // 
            resources.ApplyResources(ProgTotalEnd_pb, "ProgTotalEnd_pb");
            ProgTotalEnd_pb.BackColor = Color.Transparent;
            ProgTotalEnd_pb.Image = Client.Resources.Images.NEW_Progress_End__Blue_;
            ProgTotalEnd_pb.Name = "ProgTotalEnd_pb";
            ProgTotalEnd_pb.TabStop = false;
            // 
            // ProgEnd_pb
            // 
            resources.ApplyResources(ProgEnd_pb, "ProgEnd_pb");
            ProgEnd_pb.BackColor = Color.Transparent;
            ProgEnd_pb.Image = Client.Resources.Images.NEW_Progress_End__Green_;
            ProgEnd_pb.Name = "ProgEnd_pb";
            ProgEnd_pb.TabStop = false;
            // 
            // ProgressCurrent_pb
            // 
            resources.ApplyResources(ProgressCurrent_pb, "ProgressCurrent_pb");
            ProgressCurrent_pb.BackColor = Color.Transparent;
            ProgressCurrent_pb.Image = Client.Resources.Images.Green_Progress;
            ProgressCurrent_pb.Name = "ProgressCurrent_pb";
            ProgressCurrent_pb.TabStop = false;
            ProgressCurrent_pb.SizeChanged += ProgressCurrent_pb_SizeChanged;
            // 
            // TotalProg_pb
            // 
            resources.ApplyResources(TotalProg_pb, "TotalProg_pb");
            TotalProg_pb.BackColor = Color.Transparent;
            TotalProg_pb.Image = Client.Resources.Images.Blue_Progress;
            TotalProg_pb.Name = "TotalProg_pb";
            TotalProg_pb.TabStop = false;
            TotalProg_pb.SizeChanged += TotalProg_pb_SizeChanged;
            // 
            // Launch_pb
            // 
            resources.ApplyResources(Launch_pb, "Launch_pb");
            Launch_pb.BackColor = Color.Transparent;
            Launch_pb.Cursor = Cursors.Hand;
            Launch_pb.Image = Client.Resources.Images.Launch_Base1;
            Launch_pb.Name = "Launch_pb";
            Launch_pb.TabStop = false;
            Launch_pb.Click += Launch_pb_Click;
            Launch_pb.MouseDown += Launch_pb_MouseDown;
            Launch_pb.MouseEnter += Launch_pb_MouseEnter;
            Launch_pb.MouseLeave += Launch_pb_MouseLeave;
            Launch_pb.MouseUp += Launch_pb_MouseUp;
            // 
            // Main_browser
            // 
            resources.ApplyResources(Main_browser, "Main_browser");
            Main_browser.AllowExternalDrop = true;
            Main_browser.CausesValidation = false;
            Main_browser.CreationProperties = null;
            Main_browser.DefaultBackgroundColor = Color.White;
            Main_browser.Name = "Main_browser";
            Main_browser.ZoomFactor = 1D;
            // 
            // AMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Client.Resources.Images.pfffft;
            Controls.Add(Main_browser);
            Controls.Add(SpeedLabel);
            Controls.Add(Credit_label);
            Controls.Add(Version_label);
            Controls.Add(TotalPercent_label);
            Controls.Add(CurrentPercent_label);
            Controls.Add(CurrentFile_label);
            Controls.Add(ProgTotalEnd_pb);
            Controls.Add(ProgEnd_pb);
            Controls.Add(ProgressCurrent_pb);
            Controls.Add(TotalProg_pb);
            Controls.Add(Launch_pb);
            Controls.Add(ActionLabel);
            Controls.Add(Movement_panel);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AMain";
            TransparencyKey = Color.Black;
            FormClosed += AMain_FormClosed;
            Load += AMain_Load;
            Click += AMain_Click;
            Movement_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Config_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProgTotalEnd_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProgEnd_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProgressCurrent_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalProg_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Launch_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Main_browser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Label SpeedLabel;
        public System.Windows.Forms.Timer InterfaceTimer;
        public System.Windows.Forms.PictureBox Launch_pb;
        private System.Windows.Forms.PictureBox Close_pb;
        private System.Windows.Forms.Panel Movement_panel;
        private System.Windows.Forms.PictureBox TotalProg_pb;
        private System.Windows.Forms.PictureBox ProgressCurrent_pb;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.PictureBox ProgEnd_pb;
        private System.Windows.Forms.PictureBox ProgTotalEnd_pb;
        private System.Windows.Forms.Label CurrentFile_label;
        private System.Windows.Forms.Label CurrentPercent_label;
        private System.Windows.Forms.Label TotalPercent_label;
        private System.Windows.Forms.Label Credit_label;
        private System.Windows.Forms.Label Version_label;
        private System.Windows.Forms.PictureBox Config_pb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 Main_browser;
    }
}

