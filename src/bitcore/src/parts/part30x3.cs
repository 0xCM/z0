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
        /// Partitions the first 30 bits of a 32-bit source value into 10 8-bitt target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline), Op]
        public static ref byte part30x3(uint src, ref byte dst)
        {
            seek64(dst, 0) = Bits.scatter(src, Lsb64x8x3);
            seek16(dst, 4) = (ushort)Bits.scatter(src >> 24, Lsb64x8x3);
            return ref dst;
        }
    }
}