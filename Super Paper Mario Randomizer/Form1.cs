﻿using BitConverter;
using Newtonsoft.Json;
using Super_Paper_Mario_Randomizer.Common;
using Super_Paper_Mario_Randomizer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Paper_Mario_Randomizer
{
    public partial class Form1 : Form
    {
        private readonly SynchronizationContext synchronizationContext;
        readonly ToolTip Tip = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            this.synchronizationContext = SynchronizationContext.Current;

            Tip.AutoPopDelay = 5000;
            Tip.InitialDelay = 500;
            Tip.ReshowDelay = 500;

            chk_RandomSeed.Checked = true;
            NewSeed();

            if (File.Exists(Globals.EnemyJsonPath))
            {
                Globals.EnemyList = (List<Enemy>)Helpers.DeserializeJsonFromFile(Globals.EnemyJsonPath, typeof(List<Enemy>));

                foreach (Enemy e in Globals.EnemyList)
                    combo_Actor.Items.Add(e);
            }

            if (File.Exists(Globals.StageJsonPath))
                Globals.StageInfoList = (List<StageInfo>)Helpers.DeserializeJsonFromFile(Globals.StageJsonPath, typeof(List<StageInfo>));
        }

        #region ProgressBar

        private void SetBusy(bool Busy)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                container.Panel1.Enabled = !Busy;
            }), Busy);
        }

        private void SetProgress(string Msg = "", int Percent = -1)
        {
            if (Msg != "")
                SetProgressMessage(Msg);

            if (Percent != -1)
                SetProgressVal(Percent);
        }

        private void SetProgressMessage(string Msg)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                lbl_Progress.Text = Msg;
            }), Msg);
        }

        private void SetProgressVal(int Percent)
        {
            if (Percent < pb_Progress.Minimum || Percent > pb_Progress.Maximum)
                return;

            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                pb_Progress.Value = Percent;
            }), Percent);
        }

        #endregion

        #region ISO

        private async Task<bool> PackISO(string InPath, string OutFile)
        {
            SetBusy(true);
            SetProgress(Resources.saving_iso, 0);
            bool Res = await Task.Run(() => PackIsoImpl(InPath, OutFile));
            SetProgress(Resources.done, 100);
            SetBusy(false);

            return Res;
        }

        private bool PackIsoImpl(string InPath, string OutFile)
        {
            try
            {
                if (File.Exists(OutFile))
                    File.Delete(OutFile);

                bool Res = false;

                Thread th = new Thread(() => { Res = Wit.PackISO(InPath, OutFile); });
                th.Start();

                int i = 0;

                while (th.IsAlive)
                {
                    i++;
                    SetProgressVal(i);
                    Thread.Sleep(100);
                }

                if (Res == false)
                {
                    MessageBox.Show(Resources.saving_err);
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private async Task<bool> ExtractISO(string InFile, string OutPath)
        {
            SetBusy(true);
            SetProgress(Resources.extracting_iso, 0);
            bool Res = await Task.Run(() => ExtractISOImpl(InFile, OutPath));
            SetProgress(Resources.done, 100);
            SetBusy(false);

            return Res;
        }

        private bool ExtractISOImpl(string InFile, string OutPath)
        {
            try
            {
                int FileNum = Wit.GetNumFiles(InFile);

                if (FileNum == -1)
                {
                    MessageBox.Show(Resources.err_extract_failed);
                    return false;
                }

                if (Directory.Exists(OutPath))
                    Helpers.DeleteDirectory(OutPath);

                bool Res = false;

                Thread th = new Thread(() => { Res = Wit.UnpackISO(InFile, OutPath); });
                th.Start();

                while (th.IsAlive)
                {
                    if (Directory.Exists(OutPath))
                    {
                        int FileC = Directory.GetFiles(OutPath, "*", SearchOption.AllDirectories).Count();
                        int Percent = (int)(((decimal)FileC / (decimal)FileNum) * 100);
                        SetProgressVal(Percent);
                    }

                    Thread.Sleep(100);
                }

                if (Res == false)
                {
                    MessageBox.Show(Resources.err_extract_failed);
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion

        #region Load

        private async Task<bool> LoadFolder(string Path)
        {
            SetBusy(true);
            SetProgress(Resources.loading_stages, 0);
            bool Res = await Task.Run(() => LoadStages(Path));
            SetProgress(Resources.done, 0);
            SetBusy(false);

            return Res;
        }

        private bool LoadStages(string Path)
        {
            try
            {
                Globals.LevelSetups.Clear();
                string[] Files = Directory.GetFiles(Path);

                int i = 0;

                foreach (string File in Files)
                {
                    if (LevelSetupEntry.IsValid(File))
                    {
                        Globals.LevelSetups.Add(new LevelSetupEntry(File));

                        i++;
                        int Percent = (int)(((decimal)i / (decimal)(Files.Count())) * 100);
                        SetProgressVal(Percent);
                    }
                }

                string f = "";

                foreach (LevelSetupEntry e in Globals.LevelSetups)
                {
                    FileInfo fi = new FileInfo(e.FilePath);

                    f += e.Entries.Count() + ", " + System.BitConverter.ToString(e.Header) + ", " + fi.Length + Environment.NewLine;

                }

                File.WriteAllText("test.txt", f);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion

        #region Save

        private async Task<bool> SaveAll()
        {
            SetBusy(true);
            SetProgress(Resources.saving_sages, 0);
            bool Res = await Task.Run(() => SaveEntries());
            SetProgress(Resources.done, 100);
            SetBusy(false);

            return Res;
        }

        private bool SaveEntries()
        {
            try
            {
                int i = 0;

                foreach (LevelSetupEntry Entry in Globals.LevelSetups)
                {
                    SaveEntry(Entry);

                    i++;
                    int Percent = (int)(((decimal)i / (decimal)(Globals.LevelSetups.Count())) * 100);
                    SetProgressVal(Percent);
                }

                Globals.LoadedStagesJsonHash = Helpers.GetStringSHA1OfString(JsonConvert.SerializeObject(Globals.LevelSetups));

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool SaveEntry(LevelSetupEntry Entry)
        {
            try
            {
                File.WriteAllBytes(Entry.FilePath, Entry.ToBytes());
                Globals.LoadedStagesJsonHash = Helpers.GetStringSHA1OfString(JsonConvert.SerializeObject(Globals.LevelSetups));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion

        private async void ExtractISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string InFile = "";
            string OutPath = "";

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Title = Resources.select_spm_iso;
                fd.Filter = Resources.isoselect_filter;
                DialogResult dr = fd.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    byte[] ISOID = ByteOps.GetNumBytes(3, 0, fd.FileName);

                    if (Encoding.ASCII.GetString(ISOID) != Resources.spm_titlecode)
                    {
                        if (MessageBox.Show(Resources.not_spm_iso, Resources.not_spm_iso_title, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            InFile = fd.FileName;
                        else
                            return;
                    }
                    else
                        InFile = fd.FileName;

                    using (FolderBrowserDialog fb = new FolderBrowserDialog())
                    {
                        fb.Description = Resources.select_iso_extract_dir;
                        fb.ShowNewFolderButton = false;
                        DialogResult drsf = fb.ShowDialog();

                        if (drsf == DialogResult.OK)
                        {
                            OutPath = Path.Combine(fb.SelectedPath, Encoding.ASCII.GetString(ByteOps.GetNumBytes(6, 0, fd.FileName)));

                            if (!Directory.Exists(OutPath) || MessageBox.Show(Resources.folder_will_be_overwritten, Resources.folder_will_be_overwritten_title, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                await ExtractISO(InFile, OutPath);
                            }
                        }
                    }
                }
            }
        }

        private async void OpenSetupFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fb = new FolderBrowserDialog())
                {
                    fb.ShowNewFolderButton = false;
                    fb.Description = Resources.select_setup_folder;
                    DialogResult dr = fb.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        await LoadFolder(fb.SelectedPath);

                        lstbox_Stages.Items.Clear();

                        foreach (LevelSetupEntry Setup in Globals.LevelSetups)
                            lstbox_Stages.Items.Add(Setup);

                        Globals.LoadedStagesJsonHash = Helpers.GetStringSHA1OfString(JsonConvert.SerializeObject(Globals.LevelSetups));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Checkedlistbox_Stages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstbox_Stages.SelectedIndex < 0 || lstbox_Stages.SelectedIndex > lstbox_Stages.Items.Count)
                    return;
                else
                {
                    Globals.CurrentLevelSetupEntry = (LevelSetupEntry)lstbox_Stages.Items[lstbox_Stages.SelectedIndex];

                    lst_EnemyEntries.SelectedIndex = -1;
                    lst_EnemyEntries.Items.Clear();

                    foreach (LevelSetupEntryEntry Entry in Globals.CurrentLevelSetupEntry.Entries)
                        lst_EnemyEntries.Items.Add(Entry);

                    tx_Setupheader.SetBytes(Globals.CurrentLevelSetupEntry.Header);

                    if (lst_EnemyEntries.Items.Count != 0)
                        lst_EnemyEntries.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void SetHeaderExclusive(SPMDefs.HeaderSize Header, bool Enable)
        {
            switch (Header)
            {
                case SPMDefs.HeaderSize.HEADER_SIZE_1:
                    {
                        lbl_Header1Unk.Visible = Enable;
                        tx_Header1Unk.Visible = Enable;
                        tx_Header1Unk.SetBytes(Globals.CurrentLevelSetupEntryEntry.Unknown_Header1);
                        break;
                    }
                default: break;
            }
        }

        private void ShowHideHeaderExclusive(SPMDefs.HeaderSize CurrHeader)
        {
            foreach (SPMDefs.HeaderSize h in Enum.GetValues(typeof(SPMDefs.HeaderSize)))
            {
                if (h != CurrHeader)
                    SetHeaderExclusive(h, false);
                else
                    SetHeaderExclusive(h, true);
            }
        }

        private void Lst_EnemyEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lst_EnemyEntries.SelectedIndex < 0 || lst_EnemyEntries.SelectedIndex > lst_EnemyEntries.Items.Count)
                    pn_EnemyEditor.Enabled = false;
                else
                {
                    pn_EnemyEditor.Enabled = true;

                    Globals.CurrentLevelSetupEntryEntry = (LevelSetupEntryEntry)lst_EnemyEntries.Items[lst_EnemyEntries.SelectedIndex];

                    ShowHideHeaderExclusive((SPMDefs.HeaderSize)Globals.CurrentLevelSetupEntry.Header[1]);

                    numUp_X.Value = (decimal)Globals.CurrentLevelSetupEntryEntry.PosX;
                    numUp_Y.Value = (decimal)Globals.CurrentLevelSetupEntryEntry.PosY;
                    numUp_Z.Value = (decimal)Globals.CurrentLevelSetupEntryEntry.PosZ;

                    tx_UnknownData.SetBytes(Globals.CurrentLevelSetupEntryEntry.Unknown);

                    Enemy en = Globals.EnemyList.Find(x => x.ID == Globals.CurrentLevelSetupEntryEntry.ID);

                    lbl_ActorID.Text = Globals.CurrentLevelSetupEntryEntry.ID.ToString();

                    if (en != null)
                    {
                        combo_Actor.SelectedItem = en;

                        if (en.Description != "")
                        {
                            picturebox_info.Visible = true;
                            Tip.SetToolTip(this.picturebox_info, en.Description);
                        }
                        else
                        {
                            picturebox_info.Visible = false;
                        }
                    }
                    else
                        combo_Actor.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Bytetx_Changed(object sender, EventArgs e)
        {
            if (Globals.CurrentLevelSetupEntry == null)
                return;

            if (Globals.CurrentLevelSetupEntryEntry == null)
                return;

            switch ((sender as ByteTextbox).Tag)
            {
                case "unkd": Globals.CurrentLevelSetupEntryEntry.Unknown = (sender as ByteTextbox).GetBytes(); break;
                case "header": Globals.CurrentLevelSetupEntry.Header = (sender as ByteTextbox).GetBytes(); break;
                case "header1unk": Globals.CurrentLevelSetupEntryEntry.Unknown_Header1 = (sender as ByteTextbox).GetBytes(); break;
            }
        }

        private void NumUp_X_ValueChanged(object sender, EventArgs e)
        {
            if (Globals.CurrentLevelSetupEntry == null)
                return;

            if (Globals.CurrentLevelSetupEntryEntry == null)
                return;

            switch ((sender as NumericUpDown).Tag)
            {
                case "X": Globals.CurrentLevelSetupEntryEntry.PosX = (Int16)(sender as NumericUpDown).Value; break;
                case "Y": Globals.CurrentLevelSetupEntryEntry.PosY = (Int16)(sender as NumericUpDown).Value; break;
                case "Z": Globals.CurrentLevelSetupEntryEntry.PosZ = (Int16)(sender as NumericUpDown).Value; break;
            }
        }

        private void Combo_Actor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Globals.CurrentLevelSetupEntry == null)
                return;

            if (Globals.CurrentLevelSetupEntryEntry == null)
                return;

            Enemy en = (Enemy)combo_Actor.SelectedItem;
            Globals.CurrentLevelSetupEntryEntry.ID = (uint)en.ID;

            lst_EnemyEntries.Items[lst_EnemyEntries.SelectedIndex] = Globals.CurrentLevelSetupEntryEntry;
        }

        private bool FilesChanged()
        {
            return Globals.LevelSetups.Count != 0 && Helpers.GetStringSHA1OfString(JsonConvert.SerializeObject(Globals.LevelSetups)) != Globals.LoadedStagesJsonHash;
        }

        private async Task<DialogResult> AskToSaveFilesIfChanged()
        {
            DialogResult dr = DialogResult.None;

            if (FilesChanged())
            {
                dr = MessageBox.Show(Resources.files_changed_save, Resources.alert, MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    bool Ret = await SaveAll();

                    if (Ret)
                        return dr;
                    else
                        return DialogResult.Cancel;
                }
            }

            return dr;
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = await AskToSaveFilesIfChanged();

            if (dr == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SaveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await SaveAll();
        }

        private void SaveCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentLevelSetupEntry == null)
                return;

            SaveEntry(Globals.CurrentLevelSetupEntry);
        }

        private void OpenSetupFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    fd.Title = Resources.select_setup_file;
                    DialogResult dr = fd.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        if (!LevelSetupEntry.IsValid(fd.FileName))
                            throw new Exception(Resources.setup_file_invalid);

                        Globals.LevelSetups.Clear();
                        Globals.LevelSetups.Add(new LevelSetupEntry(fd.FileName));

                        lstbox_Stages.Items.Clear();

                        foreach (LevelSetupEntry Setup in Globals.LevelSetups)
                            lstbox_Stages.Items.Add(Setup);

                        Globals.LoadedStagesJsonHash = Helpers.GetStringSHA1OfString(JsonConvert.SerializeObject(Globals.LevelSetups));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Super Paper Mario Level Editor / Randomizer by Skawo.");
        }

        private async void SaveAsWBFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string InPath = "";
            string OutFile = "";

            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                fd.Description = Resources.select_exported;
                fd.ShowNewFolderButton = false;

                DialogResult dr = fd.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    InPath = fd.SelectedPath;

                    string[] Files = Directory.GetDirectories(InPath);
                    bool found = false;

                    foreach (string f in Files)
                    {
                        if (f.EndsWith("DATA") || f.EndsWith("disc"))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        MessageBox.Show(Resources.data_not_found);
                        return;
                    }

                    if (!File.Exists(Path.Combine(InPath, "DATA", "align-files.txt")) && !File.Exists(Path.Combine(InPath, "align-files.txt")))
                    {
                        MessageBox.Show(Resources.no_align_files);
                        return;
                    }


                    using (SaveFileDialog sf = new SaveFileDialog())
                    {
                        sf.Title = Resources.select_outf;
                        sf.Filter = Resources.isoselect_filter;

                        DialogResult drsf = sf.ShowDialog();

                        if (drsf == DialogResult.OK)
                        {
                            OutFile = Path.Combine(sf.FileName);

                            if (!File.Exists(OutFile) || MessageBox.Show(Resources.file_will_be_overwritten, Resources.file_will_be_overwritten_title, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                await PackISO(InPath, OutFile);
                            }
                        }
                    }
                }
            }
        }

        private void PresetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresetEditor pe = new PresetEditor();
            pe.ShowDialog();
        }

        private async void RandomizeWithPresetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int integerSeed = 0;

                try
                {
                    if (chk_RandomSeed.Checked)
                        NewSeed();

                    integerSeed = Convert.ToInt32(tx_Random.Text.ToUpper(), 16);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.seed_wrong);
                    return;
                }


                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    fd.Title = Resources.select_preset;
                    DialogResult dr = fd.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        Common.Preset pr = (Common.Preset)Helpers.DeserializeJsonFromFile(fd.FileName, typeof(Common.Preset));
                        await Randomize(pr, integerSeed);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private async Task<bool> Randomize(Preset Pr, int Seed)
        {
            SetBusy(true);
            SetProgress(Resources.randomizing, 0);

            Random r = new Random((int)Seed);

            bool Res = await Task.Run(() => RandomizeImpl(Pr, r));
            SetProgress(Resources.done, 100);
            SetBusy(false);

            return Res;
        }

        private bool RandomizeImpl(Preset Pr, Random r)
        {
            try
            {
                int NumStages = Globals.LevelSetups.Count();
                int Num = -1;

                foreach (LevelSetupEntry Setup in Globals.LevelSetups)
                {
                    Num++;
                    int Percent = (int)(((decimal)Num / (decimal)NumStages) * 100);
                    SetProgressVal(Percent);

                    if (Setup.Info == null || Setup.Info.Chapter == 0 || !Setup.Info.Randomize)
                        continue;

                    int Chapter = Setup.Info.Chapter;

                    int MaxDifficulty = Pr.ChapterDiffs[Chapter - 1];

                    List<Enemy> Enemies = Globals.EnemyList.Where(x => (x.Difficulty <= MaxDifficulty && Pr.Enemies[x.ID] == true)).ToList();

                    foreach (LevelSetupEntryEntry Entry in Setup.Entries)
                    {
                        if (Entry.ID != 0)
                            if (Enemies.Count == 0)
                                Entry.ID = 0;
                            else
                                Entry.ID = (uint)Enemies[r.Next(Enemies.Count)].ID;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void NewSeed()
        {
            tx_Random.Text = (Int16.MaxValue + (Environment.TickCount * Environment.TickCount) / 2).ToString("X");
        }

        private void Btn_GenerateSeed_Click(object sender, EventArgs e)
        {
            NewSeed();
        }

        private void Chk_RandomSeed_CheckedChanged(object sender, EventArgs e)
        {
            tx_Random.ReadOnly = chk_RandomSeed.Checked;
        }
    }
}
