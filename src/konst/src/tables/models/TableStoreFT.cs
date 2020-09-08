//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    using api = Table;

    public readonly struct TableStore<F,R>: ITableStore<F,R>
        where F : unmanaged, Enum
        where R : struct, ITabular
    {
        public Option<FilePath> Save(R[] src, FilePath dst)
            => Save(src, api.renderspec<F>(), dst, Overwrite);

        public Option<FilePath> Save(R[] src, FS.FilePath dst)
            => Save(src, api.renderspec<F>(), FilePath.Define(dst.Name), Overwrite);

        public Option<FilePath> Save(R[] data, TableRenderSpec<F> format, FilePath dst, FileWriteMode mode = Overwrite)
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

                z.iter(data, r => writer.WriteLine(r.DelimitedText(format.Delimiter)));
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