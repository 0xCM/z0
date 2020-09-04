//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Api = FormatBits;

    partial class XTend
    {
        public static string FormatBits(this byte src, BitFormat? config = null)
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this sbyte src, BitFormat? config = null)
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this short src, BitFormat? config = null)
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this ushort src, BitFormat? config = null)
            => Api.format(src, config ?? BitFormatter.configure());
        public static string FormatBits(this uint src, BitFormat? config = null)
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this int src, BitFormat? config = null)
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this ulong src, BitFormat? config = null)
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this long src, BitFormat? config = null)
            => Api.format(src, config ?? BitFormatter.configure());
    }
}