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
        /// Computes the Hamming distance between two generic bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static uint dist<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint dist(BitVector4 x, BitVector4 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint dist(BitVector8 x, BitVector8 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint dist(BitVector16 x, BitVector16 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint dist(BitVector32 x, BitVector32 y)
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static uint dist(BitVector64 x, BitVector64 y)
            => pop(xor(x,y)); 
    }
}