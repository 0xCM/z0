//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Computes the material implication a -> b, i.e. a | ~b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 impl(BitVector4 x, BitVector4 y)
            => gmath.impl(x.data,y.data);

        /// <summary>
        /// Computes the material implication a -> b, i.e. a | ~b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 impl(BitVector8 x, BitVector8 y)
            => gmath.impl(x.data,y.data);

        /// <summary>
        /// Computes the material implication z := x | ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 impl(BitVector16 x, BitVector16 y)
            => gmath.impl(x.data, y.data);

        /// <summary>
        /// Computes the material implication z := x | ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 impl(BitVector32 x, BitVector32 y)
            => gmath.impl(x.data, y.data);

        /// <summary>
        /// Computes the material implication z := x | ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 impl(BitVector64 x, BitVector64 y)
            => math.impl(x.data, y.data);

        /// <summary>
        /// Computes the material implication z := x | ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> impl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.impl(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the material implication z := x | ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> impl<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.impl(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the material implication z := x | ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> impl<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => ginx.vimpl(x.data, y.data);
    }
}