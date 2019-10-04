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

    partial class bitvector
    {
        /// <summary>
        /// Computes the arithmetic sum of two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 add(BitVector4 x, BitVector4 y)
            => (byte)Mod<N16>.mod(math.add(x.Scalar, y.Scalar));

        /// <summary>
        /// Computes the arithmetic sum of two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 add(BitVector8 x, BitVector8 y)
            => math.add(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the arithmetic sum of two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 add(BitVector16 x, BitVector16 y)
            => math.add(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the arithmetic sum of two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 add(BitVector32 x, BitVector32 y)
            => math.add(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the arithmetic sum of two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 add(BitVector64 x, BitVector64 y)
            => math.add(x.Scalar, y.Scalar);
 
    }
}