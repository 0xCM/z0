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
        /// Computes the bitwise NAND between two generic vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static BitVector<T> nand<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.nand(x.Data, y.Data);

        /// <summary>
        /// Computes the bitwise NAND between two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 nand(BitVector4 x, BitVector4 y)
            => math.nand(x.data, y.data);

        /// <summary>
        /// Computes the bitwise NAND between two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 nand(BitVector8 x, BitVector8 y)
            => math.nand(x.data, y.data);

        /// <summary>
        /// Computes the bitwise NAND between two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 nand(BitVector16 x, BitVector16 y)
            => math.nand(x.data, y.data);

        /// <summary>
        /// Computes the bitwise NAND between two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 nand(BitVector32 x, BitVector32 y)
            => math.nand(x.data, y.data);

        /// <summary>
        /// Computes the bitwise NAND between two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 nand(BitVector64 x, BitVector64 y)
            => math.nand(x.data, y.data);
 
    }
}