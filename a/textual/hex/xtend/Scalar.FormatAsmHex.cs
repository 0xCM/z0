//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static HexSpecs;

    partial class XTend
    {
        public static string FormatAsmHex(this ulong src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;    

        public static string FormatAsmHex(this long src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;    

        public static string FormatAsmHex(this uint src, int? digits = null)        
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        public static string FormatAsmHex(this int src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        public static string FormatAsmHex(this ushort src)
            => src.ToString($"x4") + PostSpec;

        public static string FormatAsmHex(this byte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;
    }
}