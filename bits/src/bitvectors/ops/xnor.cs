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
        
        [MethodImpl(Inline)]
        public static BitVector<T> xnor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.xnor(x.Data, y.Data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xnor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 xnor(BitVector4 x, BitVector4 y)
            => math.xnor(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xnor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 xnor(BitVector8 x, BitVector8 y)
            => math.xnor(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xnor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 xnor(BitVector16 x, BitVector16 y)
            => math.xnor(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xnor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 xnor(BitVector32 x, BitVector32 y)
            => math.xnor(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xnor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 xnor(BitVector64 x, BitVector64 y) 
            => math.xnor(x.data, y.data);
    }
}