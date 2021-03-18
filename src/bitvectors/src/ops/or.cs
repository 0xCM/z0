//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitvector z := x | y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> or<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.or(x.Data,y.Data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> or<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.or(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> or<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gcpu.vor(x.Data,y.Data);

        /// <summary>
        /// Computes the bitvector z := x | y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 or(BitVector4 x, BitVector4 y)
            => gmath.or(x.Data,y.Data);

        /// <summary>
        /// Computes the bitvector z := x | y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 or(BitVector8 x, BitVector8 y)
            => math.or(x.Data,y.Data);

        /// <summary>
        /// Computes the bitvector z := x | y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 or(BitVector16 x, BitVector16 y)
            => math.or(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z := x | y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 or(BitVector32 x, BitVector32 y)
            => math.or(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z := x | y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 or(BitVector64 x, BitVector64 y)
            => math.or(x.Data, y.Data);
    }
}