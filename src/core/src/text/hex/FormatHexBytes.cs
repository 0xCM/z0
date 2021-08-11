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
            => HexFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this short src)
            => HexFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this int src)
            => HexFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this uint src)
            => HexFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this long src)
            => HexFormat.bytes(src);

        [Op]
        public static string FormatHexBytes(this ulong src)
            => HexFormat.bytes(src);

        public static string FormatHexBytes<T>(this T src)
            where T : unmanaged
                => HexFormat.bytes(src);
    }
}