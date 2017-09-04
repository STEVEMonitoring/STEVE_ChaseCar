using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEVE_Chase_Car.Code
{
    public class DataField
    {
        private const uint BITS_PER_BYTE = 8;
        private byte[] data = new byte[8];

        public DataField(byte[] data)
        {
            Array.Copy(data, this.data, this.data.Length);
        }
        public bool get_bit(char offset)
        {
            throw new NotImplementedException("get_bit not implemented yet!");
        }

        public uint get_value(uint offset, uint width)
        {
            uint offsetInByte = offset % BITS_PER_BYTE;
            uint bytesToProcess = 1 + width / BITS_PER_BYTE;

            byte[] dataBytes = new byte[8];
            Array.Copy(this.data, offset / BITS_PER_BYTE, dataBytes, 0, 8 - offset / BITS_PER_BYTE);

            uint retVal = (uint)dataBytes[0] >> (byte)offsetInByte;

            byte bytesProcessed = 1;

            for (; bytesProcessed < bytesToProcess; ++bytesProcessed)
            {
                retVal +=
                    (uint)(dataBytes[bytesProcessed] << (byte)(BITS_PER_BYTE * bytesProcessed))
                    >> (byte)offsetInByte;
            }

            // Mask upper unused bits in hightes byte
            return (uint)(retVal & ~(0xFFFF << (int)width));
        }
    }
}
