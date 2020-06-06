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
    using System.Linq;
    
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
            where T : ITextual
        {
            sb.Append(Chars.Space);
            sb.Append(delimiter);
            sb.Append(Chars.Space);
            sb.AppendLabel(label, sep);
            sb.Append($"{content.Format()}".PadRight(pad));
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

        public static StringBuilder AppendLine(this StringBuilder sb, char c)
        {
            sb.AppendLine(c.ToString());
            return sb;
        }

        public static void AppendLines(this StringBuilder dst, IEnumerable<string> src)
        {
            foreach(var line in src)
                dst.AppendLine(line);            
        }

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