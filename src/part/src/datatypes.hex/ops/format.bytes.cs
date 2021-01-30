//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static HexFormatSpecs;

    partial struct HexFormat
    {
        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<byte> src, in HexFormatOptions config)
            => format(src, config.Delimiter, config.ZPad, config.Specifier);

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<byte> src, char sep, bool zpad = true, bool specifier = true)
            => format(src, sep, zpad, specifier, false, true, null);

        [Op]
        public static string format(ReadOnlySpan<byte> src, char sep, bool zpad, bool specifier, bool uppercase, bool prespec, int? segwidth)
        {
            var dst = Strings.build();
            var size = src.Length;
            var pre = (specifier && prespec) ? "0x" : EmptyString;
            var post = (specifier && !prespec) ? "h" : EmptyString;
            var spec = CaseSpec(uppercase).ToString();
            var width = segwidth ?? int.MaxValue;
            var counter = 0;
            if(segwidth != null)
                dst.AppendLine();

            for(var i=0; i<size; i++)
            {
                var value = src[i].ToString(spec);
                var padded = zpad ? value.PadLeft(2, Chars.D0) : value;

                dst.Append(string.Concat(pre, padded, post));
                if(i != src.Length - 1)
                    dst.Append(sep);

                if(++counter == width)
                {
                    dst.AppendLine();
                    counter = 0;
                }
            }

            return dst.ToString();
        }
    }
}