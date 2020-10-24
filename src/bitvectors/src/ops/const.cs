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
        /// Computes the bitwise TRUE operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline), True, Closures(Closure)]
        public static BitVector<T> @true<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.ones<T>();

        /// <summary>
        /// Computes the bitwise FALSE operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline), False, Closures(Closure)]
        public static BitVector<T> @false<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.zero<T>();
    }
}