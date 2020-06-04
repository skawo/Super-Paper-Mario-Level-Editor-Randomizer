using BitConverter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Paper_Mario_Randomizer
{
    public static class ByteOps
    {
        public static byte[] GetNumBytes(int Size, int Offset, string Path)
        {

            using (FileStream fsSource = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {
                byte[] OutBytes = new byte[Size];
                fsSource.Read(OutBytes, Offset, Size);

                return OutBytes;
            }
        }

        public static UInt32 GetUInt32(byte[] Data, int Offset)
        {
            return BitConverter.EndianBitConverter.BigEndian.ToUInt32(Data, Offset);
        }

        public static UInt16 GetUInt16(byte[] Data, int Offset)
        {
            return BitConverter.EndianBitConverter.BigEndian.ToUInt16(Data, Offset);
        }

        public static Int32 GetInt32(byte[] Data, int Offset)
        {
            return BitConverter.EndianBitConverter.BigEndian.ToInt32(Data, Offset);
        }

        public static Int16 GetInt16(byte[] Data, int Offset)
        {
            return BitConverter.EndianBitConverter.BigEndian.ToInt16(Data, Offset);
        }

        public static float GetFloat(byte[] Data, int Offset)
        {
            return BitConverter.EndianBitConverter.BigEndian.ToSingle(Data, Offset);
        }

        public static string GetFormattedByteString(byte[] Data)
        {
            return System.BitConverter.ToString(Data, 0).Replace("-", " ");
        }

        public static byte[] FormattedByteStringToByteArray(string Data)
        {
            try
            {
                string Working = Data.Replace(" ", "");

                var n = 2;
                string[] Bytes = Working
                                .Select((c, i) => new { letter = c, group = i / n })
                                .GroupBy(l => l.group, l => l.letter)
                                .Select(g => string.Join("", g))
                                .ToArray();

                byte[] Ret = new byte[Bytes.Length];
                for (int i = 0; i < Bytes.Length; i++)
                {
                    if (Bytes[i].Length != 2)
                        throw new InvalidDataException();

                    Ret[i] = Convert.ToByte(Bytes[i], 16);
                }

                return Ret;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
