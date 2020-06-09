//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Konst;

    partial class XTend
    {
       /// <summary>
        /// Delimits labeled content to produce '{delimiter} {label}{sep} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to delimit</param>
        /// <param name="pad">The right-padded content width</param>
        /// <param name="delimiter">The content delimiter</param>
        public static void DelimitLabel(this StringBuilder sb, string label, char sep, object content, Padding pad, char delimiter)
        {
            sb.Append(Chars.Space);
            sb.Append(delimiter);
            sb.Append(Chars.Space);
            sb.Label(label, sep);
            sb.Append($"{content}".PadRight((int)pad));
        }
    }
}