//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitVector
    {
        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.xor(x.Data,y.Data);

       /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> xor<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.xor(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> xor<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gcpu.vxor(x.Data,y.Data);

        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Xor]
        public static BitVector4 xor(BitVector4 x, BitVector4 y)
            => gmath.xor(x.Data,y.Data);

        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Xor]
        public static BitVector8 xor(BitVector8 x, BitVector8 y)
            => gmath.xor(x.Data,y.Data);

        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Xor]
        public static BitVector16 xor(BitVector16 x, BitVector16 y)
            => gmath.xor(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z: = x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Xor]
        public static BitVector32 xor(BitVector32 x, BitVector32 y)
            => gmath.xor(x.Data, y.Data);

        /// <summary>
        /// Computes  z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Xor]
        public static BitVector64 xor(BitVector64 x, BitVector64 y)
            => gmath.xor(x.Data, y.Data);
    }
}