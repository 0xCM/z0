//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static HexFormatSpecs;
    using static memory;

    partial class XHex
    {
        [Op]
        public static string FormatHexData(this byte src)
            => src.FormatHex(HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexData(this sbyte src)
            => src.FormatHex(HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexData(this short src)
            => src.FormatHex(HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexData(this ushort src)
            => src.FormatHex(HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexData(this int src)
            => src.FormatHex(HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexData(this uint src)
            => src.FormatHex(HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexData(this ulong src)
            => src.FormatHex(HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexData(this long src)
            => src.FormatHex(HexFormatSpecs.HexData);

        [Op]
        public static string FormatHexData(this ulong src, byte count)
        {
            if(count <= 8)
            {
                var data = slice(bytes(src), 0, count);
                return HexFormat.format(data, HexFormatSpecs.HexData);
            }
            return "!!FormatError!!";
        }
    }
}