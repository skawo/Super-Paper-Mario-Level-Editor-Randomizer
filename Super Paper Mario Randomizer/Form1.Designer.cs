namespace Super_Paper_Mario_Randomizer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSetupFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSetupFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savesSetupFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openISOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsWBFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeWithPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Stages = new System.Windows.Forms.Label();
            this.pb_Progress = new System.Windows.Forms.ProgressBar();
            this.lbl_Separator = new System.Windows.Forms.Label();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.tabP_Enemies = new System.Windows.Forms.TabPage();
            this.pn_EnemyEditor = new System.Windows.Forms.Panel();
            this.picturebox_info = new System.Windows.Forms.PictureBox();
            this.lbl_ActorID = new System.Windows.Forms.Label();
            this.tx_Header1Unk = new Super_Paper_Mario_Randomizer.ByteTextbox(this.components);
            this.lbl_Header1Unk = new System.Windows.Forms.Label();
            this.numUp_Z = new System.Windows.Forms.NumericUpDown();
            this.lb_PosX = new System.Windows.Forms.Label();
            this.numUp_Y = new System.Windows.Forms.NumericUpDown();
            this.combo_Actor = new System.Windows.Forms.ComboBox();
            this.numUp_X = new System.Windows.Forms.NumericUpDown();
            this.lb_Actor = new System.Windows.Forms.Label();
            this.lb_PosY = new System.Windows.Forms.Label();
            this.lb_PosZ = new System.Windows.Forms.Label();
            this.tx_UnknownData = new Super_Paper_Mario_Randomizer.ByteTextbox(this.components);
            this.lbl_UnknownData = new System.Windows.Forms.Label();
            this.tx_Setupheader = new Super_Paper_Mario_Randomizer.ByteTextbox(this.components);
            this.lb_Setupheader = new System.Windows.Forms.Label();
            this.lb_SeparatorEnemies = new System.Windows.Forms.Label();
            this.lbl_EnemyEntries = new System.Windows.Forms.Label();
            this.lst_EnemyEntries = new System.Windows.Forms.ListBox();
            this.tabC_Editor = new System.Windows.Forms.TabControl();
            this.container = new System.Windows.Forms.SplitContainer();
            this.lstbox_Stages = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabP_Enemies.SuspendLayout();
            this.pn_EnemyEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp_X)).BeginInit();
            this.tabC_Editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.randomizationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSetupFileToolStripMenuItem,
            this.openSetupFolderToolStripMenuItem,
            this.saveCurrentToolStripMenuItem,
            this.savesSetupFolderToolStripMenuItem,
            this.openISOToolStripMenuItem,
            this.saveAsWBFSToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSetupFileToolStripMenuItem
            // 
            this.openSetupFileToolStripMenuItem.Name = "openSetupFileToolStripMenuItem";
            this.openSetupFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSetupFileToolStripMenuItem.Text = "Open setup file...";
            this.openSetupFileToolStripMenuItem.Click += new System.EventHandler(this.openSetupFileToolStripMenuItem_Click);
            // 
            // openSetupFolderToolStripMenuItem
            // 
            this.openSetupFolderToolStripMenuItem.Name = "openSetupFolderToolStripMenuItem";
            this.openSetupFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSetupFolderToolStripMenuItem.Text = "Open setup folder...";
            this.openSetupFolderToolStripMenuItem.Click += new System.EventHandler(this.openSetupFolderToolStripMenuItem_Click);
            // 
            // saveCurrentToolStripMenuItem
            // 
            this.saveCurrentToolStripMenuItem.Name = "saveCurrentToolStripMenuItem";
            this.saveCurrentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveCurrentToolStripMenuItem.Text = "Save current";
            this.saveCurrentToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentToolStripMenuItem_Click);
            // 
            // savesSetupFolderToolStripMenuItem
            // 
            this.savesSetupFolderToolStripMenuItem.Name = "savesSetupFolderToolStripMenuItem";
            this.savesSetupFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savesSetupFolderToolStripMenuItem.Text = "Save all";
            this.savesSetupFolderToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // openISOToolStripMenuItem
            // 
            this.openISOToolStripMenuItem.Name = "openISOToolStripMenuItem";
            this.openISOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openISOToolStripMenuItem.Text = "Extract ISO...";
            this.openISOToolStripMenuItem.Click += new System.EventHandler(this.extractISOToolStripMenuItem_Click);
            // 
            // saveAsWBFSToolStripMenuItem
            // 
            this.saveAsWBFSToolStripMenuItem.Name = "saveAsWBFSToolStripMenuItem";
            this.saveAsWBFSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsWBFSToolStripMenuItem.Text = "Pack ISO...";
            this.saveAsWBFSToolStripMenuItem.Click += new System.EventHandler(this.saveAsWBFSToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // randomizationToolStripMenuItem
            // 
            this.randomizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeWithPresetToolStripMenuItem,
            this.presetsToolStripMenuItem});
            this.randomizationToolStripMenuItem.Name = "randomizationToolStripMenuItem";
            this.randomizationToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.randomizationToolStripMenuItem.Text = "Randomization";
            // 
            // randomizeWithPresetToolStripMenuItem
            // 
            this.randomizeWithPresetToolStripMenuItem.Name = "randomizeWithPresetToolStripMenuItem";
            this.randomizeWithPresetToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.randomizeWithPresetToolStripMenuItem.Text = "Randomize with preset...";
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.presetsToolStripMenuItem.Text = "Presets...";
            this.presetsToolStripMenuItem.Click += new System.EventHandler(this.presetsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbl_Stages
            // 
            this.lbl_Stages.AutoSize = true;
            this.lbl_Stages.Location = new System.Drawing.Point(13, 41);
            this.lbl_Stages.Name = "lbl_Stages";
            this.lbl_Stages.Size = new System.Drawing.Size(43, 13);
            this.lbl_Stages.TabIndex = 2;
            this.lbl_Stages.Text = "Stages:";
            // 
            // pb_Progress
            // 
            this.pb_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_Progress.Location = new System.Drawing.Point(578, 20);
            this.pb_Progress.Name = "pb_Progress";
            this.pb_Progress.Size = new System.Drawing.Size(145, 23);
            this.pb_Progress.TabIndex = 3;
            // 
            // lbl_Separator
            // 
            this.lbl_Separator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Separator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Separator.Location = new System.Drawing.Point(13, 5);
            this.lbl_Separator.Name = "lbl_Separator";
            this.lbl_Separator.Size = new System.Drawing.Size(708, 1);
            this.lbl_Separator.TabIndex = 4;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Progress.Location = new System.Drawing.Point(376, 20);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(196, 23);
            this.lbl_Progress.TabIndex = 5;
            this.lbl_Progress.Text = "Idle";
            this.lbl_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabP_Enemies
            // 
            this.tabP_Enemies.Controls.Add(this.pn_EnemyEditor);
            this.tabP_Enemies.Controls.Add(this.tx_Setupheader);
            this.tabP_Enemies.Controls.Add(this.lb_Setupheader);
            this.tabP_Enemies.Controls.Add(this.lb_SeparatorEnemies);
            this.tabP_Enemies.Controls.Add(this.lbl_EnemyEntries);
            this.tabP_Enemies.Controls.Add(this.lst_EnemyEntries);
            this.tabP_Enemies.Location = new System.Drawing.Point(4, 22);
            this.tabP_Enemies.Name = "tabP_Enemies";
            this.tabP_Enemies.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Enemies.Size = new System.Drawing.Size(506, 441);
            this.tabP_Enemies.TabIndex = 0;
            this.tabP_Enemies.Text = "Enemies";
            this.tabP_Enemies.UseVisualStyleBackColor = true;
            // 
            // pn_EnemyEditor
            // 
            this.pn_EnemyEditor.Controls.Add(this.picturebox_info);
            this.pn_EnemyEditor.Controls.Add(this.lbl_ActorID);
            this.pn_EnemyEditor.Controls.Add(this.tx_Header1Unk);
            this.pn_EnemyEditor.Controls.Add(this.lbl_Header1Unk);
            this.pn_EnemyEditor.Controls.Add(this.numUp_Z);
            this.pn_EnemyEditor.Controls.Add(this.lb_PosX);
            this.pn_EnemyEditor.Controls.Add(this.numUp_Y);
            this.pn_EnemyEditor.Controls.Add(this.combo_Actor);
            this.pn_EnemyEditor.Controls.Add(this.numUp_X);
            this.pn_EnemyEditor.Controls.Add(this.lb_Actor);
            this.pn_EnemyEditor.Controls.Add(this.lb_PosY);
            this.pn_EnemyEditor.Controls.Add(this.lb_PosZ);
            this.pn_EnemyEditor.Controls.Add(this.tx_UnknownData);
            this.pn_EnemyEditor.Controls.Add(this.lbl_UnknownData);
            this.pn_EnemyEditor.Enabled = false;
            this.pn_EnemyEditor.Location = new System.Drawing.Point(193, 0);
            this.pn_EnemyEditor.Name = "pn_EnemyEditor";
            this.pn_EnemyEditor.Size = new System.Drawing.Size(313, 387);
            this.pn_EnemyEditor.TabIndex = 26;
            // 
            // picturebox_info
            // 
            this.picturebox_info.Image = global::Super_Paper_Mario_Randomizer.Properties.Resources.Blue_question_mark_icon_svg;
            this.picturebox_info.Location = new System.Drawing.Point(275, 23);
            this.picturebox_info.Name = "picturebox_info";
            this.picturebox_info.Size = new System.Drawing.Size(28, 22);
            this.picturebox_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_info.TabIndex = 29;
            this.picturebox_info.TabStop = false;
            this.picturebox_info.Visible = false;
            // 
            // lbl_ActorID
            // 
            this.lbl_ActorID.AutoSize = true;
            this.lbl_ActorID.Location = new System.Drawing.Point(7, 27);
            this.lbl_ActorID.Name = "lbl_ActorID";
            this.lbl_ActorID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ActorID.TabIndex = 28;
            this.lbl_ActorID.Text = "ID";
            this.lbl_ActorID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tx_Header1Unk
            // 
            this.tx_Header1Unk.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Header1Unk.Location = new System.Drawing.Point(6, 338);
            this.tx_Header1Unk.Name = "tx_Header1Unk";
            this.tx_Header1Unk.Size = new System.Drawing.Size(297, 20);
            this.tx_Header1Unk.TabIndex = 27;
            this.tx_Header1Unk.Tag = "header1unk";
            this.tx_Header1Unk.Visible = false;
            this.tx_Header1Unk.TextChanged += new System.EventHandler(this.bytetx_Changed);
            // 
            // lbl_Header1Unk
            // 
            this.lbl_Header1Unk.AutoSize = true;
            this.lbl_Header1Unk.Location = new System.Drawing.Point(7, 322);
            this.lbl_Header1Unk.Name = "lbl_Header1Unk";
            this.lbl_Header1Unk.Size = new System.Drawing.Size(154, 13);
            this.lbl_Header1Unk.TabIndex = 26;
            this.lbl_Header1Unk.Text = "Unknown data (Size header 1):";
            this.lbl_Header1Unk.Visible = false;
            // 
            // numUp_Z
            // 
            this.numUp_Z.Location = new System.Drawing.Point(70, 105);
            this.numUp_Z.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUp_Z.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numUp_Z.Name = "numUp_Z";
            this.numUp_Z.Size = new System.Drawing.Size(120, 20);
            this.numUp_Z.TabIndex = 25;
            this.numUp_Z.Tag = "Z";
            this.numUp_Z.ValueChanged += new System.EventHandler(this.numUp_X_ValueChanged);
            // 
            // lb_PosX
            // 
            this.lb_PosX.AutoSize = true;
            this.lb_PosX.Location = new System.Drawing.Point(4, 55);
            this.lb_PosX.Name = "lb_PosX";
            this.lb_PosX.Size = new System.Drawing.Size(57, 13);
            this.lb_PosX.TabIndex = 11;
            this.lb_PosX.Text = "Position X:";
            // 
            // numUp_Y
            // 
            this.numUp_Y.Location = new System.Drawing.Point(70, 79);
            this.numUp_Y.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUp_Y.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numUp_Y.Name = "numUp_Y";
            this.numUp_Y.Size = new System.Drawing.Size(120, 20);
            this.numUp_Y.TabIndex = 24;
            this.numUp_Y.Tag = "Y";
            this.numUp_Y.ValueChanged += new System.EventHandler(this.numUp_X_ValueChanged);
            // 
            // combo_Actor
            // 
            this.combo_Actor.FormattingEnabled = true;
            this.combo_Actor.Location = new System.Drawing.Point(70, 24);
            this.combo_Actor.Name = "combo_Actor";
            this.combo_Actor.Size = new System.Drawing.Size(199, 21);
            this.combo_Actor.TabIndex = 9;
            this.combo_Actor.SelectedIndexChanged += new System.EventHandler(this.combo_Actor_SelectedIndexChanged);
            // 
            // numUp_X
            // 
            this.numUp_X.Location = new System.Drawing.Point(70, 53);
            this.numUp_X.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUp_X.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numUp_X.Name = "numUp_X";
            this.numUp_X.Size = new System.Drawing.Size(120, 20);
            this.numUp_X.TabIndex = 23;
            this.numUp_X.Tag = "X";
            this.numUp_X.ValueChanged += new System.EventHandler(this.numUp_X_ValueChanged);
            // 
            // lb_Actor
            // 
            this.lb_Actor.AutoSize = true;
            this.lb_Actor.Location = new System.Drawing.Point(7, 7);
            this.lb_Actor.Name = "lb_Actor";
            this.lb_Actor.Size = new System.Drawing.Size(35, 13);
            this.lb_Actor.TabIndex = 10;
            this.lb_Actor.Text = "Actor:";
            // 
            // lb_PosY
            // 
            this.lb_PosY.AutoSize = true;
            this.lb_PosY.Location = new System.Drawing.Point(4, 81);
            this.lb_PosY.Name = "lb_PosY";
            this.lb_PosY.Size = new System.Drawing.Size(57, 13);
            this.lb_PosY.TabIndex = 13;
            this.lb_PosY.Text = "Position Y:";
            // 
            // lb_PosZ
            // 
            this.lb_PosZ.AutoSize = true;
            this.lb_PosZ.Location = new System.Drawing.Point(4, 107);
            this.lb_PosZ.Name = "lb_PosZ";
            this.lb_PosZ.Size = new System.Drawing.Size(57, 13);
            this.lb_PosZ.TabIndex = 15;
            this.lb_PosZ.Text = "Position Z:";
            // 
            // tx_UnknownData
            // 
            this.tx_UnknownData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tx_UnknownData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_UnknownData.Location = new System.Drawing.Point(6, 153);
            this.tx_UnknownData.Multiline = true;
            this.tx_UnknownData.Name = "tx_UnknownData";
            this.tx_UnknownData.Size = new System.Drawing.Size(297, 166);
            this.tx_UnknownData.TabIndex = 17;
            this.tx_UnknownData.Tag = "unkd";
            this.tx_UnknownData.TextChanged += new System.EventHandler(this.bytetx_Changed);
            // 
            // lbl_UnknownData
            // 
            this.lbl_UnknownData.AutoSize = true;
            this.lbl_UnknownData.Location = new System.Drawing.Point(4, 137);
            this.lbl_UnknownData.Name = "lbl_UnknownData";
            this.lbl_UnknownData.Size = new System.Drawing.Size(80, 13);
            this.lbl_UnknownData.TabIndex = 18;
            this.lbl_UnknownData.Text = "Unknown data:";
            // 
            // tx_Setupheader
            // 
            this.tx_Setupheader.Enabled = false;
            this.tx_Setupheader.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Setupheader.Location = new System.Drawing.Point(6, 24);
            this.tx_Setupheader.Name = "tx_Setupheader";
            this.tx_Setupheader.Size = new System.Drawing.Size(181, 20);
            this.tx_Setupheader.TabIndex = 20;
            this.tx_Setupheader.Tag = "header";
            this.tx_Setupheader.TextChanged += new System.EventHandler(this.bytetx_Changed);
            // 
            // lb_Setupheader
            // 
            this.lb_Setupheader.AutoSize = true;
            this.lb_Setupheader.Location = new System.Drawing.Point(6, 7);
            this.lb_Setupheader.Name = "lb_Setupheader";
            this.lb_Setupheader.Size = new System.Drawing.Size(45, 13);
            this.lb_Setupheader.TabIndex = 19;
            this.lb_Setupheader.Text = "Header:";
            // 
            // lb_SeparatorEnemies
            // 
            this.lb_SeparatorEnemies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_SeparatorEnemies.Location = new System.Drawing.Point(193, 6);
            this.lb_SeparatorEnemies.Name = "lb_SeparatorEnemies";
            this.lb_SeparatorEnemies.Size = new System.Drawing.Size(1, 371);
            this.lb_SeparatorEnemies.TabIndex = 8;
            // 
            // lbl_EnemyEntries
            // 
            this.lbl_EnemyEntries.AutoSize = true;
            this.lbl_EnemyEntries.Location = new System.Drawing.Point(6, 55);
            this.lbl_EnemyEntries.Name = "lbl_EnemyEntries";
            this.lbl_EnemyEntries.Size = new System.Drawing.Size(76, 13);
            this.lbl_EnemyEntries.TabIndex = 7;
            this.lbl_EnemyEntries.Text = "Enemy entries:";
            // 
            // lst_EnemyEntries
            // 
            this.lst_EnemyEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_EnemyEntries.FormattingEnabled = true;
            this.lst_EnemyEntries.Location = new System.Drawing.Point(6, 71);
            this.lst_EnemyEntries.Name = "lst_EnemyEntries";
            this.lst_EnemyEntries.Size = new System.Drawing.Size(181, 355);
            this.lst_EnemyEntries.TabIndex = 0;
            this.lst_EnemyEntries.SelectedIndexChanged += new System.EventHandler(this.lst_EnemyEntries_SelectedIndexChanged);
            // 
            // tabC_Editor
            // 
            this.tabC_Editor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabC_Editor.Controls.Add(this.tabP_Enemies);
            this.tabC_Editor.Location = new System.Drawing.Point(209, 41);
            this.tabC_Editor.Name = "tabC_Editor";
            this.tabC_Editor.SelectedIndex = 0;
            this.tabC_Editor.Size = new System.Drawing.Size(514, 467);
            this.tabC_Editor.TabIndex = 6;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.IsSplitterFixed = true;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.lstbox_Stages);
            this.container.Panel1.Controls.Add(this.tabC_Editor);
            this.container.Panel1.Controls.Add(this.lbl_Stages);
            this.container.Panel1.Controls.Add(this.menuStrip1);
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.pb_Progress);
            this.container.Panel2.Controls.Add(this.lbl_Separator);
            this.container.Panel2.Controls.Add(this.lbl_Progress);
            this.container.Size = new System.Drawing.Size(735, 570);
            this.container.SplitterDistance = 511;
            this.container.TabIndex = 7;
            // 
            // lstbox_Stages
            // 
            this.lstbox_Stages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstbox_Stages.FormattingEnabled = true;
            this.lstbox_Stages.Location = new System.Drawing.Point(16, 57);
            this.lstbox_Stages.Name = "lstbox_Stages";
            this.lstbox_Stages.Size = new System.Drawing.Size(191, 446);
            this.lstbox_Stages.TabIndex = 27;
            this.lstbox_Stages.SelectedIndexChanged += new System.EventHandler(this.checkedlistbox_Stages_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 570);
            this.Controls.Add(this.container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(751, 9999999);
            this.Name = "Form1";
            this.Text = "Super Paper Mario Level Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabP_Enemies.ResumeLayout(false);
            this.tabP_Enemies.PerformLayout();
            this.pn_EnemyEditor.ResumeLayout(false);
            this.pn_EnemyEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp_X)).EndInit();
            this.tabC_Editor.ResumeLayout(false);
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel1.PerformLayout();
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openISOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSetupFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsWBFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Stages;
        private System.Windows.Forms.ProgressBar pb_Progress;
        private System.Windows.Forms.Label lbl_Separator;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.ToolStripMenuItem randomizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeWithPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabP_Enemies;
        private System.Windows.Forms.TabControl tabC_Editor;
        private System.Windows.Forms.Label lb_SeparatorEnemies;
        private System.Windows.Forms.Label lbl_EnemyEntries;
        private System.Windows.Forms.ListBox lst_EnemyEntries;
        private ByteTextbox tx_Setupheader;
        private System.Windows.Forms.Label lb_Setupheader;
        private System.Windows.Forms.Label lbl_UnknownData;
        private ByteTextbox tx_UnknownData;
        private System.Windows.Forms.Label lb_PosZ;
        private System.Windows.Forms.Label lb_PosY;
        private System.Windows.Forms.Label lb_PosX;
        private System.Windows.Forms.Label lb_Actor;
        private System.Windows.Forms.ComboBox combo_Actor;
        private System.Windows.Forms.ToolStripMenuItem savesSetupFolderToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numUp_Z;
        private System.Windows.Forms.NumericUpDown numUp_Y;
        private System.Windows.Forms.NumericUpDown numUp_X;
        private System.Windows.Forms.Panel pn_EnemyEditor;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSetupFileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer container;
        private ByteTextbox tx_Header1Unk;
        private System.Windows.Forms.Label lbl_Header1Unk;
        private System.Windows.Forms.Label lbl_ActorID;
        private System.Windows.Forms.PictureBox picturebox_info;
        private System.Windows.Forms.ListBox lstbox_Stages;
    }
}

