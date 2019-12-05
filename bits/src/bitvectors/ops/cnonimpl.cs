//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Computes the converse nonimplication, z := x & ~y, for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 cnonimpl(BitVector4 x, BitVector4 y)
            => gmath.cnonimpl(x.data,y.data);

        /// <summary>
        /// Computes the converse nonimplication, z := x & ~y, for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 cnonimpl(BitVector8 x, BitVector8 y)
            => gmath.cnonimpl(x.data,y.data);

        /// <summary>
        /// Computes the converse nonimplication, z := x & ~y, for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 cnonimpl(BitVector16 x, BitVector16 y)
            => gmath.cnonimpl(x.data, y.data);

        /// <summary>
        /// Computes the converse nonimplication, z := x & ~y, for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 cnonimpl(BitVector32 x, BitVector32 y)
            => gmath.cnonimpl(x.data, y.data);

        /// <summary>
        /// Computes the converse nonimplication z := x & ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 cnonimpl(BitVector64 x, BitVector64 y)
            => gmath.cnonimpl(x.data, y.data);

        /// <summary>
        /// Computes the converse nonimplication, z := x & ~y, for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> cnonimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.cnonimpl(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the converse nonimplication, z := x & ~y, for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> cnonimpl<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.cnonimpl(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the converse nonimplication, z := x & ~y, for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> cnonimpl<N,T>(BitVector128<N,T> x, BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => ginx.vcnonimpl(x.data, y.data);


    }
}