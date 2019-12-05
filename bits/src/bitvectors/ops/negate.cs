//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 negate(BitVector4 x)
            => gmath.negate(x.data);
            
        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 negate(BitVector8 x)
            => gmath.negate(x.data);

        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 negate(BitVector16 x)
            => gmath.negate(x.data);

        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 negate(BitVector32 x)
            => gmath.negate(x.data);

        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 negate(BitVector64 x)
            => gmath.negate(x.data);

        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> negate<T>(BitVector<T> x)
            where T : unmanaged
                => gmath.negate(x.Scalar);

        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> negate<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.negate(x.Scalar);

        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> negate<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => ginx.vnegate(x.data);
    }
}