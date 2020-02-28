//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Root;

    public static class ReportingExtensions
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
        public static Option<FilePath> Save<R>(this R[] records, FilePath dst, char delimiter = AsciSym.Pipe, bool header = true, bool overwrite = true)
            where R : IRecord
                => Reports.save(records, dst, delimiter, header,overwrite);

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
            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content}".PadRight(pad));
        }

        public static void DelimitField(this StringBuilder sb, object content, char delimiter)
        {
            sb.Append(text.rspace(delimiter));                        
            sb.Append(content);
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
                throw new Exception("Your string buildler is null!!");

            sb.Append(text.rspace(delimiter));            
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
            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content?.Format()}".PadRight(Enums.numeric<T,int>(pad)));
        }
    }
}