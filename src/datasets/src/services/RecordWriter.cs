//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public readonly struct RecordWriter : IRecordWriter
    {
        public static RecordWriter Service => default(RecordWriter);
        
        static IPublicationArchive Archive => PublicationArchive.Default;

        public static ParallelQuery<string> Render<R>(R[] src, Func<R,string> formatter)
            where R : IRecord
                => from r in src.AsParallel()
                   let f = formatter(r)
                   orderby r.Sequence
                   select f;

        public R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatter, char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
            where R : IRecord
        {
            var header = RecordHeader.Create<F>();
            using var writer = dst.Writer();            
            writer.WriteLine(header.Render(delimiter)); 
            
            var rendered = Render(src,formatter).ToArray();

            for(var i=0; i< rendered.Length; i++)
                writer.WriteLine(rendered[i]);   

            return src;         
        }            

        public R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatRecord, Func<int,F,string> formatLabel,  char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
            where R : IRecord
        {
            var header = RecordHeader.Create<F>();
            using var writer = dst.Writer();            
            writer.WriteLine(header.Render(formatLabel, delimiter)); 
            
            var rendered = Render(src,formatRecord).ToArray();
            for(var i=0; i< rendered.Length; i++)
                writer.WriteLine(rendered[i]);   

            return src;         
        }            

        public Option<FilePath> Save<F,R>(R[] src, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : IRecord
            where F : unmanaged, Enum
                => Save<F,R>(src, TabularFormats.derive<R>(), dst, mode);

        public Option<FilePath> Save<F,R>(R[] data, TabularFormat format, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : IRecord
            where F : unmanaged, Enum
        {                
            if(data == null || data.Length == 0)
                return Option.none<FilePath>();

            try
            {
                dst.FolderPath.Create();                            
                var overwrite = mode == FileWriteMode.Overwrite;
                var emitHeader = format.EmitHeader && (overwrite || !dst.Exists);                
                
                using var writer = dst.Writer(mode);

                if(emitHeader)
                {
                    var header = RecordHeader.Create<F>();
                    writer.WriteLine(header.Render(format.Delimiter));
                }

                Control.iter(data, r => writer.WriteLine(r.DelimitedText(format.Delimiter)));   
                return dst;                             
            }
            catch(Exception e)
            {
                term.error(e);                
                return Option.none<FilePath>();
            }
        }        
    }
}