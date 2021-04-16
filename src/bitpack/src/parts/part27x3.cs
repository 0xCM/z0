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
    using static BitMasks;
    using static BitMasks.Literals;

    partial struct BitParts
    {
        /// <summary>
        /// Partitions the first 27 bits of a 32-bit source value into 9 8-bit target segments
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte part27x3(uint src, ref byte dst)
        {
            seek64(dst, 0) = scatter(src, Lsb64x8x3);
            seek16(dst, 4) = (byte)scatter(src >> 24, Lsb64x8x3);
            return ref dst;
        }
    }
}