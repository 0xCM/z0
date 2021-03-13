//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    using api = Table;

    public readonly struct TableArchives
    {
        public static Option<FS.FilePath> deposit<F,R>(FS.FolderPath root, R[] src, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => deposit(src, api.renderspec<F>(), root + name);

        public static Option<FS.FilePath> deposit<F,R>(R[] data, TableRenderSpec<F> spec, FS.FilePath dst, FileWriteMode mode = Overwrite)
            where F : unmanaged
            where R : struct, ITabular
        {
            if(data == null || data.Length == 0)
                return Option.none<FS.FilePath>();

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
                return Option.none<FS.FilePath>();
            }
        }
    }
}