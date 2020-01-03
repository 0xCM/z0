//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector4 select(BitVector4 x, BitVector4 y, BitVector4 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise selection among three source vectors
        /// </summary>
        /// <param name="x">The pivot vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector8 select(BitVector8 x, BitVector8 y, BitVector8 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector16 select(BitVector16 x, BitVector16 y, BitVector16 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector32 select(BitVector32 x, BitVector32 y, BitVector32 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector64 select(BitVector64 x, BitVector64 y, BitVector64 z)
            => gmath.select(x.data, y.data, z.data);
 
        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector<T> select<T>(BitVector<T> x, BitVector<T> y, BitVector<T> z)
            where T : unmanaged
                => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> select<N,T>(BitVector<N,T> x, BitVector<N,T> y, BitVector<N,T> z)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> select<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y, in BitVector128<N,T> z)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => ginx.vselect(x.data, y.data, z.data); 
   }
}