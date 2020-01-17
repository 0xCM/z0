//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> select<T>(BitVector<T> x, BitVector<T> y, BitVector<T> z)
            where T : unmanaged
                => gmath.select(x.data, y.data, z.data);

  }
}