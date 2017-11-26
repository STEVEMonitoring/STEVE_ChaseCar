namespace STEVE_Chase_Car.Code
{
    public class DataField
    {
        private const int BITS_PER_BYTE = 8;
        private ulong data;

        public DataField(byte[] data)
        {
            for(int index = 0; index < data.Length; ++index)
            {
                this.data += (ulong)data[index] << index * BITS_PER_BYTE;
            }
        }
        public bool get_bit(char offset)
        {
            return 1 == (this.data & (ulong)1 << offset);
        }

        public uint get_value(int offset, int width)
        {
            return (uint)(this.data >> offset & ~(ulong.MaxValue << width));
        }
    }
}
