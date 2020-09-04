//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Api = FormatBits;

    partial class XTend
    {
        public static string FormatBlockedBits(this byte src, in BitFormat config)
            => Api.blocked(src, config);

        public static string FormatBlockedBits(this ushort src, in BitFormat config)
            => Api.blocked(src, config);

        public static string FormatBlockedBits(this uint src, in BitFormat config)
            => Api.blocked(src, config);

        public static string FormatBlockedBits(this ulong src, in BitFormat config)
            => Api.blocked(src, config);

        public static string FormatBlockedBits(this byte src, int width)
            => Api.blocked(src, BitFormatter.blocked(width));

        public static string FormatBlockedBits(this ushort src, int width)
            => Api.blocked(src, BitFormatter.blocked(width));

        public static string FormatBlockedBits(this uint src, int width)
            => Api.blocked(src, BitFormatter.blocked(width));

        public static string FormatBlockedBits(this ulong src, int width)
            => Api.blocked(src, BitFormatter.blocked(width));
    }
}