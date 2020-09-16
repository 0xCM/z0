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
            => BitConverter.GetBytes(src).FormatHexBytes();

        public static string FormatHexBytes(this ulong src)
            => BitConverter.GetBytes(src).FormatHexBytes();

        public static string FormatHexBytes(this byte[] src, HexFormatOptions config)
            => Hex.format(src,config);

        public static string FormatHexBytes(this byte[] src)
            => Hex.format(src);

        public static string FormatHexBytes(this byte[] src, char sep, bool zpad = true, bool specifier = true)
            => Hex.format(src, sep, zpad, specifier);

        public static string FormatHexBytes(this ReadOnlySpan<byte> src, char sep, bool zpad = true, bool specifier = true,
            bool uppercase = false, bool prespec = true, int? segwidth = null)
                => Hex.format(src,sep,zpad,specifier,uppercase,prespec,segwidth);
    }
}