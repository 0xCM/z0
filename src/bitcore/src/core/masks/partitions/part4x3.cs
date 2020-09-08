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

    partial class Bits
    {
        /// <summary>
        /// Partitions the first 12 bits of a 32-bit source value into 3 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte part4x3(uint src, ref byte dst)
        {
            seek(dst, 0) = (byte)((src >> 0) & L.Lsb8x8x4);
            seek(dst, 1) = (byte)((src >> 4) & L.Lsb8x8x4);
            seek(dst, 2) = (byte)((src >> 8) & L.Lsb8x8x4);
            return ref dst;
        }
    }
}