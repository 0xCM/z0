//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XTend
    {
        public static string FormatHexBytes(this ushort src)
            => HexFormat.format(memory.bytes2(src), HexFormatSpecs.HexData);

        public static string FormatHexBytes(this short src)
            => HexFormat.format(memory.bytes2(src), HexFormatSpecs.HexData);

        public static string FormatHexBytes(this int src)
            => HexFormat.format(memory.bytes2(src), HexFormatSpecs.HexData);

        public static string FormatHexBytes(this uint src)
            => HexFormat.format(memory.bytes2(src), HexFormatSpecs.HexData);

        public static string FormatHexBytes(this long src)
            => HexFormat.format(memory.bytes2(src), HexFormatSpecs.HexData);

        public static string FormatHexBytes(this ulong src)
            => HexFormat.format(memory.bytes2(src), HexFormatSpecs.HexData);
    }
}