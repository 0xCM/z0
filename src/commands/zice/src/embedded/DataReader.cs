namespace Z0.Asm.Data
{
    using System;
    using System.IO;
	ref struct DataReader 
    {
		readonly ReadOnlySpan<byte> data;
	
    	public DataReader(ReadOnlySpan<byte> data)
			: this(data, 0) {
		}

		readonly char[] stringData;

		int index;

		public int Index {
			readonly get => index;
			set => index = value;
		}

		public readonly bool CanRead => (uint)index < (uint)data.Length;

		public DataReader(ReadOnlySpan<byte> data, int maxStringLength) {
			this.data = data;
			stringData = maxStringLength == 0 ? Control.array<char>() : new char[maxStringLength];
			index = 0;
		}

		public byte ReadByte() => data[index++];

		public uint ReadCompressedUInt32() {
			uint result = 0;
			for (int shift = 0; shift < 32; shift += 7) {
				uint b = ReadByte();
				if ((b & 0x80) == 0)
					return result | (b << shift);
				result |= (b & 0x7F) << shift;
			}
			throw new InvalidOperationException();
		}

		public string ReadAsciiString() {
			int length = ReadByte();
			var stringData = this.stringData;
			for (int i = 0; i < length; i++)
				stringData[i] = (char)ReadByte();
			return new string(stringData, 0, length);
		}

    }
    
}