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
        /// Computes z := ~(x & y) for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> nand<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.nand(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes z := ~(x & y) for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 nand(BitVector4 x, BitVector4 y)
            => gmath.nand(x.data, y.data);

        /// <summary>
        /// Computes z := ~(x & y) for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 nand(BitVector8 x, BitVector8 y)
            => gmath.nand(x.data, y.data);

        /// <summary>
        /// Computes z := ~(x & y) for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 nand(BitVector16 x, BitVector16 y)
            => gmath.nand(x.data, y.data);

        /// <summary>
        /// Computes z := ~(x & y) for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 nand(BitVector32 x, BitVector32 y)
            => gmath.nand(x.data, y.data);

        /// <summary>
        /// Computes z := ~(x & y) for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 nand(BitVector64 x, BitVector64 y)
            => gmath.nand(x.data, y.data);
 
        /// <summary>
        /// Computes z := ~(x & y) for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128 nand(BitVector128 x, BitVector128 y)
            => from(n128, gmath.nand(x.x0, y.x0), gmath.nand(x.x1,  y.x1));
    }
}