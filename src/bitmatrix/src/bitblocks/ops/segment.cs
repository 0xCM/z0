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

    partial class BitBlocks
    {
        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by an inclusive position range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="firstpos">The sequence-relative position of the first bit</param>
        /// <param name="lastpos">The sequence-relative position of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Segment, Closures(Closure)]
        public static T segment<T>(in SpanBlock256<T> src, BitPos<T> firstpos, BitPos<T> lastpos)
            where T : unmanaged
                => gbits.segment(src.Storage, firstpos,lastpos);

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by an inclusive linear index range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The sequence-relative index of the first bit</param>
        /// <param name="i1">The sequence-relative index of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Segment, Closures(Closure)]
        public static T segment<T>(in SpanBlock256<T> src, int i0, int i1)
            where T : unmanaged
                => gbits.segment(src.Storage, gbits.bitpos<T>(i0), gbits.bitpos<T>(i1));
    }
}