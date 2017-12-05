using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketHandler
{
    class PacketHandler
    {
        private List<byte> buffer = new List<byte>();

        public void write(string data)
        {
            foreach (char value in data)
                buffer.Add((byte)value);
        }

        public void write(char data)
        {
            buffer.Add((byte)data);
        }

        public void write(byte data)
        {
            buffer.Add(data);
        }

        public void write(byte[] data)
        {
            foreach (byte value in data)
                buffer.Add(value);
        }

        public void write(ushort data)
        {
            foreach (byte value in BitConverter.GetBytes(data))
                buffer.Add(value);
        }

        public void write(short data)
        {
            foreach (byte value in BitConverter.GetBytes(data))
                buffer.Add(value);
        }

        public void write(uint data)
        {
            foreach (byte value in BitConverter.GetBytes(data))
                buffer.Add(value);
        }

        public void write(int data)
        {
            foreach (byte value in BitConverter.GetBytes(data))
                buffer.Add(value);
        }

        public void write(ulong data)
        {
            foreach (byte value in BitConverter.GetBytes(data))
                buffer.Add(value);
        }

        public void write(long data)
        {
            foreach (byte value in BitConverter.GetBytes(data))
                buffer.Add(value);
        }

        public void write(bool data)
        {
            buffer.Add(Convert.ToByte(data));
        }

        public void write(float data)
        {
            foreach (byte value in BitConverter.GetBytes(data))
                buffer.Add(value);
        }

        public void write(double data)
        {
            foreach (byte value in BitConverter.GetBytes(data))
                buffer.Add(value);
        }

        
        public string readString(int length)
        {
            string output = "";
            for (int i = 0; i < length; i++)
            {
                output += (char)buffer[0];
                buffer.RemoveAt(0);
            }
            return output;
        }

        public char readChar()
        {
            char output = (char)buffer[0];
            buffer.RemoveAt(0);
            return output;
        }

        public byte readByte()
        {
            byte output = buffer[0];
            buffer.RemoveAt(0);
            return output;
        }

        public byte[] readByte(int length)
        {
            byte[] output = null;
            if(buffer.Count() >= length)
            {
                output = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    output[i] = buffer[0];
                    buffer.RemoveAt(0);
                }
            }
            return output;
        }

        public ushort readUShort()
        {
            byte[] array = new byte[sizeof(ushort)];
            for(int i = 0; i < sizeof(ushort); i++)
            {
                array[i] = buffer[i];
                buffer.RemoveAt(0);
            }
            return BitConverter.ToUInt16(array,0);
        }

        public short readShort()
        {
            byte[] array = new byte[sizeof(short)];
            for (int i = 0; i < sizeof(short); i++)
            {
                array[i] = buffer[i];
                buffer.RemoveAt(0);
            }
            return BitConverter.ToInt16(array, 0);
        }

        public uint readUInt()
        {
            byte[] array = new byte[sizeof(uint)];
            for (int i = 0; i < sizeof(uint); i++)
            {
                array[i] = buffer[i];
                buffer.RemoveAt(0);
            }
            return BitConverter.ToUInt32(array, 0);
        }

        public int readInt()
        {
            byte[] array = new byte[sizeof(int)];
            for (int i = 0; i < sizeof(int); i++)
            {
                array[i] = buffer[i];
                buffer.RemoveAt(0);
            }
            return BitConverter.ToInt32(array, 0);
        }

        public ulong readULong()
        {
            byte[] array = new byte[sizeof(ulong)];
            for (int i = 0; i < sizeof(ulong); i++)
            {
                array[i] = buffer[i];
                buffer.RemoveAt(0);
            }
            return BitConverter.ToUInt64(array, 0);
        }

        public long readLong()
        {
            byte[] array = new byte[sizeof(long)];
            for (int i = 0; i < sizeof(long); i++)
            {
                array[i] = buffer[i];
                buffer.RemoveAt(0);
            }
            return BitConverter.ToInt64(array, 0);
        }

        public bool readBool()
        {
            byte[] array = new byte[sizeof(bool)];
            for (int i = 0; i < sizeof(bool); i++)
            {
                array[i] = buffer[i];
                buffer.RemoveAt(0);
            }
            return BitConverter.ToBoolean(array, 0);
        }

        public float readFloat()
        {
            byte[] array = new byte[sizeof(float)];
            for (int i = 0; i < sizeof(float); i++)
            {
                array[i] = buffer[i];
                buffer.RemoveAt(0);
            }
            return BitConverter.ToSingle(array, 0);
        }

        public double readDouble()
        {
            byte[] array = new byte[sizeof(double)];
            for (int i = 0; i < sizeof(double); i++)
            {
                array[i] = buffer[i];
                buffer.RemoveAt(0);
            }
            return BitConverter.ToDouble(array, 0);
        }
    }
}
