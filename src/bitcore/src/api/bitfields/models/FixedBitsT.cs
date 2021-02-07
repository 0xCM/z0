//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly ref struct FixedBits<T>
        where T : unmanaged
    {
        public readonly uint BitCount {get;}

        public readonly uint CellWidth {get;}

        public readonly uint CellCount {get;}

        public readonly uint BlockCount {get;}

        internal readonly SpanBlock64<T> Data;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Bytes;
        }

        public FixedBits(SpanBlock64<T> src, uint bitcount)
        {
            Data = src;
            BitCount = bitcount;
            CellWidth = (byte)bitwidth<T>();
            BlockCount = (uint)src.BlockCount;
            CellCount = (uint)src.CellCount;
        }

        [MethodImpl(Inline)]
        public T BitSlice(byte start, byte length)
            => gbits.extract(Data[(int)(start/CellWidth)], (byte)(start % CellWidth), length);

        public bit this[ByteSize offset, byte pos]
        {
            [MethodImpl(Inline)]
            get => bit.test(Bytes[offset], pos);

            [MethodImpl(Inline)]
            set => Bytes[offset] = bit.set(Bytes[offset], pos, value);
        }
    }
}