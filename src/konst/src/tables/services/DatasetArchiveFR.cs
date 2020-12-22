//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    using api = Table;

    public readonly struct DatasetArchive<F,R> : IDatasetArchive<F,R>
        where F : unmanaged
        where R : struct, ITabular
    {
        public Option<FS.FilePath> Save(R[] src, FS.FilePath dst)
            => Save(src, api.renderspec<F>(), dst, Overwrite);

        public Option<FS.FilePath> Save(R[] data, TableRenderSpec<F> spec, FS.FilePath dst, FileWriteMode mode = Overwrite)
            => TableArchives.deposit(data,spec,dst,mode);
    }
}