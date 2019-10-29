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

    partial class BitVector
    {
        /// <summary>
        /// Computes the converse nonimplication, equivalent to the bitwise expression x & (~y) for operands x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> cnotimply<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.cnotimply(x.Data, y.Data);

        /// <summary>
        /// Computes the converse nonimplication, equivalent to the bitwise expression x & (~y) for operands x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 cnotimply(BitVector4 x, BitVector4 y)
            => math.cnotimply(x.data,y.data);

        /// <summary>
        /// Computes the converse nonimplication, equivalent to the bitwise expression x & (~y) for operands x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 cnotimply(BitVector8 x, BitVector8 y)
            => math.cnotimply(x.data,y.data);

        /// <summary>
        /// Computes the converse nonimplication, equivalent to the bitwise expression x & (~y) for operands x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 cnotimply(BitVector16 x, BitVector16 y)
            => math.cnotimply(x.data, y.data);

        /// <summary>
        /// Computes the converse nonimplication, equivalent to the bitwise expression x & (~y) for operands x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 cnotimply(BitVector32 x, BitVector32 y)
            => math.cnotimply(x.data, y.data);

        /// <summary>
        /// Computes the vector z = x & ~y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 cnotimply(BitVector64 x, BitVector64 y)
            => math.cnotimply(x.data, y.data);
 
 
    }
}