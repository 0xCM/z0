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
        /// Computes a new bitvector z = x & y from bitvectors x sub y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 sub(BitVector4 x, BitVector4 y)
            => math.add(x.data, negate(y.data));

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x sub y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 sub(BitVector8 x, BitVector8 y)
            => x + -y;

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x sub y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 sub(BitVector16 x, BitVector16 y)
            => x + -y;

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x sub y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 sub(BitVector32 x, BitVector32 y)
            => x + -y;

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x sub y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 sub(BitVector64 x, BitVector64 y)
            => x + -y;
 
    }
}