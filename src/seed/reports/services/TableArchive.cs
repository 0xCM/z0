//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableArchive : ITableArchive
    {
        public FolderPath ArchiveRoot {get;}

        [MethodImpl(Inline)]
        public static ITableArchive Service(FolderPath root)
            => new TableArchive(root);

        [MethodImpl(Inline)]
        public TableArchive(FolderPath root)
            => ArchiveRoot = root;

        public Option<FilePath> Deposit<F,R>(R[] src, FileName name)            
            where F : unmanaged, Enum
            where R : ITabular
                => TableLog<F,R>.Service.Save(src, TabularFormats.derive<F>(), ArchiveRoot + name);

        public Option<FilePath> Deposit<F,R>(R[] src, FolderName folder, FileName name)
            where F : unmanaged, Enum
            where R : ITabular
                => TableLog<F,R>.Service.Save(src, TabularFormats.derive<F>(), (ArchiveRoot + folder) + name);
    }
}