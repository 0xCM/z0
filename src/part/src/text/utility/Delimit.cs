//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    partial class XText
    {
        public static void Delimit<T>(this StringBuilder sb, string content, Padding pad, char delimiter = FieldDelimiter)
        {
            sb.Append(text.rspace(delimiter));
            sb.Append($"{content}".PadRight((int)pad));
        }

        public static void Delimit<T>(this StringBuilder sb, T content, Padding pad, char delimiter = FieldDelimiter)
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

        public static void Delimit(this StringBuilder sb, object content, Padding pad, char delimiter = FieldDelimiter)
        {
            sb.Append(text.rspace(delimiter));
            sb.Append($"{content}".PadRight((int)pad));
        }

        public static void Delimit(this StringBuilder sb, object content, char delimiter = FieldDelimiter)
        {
            sb.Append(text.rspace(delimiter));
            sb.Append(content);
        }
    }
}