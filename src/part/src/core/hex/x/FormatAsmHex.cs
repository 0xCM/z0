//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XHex
    {
        [Op]
        public static string FormatAsmHex(this sbyte src, int? digits = null)
            => HexFormat.asmhex(src,digits);

        [Op]
        public static string FormatAsmHex(this byte src, int? digits = null)
            => HexFormat.asmhex(src,digits);

        [Op]
        public static string FormatAsmHex(this short src, int? digits = null)
            => HexFormat.asmhex(src,digits);

        [Op]
        public static string FormatAsmHex(this ushort src, int? digits = null)
            => HexFormat.asmhex(src,digits);

        [Op]
        public static string FormatAsmHex(this int src, int? digits = null)
            => HexFormat.asmhex(src,digits);

        [Op]
        public static string FormatAsmHex(this uint src, int? digits = null)
            => HexFormat.asmhex(src,digits);

        [Op]
        public static string FormatAsmHex(this ulong src, int? digits = null)
            => HexFormat.asmhex(src,digits);

        [Op]
        public static string FormatAsmHex(this long src, int? digits = null)
            => HexFormat.asmhex(src,digits);

        [Op]
        public static string FormatAsmHex(this ushort src, NumericWidth width)
            => HexFormat.asmhex(src, width);

        [Op]
        public static string FormatAsmHex(this uint src, NumericWidth width)
            => HexFormat.asmhex(src, width);


        [Op]
        public static string FormatAsmHex(this ulong src, NumericWidth width)
            => HexFormat.asmhex(src, width);

        [Op]
        public static string FormatTrimmedAsmHex(this ushort src)
            => src.FormatAsmHex(Numeric.effwidth(src));

        [Op]
        public static string FormatTrimmedAsmHex(this uint src)
            => src.FormatAsmHex(Numeric.effwidth(src));

        [Op]
        public static string FormatTrimmedAsmHex(this ulong src)
            => src.FormatAsmHex(Numeric.effwidth(src));
    }
}