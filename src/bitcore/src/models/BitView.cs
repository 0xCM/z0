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
    [ApiDeep]
    public unsafe ref struct BitView
    {
        /// <summary>
        /// The data over which the view is constructed
        /// </summary>
        readonly ReadOnlySpan<ulong> Data;

        [MethodImpl(Inline)]
        public BitView(ReadOnlySpan<ulong> src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public bit View(uint pos, W1 w)
        {
            var (i, j) = math.divmod(pos,64);
            ref readonly var cell = ref skip(Data,i);
            return bit.test(cell, (byte)j);
        }

        [MethodImpl(Inline)]
        public uint2 View(uint pos, W2 w)
        {
            var (i, j) = math.divmod(pos,64);
            ref readonly var cell = ref skip(Data,i);
            var spec = new BitExtractSpec((byte)j, 2);
            return (uint2)Bits.extract(cell,spec);
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
        public BitSize BitCount
        {
            [MethodImpl(Inline)]
            get => (BitSize)ByteCount;
        }


        public override bool Equals(object obj)
            => true;

        public override int GetHashCode()
            => -1;

        [MethodImpl(Inline)]
        public static bool operator ==(BitView lhs, BitView rhs)
            => lhs.Data.SequenceEqual(rhs.Data);

        [MethodImpl(Inline)]
        public static bool operator !=(BitView lhs, BitView rhs)
            => !(lhs == rhs);
    }
}