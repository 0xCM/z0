//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class math
    {
        /// <summary>
        /// 64x64 -> 128 multiplication, reference implementation
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>
        /// Taken from https://github.com/chfast/intx/blob/master/include/intx/int128.hpp
        /// </returns>
        [MethodImpl(Inline), Op]
        public static Pair<ulong> mul128(ulong x, ulong y)
        {
            var xl = x & Max32u;
            var xh = x >> 32;
            var yl = y & Max32u;
            var yh = y >> 32;

            var t0 = xl * yl;
            var t1 = xh * yl;
            var t2 = xl * yh;
            var t3 = xh * yh;

            var u1 = t1 + (t0 >> 32);
            var u2 = t2 + (u1 & Max32u);

            var lo = (u2 << 32) | (t0 & Max32u);
            var hi = t3 + (u2 >> 32) + (u1 >> 32);
            return (lo,hi);
        }
    }
}