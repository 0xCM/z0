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

    partial struct BitParts
    {
        /// <summary>
        /// Partitions a 16-bit source value into 2 segments of width 8
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline), Op]
        public static ref byte part2x8(ushort src, ref byte dst)
        {
            seek16(dst,0) = src;
            return ref dst;
        }
    }
}