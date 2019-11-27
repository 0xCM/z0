//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> not<T>(BitVector<T> x)
            where T : unmanaged
                => gmath.not(x.Scalar);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> not<N,T>(BitVector<N,T> x)
            where N : unmanaged,ITypeNat
            where T : unmanaged
                => gmath.not(x.Scalar);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> not<N,T>(in BitVector128<N,T> x)
            where N : unmanaged,ITypeNat
            where T : unmanaged
                => ginx.vnot(x.data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 not(BitVector4 x)
            => gmath.not(x.data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 not(BitVector8 x)
            => gmath.not(x.data);
            
        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 not(BitVector16 x)
            => gmath.not(x.data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 not(BitVector32 x)
            => gmath.not(x.data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 not(BitVector64 x)
            => gmath.not(x.data);
 
        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector128 not(in BitVector128 x)
        {
            var z = alloc(n128);
            vblock.not(n128, in x.x0, ref z.x0);
            return z;
        }
    }
}