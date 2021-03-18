//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitVector
    {
        /// <summary>
        /// Computes the Hamming distance between two generic bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint hamming<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint hamming<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint hamming<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint hamming(BitVector4 x, BitVector4 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint hamming(BitVector8 x, BitVector8 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint hamming(BitVector16 x, BitVector16 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint hamming(BitVector32 x, BitVector32 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint hamming(BitVector64 x, BitVector64 y)
            => pop(xor(x,y));
    }
}