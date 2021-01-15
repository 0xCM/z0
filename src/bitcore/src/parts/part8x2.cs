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
        /// Partitions the source into 4 target segments of physical width 8 and effective width 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline), Op]
        public static ref byte part8x2(byte src, ref byte dst)
            => ref part8x2((uint)src, ref dst);

        /// <summary>
        /// Partitions the first 8 bits of a 32-bit source into 4 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline), Op]
        public static ref byte part8x2(uint src, ref byte dst)
        {
            seek(dst, 0) = (byte)(src >> 0 & Lsb8x8x2);
            seek(dst, 1) = (byte)(src >> 2 & Lsb8x8x2);
            seek(dst, 2) = (byte)(src >> 4 & Lsb8x8x2);
            seek(dst, 3) = (byte)(src >> 6 & Lsb8x8x2);
            return ref dst;
        }
    }
}