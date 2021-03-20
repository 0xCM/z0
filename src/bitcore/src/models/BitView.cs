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

    /// <summary>
    /// Represents a value as an ordered sequence of bits/bytes
    /// </summary>
    [ApiComplete]
    public unsafe ref struct BitView
    {
        [MethodImpl(Inline)]
        public static BitView create(ulong src)
            => new BitView(span64u(src));

        /// <summary>
        /// The data over which the view is constructed
        /// </summary>
        readonly ReadOnlySpan<ulong> Data;

        const byte CellWidth = 64;

        [MethodImpl(Inline)]
        public BitView(ReadOnlySpan<ulong> src)
            => Data = src;

        [MethodImpl(Inline)]
        public bit View(uint offset, W1 w)
        {
            var (i, j) = math.divmod(offset,64);
            ref readonly var cell = ref skip(Data,i);
            return bit.test(cell, (byte)j);
        }

        [MethodImpl(Inline)]
        public uint2 View(uint offset, W2 w)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint2)Bits.extract(skip(Data,d), (byte)r, 2);
        }

        [MethodImpl(Inline)]
        public uint3 View(uint offset, W3 w)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint3)Bits.extract(skip(Data,d), (byte)r, 3);
        }

        [MethodImpl(Inline)]
        public uint4 View(uint offset, W4 w)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint4)Bits.extract(skip(Data,d), (byte)r, 4);
        }

        [MethodImpl(Inline)]
        public uint5 View(uint offset, W5 w)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint5)Bits.extract(skip(Data,d), (byte)r, 5);
        }

        [MethodImpl(Inline)]
        public uint6 View(uint offset, W6 w)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint6)Bits.extract(skip(Data,d), (byte)r, 6);
        }

        [MethodImpl(Inline)]
        public uint7 View(uint offset, W7 w)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint7)Bits.extract(skip(Data,d), (byte)r, 7);
        }

        [MethodImpl(Inline)]
        public uint8T View(uint offset, W8 w)
        {
            math.divmod(offset, CellWidth, out var d, out var r);
            return (uint8T)Bits.extract(skip(Data,d), (byte)r, 8);
        }

        [MethodImpl(Inline)]
        public bit View(W1 w)
            => View(0, w);

        [MethodImpl(Inline)]
        public uint2 View(W2 w)
            => View(0, w);

        [MethodImpl(Inline)]
        public uint3 View(W3 w)
            => View(0, w);

        [MethodImpl(Inline)]
        public uint4 View(W4 w)
            => View(0, w);

        [MethodImpl(Inline)]
        public uint5 View(W5 w)
            => View(0, w);

        [MethodImpl(Inline)]
        public uint6 View(W6 w)
            => View(0, w);

        [MethodImpl(Inline)]
        public uint7 View(W7 w)
            => View(0, w);

        [MethodImpl(Inline)]
        public uint8T View(W8 w)
            => View(0, w);

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