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
        {
            this.ArchiveRoot = root;
        }

        public Option<FilePath> Deposit<R>(R[] src, FileName name)
            where R : ITabular
        {
            var format = TabularFormats.derive<R>();
            var svc = TableLog.Service;
            return svc.Save(src, format, ArchiveRoot + name);
        }

        public Option<FilePath> Deposit<R>(R[] src, FolderName folder, FileName name)
            where R : ITabular
        {
            var format = TabularFormats.derive<R>();
            var svc = TableLog.Service;
            return svc.Save(src, format, (ArchiveRoot + folder) + name);
        }
    }
}