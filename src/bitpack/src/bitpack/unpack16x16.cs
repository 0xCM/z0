//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static cpu;

    partial struct BitPack
    {
        /// <summary>
        /// Projects 16 8-bit segments onto 16 16-bit targets
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ushort> unpack16x16(in Cell128 src)
            => recover<ushort>(bytes(vinflate256x16u(src)));

        /// <summary>
        /// Projects 16 8-bit segments onto 16 16-bit targets
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="src">The target</param>
        [MethodImpl(Inline), Op]
        public static void unpack16x16(in Cell128 src, Span<ushort> dst)
            => gcpu.vstore(vinflate256x16u(src), dst);

    }
}