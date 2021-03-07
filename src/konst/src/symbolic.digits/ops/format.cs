//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static Asci;

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    partial struct Digital
    {
        public static string format(ReadOnlySpan<BinaryDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            Digital.render(src,dst);
            return @string(dst);
        }

        public static string format(ReadOnlySpan<DecimalDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            Digital.render(src,dst);
            return @string(dst);
        }

        public static string format(ReadOnlySpan<HexDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            Digital.render(src,dst);
            return @string(dst);
        }

        public static string format(Base16 @base, UpperCased @case, ReadOnlySpan<byte> src)
        {
            Span<char> digits = stackalloc char[src.Length*3];
            Digital.render(@base, @case, src,digits);
            return @string(digits);
        }

        public static string format(in BinaryCode src)
        {
            var dst = span<char>(src.Length);
            decode(src,dst);
            return sys.@string(dst);
        }

    }
}