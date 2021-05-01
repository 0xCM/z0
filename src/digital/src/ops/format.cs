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

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    partial struct Digital
    {
        public static string format(ReadOnlySpan<BinaryDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            render(src,dst);
            return text.@string(dst);
        }

        public static string format(ReadOnlySpan<DecimalDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            render(src,dst);
            return text.@string(dst);
        }

        public static string format(ReadOnlySpan<HexDigit> src)
            => Hex.format(src);

        public static string format(Base16 @base, UpperCased @case, ReadOnlySpan<byte> src)
            => Hex.format(@case, src);
    }
}