//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using L = BitMasks.Literals;

    partial class BitMasks
    {
        /// <summary>
        /// Partitions the first 63 bits of a 64 bit source value into 21 8-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline), Op]
        public static void part63x3(ulong src, ref byte dst)
        {
            var x = BitMasks.lo(n63) & src;
            seek64(dst, 0) = scatter(x, L.Lsb64x8x3);
            seek64(dst, 1) = scatter(x >> 24, L.Lsb64x8x3);
            seek64(dst, 2) = scatter(x >> 48, L.Lsb64x8x3);
        }
    }
}