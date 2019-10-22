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
        /// Computes the bitwise OR between two generic bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> or<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.or(x.Data,y.Data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 or(BitVector4 x, BitVector4 y)
            => math.or(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 or(BitVector8 x, BitVector8 y)
            => math.or(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 or(BitVector16 x, BitVector16 y)
            => math.or(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 or(BitVector32 x, BitVector32 y)
            => math.or(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 or(BitVector64 x, BitVector64 y)
            => math.or(x.data, y.data);
    }
}