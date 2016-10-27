//-------------------------------------------﻿﻿﻿
// YU Xinbo  
// bruce.xb.yu@connect.polyu.hk      
// PhD Candidate 
// in the Hong Kong PolyTechnical University   
//-------------------------------------------
namespace DF_FaceTracking.cs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.colorResolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Live = new System.Windows.Forms.ToolStripMenuItem();
            this.Playback = new System.Windows.Forms.ToolStripMenuItem();
            this.Record = new System.Windows.Forms.ToolStripMenuItem();
            this.Status2 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AlertsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Scale = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.PictureBox();
            this.Recognition = new System.Windows.Forms.CheckBox();
            this.RegisterUser = new System.Windows.Forms.Button();
            this.UnregisterUser = new System.Windows.Forms.Button();
            this.NumDetectionText = new System.Windows.Forms.TextBox();
            this.NumLandmarksText = new System.Windows.Forms.TextBox();
            this.NumPoseText = new System.Windows.Forms.TextBox();
            this.NumExpressionsText = new System.Windows.Forms.TextBox();
            this.Detection = new System.Windows.Forms.CheckBox();
            this.Landmarks = new System.Windows.Forms.CheckBox();
            this.Pose = new System.Windows.Forms.CheckBox();
            this.Expressions = new System.Windows.Forms.CheckBox();
            this.Pulse = new System.Windows.Forms.CheckBox();
            this.NumPulseText = new System.Windows.Forms.TextBox();
            this.MongoCon = new System.Windows.Forms.Button();
            this.mongo_icon = new System.Windows.Forms.PictureBox();
            this.btn_RecordSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_kidinfo = new System.Windows.Forms.Button();
            this.pic_kid_icon = new System.Windows.Forms.PictureBox();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.Status2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mongo_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kid_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(820, 225);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(80, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "SR300 ON";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(820, 254);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(80, 23);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "SR300 OFF";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sourceToolStripMenuItem.Text = "Device";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.moduleToolStripMenuItem.Text = "Module";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceToolStripMenuItem,
            this.colorResolutionToolStripMenuItem,
            this.moduleToolStripMenuItem,
            this.ProfileToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(941, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // colorResolutionToolStripMenuItem
            // 
            this.colorResolutionToolStripMenuItem.Name = "colorResolutionToolStripMenuItem";
            this.colorResolutionToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorResolutionToolStripMenuItem.Text = "Color";
            // 
            // ProfileToolStripMenuItem
            // 
            this.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem";
            this.ProfileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ProfileToolStripMenuItem.Text = "Profile";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Live,
            this.Playback,
            this.Record});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // Live
            // 
            this.Live.Checked = true;
            this.Live.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Live.Name = "Live";
            this.Live.Size = new System.Drawing.Size(121, 22);
            this.Live.Text = "Live";
            this.Live.Click += new System.EventHandler(this.Live_Click);
            // 
            // Playback
            // 
            this.Playback.Name = "Playback";
            this.Playback.Size = new System.Drawing.Size(121, 22);
            this.Playback.Text = "Playback";
            this.Playback.Click += new System.EventHandler(this.Playback_Click);
            // 
            // Record
            // 
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(121, 22);
            this.Record.Text = "Record";
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Status2
            // 
            this.Status2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.AlertsLabel});
            this.Status2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Status2.Location = new System.Drawing.Point(0, 481);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(941, 20);
            this.Status2.TabIndex = 25;
            this.Status2.Text = "Status2";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.StatusLabel.Size = new System.Drawing.Size(73, 15);
            this.StatusLabel.Text = "OK";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlertsLabel
            // 
            this.AlertsLabel.AutoSize = false;
            this.AlertsLabel.Name = "AlertsLabel";
            this.AlertsLabel.Size = new System.Drawing.Size(200, 15);
            this.AlertsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Scale
            // 
            this.Scale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Scale.AutoSize = true;
            this.Scale.Checked = true;
            this.Scale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Scale.Location = new System.Drawing.Point(820, 27);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(53, 17);
            this.Scale.TabIndex = 26;
            this.Scale.Text = "Scale";
            this.Scale.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.ErrorImage = null;
            this.Panel2.InitialImage = null;
            this.Panel2.Location = new System.Drawing.Point(12, 27);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(802, 444);
            this.Panel2.TabIndex = 27;
            this.Panel2.TabStop = false;
            // 
            // Recognition
            // 
            this.Recognition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Recognition.AutoSize = true;
            this.Recognition.Enabled = false;
            this.Recognition.Location = new System.Drawing.Point(820, 188);
            this.Recognition.Name = "Recognition";
            this.Recognition.Size = new System.Drawing.Size(83, 17);
            this.Recognition.TabIndex = 33;
            this.Recognition.Text = "Recognition";
            this.Recognition.UseVisualStyleBackColor = true;
            // 
            // RegisterUser
            // 
            this.RegisterUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterUser.Enabled = false;
            this.RegisterUser.Location = new System.Drawing.Point(820, 283);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(80, 23);
            this.RegisterUser.TabIndex = 34;
            this.RegisterUser.Text = "Register";
            this.RegisterUser.UseVisualStyleBackColor = true;
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // UnregisterUser
            // 
            this.UnregisterUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnregisterUser.Enabled = false;
            this.UnregisterUser.Location = new System.Drawing.Point(820, 312);
            this.UnregisterUser.Name = "UnregisterUser";
            this.UnregisterUser.Size = new System.Drawing.Size(80, 23);
            this.UnregisterUser.TabIndex = 35;
            this.UnregisterUser.Text = "Unregister";
            this.UnregisterUser.UseVisualStyleBackColor = true;
            this.UnregisterUser.Click += new System.EventHandler(this.UnregisterUser_Click);
            // 
            // NumDetectionText
            // 
            this.NumDetectionText.AccessibleName = "";
            this.NumDetectionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumDetectionText.Location = new System.Drawing.Point(906, 73);
            this.NumDetectionText.Name = "NumDetectionText";
            this.NumDetectionText.Size = new System.Drawing.Size(21, 20);
            this.NumDetectionText.TabIndex = 36;
            // 
            // NumLandmarksText
            // 
            this.NumLandmarksText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumLandmarksText.Location = new System.Drawing.Point(906, 96);
            this.NumLandmarksText.Name = "NumLandmarksText";
            this.NumLandmarksText.Size = new System.Drawing.Size(21, 20);
            this.NumLandmarksText.TabIndex = 37;
            // 
            // NumPoseText
            // 
            this.NumPoseText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumPoseText.Location = new System.Drawing.Point(906, 119);
            this.NumPoseText.Name = "NumPoseText";
            this.NumPoseText.Size = new System.Drawing.Size(21, 20);
            this.NumPoseText.TabIndex = 38;
            // 
            // NumExpressionsText
            // 
            this.NumExpressionsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumExpressionsText.Location = new System.Drawing.Point(906, 142);
            this.NumExpressionsText.Name = "NumExpressionsText";
            this.NumExpressionsText.Size = new System.Drawing.Size(21, 20);
            this.NumExpressionsText.TabIndex = 45;
            // 
            // Detection
            // 
            this.Detection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Detection.AutoSize = true;
            this.Detection.Location = new System.Drawing.Point(820, 73);
            this.Detection.Name = "Detection";
            this.Detection.Size = new System.Drawing.Size(72, 17);
            this.Detection.TabIndex = 46;
            this.Detection.Text = "Detection";
            this.Detection.UseVisualStyleBackColor = true;
            // 
            // Landmarks
            // 
            this.Landmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Landmarks.AutoSize = true;
            this.Landmarks.Location = new System.Drawing.Point(820, 96);
            this.Landmarks.Name = "Landmarks";
            this.Landmarks.Size = new System.Drawing.Size(78, 17);
            this.Landmarks.TabIndex = 47;
            this.Landmarks.Text = "Landmarks";
            this.Landmarks.UseVisualStyleBackColor = true;
            // 
            // Pose
            // 
            this.Pose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pose.AutoSize = true;
            this.Pose.Location = new System.Drawing.Point(820, 119);
            this.Pose.Name = "Pose";
            this.Pose.Size = new System.Drawing.Size(50, 17);
            this.Pose.TabIndex = 48;
            this.Pose.Text = "Pose";
            this.Pose.UseVisualStyleBackColor = true;
            // 
            // Expressions
            // 
            this.Expressions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Expressions.AutoSize = true;
            this.Expressions.Location = new System.Drawing.Point(820, 142);
            this.Expressions.Name = "Expressions";
            this.Expressions.Size = new System.Drawing.Size(82, 17);
            this.Expressions.TabIndex = 49;
            this.Expressions.Text = "Expressions";
            this.Expressions.UseVisualStyleBackColor = true;
            // 
            // Pulse
            // 
            this.Pulse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pulse.AutoSize = true;
            this.Pulse.Location = new System.Drawing.Point(820, 165);
            this.Pulse.Name = "Pulse";
            this.Pulse.Size = new System.Drawing.Size(52, 17);
            this.Pulse.TabIndex = 51;
            this.Pulse.Text = "Pulse";
            this.Pulse.UseVisualStyleBackColor = true;
            // 
            // NumPulseText
            // 
            this.NumPulseText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumPulseText.Location = new System.Drawing.Point(906, 165);
            this.NumPulseText.Name = "NumPulseText";
            this.NumPulseText.Size = new System.Drawing.Size(21, 20);
            this.NumPulseText.TabIndex = 52;
            // 
            // MongoCon
            // 
            this.MongoCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MongoCon.Location = new System.Drawing.Point(820, 370);
            this.MongoCon.Name = "MongoCon";
            this.MongoCon.Size = new System.Drawing.Size(80, 23);
            this.MongoCon.TabIndex = 2;
            this.MongoCon.Text = "MongoDB";
            this.MongoCon.UseVisualStyleBackColor = true;
            this.MongoCon.Click += new System.EventHandler(this.MongoCon_Click);
            // 
            // mongo_icon
            // 
            this.mongo_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mongo_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mongo_icon.BackgroundImage")));
            this.mongo_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mongo_icon.InitialImage = null;
            this.mongo_icon.Location = new System.Drawing.Point(905, 366);
            this.mongo_icon.Name = "mongo_icon";
            this.mongo_icon.Size = new System.Drawing.Size(22, 33);
            this.mongo_icon.TabIndex = 53;
            this.mongo_icon.TabStop = false;
            // 
            // btn_RecordSwitch
            // 
            this.btn_RecordSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RecordSwitch.Location = new System.Drawing.Point(820, 447);
            this.btn_RecordSwitch.Name = "btn_RecordSwitch";
            this.btn_RecordSwitch.Size = new System.Drawing.Size(80, 23);
            this.btn_RecordSwitch.TabIndex = 54;
            this.btn_RecordSwitch.Text = "Start Collect";
            this.btn_RecordSwitch.UseVisualStyleBackColor = true;
            this.btn_RecordSwitch.Click += new System.EventHandler(this.btn_RecordSwitch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Duration:";
            // 
            // txt_duration
            // 
            this.txt_duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_duration.Location = new System.Drawing.Point(867, 418);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(31, 20);
            this.txt_duration.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(898, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "mins";
            // 
            // btn_kidinfo
            // 
            this.btn_kidinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kidinfo.Location = new System.Drawing.Point(820, 341);
            this.btn_kidinfo.Name = "btn_kidinfo";
            this.btn_kidinfo.Size = new System.Drawing.Size(80, 23);
            this.btn_kidinfo.TabIndex = 58;
            this.btn_kidinfo.Text = "Kid Info.";
            this.btn_kidinfo.UseVisualStyleBackColor = true;
            this.btn_kidinfo.Click += new System.EventHandler(this.btn_kidinfo_Click);
            // 
            // pic_kid_icon
            // 
            this.pic_kid_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_kid_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_kid_icon.BackgroundImage")));
            this.pic_kid_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_kid_icon.Location = new System.Drawing.Point(903, 339);
            this.pic_kid_icon.Name = "pic_kid_icon";
            this.pic_kid_icon.Size = new System.Drawing.Size(26, 26);
            this.pic_kid_icon.TabIndex = 59;
            this.pic_kid_icon.TabStop = false;
            // 
            // lbl_timer
            // 
            this.lbl_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(818, 485);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(33, 13);
            this.lbl_timer.TabIndex = 60;
            this.lbl_timer.Text = "Timer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(941, 501);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.pic_kid_icon);
            this.Controls.Add(this.btn_kidinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RecordSwitch);
            this.Controls.Add(this.mongo_icon);
            this.Controls.Add(this.MongoCon);
            this.Controls.Add(this.NumPulseText);
            this.Controls.Add(this.Pulse);
            this.Controls.Add(this.Expressions);
            this.Controls.Add(this.Pose);
            this.Controls.Add(this.Landmarks);
            this.Controls.Add(this.Detection);
            this.Controls.Add(this.NumExpressionsText);
            this.Controls.Add(this.NumPoseText);
            this.Controls.Add(this.NumLandmarksText);
            this.Controls.Add(this.NumDetectionText);
            this.Controls.Add(this.UnregisterUser);
            this.Controls.Add(this.RegisterUser);
            this.Controls.Add(this.Recognition);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SR300 Face to MongoDB";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Status2.ResumeLayout(false);
            this.Status2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mongo_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kid_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Start;
        public System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.StatusStrip Status2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private new System.Windows.Forms.CheckBox Scale;
        private System.Windows.Forms.PictureBox Panel2;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Live;
        private System.Windows.Forms.ToolStripMenuItem Playback;
        private System.Windows.Forms.ToolStripMenuItem Record;
        private System.Windows.Forms.ToolStripMenuItem ProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel AlertsLabel;
        private System.Windows.Forms.CheckBox Recognition;
        private System.Windows.Forms.Button RegisterUser;
        private System.Windows.Forms.Button UnregisterUser;
        private System.Windows.Forms.ToolStripMenuItem colorResolutionToolStripMenuItem;
        private System.Windows.Forms.TextBox NumDetectionText;
        private System.Windows.Forms.TextBox NumLandmarksText;
        private System.Windows.Forms.TextBox NumPoseText;
        private System.Windows.Forms.TextBox NumExpressionsText;
        private System.Windows.Forms.CheckBox Detection;
        private System.Windows.Forms.CheckBox Landmarks;
        private System.Windows.Forms.CheckBox Pose;
        private System.Windows.Forms.CheckBox Expressions;
        //private System.Windows.Forms.CheckBox Mirror;
        private System.Windows.Forms.CheckBox Pulse;
        private System.Windows.Forms.TextBox NumPulseText;
        public System.Windows.Forms.Button MongoCon;
        private System.Windows.Forms.PictureBox mongo_icon;
        public System.Windows.Forms.Button btn_RecordSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_kidinfo;
        private System.Windows.Forms.PictureBox pic_kid_icon;
        private System.Windows.Forms.Label lbl_timer;
    }
}