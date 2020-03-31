//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class BitVector
    {
        /// <summary>
        /// Computes the arithmetic sum z := x + y for generic bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> add<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.add(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 add(BitVector4 x, BitVector4 y)
            => new BitVector4(math.mod(math.add(x.Scalar, y.Scalar), (byte)4),true);

        /// <summary>
        /// Computes the arithmetic sum of two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 add(BitVector8 x, BitVector8 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 add(BitVector16 x, BitVector16 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 add(BitVector32 x, BitVector32 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 add(BitVector64 x, BitVector64 y)
            => gmath.add(x.data, y.data);
    }
}