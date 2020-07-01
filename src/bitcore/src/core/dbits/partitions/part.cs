//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static As;
    using static Typed;
       
    partial class Bits
    {
        /// <summary>
        /// Partitions the first 63 bits of a 64 bit source value into 21 8-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline), Op]
        public static void part(ulong src, N63 count, N3 wSrc, N8 wDst, ref byte dst)
        {
            const ulong M = BitMasks.Lsb64x8x3;

            var x = BitMask.lo(n63) & src;
            seek64(dst, 0) = scatter(x, M); 
            seek64(dst, 1) = scatter(x >> 24, M); 
            seek64(dst, 2) = scatter(x >> 48, M); 
        }
    }
}