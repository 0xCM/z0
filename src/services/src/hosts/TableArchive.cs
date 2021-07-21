//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TableArchive : IFileArchive
    {
        [MethodImpl(Inline)]
        public static TableArchive create(FS.FolderPath root)
            => new TableArchive(root);

        public FS.FolderPath Root {get;}

        public TableArchive(FS.FolderPath root)
        {
            Root = root;
        }

        public FS.FolderPath Dir(Scope scope)
            => Root + FS.folder(scope.Format());

        public FS.FilePath Path(Scope scope, TableId id)
            => Dir(scope) + FS.file(id.Format(), FS.Csv);

        public FS.FilePath Path(TableId id)
            => Root + FS.file(id.Format(), FS.Csv);

        public FS.FilePath Path<T>()
            where T : struct
                => Root + FS.file(Tables.identify<T>().Format(), FS.Csv);

    }
}