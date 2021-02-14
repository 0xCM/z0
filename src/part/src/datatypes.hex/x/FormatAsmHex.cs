//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static HexFormatSpecs;

    partial class XHex
    {
        [Op]
        public static string FormatAsmHex(this sbyte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this byte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this short src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this ushort src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this int src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this uint src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x8")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this ulong src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this long src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;


        [Op]
        public static string FormatAsmHex(this ulong src, NumericWidth width)
        {
            return width switch{
                    NumericWidth.W8 => ((byte)src).FormatAsmHex(2),
                    NumericWidth.W16 => ((ushort)src).FormatAsmHex(4),
                    NumericWidth.W32 => ((uint)src).FormatAsmHex(8),
                    _ => src.FormatAsmHex(12),
            };
        }

        [Op]
        public static string FormatTrimmedAsmHex(this ulong src)
            => src.FormatAsmHex(Numeric.effwidth(src));
    }
}