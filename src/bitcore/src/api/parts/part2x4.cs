//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static BitMasks.Literals;

    partial struct BitParts
    {
        /// <summary>
        /// Partitions an 8-bit source value into 2 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte part2x4(byte src, ref byte dst)
        {
            seek(dst, 0) = (byte)((src >> 0) & Lsb8x8x4);
            seek(dst, 1) = (byte)((src >> 4) & Lsb8x8x4);
            return ref dst;
        }
    }
}