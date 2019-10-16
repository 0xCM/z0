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
        /// Computes the XOR between two generic bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            if(x.SingleCell && y.SingleCell)
                return gmath.xor(x.Data[0], y.Data[0]);
            else
                return xor_multicell(x,y);
        }

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 xor(BitVector4 x, BitVector4 y)
            => math.xor(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 xor(BitVector8 x, BitVector8 y)
            => math.xor(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 xor(BitVector16 x, BitVector16 y)
            => math.xor(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 xor(BitVector32 x, BitVector32 y)
            => math.xor(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 xor(BitVector64 x, BitVector64 y)
            => math.xor(x.data, y.data);
 
        [MethodImpl(Inline)]
        static BitVector<T> xor_multicell<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => mathspan.xor(x.Data.ReadOnly(),y.Data.ReadOnly());
    }
}