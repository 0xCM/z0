//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        [Op]
        public static string FormatHexBytes(this ushort src)
            => HexMemoryFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this short src)
            => HexMemoryFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this int src)
            => HexMemoryFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this uint src)
            => HexMemoryFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this long src)
            => HexMemoryFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this ulong src)
            => HexMemoryFormat.bytes(src);
    }
}