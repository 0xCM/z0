//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline), Select, Closures(UnsignedInts)]
        public static BitVector<T> select<T>(BitVector<T> x, BitVector<T> y, BitVector<T> z)
            where T : unmanaged
                => gmath.select(x.Data, y.Data, z.Data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> select<N,T>(BitVector<N,T> x, BitVector<N,T> y, BitVector<N,T> z)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.select(x.Data, y.Data, z.Data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> select<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y, in BitVector128<N,T> z)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vselect(x.Data, y.Data, z.Data);   

    }
}