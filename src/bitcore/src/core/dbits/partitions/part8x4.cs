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
       
    partial class Bits
    {
        /// <summary>
        /// Partitions a 32-bit source value into 8 4-bit segments distributed across 8 bytes
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static void part8x4(uint src, ref byte dst)
        {
            seek64(dst,0) = scatter(src, BitMasks.Lsb64x8x4); 
        }
    }
}