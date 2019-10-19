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
        public static BitVector<T> nand<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            if(x.SingleCell && y.SingleCell)
                return gmath.nand(x.Head, y.Head);
            else
                return nand_multicell(x,y);
        }

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 nand(BitVector4 x, BitVector4 y)
            => math.nand(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 nand(BitVector8 x, BitVector8 y)
            => math.nand(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 nand(BitVector16 x, BitVector16 y)
            => math.nand(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 nand(BitVector32 x, BitVector32 y)
            => math.nand(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x or y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 nand(BitVector64 x, BitVector64 y)
            => math.nand(x.data, y.data);
 
        [MethodImpl(NotInline)]
        static BitVector<T> nand_multicell<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => mathspan.nand(x.Data.ReadOnly(),y.Data.ReadOnly());

    }
}