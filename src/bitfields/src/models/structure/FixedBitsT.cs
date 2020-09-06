//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly ref struct FixedBits<T>
        where T : unmanaged
    {
        public readonly uint BitCount;

        readonly byte CellWidth;

        internal readonly int CellCount;

        internal readonly int BlockCount;

        internal readonly SpanBlock64<T> Data;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Bytes;
        }

        internal FixedBits(SpanBlock64<T> src, uint bitcount)
        {
            this.Data = src;
            this.BitCount = bitcount;
            this.CellWidth = (byte)bitsize<T>();
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