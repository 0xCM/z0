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
    using static memory;

    partial struct HexFormat
    {
        // [MethodImpl(Inline), Op]
        // public static string format(ReadOnlySpan<byte> src, in HexFormatOptions config)
        //     => format(src,config);

        // [MethodImpl(Inline), Op]
        // public static string format(ReadOnlySpan<byte> src, in HexFormatOptions config)
        //     => format(src, config.SegDelimiter, config.ZeroPad, config.Specifier);

        // [MethodImpl(Inline), Op]
        // public static string format(ReadOnlySpan<byte> src, char sep, bool zpad, bool specifier)
        //     => format(src, sep, zpad, specifier, false, true, null);

        [Op]
        public static string format(ReadOnlySpan<byte> src, in HexFormatOptions config)
        {
            int? blockwidth = null;
            var dst = text.build();
            var count = src.Length;
            var pre = (config.Specifier && config.PreSpec) ? "0x" : EmptyString;
            var post = (config.Specifier && !config.PreSpec) ? "h" : EmptyString;
            var spec = CaseSpec(config.Uppercase).ToString();
            var width = config.BlockWidth ?? uint.MaxValue;
            var counter = 0;

            for(var i=0; i<count; i++)
            {
                var value = skip(src,i).ToString(spec);
                var padded = config.ZeroPad ? value.PadLeft(2, Chars.D0) : value;
                dst.Append(string.Concat(pre, padded, post));
                if(config.DelimitSegs && i != count - 1)
                    dst.Append(config.SegDelimiter);

                if(++counter >= width && config.DelimitBlocks)
                {
                    if(config.BlockDelimiter == Chars.NL || config.BlockDelimiter == Chars.LineFeed)
                        dst.AppendLine();
                    else
                        dst.Append(config.BlockDelimiter);
                    counter = 0;
                }
            }

            return dst.ToString();
        }

        // [Op]
        // public static string format(ReadOnlySpan<byte> src, char sep, bool zpad, bool specifier, bool uppercase, bool prespec, int? segwidth)
        // {
        //     var dst = text.build();
        //     var size = src.Length;
        //     var pre = (specifier && prespec) ? "0x" : EmptyString;
        //     var post = (specifier && !prespec) ? "h" : EmptyString;
        //     var spec = CaseSpec(uppercase).ToString();
        //     var width = segwidth ?? int.MaxValue;
        //     var counter = 0;
        //     if(segwidth != null)
        //         dst.AppendLine();

        //     for(var i=0; i<size; i++)
        //     {
        //         var value = src[i].ToString(spec);
        //         var padded = zpad ? value.PadLeft(2, Chars.D0) : value;

        //         dst.Append(string.Concat(pre, padded, post));
        //         if(i != src.Length - 1)
        //             dst.Append(sep);

        //         if(++counter == width)
        //         {
        //             dst.AppendLine();
        //             counter = 0;
        //         }
        //     }

        //     return dst.ToString();
        // }
    }
}