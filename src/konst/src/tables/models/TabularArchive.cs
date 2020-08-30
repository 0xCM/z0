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

    public readonly struct TabularArchive : ITabularArchive
    {
        public FolderPath ArchiveRoot {get;}

        [MethodImpl(Inline)]
        public static TabularArchive Service(FolderPath root)
            => new TabularArchive(root);

        [MethodImpl(Inline)]
        public TabularArchive(FolderPath root)
            => ArchiveRoot = root;

        public void Clear()
            => ArchiveRoot.Clear();

        public void Clear(FolderName folder)
            => (ArchiveRoot + folder).Clear();

        public IEnumerable<FilePath> Files()
            => ArchiveRoot.Files(FileExtensions.Csv, true);

        public Option<FilePath> Deposit<F,R>(R[] src, FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => Table.store<F,R>().Save(src, Tabular.Specify<F>(), ArchiveRoot + name);

        public Option<FilePath> Deposit<F,R>(R[] src, FolderName folder, FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => Table.store<F,R>().Save(src, Tabular.Specify<F>(), (ArchiveRoot + folder) + name);
    }
}