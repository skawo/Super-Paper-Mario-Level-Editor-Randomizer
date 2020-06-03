using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Super_Paper_Mario_Randomizer
{
    public class LevelSetupEntry
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }

        public byte[] Header { get; set; }
        public List<LevelSetupEntryEntry> Entries { get; set; }

        public LevelSetupEntry(string _FilePath)
        {
            FilePath = _FilePath;
            FileName = Path.GetFileNameWithoutExtension(FilePath);
            Description = "";

            Header = ByteOps.GetNumBytes(2, 0, FilePath);
            Entries = LevelSetupEntryEntry.GetListOfEntriesFromData(File.ReadAllBytes(FilePath).Skip(2).ToArray());
        }

        public override string ToString()
        {
            if (Description != "")
                return Description;
            else
                return FileName;
        }
    }

    public class LevelSetupEntryEntry
    {
        public UInt32 ID;
        public int PosX;
        public int PosY;
        public int PosZ;
        public byte[] Unk = new byte[0x2];
        public byte[] Unknown = new byte[0x64];

        public LevelSetupEntryEntry(byte[] Data)
        {
            if (Data.Length != 0x70)
                return;
            else
            {
                PosX = ByteOps.GetInt32(Data, 0);
                PosY = ByteOps.GetInt32(Data, 4);
                PosZ = ByteOps.GetInt32(Data, 8);
                Unk = Data.Skip(12).Take(2).ToArray();
                ID = ByteOps.GetUInt32(Data, 14);

                Unknown = Data.Skip(18).Take(100).ToArray();
            }
        }

        public override string ToString()
        {
            Enemy E = null;

            if (Globals.EnemyList != null)
                E = Globals.EnemyList.Find(x => x.ID == ID);

            if (E == null)
                return "Enemy ID " + ID;
            else
                return ID.ToString() + " - " + E.Name;
        }

        public static List<LevelSetupEntryEntry> GetListOfEntriesFromData(byte[] Data)
        {
            int Pos = 0;
            List<LevelSetupEntryEntry> Outl = new List<LevelSetupEntryEntry>();

            while (Pos < Data.Length)
            {
                byte[] Entry = Data.Skip(Pos).Take(0x70).ToArray();
                Outl.Add(new LevelSetupEntryEntry(Entry));

                Pos += 0x70;
            }

            return Outl;
        }
    }

    public class Enemy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }
        public bool Weird { get; set; }
        public bool Boss { get; set; }
        public bool Obstacle { get; set; }

        public Enemy()
        {
            ID = -1;
            Name = "";
            Description = "";
            Difficulty = 0;
            Weird = false;
            Boss = false;
            Obstacle = false;
        }

        public override string ToString()
        {
            return ID + " - " + Name;
        }
    }
}
