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
        /// Computes the vector z = x & ~y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 andnot(BitVector4 x, BitVector4 y)
            => Bits.andnot(x.data,y.data);

        /// <summary>
        /// Computes the vector z = x & ~y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 andnot(BitVector8 x, BitVector8 y)
            => Bits.andnot(x.data,y.data);

        /// <summary>
        /// Computes the vector z = x & ~y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 andnot(BitVector16 x, BitVector16 y)
            => Bits.andnot(x.data, y.data);

        /// <summary>
        /// Computes the vector z = x & ~y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 andnot(BitVector32 x, BitVector32 y)
            => Bits.andnot(x.data, y.data);

        /// <summary>
        /// Computes the vector z = x & ~y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 andnot(BitVector64 x, BitVector64 y)
            => Bits.andnot(x.data, y.data);
 
    }
}