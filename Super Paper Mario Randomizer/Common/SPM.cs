using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BitConverter;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Super_Paper_Mario_Randomizer
{
    public class SPMDefs
    {
        public enum HeaderSize
        {
            HEADER_SIZE_1 = 1,
            HEADER_SIZE_2 = 2,
            HEADER_SIZE_3 = 3,
            HEADER_SIZE_4 = 4,
            HEADER_SIZE_5 = 5,
            HEADER_SIZE_6 = 6,
        }

        public static Dictionary<HeaderSize, int> EntrySizes = new Dictionary<HeaderSize, int>()
        {
            [HeaderSize.HEADER_SIZE_1] = 0x1C,
            [HeaderSize.HEADER_SIZE_2] = 0x60,
            [HeaderSize.HEADER_SIZE_3] = 0x64,
            [HeaderSize.HEADER_SIZE_4] = 0x68,
            [HeaderSize.HEADER_SIZE_5] = 0x6C,
            [HeaderSize.HEADER_SIZE_6] = 0x70
        };
    }

    public class LevelSetupEntry
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public StageInfo Info { get; set; }

        public byte[] Header { get; set; }
        public List<LevelSetupEntryEntry> Entries { get; set; }
        public byte[] Footer { get; set; }

        public LevelSetupEntry(string _FilePath)
        {
            FilePath = _FilePath;
            FileName = Path.GetFileNameWithoutExtension(FilePath);
            Info = Globals.StageInfoList.Find(x => x.Name == FileName);

            Header = ByteOps.GetNumBytes(4, 0, FilePath);
            Entries = LevelSetupEntryEntry.GetListOfEntriesFromData(File.ReadAllBytes(FilePath).Skip(4).ToArray(), Header);
            Footer = File.ReadAllBytes(FilePath).Skip(4 + (100 * (int)SPMDefs.EntrySizes[(SPMDefs.HeaderSize)Header[1]])).ToArray();
        }

        public override string ToString()
        {
            if (Info != null)
                return Info.Description;
            else
                return FileName;
        }

        public byte[] ToBytes()
        {
            List<byte> Out = new List<byte>();

            Out.AddRange(this.Header);

            foreach (LevelSetupEntryEntry Entry in this.Entries)
                Out.AddRange(Entry.ToBytes(this.Header));

            Out.AddRange(this.Footer);

            return Out.ToArray();
        }

        public static bool IsValid(string FilePath)
        {
            byte[] HeaderSize = ByteOps.GetNumBytes(2, 0, FilePath);

            if (HeaderSize[1] < (byte)SPMDefs.HeaderSize.HEADER_SIZE_1 || HeaderSize[1] > (byte)SPMDefs.HeaderSize.HEADER_SIZE_6)
                return false;
            else
                return true;
        }
    }

    public class LevelSetupEntryEntry
    {
        public UInt32 ID;
        public float PosX;
        public float PosY;
        public float PosZ;
        public byte[] Unknown_Header1;
        public byte[] Unknown;

        public LevelSetupEntryEntry(byte[] Data, byte[] Header)
        {
            switch (Header[1])
            {
                case 1:
                    {
                        Unknown_Header1 = Data.Take(4).ToArray();
                        PosX = ByteOps.GetFloat(Data, 4);
                        PosY = ByteOps.GetFloat(Data, 8);
                        PosZ = ByteOps.GetFloat(Data, 12);
                        ID = ByteOps.GetUInt32(Data, 16);

                        Unknown = Data.Skip(20).Take(8).ToArray();
                        break;
                    }
                default:
                    {
                        PosX = ByteOps.GetFloat(Data, 0);
                        PosY = ByteOps.GetFloat(Data, 4);
                        PosZ = ByteOps.GetFloat(Data, 8);
                        ID = ByteOps.GetUInt32(Data, 12);

                        Unknown = Data.Skip(16).Take(SPMDefs.EntrySizes[(SPMDefs.HeaderSize)Header[1]] - 16).ToArray();
                        break;
                    }

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

        public byte[] ToBytes(byte[] Header)
        {
            List<byte> Out = new List<byte>();

            if (Header[1] == (byte)SPMDefs.HeaderSize.HEADER_SIZE_1)
                Out.AddRange(Unknown_Header1);

            Out.AddRange(EndianBitConverter.BigEndian.GetBytes(PosX));
            Out.AddRange(EndianBitConverter.BigEndian.GetBytes(PosY));
            Out.AddRange(EndianBitConverter.BigEndian.GetBytes(PosZ));
            Out.AddRange(EndianBitConverter.BigEndian.GetBytes(ID));
            Out.AddRange(Unknown);

            return Out.ToArray();
        }

        public static List<LevelSetupEntryEntry> GetListOfEntriesFromData(byte[] Data, byte[] Header)
        {
            int Pos = 0;
            List<LevelSetupEntryEntry> Outl = new List<LevelSetupEntryEntry>();

            int EntrySize = (int)SPMDefs.EntrySizes[(SPMDefs.HeaderSize)Header[1]];

            for (int i = 0; i < 100; i++)
            {
                byte[] Entry = Data.Skip(Pos).Take(EntrySize).ToArray();
                Outl.Add(new LevelSetupEntryEntry(Entry, Header));

                Pos += EntrySize;
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
            return Name;
        }
    }

    public class StageInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Chapter { get; set; }
        public bool Randomize { get; set; }

        public StageInfo()
        {
            Name = "";
            Description = "";
            Chapter = 0;
            Randomize = false;
        }

        public override string ToString()
        {
            return Description == "" ? Name : Description;
        }
    }
}
