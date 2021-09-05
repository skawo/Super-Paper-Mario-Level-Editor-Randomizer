namespace Super_Paper_Mario_Randomizer
{
    partial class PresetEditor
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
            this.checkedlstbox_enemies = new System.Windows.Forms.CheckedListBox();
            this.lbl_enemiestorandoin = new System.Windows.Forms.Label();
            this.btnTglBosses = new System.Windows.Forms.Button();
            this.btnTglWeird = new System.Windows.Forms.Button();
            this.lbxChapterDifficultyChart = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tglAll = new System.Windows.Forms.Button();
            this.tglObst = new System.Windows.Forms.Button();
            this.Chapter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Allowed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstChapterDifficultyChart = new System.Windows.Forms.ListView();
            this.numMaxDif = new System.Windows.Forms.NumericUpDown();
            this.lbl_MaxDiff = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDif)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedlstbox_enemies
            // 
            this.checkedlstbox_enemies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedlstbox_enemies.FormattingEnabled = true;
            this.checkedlstbox_enemies.Location = new System.Drawing.Point(12, 40);
            this.checkedlstbox_enemies.Name = "checkedlstbox_enemies";
            this.checkedlstbox_enemies.Size = new System.Drawing.Size(190, 424);
            this.checkedlstbox_enemies.TabIndex = 2;
            // 
            // lbl_enemiestorandoin
            // 
            this.lbl_enemiestorandoin.AutoSize = true;
            this.lbl_enemiestorandoin.Location = new System.Drawing.Point(12, 24);
            this.lbl_enemiestorandoin.Name = "lbl_enemiestorandoin";
            this.lbl_enemiestorandoin.Size = new System.Drawing.Size(124, 13);
            this.lbl_enemiestorandoin.TabIndex = 3;
            this.lbl_enemiestorandoin.Text = "Enemies to randomize in:";
            // 
            // btnTglBosses
            // 
            this.btnTglBosses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTglBosses.Location = new System.Drawing.Point(12, 499);
            this.btnTglBosses.Name = "btnTglBosses";
            this.btnTglBosses.Size = new System.Drawing.Size(190, 23);
            this.btnTglBosses.TabIndex = 4;
            this.btnTglBosses.Tag = "t";
            this.btnTglBosses.Text = "Toggle bosses";
            this.btnTglBosses.UseVisualStyleBackColor = true;
            this.btnTglBosses.Click += new System.EventHandler(this.BtnTglBosses_Click);
            // 
            // btnTglWeird
            // 
            this.btnTglWeird.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTglWeird.Location = new System.Drawing.Point(12, 528);
            this.btnTglWeird.Name = "btnTglWeird";
            this.btnTglWeird.Size = new System.Drawing.Size(190, 23);
            this.btnTglWeird.TabIndex = 5;
            this.btnTglWeird.Tag = "t";
            this.btnTglWeird.Text = "Toggle crashing / weird";
            this.btnTglWeird.UseVisualStyleBackColor = true;
            this.btnTglWeird.Click += new System.EventHandler(this.BtnTglWeird_Click);
            // 
            // lbxChapterDifficultyChart
            // 
            this.lbxChapterDifficultyChart.AutoSize = true;
            this.lbxChapterDifficultyChart.Location = new System.Drawing.Point(214, 24);
            this.lbxChapterDifficultyChart.Name = "lbxChapterDifficultyChart";
            this.lbxChapterDifficultyChart.Size = new System.Drawing.Size(85, 13);
            this.lbxChapterDifficultyChart.TabIndex = 7;
            this.lbxChapterDifficultyChart.Text = "Chapter difficulty";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // tglAll
            // 
            this.tglAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tglAll.Location = new System.Drawing.Point(12, 470);
            this.tglAll.Name = "tglAll";
            this.tglAll.Size = new System.Drawing.Size(190, 23);
            this.tglAll.TabIndex = 11;
            this.tglAll.Tag = "t";
            this.tglAll.Text = "Toggle all";
            this.tglAll.UseVisualStyleBackColor = true;
            this.tglAll.Click += new System.EventHandler(this.TglAll_Click);
            // 
            // tglObst
            // 
            this.tglObst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tglObst.Location = new System.Drawing.Point(12, 557);
            this.tglObst.Name = "tglObst";
            this.tglObst.Size = new System.Drawing.Size(190, 23);
            this.tglObst.TabIndex = 12;
            this.tglObst.Tag = "t";
            this.tglObst.Text = "Toggle obstacles";
            this.tglObst.UseVisualStyleBackColor = true;
            this.tglObst.Click += new System.EventHandler(this.TglObst_Click);
            // 
            // Chapter
            // 
            this.Chapter.Text = "Chapter";
            this.Chapter.Width = 100;
            // 
            // Allowed
            // 
            this.Allowed.Text = "Allowed difficulty";
            this.Allowed.Width = 90;
            // 
            // lstChapterDifficultyChart
            // 
            this.lstChapterDifficultyChart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Chapter,
            this.Allowed});
            this.lstChapterDifficultyChart.FullRowSelect = true;
            this.lstChapterDifficultyChart.GridLines = true;
            this.lstChapterDifficultyChart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstChapterDifficultyChart.HideSelection = false;
            this.lstChapterDifficultyChart.Location = new System.Drawing.Point(217, 40);
            this.lstChapterDifficultyChart.MultiSelect = false;
            this.lstChapterDifficultyChart.Name = "lstChapterDifficultyChart";
            this.lstChapterDifficultyChart.Size = new System.Drawing.Size(202, 424);
            this.lstChapterDifficultyChart.TabIndex = 6;
            this.lstChapterDifficultyChart.UseCompatibleStateImageBehavior = false;
            this.lstChapterDifficultyChart.View = System.Windows.Forms.View.Details;
            this.lstChapterDifficultyChart.SelectedIndexChanged += new System.EventHandler(this.LstChapterDifficultyChart_SelectedIndexChanged);
            // 
            // numMaxDif
            // 
            this.numMaxDif.Enabled = false;
            this.numMaxDif.Location = new System.Drawing.Point(350, 470);
            this.numMaxDif.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numMaxDif.Name = "numMaxDif";
            this.numMaxDif.Size = new System.Drawing.Size(69, 20);
            this.numMaxDif.TabIndex = 13;
            this.numMaxDif.ValueChanged += new System.EventHandler(this.NumMaxDif_ValueChanged);
            // 
            // lbl_MaxDiff
            // 
            this.lbl_MaxDiff.AutoSize = true;
            this.lbl_MaxDiff.Location = new System.Drawing.Point(273, 475);
            this.lbl_MaxDiff.Name = "lbl_MaxDiff";
            this.lbl_MaxDiff.Size = new System.Drawing.Size(71, 13);
            this.lbl_MaxDiff.TabIndex = 14;
            this.lbl_MaxDiff.Text = "Max difficulty:";
            // 
            // PresetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 591);
            this.Controls.Add(this.lbl_MaxDiff);
            this.Controls.Add(this.numMaxDif);
            this.Controls.Add(this.tglObst);
            this.Controls.Add(this.tglAll);
            this.Controls.Add(this.lbxChapterDifficultyChart);
            this.Controls.Add(this.lstChapterDifficultyChart);
            this.Controls.Add(this.btnTglWeird);
            this.Controls.Add(this.btnTglBosses);
            this.Controls.Add(this.lbl_enemiestorandoin);
            this.Controls.Add(this.checkedlstbox_enemies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PresetEditor";
            this.Text = "Preset editor";
            this.Load += new System.EventHandler(this.PresetEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedlstbox_enemies;
        private System.Windows.Forms.Label lbl_enemiestorandoin;
        private System.Windows.Forms.Button btnTglBosses;
        private System.Windows.Forms.Button btnTglWeird;
        private System.Windows.Forms.Label lbxChapterDifficultyChart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button tglAll;
        private System.Windows.Forms.Button tglObst;
        private System.Windows.Forms.ColumnHeader Chapter;
        private System.Windows.Forms.ColumnHeader Allowed;
        private System.Windows.Forms.ListView lstChapterDifficultyChart;
        private System.Windows.Forms.NumericUpDown numMaxDif;
        private System.Windows.Forms.Label lbl_MaxDiff;
    }
}