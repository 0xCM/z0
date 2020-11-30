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
    using static BitMasks;

    partial struct BitParts
    {
        /// <summary>
        /// Partitions a 16-bit source value into 4 8-bit target segments
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte part4x4(ushort src, ref byte dst)
        {
            seek32(dst, 0) = scatter(src, L.Lsb32x8x4);
            return ref dst;
        }
    }

}