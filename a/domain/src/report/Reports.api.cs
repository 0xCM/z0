//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Core;


    public static class Reports
    {
        public static ReportInfo describe(Type record)
            => Descriptions.GetOrAdd(record, DescribeReport);

        [MethodImpl(Inline)]
        public static ReportInfo describe<R>()
            where R : IRecord
                => describe(typeof(R));

        [MethodImpl(Inline)]
        public static ReportInfo<F> describe<F,R>()
            where F : unmanaged, Enum
            where R : IRecord<F, R>
                => new ReportInfo<F>(describe(typeof(R)));
                        
        [MethodImpl(Inline)]
        public static Report<R> empty<R>()
            where R : IRecord<R>
                => Report<R>.Empty;        

        [MethodImpl(Inline)]
        public static Report<R> empty<F,R>()
            where F : unmanaged, Enum
            where R : IRecord<F, R>
                => Report<F,R>.Empty;

        [MethodImpl(Inline)]
        public static RecordFormatter<F,R> formatter<F,R>()
            where F : unmanaged, Enum
            where R : IRecord<F, R>
                => new RecordFormatter<F,R>(describe<R>());

        public static string[] headers<T>()
            where T : IRecord
                => describe<T>().HeaderNames;

        [MethodImpl(Inline)]
        public static int width<F>(F f)
            where F : unmanaged, Enum                
                => (int)(Enums.numeric<F,ulong>(f) >> 32);

        [MethodImpl(Inline)]
        public static int index<F>(F f)
            where F : unmanaged, Enum                
                => (int)Enums.numeric<F,ulong>(f);

        /// <summary>
        /// Saves an array of records to a target path
        /// </summary>
        /// <param name="records">The records to emit</param>
        /// <param name="dst">The target path</param>
        /// <param name="delimiter">The character used to demarcate record fields</param>
        /// <param name="header">Whether to emit a header row</param>
        /// <param name="overwrite">Whether to overwrite or altnernalely append to an existing file</param>
        /// <typeparam name="R">The source record type</typeparam>
        public static Option<FilePath> save<R>(R[] records, FilePath dst, char delimiter = Chars.Pipe, 
            bool header = true, FileWriteMode mode = FileWriteMode.Overwrite)
                where R : IRecord
        {            
            if(records == null)
            {
                error($"The source record array is null!");
                return none<FilePath>();
            }
                    
            try
            {
                if(records.Length == 0)
                    return FilePath.Empty;                

                dst.FolderPath.CreateIfMissing();                            

                var overwrite = mode == FileWriteMode.Overwrite;
                var emitHeader = header && (overwrite || !dst.Exists());                
                
                using var writer = dst.Writer(mode);

                if(emitHeader)
                    writer.WriteLine(string.Join(delimiter, records[0].HeaderNames));            
                Streams.iter(records, r => writer.WriteLine(r.DelimitedText(delimiter)));
                
                return dst;
            }
            catch(Exception e)
            {
                error(e);
                return default;
            }
        }        

        static ReportFieldInfo DescribeField(MemberInfo src)
        {
            var attrib = src.Tag<ReportFieldAttribute>().Require();
            return ReportFieldInfo.Define(attrib.Name.IfBlank(src.Name), attrib.Index ?? 0, attrib.Width ?? 0);            
        }

        /// <summary>
        /// Prepends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline)]
        internal static string lspace(object content)
            => $" {content}";

        static string[] GetHeaderNames(ReportFieldInfo[] fields)
        {
            var count = fields.Length;
            var headers = new string[count];

            for(var i=0; i<count; i++)
            {
                var field = fields[i];
                if(i == 0)
                    headers[i] = field.Name.PadRight(field.Width);
                else if(i == count - 1)
                    headers[i] = lspace(field.Name);
                else
                    headers[i] = lspace(field.Name.PadRight(field.Width));        
            }
            return headers;
        }

        static ReportInfo DescribeReport(Type record)
        {
            var props = from p in record.DeclaredProperties().Instance()
                        where p.Tagged<ReportFieldAttribute>()
                        select DescribeField(p);
            var fields = from f in record.DeclaredFields().Instance()
                        where f.Tagged<ReportFieldAttribute>()
                        select DescribeField(f);
            
            var members = props.Union(fields).OrderBy(x => x.Index).ToArray();
            return ReportInfo.Define(members, GetHeaderNames(members));
        }

        static ConcurrentDictionary<Type,ReportInfo> Descriptions {get;}
            = new ConcurrentDictionary<Type, ReportInfo>();
    }
}