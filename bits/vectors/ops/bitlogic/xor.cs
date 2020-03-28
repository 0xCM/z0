//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;    

    partial class BitVector
    {
        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.xor(x.Scalar,y.Scalar);

        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 xor(BitVector4 x, BitVector4 y)
            => gmath.xor(x.data,y.data);

        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 xor(BitVector8 x, BitVector8 y)
            => gmath.xor(x.data,y.data);

        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 xor(BitVector16 x, BitVector16 y)
            => gmath.xor(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z: = x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 xor(BitVector32 x, BitVector32 y)
            => gmath.xor(x.data, y.data);

        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 xor(BitVector64 x, BitVector64 y)
            => gmath.xor(x.data, y.data);
    }
}