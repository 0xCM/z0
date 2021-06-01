//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    partial struct Digital
    {
        [Op]
        public static string format(ReadOnlySpan<BinaryDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            render(src,dst);
            return text.@string(dst);
        }

        [Op]
        public static string format(ReadOnlySpan<DecimalDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            render(src,dst);
            return text.@string(dst);
        }

        public static string format<C>(C @case, ReadOnlySpan<HexDigit> src)
            where C : unmanaged, ILetterCase
        {
            Span<char> buffer = stackalloc char[src.Length];
            return format(@case, src, buffer);
        }

        [MethodImpl(Inline)]
        public static string format<C>(C @case, ReadOnlySpan<HexDigit> src, Span<char> buffer)
            where C : unmanaged, ILetterCase
        {
            var count = Hex.render(@case, src, buffer);
            return new string(slice(buffer,0,count));
        }
    }
}