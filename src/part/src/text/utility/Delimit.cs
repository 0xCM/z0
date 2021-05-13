//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    partial class XText
    {


        [MethodImpl(Inline)]
        public static DelimitedIndex<T> Delimit<T>(this T[] src, char delimiter = FieldDelimiter, int pad = 0)
            => new DelimitedIndex<T>(src, delimiter, pad);

        [MethodImpl(Inline)]
        public static DelimitedIndex<T> Delimit<T>(this IEnumerable<T> src, char delimiter = FieldDelimiter, int pad = 0)
            => new DelimitedIndex<T>(src.Array(), delimiter, pad);

        [MethodImpl(Inline)]
        public static DelimitedSpan<T> Delimit<T>(this ReadOnlySpan<T> src, char delimiter = FieldDelimiter, int pad = 0)
            => Seq.delimit(delimiter, pad, src);

        [MethodImpl(Inline)]
        public static DelimitedSpan<T> Delimit<T>(this Span<T> src, char delimiter = FieldDelimiter, int pad = 0)
            => Seq.delimit(delimiter, pad, src);

        [MethodImpl(Inline)]
        public static DelimitedIndex<T> Delimit<T>(this IIndex<T> src, char delimiter = Chars.Comma, int pad = 0)
            => new DelimitedIndex<T>(src.Storage, delimiter, pad);

        public static void Delimit<T>(this StringBuilder sb, string content, char delimiter, int pad)
        {
            sb.Append(text.rspace(delimiter));
            sb.Append($"{content}".PadRight((int)pad));
        }

        public static void Delimit<T>(this StringBuilder sb, T content, char delimiter, int pad)
            where T : ITextual
        {
            sb.Append(text.rspace(delimiter));
            sb.Append($"{content.Format()}".PadRight((int)pad));
        }

        public static void Delimit<F,T>(this StringBuilder sb, F field, T content, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where T : ITextual
        {
            sb.Append(text.rspace(delimiter));
            sb.Append($"{content.Format()}".PadRight(text.width(field)));
        }

        public static void Delimit<F>(this StringBuilder sb, F field, object content, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            sb.Append(text.rspace(delimiter));
            sb.Append($"{content}".PadRight(text.width(field)));
        }
    }
}