//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <typeparam name="T">The primal bitvector type</typeparam>
        [MethodImpl(Inline), Nor, Closures(UnsignedInts)]
        public static BitVector<T> nor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.nor(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <typeparam name="T">The primal bitvector type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> nor<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.nor(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <typeparam name="T">The primal bitvector type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> nor<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vnor(x.Data,y.Data);

        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Nor]
        public static BitVector4 nor(BitVector4 x, BitVector4 y)
            => gmath.nor(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Nor]
        public static BitVector8 nor(BitVector8 x, BitVector8 y)
            => gmath.nor(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Nor]
        public static BitVector16 nor(BitVector16 x, BitVector16 y)
            => gmath.nor(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Nor]
        public static BitVector32 nor(BitVector32 x, BitVector32 y)
            => gmath.nor(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Nor]
        public static BitVector64 nor(BitVector64 x, BitVector64 y)
            => gmath.nor(x.Data, y.Data); 
   }
}