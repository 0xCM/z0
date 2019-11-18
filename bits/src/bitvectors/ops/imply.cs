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
        /// Computes the material implication a -> b, i.e. a | ~b
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> impl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.impl(x.Data, y.Data);

        /// <summary>
        /// Computes the material implication a -> b, i.e. a | ~b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 impl(BitVector4 x, BitVector4 y)
            => math.impl(x.data,y.data);

        /// <summary>
        /// Computes the material implication a -> b, i.e. a | ~b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 impl(BitVector8 x, BitVector8 y)
            => math.impl(x.data,y.data);

        /// <summary>
        /// Computes the material implication a -> b, i.e. a | ~b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 impl(BitVector16 x, BitVector16 y)
            => math.impl(x.data, y.data);

        /// <summary>
        /// Computes the material implication a -> b, i.e. a | ~b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 impl(BitVector32 x, BitVector32 y)
            => math.impl(x.data, y.data);

        /// <summary>
        /// Computes the material implication a -> b, i.e. a | ~b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 impl(BitVector64 x, BitVector64 y)
            => math.impl(x.data, y.data);
    }
}