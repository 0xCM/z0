//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    using api = Table;

    public readonly struct TableArchive : ITableArchive
    {
        public FolderPath ArchiveRoot {get;}

        [MethodImpl(Inline)]
        public static TableArchive create(FS.FolderPath root)
            => new TableArchive(root);

        [MethodImpl(Inline)]
        public TableArchive(FolderPath root)
            => ArchiveRoot = root;

        [MethodImpl(Inline)]
        public TableArchive(FS.FolderPath root)
            => ArchiveRoot = FolderPath.Define(root.Name);

        public void Clear()
            => ArchiveRoot.Clear();

        public void Clear(FolderName folder)
            => (ArchiveRoot + folder).Clear();

        public void Clear(FS.FolderName folder)
            => (FS.dir(ArchiveRoot.Name) + folder).Clear();


        public IEnumerable<FilePath> Files()
            => ArchiveRoot.Files(FileExtensions.Csv, true);

        public Option<FilePath> Deposit<F,R>(R[] src, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => api.store<F,R>().Save(src, api.renderspec<F>(), ArchiveRoot + FileName.define(name.Name));

        public Option<FilePath> Deposit<F,R>(R[] src, FS.FolderName folder, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => api.store<F,R>().Save(src, api.renderspec<F>(), (FS.dir(ArchiveRoot.Name) + folder) + name);

        public Option<FilePath> Deposit<F,R>(R[] src, FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => api.store<F,R>().Save(src, api.renderspec<F>(), ArchiveRoot + name);

        public Option<FilePath> Deposit<F,R>(R[] src, FolderName folder, FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => api.store<F,R>().Save(src, api.renderspec<F>(), (ArchiveRoot + folder) + name);
    }
}