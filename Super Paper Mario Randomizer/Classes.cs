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
        public UInt32 ActorID;
        public int PosX;
        public int PosY;
        public int PosZ;
        public UInt16 Unk;
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
                Unk = ByteOps.GetUInt16(Data, 12);
                ActorID = ByteOps.GetUInt32(Data, 14);

                Unknown = Data.Skip(18).Take(100).ToArray();
            }
        }

        public override string ToString()
        {
            return "Enemy ID " + ActorID;
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
}
