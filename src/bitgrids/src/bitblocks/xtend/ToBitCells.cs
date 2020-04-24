//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    partial class XTend
    {
        /// <summary>
        /// Extracts the bitcells froma span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<T> ToBitCells<T>(this Span<T> src, int len)
            where T : unmanaged
                => BitBlocks.load(src,len);

        [MethodImpl(Inline)]
        public static BitBlock<N,T> ToBitCells<N,T>(this BitVector128<N,T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitBlocks.load(src.Content.ToSpan(),n);
    }
}