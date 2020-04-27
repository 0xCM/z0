//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        public static void AppendDelimited<T>(this StringBuilder sb, object content, T pad, char delimiter)
            where T : unmanaged, Enum
        {
            if(sb == null)
                throw new Exception("Your string builder is null!!");

            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content}".PadRight(EnumFormatter.numeric<T,int>(pad)));
        }

        public static void AppendDelimited(this StringBuilder sb, object content, int pad, char delimiter)
        {
            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content}".PadRight(pad));
        }

        public static void AppendDelimited(this StringBuilder sb, object content, char delimiter)
        {
            sb.Append(text.rspace(delimiter));                        
            sb.Append(content);
        }

        /// <summary>
        /// Delimits labeled content to produce '{delimiter} {label}{sep} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to delimit</param>
        /// <param name="pad">The right-padded content width</param>
        /// <param name="delimiter">The content delimiter</param>
        public static void AppendDelimited(this StringBuilder sb, string label, char sep, object content, int pad, char delimiter)
        {
            sb.Append(Chars.Space);
            sb.Append(delimiter);
            sb.Append(Chars.Space);
            sb.AppendLabel(label, sep);
            sb.Append($"{content}".PadRight(pad));
        }

        /// <summary>
        /// Delimits labeled formattable content to produce '{delimiter} {label}{sep} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to delimit</param>
        /// <param name="pad">The right-padded content width</param>
        /// <param name="delimiter">The content delimiter</param>
        public static void AppendDelimited<T>(this StringBuilder sb, string label, char sep, T content, int pad, char delimiter)
            where T : ICustomFormattable
        {
            sb.Append(Chars.Space);
            sb.Append(delimiter);
            sb.Append(Chars.Space);
            sb.AppendLabel(label, sep);
            sb.Append($"{content.Format()}".PadRight(pad));
        }        
    }
}