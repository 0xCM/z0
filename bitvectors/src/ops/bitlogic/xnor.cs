//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    partial class BitVector
    {        
        /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> xnor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.xnor(x.Scalar, y.Scalar);
         
        /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 xnor(BitVector4 x, BitVector4 y)
            => gmath.xnor(x.Scalar,y.Scalar);

        /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 xnor(BitVector8 x, BitVector8 y)
            => gmath.xnor(x.Scalar,y.Scalar);

        /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 xnor(BitVector16 x, BitVector16 y)
            => gmath.xnor(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 xnor(BitVector32 x, BitVector32 y)
            => gmath.xnor(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 xnor(BitVector64 x, BitVector64 y) 
            => gmath.xnor(x.Scalar, y.Scalar);  
   }
}