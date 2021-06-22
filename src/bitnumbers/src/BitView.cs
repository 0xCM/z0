//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Represents a value as an ordered sequence of bits/bytes
    /// </summary>
    [ApiComplete]
    public unsafe ref struct BitView
    {
        [MethodImpl(Inline)]
        public static BitView create(ulong src)
            => new BitView(bytes(src));

        /// <summary>
        /// The data over which the view is constructed
        /// </summary>
        readonly ReadOnlySpan<byte> Data;

        const byte CellWidth = 8;

        [MethodImpl(Inline)]
        public BitView(ReadOnlySpan<byte> src)
            => Data = src;

        [MethodImpl(Inline)]
        public bit View(W1 w, ByteSize offset)
        {
            var (i, j) = math.divmod(offset,CellWidth);
            ref readonly var cell = ref skip(Data,i);
            return bit.test(cell, (byte)j);
        }

        [MethodImpl(Inline)]
        public uint2 View(W2 w, ByteSize offset)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint2)Bits.segment(skip(Data,d), (byte)r, 2);
        }

        [MethodImpl(Inline)]
        public uint3 View(W3 w, ByteSize offset)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint3)Bits.segment(skip(Data,d), (byte)r, 3);
        }

        [MethodImpl(Inline)]
        public uint4 View(W4 w, ByteSize offset)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint4)Bits.segment(skip(Data,d), (byte)r, 4);
        }

        [MethodImpl(Inline)]
        public uint5 View(W5 w, ByteSize offset)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint5)Bits.segment(skip(Data,d), (byte)r, 5);
        }

        [MethodImpl(Inline)]
        public uint6 View(W6 w, ByteSize offset)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint6)Bits.segment(skip(Data,d), (byte)r, 6);
        }

        [MethodImpl(Inline)]
        public uint7 View(W7 w, ByteSize offset)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint7)Bits.segment(skip(Data,d), (byte)r, 7);
        }

        [MethodImpl(Inline)]
        public eight View(W8 w, ByteSize offset)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (eight)Bits.segment(skip(Data,d), (byte)r, 8);
        }

        /// <summary>
        /// The total number of represented bytes
        /// </summary>
        public ByteSize ByteCount
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        /// <summary>
        /// The total number of represented bits
        /// </summary>
        public BitWidth BitCount
        {
            [MethodImpl(Inline)]
            get => (BitWidth)ByteCount;
        }


        public override bool Equals(object obj)
            => true;

        public override int GetHashCode()
            => -1;

        [MethodImpl(Inline)]
        public static bool operator ==(BitView a, BitView b)
            => a.Data.SequenceEqual(b.Data);

        [MethodImpl(Inline)]
        public static bool operator !=(BitView a, BitView b)
            => !(a == b);
    }
}