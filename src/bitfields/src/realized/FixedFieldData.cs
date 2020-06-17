//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static Memories;

    public readonly ref struct FixedFieldData<T>
        where T : unmanaged
    {
        public readonly int BitCount;

        internal readonly int CellWidth;

        internal readonly int CellCount;

        internal readonly int BlockCount;

        internal readonly Block64<T> Data;   

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Bytes;
        }

        internal FixedFieldData(Block64<T> src, int bitcount)
        {
            this.Data = src;
            this.BitCount = bitcount;
            this.CellWidth = bitsize<T>();
            this.BlockCount = src.BlockCount;
            this.CellCount = src.CellCount;
        }

        [MethodImpl(Inline)]
        public T BitSlice(byte start, byte length)
            => gbits.slice(Data[start/CellWidth], (byte)(start % CellWidth), length);

        public bit this[ByteSize offset, byte pos]        
        {
            [MethodImpl(Inline)]
            get => bit.test(Bytes[offset], pos);
            
            [MethodImpl(Inline)]
            set => Bytes[offset] = bit.set(Bytes[offset], pos, value);                
        }
    }
}