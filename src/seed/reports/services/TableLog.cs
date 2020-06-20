//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public readonly struct TableLog<F,R>: ITableLog<F,R>
        where F : unmanaged, Enum
        where R : ITabular
    {
        public static TableLog<F,R> Service => default;

        public Option<FilePath> Save(R[] src, FilePath dst)
            => Save(src, TabularFormats.derive<F>(), dst, Overwrite);

        public Option<FilePath> Save(R[] data, TabularFormat<F> format, FilePath dst, FileWriteMode mode = Overwrite)
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
                    writer.WriteLine(format.FormatHeader());

                Root.iter(data, r => writer.WriteLine(r.DelimitedText(format.Delimiter)));   
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