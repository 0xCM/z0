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
        /// Computes the material implication z := x | ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> impl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.impl(x.Scalar, y.Scalar);

   }
}