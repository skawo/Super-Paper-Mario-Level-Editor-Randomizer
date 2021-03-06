﻿using System;
using Super_Paper_Mario_Randomizer.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Super_Paper_Mario_Randomizer.Common;

namespace Super_Paper_Mario_Randomizer
{
    public partial class PresetEditor : Form
    {
        string Opened = "";

        public PresetEditor()
        {
            InitializeComponent();

            foreach (Enemy en in Globals.EnemyList)
                checkedlstbox_enemies.Items.Add(en.Name + " {" + en.Difficulty + "} ");

            for (int i = 1; i < 9; i++)
            {
                ListViewItem item = new ListViewItem(new string[] { "Chapter " + i, "0" });
                lstChapterDifficultyChart.Items.Add(item);
            }
        }

        private void tglAll_Click(object sender, EventArgs e)
        {
            string t = (string)tglAll.Tag;

            for (int i = 0; i < checkedlstbox_enemies.Items.Count; i++)
                checkedlstbox_enemies.SetItemChecked(i, t == "t");

            tglAll.Tag = t == "t" ? "f" : "t";
        }

        private void PresetEditor_Load(object sender, EventArgs e)
        {

        }

        private void btnTglBosses_Click(object sender, EventArgs e)
        {
            string t = (string)btnTglBosses.Tag;

            for (int i = 0; i < checkedlstbox_enemies.Items.Count; i++)
            {
                Enemy en = Globals.EnemyList[i];

                if (en.Boss)
                    checkedlstbox_enemies.SetItemChecked(i, t == "t");
            }

            btnTglBosses.Tag = t == "t" ? "f" : "t";
        }

        private void btnTglWeird_Click(object sender, EventArgs e)
        {
            string t = (string)btnTglWeird.Tag;

            for (int i = 0; i < checkedlstbox_enemies.Items.Count; i++)
            {
                Enemy en = Globals.EnemyList[i];

                if (en.Weird)
                    checkedlstbox_enemies.SetItemChecked(i, t == "t");
            }

            btnTglWeird.Tag = t == "t" ? "f" : "t";
        }

        private void tglObst_Click(object sender, EventArgs e)
        {
            string t = (string)tglObst.Tag;

            for (int i = 0; i < checkedlstbox_enemies.Items.Count; i++)
            {
                Enemy en = Globals.EnemyList[i];

                if (en.Obstacle)
                    checkedlstbox_enemies.SetItemChecked(i, t == "t");
            }

            tglObst.Tag = t == "t" ? "f" : "t";
        }

        private void lstChapterDifficultyChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstChapterDifficultyChart.SelectedItems.Count == 0)
            {
                numMaxDif.Enabled = false;
                return;
            }
            else
            {
                numMaxDif.Value = Convert.ToInt32(lstChapterDifficultyChart.SelectedItems[0].SubItems[1].Text);
                numMaxDif.Enabled = true;
            }
        }

        private void numMaxDif_ValueChanged(object sender, EventArgs e)
        {
            if (lstChapterDifficultyChart.SelectedItems.Count == 0)
                return;

            lstChapterDifficultyChart.SelectedItems[0].SubItems[1].Text = numMaxDif.Value.ToString();
        }

        private Preset GetPresetFromCurrent()
        {
            Preset pr = new Preset();
            
            for (int i= 0; i < checkedlstbox_enemies.Items.Count; i++)
            {
                CheckState ch = checkedlstbox_enemies.GetItemCheckState(i);
                pr.Enemies[i] = (ch == CheckState.Checked) ? true : false;
            }

            for (int i = 0; i < 8; i++)
                pr.ChapterDiffs[i] = Convert.ToInt32(lstChapterDifficultyChart.Items[i].SubItems[1].Text);

            return pr;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Title = Resources.select_outf;
                sf.Filter = Resources.presetsf_filter;

                DialogResult dr = sf.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Helpers.SerializeJsonToFile(GetPresetFromCurrent(), sf.FileName);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Title = Resources.select_preset;
                DialogResult dr = fd.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        Preset pr = (Preset)Helpers.DeserializeJsonFromFile(fd.FileName, typeof(Preset));

                        for (int i = 0; i < checkedlstbox_enemies.Items.Count; i++)
                            checkedlstbox_enemies.SetItemChecked(i, pr.Enemies[i]);

                        for (int i = 0; i < lstChapterDifficultyChart.Items.Count; i++)
                            lstChapterDifficultyChart.Items[i].SubItems[1].Text = pr.ChapterDiffs[i].ToString();

                        Opened = fd.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Opened == "")
                saveAsToolStripMenuItem_Click(null, null);
            else
                Helpers.SerializeJsonToFile(GetPresetFromCurrent(), Opened);
        }
    }
}
