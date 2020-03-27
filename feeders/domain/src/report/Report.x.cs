//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Domain;

    public static class XReport
    {

        /// <summary>
        /// Saves an array of records to a filee
        /// </summary>
        /// <param name="records">The records to emit</param>
        /// <param name="dst">The target path</param>
        /// <param name="delimiter">The character used to demarcate record fields</param>
        /// <param name="header">Whether to emit a header row</param>
        /// <param name="overwrite">Whether to overwrite or altnernalely append to an existing file</param>
        /// <typeparam name="R">The source record type</typeparam>
        public static Option<FilePath> Save<R>(this R[] records, FilePath dst, char delimiter = Chars.Pipe, 
            bool header = true, FileWriteMode mode = FileWriteMode.Overwrite)
                where R : IRecord
                    => Reports.save(records, dst, delimiter, header, mode);

        public static void AppendField(this StringBuilder sb, object content)
        {
            sb.Append($"{content}");
        }

        public static void AppendField(this StringBuilder sb, object content, int pad)
        {            
            sb.Append($"{content}".PadRight(pad));
        }

        public static void DelimitField(this StringBuilder sb, object content, int pad, char delimiter)
        {
            sb.Append(rspace(delimiter));            
            sb.Append($"{content}".PadRight(pad));
        }

        public static void DelimitField(this StringBuilder sb, object content, char delimiter)
        {
            sb.Append(rspace(delimiter));                        
            sb.Append(content);
        }

        /// <summary>
        /// Appends a label suffixed by an eol (end-of-label) signifier to produce '{label}{eol}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="eol">A character that denotes the end of a label and indicate that what follows is content</param>
        public static void AppendLabel(this StringBuilder sb, string label, char eol)
        {
            sb.Append(label);
            sb.Append(eol);
            sb.Append(Chars.Space);
        }

        /// <summary>
        /// Appends labeled content to produce: '{label}{eol} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="eol">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to append</param>
        public static void AppendLabeled(this StringBuilder sb, string label, char eol, object content)
        {
            sb.AppendLabel(label,eol);
            sb.Append(content);
        }

        /// <summary>
        /// Appends labeled formattable content to produce: '{label}{eol} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="eol">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to append</param>
        public static void AppendLabeled<T>(this StringBuilder sb, string label, char eol, T content)
            where T : ICustomFormattable
        {
            sb.AppendLabel(label,eol);
            sb.Append(content.Format());
        }

        /// <summary>
        /// Delimits labeled content to produce '{delimiter} {label}{eol} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="eol">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to delimit</param>
        /// <param name="pad">The right-padded content width</param>
        /// <param name="delimiter">The content delimiter</param>
        public static void DelimitLabeled(this StringBuilder sb, string label, char eol, object content, int pad, char delimiter)
        {
            sb.Append(Chars.Space);
            sb.Append(delimiter);
            sb.Append(Chars.Space);
            sb.AppendLabel(label, eol);
            sb.Append($"{content}".PadRight(pad));
        }

        /// <summary>
        /// Delimits labeled formattable content to produce '{delimiter} {label}{eol} {content}'
        /// </summary>
        /// <param name="sb">The target builder</param>
        /// <param name="label">The label text</param>
        /// <param name="eol">A character that denotes the end of a label and indicate that what follows is content</param>
        /// <param name="content">The content to delimit</param>
        /// <param name="pad">The right-padded content width</param>
        /// <param name="delimiter">The content delimiter</param>
        public static void DelimitLabeled<T>(this StringBuilder sb, string label, char eol, T content, int pad, char delimiter)
            where T : ICustomFormattable
        {
            sb.Append(Chars.Space);
            sb.Append(delimiter);
            sb.Append(Chars.Space);
            sb.AppendLabel(label, eol);
            sb.Append($"{content.Format()}".PadRight(pad));
        }

        public static void AppendField<T>(this StringBuilder sb, object content, T pad)
            where T : unmanaged, Enum
        {                        
            sb.Append($"{content}".PadRight(Enums.numeric<T,int>(pad)));
        }

        public static void DelimitField<T>(this StringBuilder sb, object content, T pad, char delimiter)
            where T : unmanaged, Enum
        {
            if(sb == null)
                throw new Exception("Your string builder is null!!");

            sb.Append(rspace(delimiter));            
            sb.Append($"{content}".PadRight(Enums.numeric<T,int>(pad)));
        }

        public static void AppendField<F>(this StringBuilder sb, F content, int pad)
            where F : ICustomFormattable
        {            
            sb.Append($"{content?.Format()}".PadRight(pad));
        }

        public static void DelimitField<F,T>(this StringBuilder sb, F content, T pad, char delimiter)
            where F : ICustomFormattable
            where T : unmanaged, Enum
        {
            sb.Append(rspace(delimiter));            
            sb.Append($"{content?.Format()}".PadRight(Enums.numeric<T,int>(pad)));
        }
    }
}