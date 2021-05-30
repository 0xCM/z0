//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static BitMasks.Literals;

    partial struct BitPack
    {
        /// <summary>
        /// [11:0] => [11:9 | 8:6 | 5:3 | 2:0]
        /// Partitions the first 12 bits of a 16-bit source into 4 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte pack3x4(ushort src, ref byte dst)
        {
            pack3x3(src, ref dst);
            seek(dst, 3) = (byte)(src >> 9 & Lsb8x8x3);
            return ref dst;
        }
    }
}