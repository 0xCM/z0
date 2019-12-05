//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {

        /// <summary>
        /// Converts the source bitvector to bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitCells<N8,byte> ToBitCells(this BitVector8 src)
            => src;

        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitCells<N16,ushort> ToBitCells(this BitVector16 src)
            => src;

        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitCells<N64,ulong> ToBitCells(this BitVector64 src)
            => src;

        /// <summary>
        /// Constructs a bitvector from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> ToBitCells<T>(this Span<T> src, int len)
            where T : unmanaged
                => BitCells.load(src,len);

        [MethodImpl(Inline)]
        public static BitCells<T> ToBitCells<T>(this BitVector<T> src)
            where T : unmanaged
                => BitCells.literals(src.Scalar);

        [MethodImpl(Inline)]
        public static BitCells<N,T> ToBitCells<N,T>(this BitVector128<N,T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitCells.load(src.data.ToSpan(),n);
    }

}