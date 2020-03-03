//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;    

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitvector z := x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> and<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.and(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 and(BitVector4 x, BitVector4 y)
            => gmath.and(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z := x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 and(BitVector8 x, BitVector8 y)
            => gmath.and(x.data,y.data);

        /// <summary>
        /// Computes the bitvector z := x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 and(BitVector16 x, BitVector16 y)
            => gmath.and(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z := x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 and(BitVector32 x, BitVector32 y)
            => gmath.and(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z := x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 and(BitVector64 x, BitVector64 y)
            => gmath.and(x.data, y.data);
 
    }
}