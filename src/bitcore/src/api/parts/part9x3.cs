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
        /// Partitions the first 9 bits of a 32-bit source value into 3 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline), Op]
        public static ref byte part9x3(uint src, ref byte dst)
        {
            part6x3(src, ref dst);
            seek(dst, 2) = (byte)(src >> 6 & Lsb8x8x3);
            return ref dst;
        }
    }
}