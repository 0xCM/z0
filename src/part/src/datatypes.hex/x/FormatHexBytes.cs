//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XTend
    {
        public static string FormatHexBytes(this uint src)
            => HexFormat.format(memory.bytes(src));

        public static string FormatHexBytes(this ulong src)
            => HexFormat.format(memory.bytes(src));

        public static string FormatHexBytes(this byte[] src, HexFormatOptions config)
            => HexFormat.format(src, config);

        public static string FormatHexBytes(this byte[] src)
            => HexFormat.format(src);

        public static string FormatHexBytes(this byte[] src, char sep, bool zpad = true, bool specifier = true)
            => HexFormat.format(src, sep, zpad, specifier);

        public static string FormatHexBytes(this ReadOnlySpan<byte> src, char sep, bool zpad = true, bool specifier = true,
            bool uppercase = false, bool prespec = true, int? segwidth = null)
                => HexFormat.format(src, sep, zpad, specifier, uppercase, prespec, segwidth);

        public static string FormatHexBytes(this Span<byte> src, char sep, bool zpad = true, bool specifier = true,
            bool uppercase = false, bool prespec = true, int? segwidth = null)
                => HexFormat.format(src, sep, zpad, specifier, uppercase, prespec, segwidth);
    }
}