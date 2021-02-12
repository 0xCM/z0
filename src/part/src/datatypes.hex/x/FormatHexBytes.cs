//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial class XHex
    {
        [Op]
        public static string FormatHexBytes(this ushort src)
            => HexFormat.format(bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexBytes(this short src)
            => HexFormat.format(bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexBytes(this int src)
            => HexFormat.format(bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexBytes(this uint src)
            => HexFormat.format(bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexBytes(this long src)
            => HexFormat.format(bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexBytes(this ulong src)
            => HexFormat.format(bytes(src), HexFormatSpecs.HexData);
    }
}