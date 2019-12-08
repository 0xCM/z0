//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class BitVector
    {

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 nonimpl(BitVector4 x, BitVector4 y)
            => math.nonimpl(x.data,y.data);

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 nonimpl(BitVector8 x, BitVector8 y)
            => math.nonimpl(x.data,y.data);

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 nonimpl(BitVector16 x, BitVector16 y)
            => math.nonimpl(x.data, y.data);

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 nonimpl(BitVector32 x, BitVector32 y)
            => math.nonimpl(x.data, y.data);

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 nonimpl(BitVector64 x, BitVector64 y)
            => math.nonimpl(x.data, y.data);

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> nonimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.nonimpl(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> nonimpl<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.nonimpl(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> nonimpl<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => ginx.vnonimpl(x.data, y.data);

    }
}