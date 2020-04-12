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
                => BitBlocks.load(src.Data.ToSpan(),n);

        [MethodImpl(Inline)]
        public static BitBlock<T> Unsize<N,T>(this BitBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitBlocks.load(src.Data, nati<N>()); 

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<N,T>(this BitBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitString.scalars(src.Data, src.Width); 

        [MethodImpl(Inline)]
        public static string Format<N,T>(this BitBlock<N,T> src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToBitString().Format(tlz, specifier, blockWidth);


        [MethodImpl(Inline)]
        public static bit Identical<T>(this Block128<T> xb, Block128<T> yb)        
            where T : unmanaged        
                => xb.Data.Identical(yb.Data);

        [MethodImpl(Inline)]
        public static bit Identical<T>(this Block256<T> xb, Block256<T> yb)        
            where T : unmanaged        
                => xb.Data.Identical(yb.Data);
    }
}