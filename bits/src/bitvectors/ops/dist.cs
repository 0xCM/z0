//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;
    using static As;

    partial class BitVector
    {
        /// <summary>
        /// Computes the Hamming distance between two generic bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
            => gbits.pop(gmath.xor(x.Data,y.Data));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector4 x, BitVector4 y)
            => Bits.pop(math.xor(x.data,y.data));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector8 x, BitVector8 y)
            => Bits.pop(math.xor(x.data,y.data));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector16 x, BitVector16 y)
            => Bits.pop(math.xor(x.data,y.data));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector32 x, BitVector32 y)
            => Bits.pop(math.xor(x.data,y.data));

        /// <summary>
        /// Computes the Hamming distance between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static uint dist(BitVector64 x, BitVector64 y)
            => Bits.pop(math.xor(x.data,y.data));
 
    }
}