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
        /// Computes a new bitvector z = x & y from bitvectors x andn y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 andn(BitVector4 x, BitVector4 y)
            => gbits.andn(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x andn y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 andn(BitVector8 x, BitVector8 y)
            => gbits.andn(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x andn y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 andn(BitVector16 x, BitVector16 y)
            => gbits.andn(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x andn y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 andn(BitVector32 x, BitVector32 y)
            => gbits.andn(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x andn y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 andn(BitVector64 x, BitVector64 y)
            => gbits.andn(x.data, y.data);
 
    }
}