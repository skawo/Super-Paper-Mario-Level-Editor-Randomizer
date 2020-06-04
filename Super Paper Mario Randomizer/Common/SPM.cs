using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BitConverter;

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

            Header = ByteOps.GetNumBytes(4, 0, FilePath);
            Entries = LevelSetupEntryEntry.GetListOfEntriesFromData(File.ReadAllBytes(FilePath).Skip(4).ToArray());
        }

        public override string ToString()
        {
            if (Description != "")
                return Description;
            else
                return FileName;
        }

        public byte[] ToBytes()
        {
            List<byte> Out = new List<byte>();

            Out.AddRange(this.Header);

            foreach (LevelSetupEntryEntry Entry in this.Entries)
                Out.AddRange(Entry.ToBytes());

            return Out.ToArray();
        }

        public static bool IsValid(string FilePath)
        {
            FileInfo fi = new FileInfo(FilePath);
            return true;
        }
    }

    public class LevelSetupEntryEntry
    {
        public UInt32 ID;
        public float PosX;
        public float PosY;
        public float PosZ;
        public byte[] Unknown = new byte[0x60];

        public LevelSetupEntryEntry(byte[] Data)
        {
            if (Data.Length != 0x70)
                return;
            else
            {
                PosX = ByteOps.GetFloat(Data, 0);
                PosY = ByteOps.GetFloat(Data, 4);
                PosZ = ByteOps.GetFloat(Data, 8);
                ID = ByteOps.GetUInt32(Data, 12);

                Unknown = Data.Skip(16).Take(0x60).ToArray();
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

        public byte[] ToBytes()
        {
            List<byte> Out = new List<byte>();

            Out.AddRange(EndianBitConverter.BigEndian.GetBytes(PosX));
            Out.AddRange(EndianBitConverter.BigEndian.GetBytes(PosY));
            Out.AddRange(EndianBitConverter.BigEndian.GetBytes(PosZ));
            Out.AddRange(EndianBitConverter.BigEndian.GetBytes(ID));
            Out.AddRange(Unknown);

            return Out.ToArray();
        }

        public static List<LevelSetupEntryEntry> GetListOfEntriesFromData(byte[] Data)
        {
            int Pos = 0;
            List<LevelSetupEntryEntry> Outl = new List<LevelSetupEntryEntry>();

            while (Pos + 0x70 <= Data.Length)
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
