//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Not, Closures(UnsignedInts)]
        public static BitVector<T> not<T>(BitVector<T> x)
            where T : unmanaged
                => gmath.not(x.Data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> not<N,T>(BitVector<N,T> x)
            where N : unmanaged,ITypeNat
            where T : unmanaged
                => gmath.not(x.Data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> not<N,T>(in BitVector128<N,T> x)
            where N : unmanaged,ITypeNat
            where T : unmanaged
                => gvec.vnot(x.Data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline), Not]
        public static BitVector4 not(BitVector4 x)
            => gmath.not(x.Data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline), Not]
        public static BitVector8 not(BitVector8 x)
            => gmath.not(x.Data);
            
        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline), Not]
        public static BitVector16 not(BitVector16 x)
            => gmath.not(x.Data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline), Not]
        public static BitVector32 not(BitVector32 x)
            => gmath.not(x.Data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline), Not]
        public static BitVector64 not(BitVector64 x)
            => gmath.not(x.Data);
    }
}