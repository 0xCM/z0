//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Seed;
    using static HexSpecs;

    partial class XTend
    {        
        public static string FormatHexBytes(this byte[] src, char sep, bool zpad = true, bool specifier = true)
            => src.ToReadOnlySpan().FormatHexBytes(sep, zpad, specifier, false, true, null);

        public static string FormatHexBytes(this ReadOnlySpan<byte> src, char sep = Chars.Comma, bool zpad = true, bool specifier = true, 
            bool uppercase = false, bool prespec = true, int? segwidth = null)
        {
            var builder = string.Empty.Build();
            var pre = (specifier && prespec) ? "0x" : string.Empty;
            var post = (specifier && !prespec) ? "h" : string.Empty;
            var spec = HexFmtSpec(uppercase);
            var width = segwidth ?? int.MaxValue;
            var counter = 0;
            if(segwidth != null)
                builder.AppendLine();

            for(var i=0; i<src.Length; i++)
            {                
                var value = src[i].ToString(spec);
                var padded = zpad ? value.PadLeft(2,AsciDigits.D0) : value;

                builder.Append(string.Concat(pre, padded, post));
                if(i != src.Length - 1)
                    builder.Append(sep);
                
                if(++counter == width)
                {
                    builder.AppendLine();
                    counter = 0;
                }                
            }
            return builder.ToString();
        }
    }
}