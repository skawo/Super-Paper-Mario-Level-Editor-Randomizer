using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Super_Paper_Mario_Randomizer.Properties;

namespace Super_Paper_Mario_Randomizer
{
    public partial class Form1 : Form
    {
        List<LevelSetupEntry> LevelSetups = new List<LevelSetupEntry>();
        

        public Form1()
        {
            InitializeComponent();
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
                                WkrCheckExtractProgress.ProgressChanged += WkrCheckExtractProgress_ProgressChanged; ;
                                WkrCheckExtractProgress.RunWorkerCompleted += WkrCheckExtractProgress_RunWorkerCompleted;
                                WkrCheckExtractProgress.RunWorkerAsync(10000);
                            }
                        }
                    }
                }
            }
        }

        private void WkrCheckExtractProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetProgress(Resources.done, 100);
        }

        private void WkrCheckExtractProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SetProgressVal(e.ProgressPercentage);
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

        #endregion

        private void openSetupFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fb = new FolderBrowserDialog())
            {
                fb.ShowNewFolderButton = false;
                fb.Description = Resources.select_setup_folder;
                DialogResult dr = fb.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    string[] Files = Directory.GetFiles(fb.SelectedPath);

                    checkedlistbox_Stages.Items.Clear();
                    LevelSetups.Clear();
                
                    foreach (string File in Files)
                            LevelSetups.Add(new LevelSetupEntry(File));

                    foreach (LevelSetupEntry Setup in LevelSetups)
                        checkedlistbox_Stages.Items.Add(Setup, true);
                }
            }
        }

        private void checkedlistbox_Stages_SelectedIndexChanged(object sender, EventArgs e)
        {
            LevelSetupEntry Setup = (LevelSetupEntry)checkedlistbox_Stages.Items[checkedlistbox_Stages.SelectedIndex];

            lst_EnemyEntries.Items.Clear();

            foreach (LevelSetupEntryEntry Entry in Setup.Entries)
                lst_EnemyEntries.Items.Add(Entry);

            tx_Setupheader.Text = BitConverter.ToString(Setup.Header, 0).Replace("-", string.Empty);
        }

        private void lst_EnemyEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_EnemyEntries.SelectedIndex == -1)
                return;

            LevelSetupEntryEntry Setup = (LevelSetupEntryEntry)lst_EnemyEntries.Items[lst_EnemyEntries.SelectedIndex];

            tx_PosX.Text = Setup.PosX.ToString();
            tx_PosY.Text = Setup.PosY.ToString();
            tx_PosZ.Text = Setup.PosZ.ToString();
            tx_Unk.Text = Setup.Unk.ToString();

            tx_UnknownData.Text = BitConverter.ToString(Setup.Unknown, 0).Replace("-", string.Empty);

            //combo_Actor.SelectedIndex = Setup.ActorID;
        }
    }
}
