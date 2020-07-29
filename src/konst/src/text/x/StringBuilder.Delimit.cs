//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    partial class XTend
    {
        public static void Delimit<T>(this StringBuilder sb, string content, Padding pad, char delimiter = Chars.Pipe)
        {
            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content}".PadRight((int)pad));
        }

        public static void Delimit<T>(this StringBuilder sb, T content, Padding pad, char delimiter = Chars.Pipe)
            where T : ITextual             
        {
            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content.Format()}".PadRight((int)pad));
        }

        public static void Delimit<F,T>(this StringBuilder sb, F field, T content, char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
            where T : ITextual             
        {
            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content.Format()}".PadRight(text.width(field)));
        }

        public static void Delimit<F>(this StringBuilder sb, F field, object content, char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
        {
            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content}".PadRight(text.width(field)));
        }
        
        public static void Delimit(this StringBuilder sb, object content, Padding pad, char delimiter = Chars.Pipe)
        {
            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content}".PadRight((int)pad));
        }

        public static void Delimit(this StringBuilder sb, object content, char delimiter = Chars.Pipe)
        {
            sb.Append(text.rspace(delimiter));                        
            sb.Append(content);
        }
    }
}