//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static HexSpecs;

    partial class XTend
    {
        public static string FormatSmallHex(this ulong src, bool postspec = false)
            => src.ToString("x4") + (postspec ? $"{PostSpec}" : string.Empty);

        public static string FormatSmallHex(this byte src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);

        public static string FormatSmallHex(this uint src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);

        public static string FormatSmallHex(this ushort src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);
    }
}