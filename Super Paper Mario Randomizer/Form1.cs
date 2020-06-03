using Super_Paper_Mario_Randomizer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Super_Paper_Mario_Randomizer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(Globals.EnemyJsonPath))
            {
                Globals.EnemyList = (List<Enemy>)Helpers.DeserializeJsonFromFile(Globals.EnemyJsonPath, typeof(List<Enemy>));

                foreach (Enemy e in Globals.EnemyList)
                    combo_Actor.Items.Add(e);

                int last = -1;

                foreach (Enemy e in Globals.EnemyList)
                {
                    if (e.ID != last + 1)
                        MessageBox.Show(e.Name + e.ID);


                    else
                        last = e.ID;
                }
            }
        }

        #region Extract ISO Option

        string OutPath = "";
        string InFile = "";
        int FileNum = 0;

        private void openISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                        MessageBox.Show(Resources.not_spm_iso);
                        return;
                    }
                    else
                        InFile = fd.FileName;

                    FileNum = Wit.GetNumFiles(InFile);

                    if (FileNum == -1)
                    {
                        MessageBox.Show(Resources.err_extract_failed);
                        return;
                    }

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
                                if (Directory.Exists(OutPath))
                                    Directory.Delete(OutPath, true);

                                SetProgress("Extracting " + FileNum + " files...", 0);

                                BackgroundWorker WkrCheckExtractProgress = new BackgroundWorker();
                                WkrCheckExtractProgress.WorkerReportsProgress = true;
                                WkrCheckExtractProgress.DoWork += WkrCheckExtractProgress_DoWork;
                                WkrCheckExtractProgress.ProgressChanged += Workers_ProgressChanged;
                                WkrCheckExtractProgress.RunWorkerCompleted += Workers_Complete;
                                WkrCheckExtractProgress.RunWorkerAsync(10000);
                            }
                        }
                    }
                }
            }
        }

        private void WkrCheckExtractProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            bool Res = false;

            Thread th = new Thread(() => { Res = Wit.UnpackISO(InFile, OutPath); });
            th.Start();

            while (th.IsAlive)
            {
                if (Directory.Exists(OutPath))
                {
                    int FileC = Directory.GetFiles(OutPath, "*", SearchOption.AllDirectories).Count();
                    int Percent = (int)(((decimal)FileC / (decimal)FileNum) * 100);
                    (sender as BackgroundWorker).ReportProgress(Percent);
                }

                Thread.Sleep(100);
            }

            if (Res == false)
            {
                MessageBox.Show(Resources.err_extract_failed);
                return;
            }
        }

        #endregion

        #region ProgressBar

        private void SetProgress(string Msg = "", int Percent = -1)
        {
            if (Msg != "")
                SetProgressMessage(Msg);

            if (Percent != -1)
                SetProgressVal(Percent);
        }

        private void SetProgressMessage(string Msg)
        {
            lbl_Progress.Text = Msg;
            lbl_Progress.Update();
        }

        private void SetProgressVal(int Percent)
        {
            if (Percent < pb_Progress.Minimum || Percent > pb_Progress.Maximum)
                return;

            pb_Progress.Value = Percent;
            pb_Progress.Update();
        }

        private void Workers_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            SetProgress(Resources.done, 100);
        }

        private void Workers_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SetProgressVal(e.ProgressPercentage);
        }

        #endregion

        private void openSetupFolderToolStripMenuItem_Click(object sender, EventArgs e)
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
                        SetProgress(Resources.loading_stages, 0);

                        BackgroundWorker WkrLoadStagesProgress = new BackgroundWorker();
                        WkrLoadStagesProgress.WorkerReportsProgress = true;
                        WkrLoadStagesProgress.DoWork += WkrLoadStagesProgress_DoWork;
                        WkrLoadStagesProgress.ProgressChanged += Workers_ProgressChanged;
                        WkrLoadStagesProgress.RunWorkerCompleted += WkrLoadStagesProgress_RunWorkerCompleted; ;
                        WkrLoadStagesProgress.RunWorkerAsync(fb.SelectedPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void WkrLoadStagesProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            checkedlistbox_Stages.Items.Clear();

            foreach (LevelSetupEntry Setup in Globals.LevelSetups)
                checkedlistbox_Stages.Items.Add(Setup, true);

            SetProgress(Resources.done, 100);
        }

        private void WkrLoadStagesProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Globals.LevelSetups.Clear();

                string[] Files = Directory.GetFiles((string)e.Argument);

                int i = 0;

                foreach (string File in Files)
                {
                    Globals.LevelSetups.Add(new LevelSetupEntry(File));

                    i++;
                    int Percent = (int)(((decimal)i / (decimal)(Files.Count())) * 100);
                    (sender as BackgroundWorker).ReportProgress(Percent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void checkedlistbox_Stages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkedlistbox_Stages.SelectedIndex < 0 || checkedlistbox_Stages.SelectedIndex > checkedlistbox_Stages.Items.Count)
                    return;

                LevelSetupEntry Setup = (LevelSetupEntry)checkedlistbox_Stages.Items[checkedlistbox_Stages.SelectedIndex];

                lst_EnemyEntries.Items.Clear();

                foreach (LevelSetupEntryEntry Entry in Setup.Entries)
                    lst_EnemyEntries.Items.Add(Entry);

                tx_Setupheader.Text = ByteOps.GetFormattedByteString(Setup.Header);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void lst_EnemyEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lst_EnemyEntries.SelectedIndex < 0 || lst_EnemyEntries.SelectedIndex > lst_EnemyEntries.Items.Count)
                    return;

                LevelSetupEntryEntry Setup = (LevelSetupEntryEntry)lst_EnemyEntries.Items[lst_EnemyEntries.SelectedIndex];

                tx_PosX.Text = Setup.PosX.ToString();
                tx_PosY.Text = Setup.PosY.ToString();
                tx_PosZ.Text = Setup.PosZ.ToString();

                tx_Unk.Text = ByteOps.GetFormattedByteString(Setup.Unk);
                tx_UnknownData.Text = ByteOps.GetFormattedByteString(Setup.Unknown);

                combo_Actor.SelectedIndex = (int)Setup.ID - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
