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
        /// Computes a new bitvector z = x & y from bitvectors x select y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 select(BitVector4 x, BitVector4 y)
            => gmath.select(x.data,y.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x select y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 select(BitVector8 x, BitVector8 y)
            => gmath.select(x.data,y.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x select y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 select(BitVector16 x, BitVector16 y)
            => gmath.select(x.data,y.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x select y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 select(BitVector32 x, BitVector32 y)
            =>gmath.select(x.data,y.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x select y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 select(BitVector64 x, BitVector64 y)
            => gmath.select(x.data,y.data,y.data);
    }
}