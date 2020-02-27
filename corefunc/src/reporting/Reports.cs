//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using System.Linq;
    using System.IO;
    using System.Text;

    using static Root;

    public static class Reports
    {
        static ReportFieldInfo FieldInfo(MemberInfo src)
            => src.Tag<ReportFieldAttribute>().MapRequired(a => ReportFieldInfo.Define(a.Name.IfBlank(src.Name), a.Width));

        static ReportInfo CreateReportInfo(Type record)
            => ReportInfo.Define(from p in  record.DeclaredProperties().Instance()
                        where p.Tagged<ReportFieldAttribute>()
                        select FieldInfo(p));        

        public static IReadOnlyList<string> ReportHeaders(Type record)
        {            
            var info = GetReportInfo(record);

            var count = info.FieldCount;
            var headers = new string[count];

            for(var i=0; i<count; i++)
            {
                var field = info[i];
                if(i == 0)
                    headers[i] = field.Name.PadRight(field.Width ?? 0);
                else if(i == count - 1)
                    headers[i] = text.lspace(field.Name);
                else
                    headers[i] = text.lspace(field.Name.PadRight(field.Width ?? 0));        
            }
            return headers;
        }

        public static IReadOnlyList<string> ReportHeaders<T>()
            where T : IRecord
                => ReportHeaders(typeof(T));


        /// <summary>
        /// Saves an array of records to a filee
        /// </summary>
        /// <param name="records">The records to emit</param>
        /// <param name="dst">The target path</param>
        /// <param name="delimiter">The character used to demarcate record fields</param>
        /// <param name="header">Whether to emit a header row</param>
        /// <param name="overwrite">Whether to overwrite or altnernalely append to an existing file</param>
        /// <typeparam name="R">The source record type</typeparam>
        public static Option<FilePath> SaveReport<R>(R[] records, FilePath dst, char delimiter = AsciSym.Pipe, bool header = true, bool overwrite = true)
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
                    writer.WriteLine(string.Join(delimiter, records[0].HeaderFields));            
                iter(records, r => writer.WriteLine(r.DelimitedText(delimiter)));
                
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        static ReportInfo GetReportInfo(Type record)
            => ReportInfoCache.GetOrAdd(record,CreateReportInfo);
        
        static ConcurrentDictionary<Type,ReportInfo> ReportInfoCache {get;}
            = new ConcurrentDictionary<Type, ReportInfo>();
    }
}