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
        /// <summary>
        /// Appends a label suffixed by a separator to produce '{label}{sep}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        public static void AppendLabel(this StringBuilder sb, string label, char sep)
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
        public static void AppendLabeled(this StringBuilder sb, string label, char sep, object content)
        {
            sb.AppendLabel(label,sep);
            sb.Append(content);
        }

        /// <summary>
        /// Appends labeled formattable content to produce: '{label}{sep} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="sep">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to append</param>
        public static void AppendLabeled<T>(this StringBuilder sb, string label, char sep, T content)
            where T : ITextual
        {
            sb.AppendLabel(label,sep);
            sb.Append(content.Format());
        }
    }
}