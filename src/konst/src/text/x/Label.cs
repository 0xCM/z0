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

    partial class XTend
    {
        /// <summary>
        /// Appends a label suffixed by a separator to produce '{label}{sep}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        [TextUtility]
        public static void Label(this StringBuilder sb, string label, char sep = Chars.Pipe)
        {
            sb.Append(label);
            sb.Append(sep);
            sb.Append(Chars.Space);
        }

        /// <summary>
        /// Appends labeled content to produce: '{label}{sep} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to append</param>
        [TextUtility]
        public static void Label(this StringBuilder sb, string label, char sep, object content)
        {
            sb.Label(label,sep);
            sb.Append(content);
        }


        /// <summary>
        /// Appends labeled content to produce: '{label}{sep} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to append</param>
        [TextUtility]
        public static void Label(this ITextBuffer sb, string label, char sep, object content)
        {
            sb.Label(label, sep);
            sb.Append(content?.ToString() ?? EmptyString);
        }

        /// <summary>
        /// Appends a label suffixed by a separator to produce '{label}{sep}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        [TextUtility]
        public static void Label(this ITextBuffer sb, string label, char sep = Chars.Pipe)
        {
            sb.Append(label);
            sb.Append(sep);
            sb.Append(Chars.Space);
        }

        /// <summary>
        /// Appends labeled formattable content to produce: '{label}{sep} {content}'
        /// </summary>
        /// <param name="dst">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to append</param>
        [TextUtility]
        public static void Label<T>(this ITextBuffer dst, string label, T content, char delimiter = Chars.Pipe)
            where T : ITextual
        {
            dst.Label(label,delimiter);
            dst.Append(content.Format());
        }

        /// <summary>
        /// Delimits labeled formattable content to produce '{delimiter} {label}{sep} {content}'
        /// </summary>
        /// <param name="dst">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to delimit</param>
        /// <param name="pad">The right-padded content width</param>
        /// <param name="delimiter">The content delimiter</param>
        [TextUtility]
        public static void Label<T>(this ITextBuffer dst, string label, char sep, T content, Padding pad, char delimiter = Chars.Pipe)
            where T : ITextual
        {
            dst.Append(Chars.Space);
            dst.Append(delimiter);
            dst.Append(Chars.Space);
            dst.Label(label, sep);
            dst.Append($"{content.Format()}".PadRight((int)pad));
        }
    }
}