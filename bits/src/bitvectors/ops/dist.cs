//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector4 x, BitVector4 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector8 x, BitVector8 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector16 x, BitVector16 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector32 x, BitVector32 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector64 x, BitVector64 y)
            => pop(xor(x,y)); 

        /// <summary>
        /// Computes the Hamming distance between two generic bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint dist<N,T>(BitVector<N,T> x, BitVector<N,T> y)
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
        public static uint dist<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => pop(xor(x,y));
    }
}