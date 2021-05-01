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

    partial struct BitFields
    {
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static T read<T>(in Bitfield8<T> src, byte i0, byte i1)
            where T : unmanaged
                => @as<T>(Bits.bitseg((byte)src, i0, i1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the segment specification
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T read<T>(in BitfieldPart seg, T src)
            where T : unmanaged
                => gbits.bitslice(src, (byte)seg.FirstIndex, (byte)seg.Width);

        [MethodImpl(Inline)]
        public static T read<S,T>(in BitfieldPart segment, in S src)
            where S : unmanaged
            where T : unmanaged
                => memory.@as<S,T>(gbits.bitslice(src, (byte)segment.FirstIndex, (byte)segment.Width));

        [MethodImpl(Inline)]
        public static T read<S,T>(in BitfieldPart segment, in S src, bool offset)
            where S : unmanaged
            where T : unmanaged
                => offset ? gmath.sll(read<S,T>(segment, src), (byte)segment.FirstIndex) : read<S,T>(segment,src);
    }
}