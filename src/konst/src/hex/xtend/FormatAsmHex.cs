//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static HexSpecs;

    partial class XTend
    {
        public static string FormatAsmHex(this byte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2")) + PostSpec;

        public static string FormatAsmHex(this ushort src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4")) + PostSpec;    

        public static string FormatAsmHex(this uint src, int? digits = null)        
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x8")) + PostSpec;

        public static string FormatAsmHex(this ulong src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;    

        public static string FormatAsmHex(this int src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        public static string FormatSmallHex(this ulong src, bool postspec = false)
            => src.ToString("x4") + (postspec ? $"{PostSpec}" : string.Empty);

        public static string FormatSmallHex(this uint src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);

        public static string FormatSmallHex(this ushort src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);            
    }
}