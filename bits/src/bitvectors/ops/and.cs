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
        public static UInt4 and(UInt4 x, UInt4 y)
            => x & y;

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 and(BitVector4 x, BitVector4 y)
            => math.and(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 and(BitVector8 x, BitVector8 y)
            => math.and(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 and(BitVector16 x, BitVector16 y)
            => math.and(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 and(in BitVector32 x, in BitVector32 y)
            => math.and(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 and(BitVector64 x, BitVector64 y)
            => math.and(x.data, y.data);
 
 
        /// <summary>
        /// Computses the logical and in-place, x = x & y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector4 and(ref BitVector4 x, BitVector4 y)
        {
            x = math.and(x.data,y.data);
            return ref x;
        }

        /// <summary>
        /// Computses the logical and in-place, x = x & y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 and(ref BitVector8 x, BitVector8 y)
        {
            x = math.and(x.data,y.data);
            return ref x;
        }

        /// <summary>
        /// Computses the logical and in-place, x = x & y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 and(ref BitVector16 x, BitVector16 y)
        {
            x = math.and(x.data,y.data);
            return ref x;
        }

        /// <summary>
        /// Computses the logical and in-place, x = x & y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 and(ref BitVector32 x, BitVector32 y)
        {
            x = math.and(x.data,y.data);
            return ref x;
        }

        /// <summary>
        /// Computses the logical and in-place, x = x & y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 and(ref BitVector64 x, BitVector64 y)
        {
            x = math.and(x.data,y.data);
            return ref x;
        }

    }
}