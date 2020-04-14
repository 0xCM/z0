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
        public static string FormatBlockedBits(this byte src, BitFormatConfig config)
            => Api.blocked(src, config);

        public static string FormatBlockedBits(this ushort src, BitFormatConfig config)
            => Api.blocked(src, config);

        public static string FormatBlockedBits(this uint src, BitFormatConfig config)
            => Api.blocked(src, config);

        public static string FormatBlockedBits(this ulong src, BitFormatConfig config)
            => Api.blocked(src, config);

        public static string FormatBlockedBits(this byte src, int width)
            => Api.blocked(src, BitFormatConfig.Blocked(width));

        public static string FormatBlockedBits(this ushort src, int width)
            => Api.blocked(src, BitFormatConfig.Blocked(width));

        public static string FormatBlockedBits(this uint src, int width)
            => Api.blocked(src, BitFormatConfig.Blocked(width));

        public static string FormatBlockedBits(this ulong src, int width)
            => Api.blocked(src, BitFormatConfig.Blocked(width));
    }
}