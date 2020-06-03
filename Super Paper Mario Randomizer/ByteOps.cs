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
            return (UInt32)(Data[Offset] | Data[Offset + 1] | Data[Offset + 2] | Data[Offset + 3]);
        }

        public static UInt16 GetUInt16(byte[] Data, int Offset)
        {
            return (UInt16)(Data[Offset] | Data[Offset + 1]);
        }

        public static Int32 GetInt32(byte[] Data, int Offset)
        {
            return (Int32)(Data[Offset] | Data[Offset + 1] | Data[Offset + 2] | Data[Offset + 3]);
        }

        public static Int16 GetInt16(byte[] Data, int Offset)
        {
            return (Int16)(Data[Offset] | Data[Offset + 1]);
        }

        public static string GetFormattedByteString(byte[] Data)
        {
            return BitConverter.ToString(Data, 0).Replace("-", " ");
        }
    }
}
