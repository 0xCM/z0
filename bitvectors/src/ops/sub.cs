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
        /// Computes the arithmetic difference z := x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Sub]
        public static BitVector4 sub(BitVector4 x, BitVector4 y)
            => (byte)Mod16.mod(math.sub((uint)x.data, (uint)y.data));

        [MethodImpl(Inline), Sub]
        public static BitVector4 sub2(BitVector4 x, BitVector4 y)
        {
            const int modulus = 16;
            var diff = (int)x - (int)y;
            var reduced = (byte)(diff < 0 ? (uint)(diff + modulus) : (uint)diff);
            return new BitVector4(reduced,true);
        }

        /// <summary>
        /// Computes the arithmetic difference z := x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Sub]
        public static BitVector8 sub(BitVector8 x, BitVector8 y)
            => gmath.sub(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic difference z := x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Sub]
        public static BitVector16 sub(BitVector16 x, BitVector16 y)
            => gmath.sub(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic difference z := x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Sub]
        public static BitVector32 sub(BitVector32 x, BitVector32 y)
            => gmath.sub(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic difference z := x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Sub]
        public static BitVector64 sub(BitVector64 x, BitVector64 y)
            => gmath.sub(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic difference z := x - y for generic bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Sub, Closures(UnsignedInts)]
        public static BitVector<T> sub<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.sub(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> sub<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.sub(x.Scalar, y.Scalar);
    }
}