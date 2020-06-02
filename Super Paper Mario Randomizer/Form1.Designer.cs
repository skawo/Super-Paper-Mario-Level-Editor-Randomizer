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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSetupFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openISOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsWBFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsRiivolutionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeWithPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedlistbox_Stages = new System.Windows.Forms.CheckedListBox();
            this.lbl_Stages = new System.Windows.Forms.Label();
            this.pb_Progress = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_Separator = new System.Windows.Forms.Label();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.tabP_Enemies = new System.Windows.Forms.TabPage();
            this.tabC_Editor = new System.Windows.Forms.TabControl();
            this.lst_EnemyEntries = new System.Windows.Forms.ListBox();
            this.lbl_EnemyEntries = new System.Windows.Forms.Label();
            this.lb_SeparatorEnemies = new System.Windows.Forms.Label();
            this.combo_Actor = new System.Windows.Forms.ComboBox();
            this.lb_Actor = new System.Windows.Forms.Label();
            this.lb_PosX = new System.Windows.Forms.Label();
            this.tx_PosX = new System.Windows.Forms.TextBox();
            this.tx_PosY = new System.Windows.Forms.TextBox();
            this.lb_PosY = new System.Windows.Forms.Label();
            this.tx_PosZ = new System.Windows.Forms.TextBox();
            this.lb_PosZ = new System.Windows.Forms.Label();
            this.tx_UnknownData = new System.Windows.Forms.TextBox();
            this.lbl_UnknownData = new System.Windows.Forms.Label();
            this.lb_Setupheader = new System.Windows.Forms.Label();
            this.tx_Setupheader = new System.Windows.Forms.TextBox();
            this.tx_Unk = new System.Windows.Forms.TextBox();
            this.lbl_Unk = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabP_Enemies.SuspendLayout();
            this.tabC_Editor.SuspendLayout();
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
            this.openSetupFolderToolStripMenuItem,
            this.openISOToolStripMenuItem,
            this.saveAsWBFSToolStripMenuItem,
            this.saveAsRiivolutionSetupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSetupFolderToolStripMenuItem
            // 
            this.openSetupFolderToolStripMenuItem.Name = "openSetupFolderToolStripMenuItem";
            this.openSetupFolderToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openSetupFolderToolStripMenuItem.Text = "Open...";
            this.openSetupFolderToolStripMenuItem.Click += new System.EventHandler(this.openSetupFolderToolStripMenuItem_Click);
            // 
            // openISOToolStripMenuItem
            // 
            this.openISOToolStripMenuItem.Name = "openISOToolStripMenuItem";
            this.openISOToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openISOToolStripMenuItem.Text = "Extract ISO...";
            this.openISOToolStripMenuItem.Click += new System.EventHandler(this.openISOToolStripMenuItem_Click);
            // 
            // saveAsWBFSToolStripMenuItem
            // 
            this.saveAsWBFSToolStripMenuItem.Name = "saveAsWBFSToolStripMenuItem";
            this.saveAsWBFSToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveAsWBFSToolStripMenuItem.Text = "Pack ISO...";
            this.saveAsWBFSToolStripMenuItem.Visible = false;
            // 
            // saveAsRiivolutionSetupToolStripMenuItem
            // 
            this.saveAsRiivolutionSetupToolStripMenuItem.Name = "saveAsRiivolutionSetupToolStripMenuItem";
            this.saveAsRiivolutionSetupToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveAsRiivolutionSetupToolStripMenuItem.Text = "Save as Riivolution setup...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // checkedlistbox_Stages
            // 
            this.checkedlistbox_Stages.FormattingEnabled = true;
            this.checkedlistbox_Stages.Location = new System.Drawing.Point(13, 57);
            this.checkedlistbox_Stages.Name = "checkedlistbox_Stages";
            this.checkedlistbox_Stages.Size = new System.Drawing.Size(190, 394);
            this.checkedlistbox_Stages.TabIndex = 1;
            this.checkedlistbox_Stages.SelectedIndexChanged += new System.EventHandler(this.checkedlistbox_Stages_SelectedIndexChanged);
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
            this.pb_Progress.Location = new System.Drawing.Point(578, 474);
            this.pb_Progress.Name = "pb_Progress";
            this.pb_Progress.Size = new System.Drawing.Size(145, 23);
            this.pb_Progress.TabIndex = 3;
            // 
            // lbl_Separator
            // 
            this.lbl_Separator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Separator.Location = new System.Drawing.Point(15, 470);
            this.lbl_Separator.Name = "lbl_Separator";
            this.lbl_Separator.Size = new System.Drawing.Size(708, 1);
            this.lbl_Separator.TabIndex = 4;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.Location = new System.Drawing.Point(376, 474);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(196, 23);
            this.lbl_Progress.TabIndex = 5;
            this.lbl_Progress.Text = "Idle";
            this.lbl_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabP_Enemies
            // 
            this.tabP_Enemies.Controls.Add(this.tx_Unk);
            this.tabP_Enemies.Controls.Add(this.lbl_Unk);
            this.tabP_Enemies.Controls.Add(this.tx_Setupheader);
            this.tabP_Enemies.Controls.Add(this.lb_Setupheader);
            this.tabP_Enemies.Controls.Add(this.lbl_UnknownData);
            this.tabP_Enemies.Controls.Add(this.tx_UnknownData);
            this.tabP_Enemies.Controls.Add(this.tx_PosZ);
            this.tabP_Enemies.Controls.Add(this.lb_PosZ);
            this.tabP_Enemies.Controls.Add(this.tx_PosY);
            this.tabP_Enemies.Controls.Add(this.lb_PosY);
            this.tabP_Enemies.Controls.Add(this.tx_PosX);
            this.tabP_Enemies.Controls.Add(this.lb_PosX);
            this.tabP_Enemies.Controls.Add(this.lb_Actor);
            this.tabP_Enemies.Controls.Add(this.combo_Actor);
            this.tabP_Enemies.Controls.Add(this.lb_SeparatorEnemies);
            this.tabP_Enemies.Controls.Add(this.lbl_EnemyEntries);
            this.tabP_Enemies.Controls.Add(this.lst_EnemyEntries);
            this.tabP_Enemies.Location = new System.Drawing.Point(4, 22);
            this.tabP_Enemies.Name = "tabP_Enemies";
            this.tabP_Enemies.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Enemies.Size = new System.Drawing.Size(506, 384);
            this.tabP_Enemies.TabIndex = 0;
            this.tabP_Enemies.Text = "Enemies";
            this.tabP_Enemies.UseVisualStyleBackColor = true;
            // 
            // tabC_Editor
            // 
            this.tabC_Editor.Controls.Add(this.tabP_Enemies);
            this.tabC_Editor.Location = new System.Drawing.Point(209, 41);
            this.tabC_Editor.Name = "tabC_Editor";
            this.tabC_Editor.SelectedIndex = 0;
            this.tabC_Editor.Size = new System.Drawing.Size(514, 410);
            this.tabC_Editor.TabIndex = 6;
            // 
            // lst_EnemyEntries
            // 
            this.lst_EnemyEntries.FormattingEnabled = true;
            this.lst_EnemyEntries.Location = new System.Drawing.Point(6, 71);
            this.lst_EnemyEntries.Name = "lst_EnemyEntries";
            this.lst_EnemyEntries.Size = new System.Drawing.Size(181, 303);
            this.lst_EnemyEntries.TabIndex = 0;
            this.lst_EnemyEntries.SelectedIndexChanged += new System.EventHandler(this.lst_EnemyEntries_SelectedIndexChanged);
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
            // lb_SeparatorEnemies
            // 
            this.lb_SeparatorEnemies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_SeparatorEnemies.Location = new System.Drawing.Point(193, 6);
            this.lb_SeparatorEnemies.Name = "lb_SeparatorEnemies";
            this.lb_SeparatorEnemies.Size = new System.Drawing.Size(1, 371);
            this.lb_SeparatorEnemies.TabIndex = 8;
            // 
            // combo_Actor
            // 
            this.combo_Actor.FormattingEnabled = true;
            this.combo_Actor.Location = new System.Drawing.Point(200, 23);
            this.combo_Actor.Name = "combo_Actor";
            this.combo_Actor.Size = new System.Drawing.Size(169, 21);
            this.combo_Actor.TabIndex = 9;
            // 
            // lb_Actor
            // 
            this.lb_Actor.AutoSize = true;
            this.lb_Actor.Location = new System.Drawing.Point(200, 7);
            this.lb_Actor.Name = "lb_Actor";
            this.lb_Actor.Size = new System.Drawing.Size(35, 13);
            this.lb_Actor.TabIndex = 10;
            this.lb_Actor.Text = "Actor:";
            // 
            // lb_PosX
            // 
            this.lb_PosX.AutoSize = true;
            this.lb_PosX.Location = new System.Drawing.Point(200, 62);
            this.lb_PosX.Name = "lb_PosX";
            this.lb_PosX.Size = new System.Drawing.Size(57, 13);
            this.lb_PosX.TabIndex = 11;
            this.lb_PosX.Text = "Position X:";
            // 
            // tx_PosX
            // 
            this.tx_PosX.Location = new System.Drawing.Point(263, 59);
            this.tx_PosX.Name = "tx_PosX";
            this.tx_PosX.Size = new System.Drawing.Size(106, 20);
            this.tx_PosX.TabIndex = 12;
            // 
            // tx_PosY
            // 
            this.tx_PosY.Location = new System.Drawing.Point(263, 85);
            this.tx_PosY.Name = "tx_PosY";
            this.tx_PosY.Size = new System.Drawing.Size(106, 20);
            this.tx_PosY.TabIndex = 14;
            // 
            // lb_PosY
            // 
            this.lb_PosY.AutoSize = true;
            this.lb_PosY.Location = new System.Drawing.Point(200, 88);
            this.lb_PosY.Name = "lb_PosY";
            this.lb_PosY.Size = new System.Drawing.Size(57, 13);
            this.lb_PosY.TabIndex = 13;
            this.lb_PosY.Text = "Position Y:";
            // 
            // tx_PosZ
            // 
            this.tx_PosZ.Location = new System.Drawing.Point(263, 111);
            this.tx_PosZ.Name = "tx_PosZ";
            this.tx_PosZ.Size = new System.Drawing.Size(106, 20);
            this.tx_PosZ.TabIndex = 16;
            // 
            // lb_PosZ
            // 
            this.lb_PosZ.AutoSize = true;
            this.lb_PosZ.Location = new System.Drawing.Point(200, 114);
            this.lb_PosZ.Name = "lb_PosZ";
            this.lb_PosZ.Size = new System.Drawing.Size(57, 13);
            this.lb_PosZ.TabIndex = 15;
            this.lb_PosZ.Text = "Position Z:";
            // 
            // tx_UnknownData
            // 
            this.tx_UnknownData.Location = new System.Drawing.Point(203, 199);
            this.tx_UnknownData.Multiline = true;
            this.tx_UnknownData.Name = "tx_UnknownData";
            this.tx_UnknownData.Size = new System.Drawing.Size(297, 175);
            this.tx_UnknownData.TabIndex = 17;
            // 
            // lbl_UnknownData
            // 
            this.lbl_UnknownData.AutoSize = true;
            this.lbl_UnknownData.Location = new System.Drawing.Point(200, 183);
            this.lbl_UnknownData.Name = "lbl_UnknownData";
            this.lbl_UnknownData.Size = new System.Drawing.Size(80, 13);
            this.lbl_UnknownData.TabIndex = 18;
            this.lbl_UnknownData.Text = "Unknown data:";
            // 
            // lb_Setupheader
            // 
            this.lb_Setupheader.AutoSize = true;
            this.lb_Setupheader.Location = new System.Drawing.Point(6, 7);
            this.lb_Setupheader.Name = "lb_Setupheader";
            this.lb_Setupheader.Size = new System.Drawing.Size(92, 13);
            this.lb_Setupheader.TabIndex = 19;
            this.lb_Setupheader.Text = "Unknown header:";
            // 
            // tx_Setupheader
            // 
            this.tx_Setupheader.Location = new System.Drawing.Point(6, 24);
            this.tx_Setupheader.Name = "tx_Setupheader";
            this.tx_Setupheader.Size = new System.Drawing.Size(181, 20);
            this.tx_Setupheader.TabIndex = 20;
            // 
            // tx_Unk
            // 
            this.tx_Unk.Location = new System.Drawing.Point(263, 137);
            this.tx_Unk.Name = "tx_Unk";
            this.tx_Unk.Size = new System.Drawing.Size(106, 20);
            this.tx_Unk.TabIndex = 22;
            // 
            // lbl_Unk
            // 
            this.lbl_Unk.AutoSize = true;
            this.lbl_Unk.Location = new System.Drawing.Point(200, 140);
            this.lbl_Unk.Name = "lbl_Unk";
            this.lbl_Unk.Size = new System.Drawing.Size(30, 13);
            this.lbl_Unk.TabIndex = 21;
            this.lbl_Unk.Text = "Unk:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 507);
            this.Controls.Add(this.tabC_Editor);
            this.Controls.Add(this.lbl_Progress);
            this.Controls.Add(this.lbl_Separator);
            this.Controls.Add(this.pb_Progress);
            this.Controls.Add(this.lbl_Stages);
            this.Controls.Add(this.checkedlistbox_Stages);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Super Paper Mario Level Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabP_Enemies.ResumeLayout(false);
            this.tabP_Enemies.PerformLayout();
            this.tabC_Editor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openISOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSetupFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsRiivolutionSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsWBFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedlistbox_Stages;
        private System.Windows.Forms.Label lbl_Stages;
        private System.Windows.Forms.ProgressBar pb_Progress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
        private System.Windows.Forms.TextBox tx_Setupheader;
        private System.Windows.Forms.Label lb_Setupheader;
        private System.Windows.Forms.Label lbl_UnknownData;
        private System.Windows.Forms.TextBox tx_UnknownData;
        private System.Windows.Forms.TextBox tx_PosZ;
        private System.Windows.Forms.Label lb_PosZ;
        private System.Windows.Forms.TextBox tx_PosY;
        private System.Windows.Forms.Label lb_PosY;
        private System.Windows.Forms.TextBox tx_PosX;
        private System.Windows.Forms.Label lb_PosX;
        private System.Windows.Forms.Label lb_Actor;
        private System.Windows.Forms.ComboBox combo_Actor;
        private System.Windows.Forms.TextBox tx_Unk;
        private System.Windows.Forms.Label lbl_Unk;
    }
}

