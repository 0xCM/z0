//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    public struct TableLog : ITableLog
    {
        public static ITableLog Service => default(TableLog);

        public Option<FilePath> Save<R>(R[] src, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : ITabular
                => Save(src, TabularFormats.derive<R>(), dst, mode);

        public Option<FilePath> Save<R>(R[] data, TabularFormat format, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : ITabular
        {                
            if(data == null || data.Length == 0)
                return Option.none<FilePath>();

            try
            {
                dst.FolderPath.CreateIfMissing();                            
                var overwrite = mode == FileWriteMode.Overwrite;
                var emitHeader = format.EmitHeader && (overwrite || !dst.Exists());                
                
                using var writer = dst.Writer(mode);

                if(emitHeader)
                    writer.WriteLine(string.Join(format.Delimiter, data[0].HeaderNames));            

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