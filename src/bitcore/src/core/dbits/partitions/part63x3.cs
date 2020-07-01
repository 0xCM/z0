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
        public static void part63x3(ulong src, ref byte dst)
        {
            const ulong M = BitMasks.Lsb64x8x3;
            
            var x = BitMask.lo(n63) & src;
            seek64(dst, 0) = Bits.scatter(x, M); 
            seek64(dst, 1) = Bits.scatter(x >> 24, M); 
            seek64(dst, 2) = Bits.scatter(x >> 48, M); 
        }
    }
}