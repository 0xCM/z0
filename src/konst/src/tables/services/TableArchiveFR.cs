//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    using api = Table;

    public readonly struct TableArchive<F,R>: ITableArchive<F,R>
        where F : unmanaged, Enum
        where R : struct, ITabular
    {
        public Option<FilePath> Save(R[] src, FilePath dst)
            => Save(src, api.renderspec<F>(), dst, Overwrite);

        public Option<FilePath> Save(R[] src, FS.FilePath dst)
            => Save(src, api.renderspec<F>(), FilePath.Define(dst.Name), Overwrite);

        public Option<FilePath> Save(R[] data, TableRenderSpec<F> format, FS.FilePath dst, FileWriteMode mode = Overwrite)
            => Save(data,format,FilePath.Define(dst.Name), mode);

        public Option<FilePath> Save(R[] data, TableRenderSpec<F> spec, FilePath dst, FileWriteMode mode = Overwrite)
        {
            if(data == null || data.Length == 0)
                return Option.none<FilePath>();

            try
            {
                dst.FolderPath.Create();
                var overwrite = mode == FileWriteMode.Overwrite;
                var emitHeader = spec.EmitHeader && (overwrite || !dst.Exists);

                using var writer = dst.Writer(mode);

                if(emitHeader)
                    writer.WriteLine(spec.FormatHeader());

                z.iter(data, r => writer.WriteLine(r.DelimitedText(spec.Delimiter)));
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