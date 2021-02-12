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
        public static string FormatAsmHex(this byte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this ushort src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this uint src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x8")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this ulong src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string FormatAsmHex(this int src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string FormatSmallHex(this ulong src, bool postspec = false)
            => src.ToString("x4") + (postspec ? $"{PostSpec}" : string.Empty);

        [Op]
        public static string FormatSmallHex(this uint src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);

        [Op]
        public static string FormatSmallHex(this ushort src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);
    }
}