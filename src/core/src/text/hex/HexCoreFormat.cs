//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    partial class XTend
    {
        [Op]
        public static string HexCoreFormat(this ReadOnlySpan<byte> src, in HexFormatOptions config)
            => HexFormatter.format(src,config);

        [Op]
        public static string HexCoreFormat(this Span<byte> src, in HexFormatOptions config)
            => HexFormatter.format(src.ReadOnly(), config);

        [Op]
        public static string HexCoreFormat(this byte[] src, in HexFormatOptions config)
            => HexFormatter.format(@readonly(src),config);
    }
}