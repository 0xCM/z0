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
    using static cpu;

    partial struct BitPack
    {
        /// <summary>
        /// Projects 16 8-bit integers partitioned from a 128-bit source onto 16 16-bit integers
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ushort> unpack16x16(in Cell128 src)
            => recover<ushort>(memory.bytes(vinflate256x16u(src)));
    }
}