//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text;

    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Manufactures the type that reifies the record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        public static Type CreateType(this RecordSpec spec)        
            => Record.CreateType(spec);

        public static IEnumerable<Type> CreateTypes(this IEnumerable<RecordSpec> specs)
            => Record.CreateTypes(specs.ToArray());         
    
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
        {            
            try
            {
                if(records.Length == 0)
                    return FilePath.Empty;
                            
                dst.FolderPath.CreateIfMissing();                            
                var emitHeader = header && (overwrite || !dst.Exists());
                using var writer = new StreamWriter(dst.Name, !overwrite);            

                if(emitHeader)
                    writer.WriteLine(string.Join(delimiter, records[0].GetHeaders()));            
                iter(records, r => writer.WriteLine(r.DelimitedText(delimiter)));
                
                return dst;
            }
            catch(Exception e)
            {
                errout(e);
                return default;
            }
        }

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

        public static void AppendField<T>(this StringBuilder sb, object content, T pad)
            where T : unmanaged, Enum
        {                        
            sb.Append($"{content}".PadRight(evalue<T,int>(pad)));
        }

        public static void DelimitField<T>(this StringBuilder sb, object content, T pad, char delimiter)
            where T : unmanaged, Enum
        {
            if(sb == null)
                throw new Exception("Your string buildler is null!!");

            sb.Append(rspace(delimiter));            
            sb.Append($"{content}".PadRight(evalue<T,int>(pad)));
        }

        public static void AppendField<F>(this StringBuilder sb, F content, int pad)
            where F : ICustomFormattable
        {            
            sb.Append($"{content?.Format()}".PadRight(pad));
        }

        public static void DelimitField<F>(this StringBuilder sb, F content, int pad, char delimiter)
            where F : ICustomFormattable
        {
            sb.Append(rspace(delimiter));            
            sb.Append($"{content?.Format()}".PadRight(pad));
        }

        public static void AppendField<F,T>(this StringBuilder sb, F content, T pad)
            where F : ICustomFormattable
            where T : unmanaged, Enum
        {                        

            sb.Append($"{content?.Format()}".PadRight(evalue<T,int>(pad)));
        }

        public static void DelimitField<F,T>(this StringBuilder sb, F content, T pad, char delimiter)
            where F : ICustomFormattable
            where T : unmanaged, Enum
        {
            sb.Append(rspace(delimiter));            
            sb.Append($"{content?.Format()}".PadRight(evalue<T,int>(pad)));
        }

    }
}