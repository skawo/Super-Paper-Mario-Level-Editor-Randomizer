using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Paper_Mario_Randomizer
{
    class Helpers
    {
        public static object DeserializeJsonFromFile(string Path, Type type)
        {
            try
            {
                string Json = File.ReadAllText(Path);
                return Newtonsoft.Json.JsonConvert.DeserializeObject(Json, type);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void SerializeJsonToFile(object Obj, string Path)
        {
            try
            {
                string Json = Newtonsoft.Json.JsonConvert.SerializeObject(Obj, Newtonsoft.Json.Formatting.Indented);

                File.Delete(Path);
                File.WriteAllText(Path, Json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public static string GetStringSHA1OfString(string s)
        {
            HashAlgorithm hsh = HashAlgorithm.Create("SHA1");
            return Encoding.ASCII.GetString(hsh.ComputeHash(Encoding.ASCII.GetBytes(s)));
        }

        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }
    }
}
