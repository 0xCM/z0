//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;
    using static core;
    using static BitMasks;
    using static BitMasks.Literals;

    partial struct BitPack
    {
        /// <summary>
        /// Partitions the first 24 bits of a 32-bit source value into 9 3-bit target segments
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte pack3x8(uint src, ref byte dst)
        {
            seek64(dst, 0) = scatter(src, Lsb64x8x3);
            return ref dst;
        }
    }
}