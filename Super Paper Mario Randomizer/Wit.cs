using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Super_Paper_Mario_Randomizer
{
    class Wit
    {
        static string WitPath = @"Wit\wit.exe";

        public static int GetNumFiles(string InPath)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(WitPath);
                info.Arguments = " files \"" + InPath + "\"";

                info.UseShellExecute = false;
                info.RedirectStandardOutput = true;
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process p = new Process();
                p.EnableRaisingEvents = true;
                p.StartInfo = info;
                p.Start();

                string output = p.StandardOutput.ReadToEnd();
                string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                return lines.Count(x => !String.IsNullOrEmpty(x) && x.Contains("/") && !x.EndsWith("/"));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }

        }

        public static bool UnpackISO(string InPath, string OutPath)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(WitPath);
                info.Arguments = " extract \"" + InPath + "\" \"" + OutPath + "\"";
                info.UseShellExecute = true;
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process p = new Process();
                p.EnableRaisingEvents = true;
                p.StartInfo = info;
                p.Start();

                p.WaitForExit();
                int ec = p.ExitCode;

                if (ec != 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
