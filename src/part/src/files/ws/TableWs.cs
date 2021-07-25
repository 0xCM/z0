//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct TableWs : IWorkspace<TableWs>
    {
        [MethodImpl(Inline)]
        public static TableWs create(FS.FolderPath root)
            => new TableWs(root);

        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        TableWs(FS.FolderPath root)
        {
            _WsRoot = root;
        }

        public FS.FolderPath Root
        {
            [MethodImpl(Inline)]
            get => _WsRoot;
        }

        public FS.FolderPath WsRoot()
            => _WsRoot;

        // public FS.FilePath Path(string id, FS.FileExt ext)
        //     => Root + FS.file(id,ext);

        // public FS.FilePath Table(Scope scope, TableId id)
        //     => Subdir(scope) + TableName(id);

        // public FS.FilePath Table<T>(Scope scope)
        //     where T : struct
        //         => Subdir(scope) + TableName<T>();

        // public FS.FileName TableName<T>()
        //     where T : struct
        //         => FS.file(Z0.TableId.identify<T>().Format(), FS.Csv);

        // public FS.FileName TableName(TableId id)
        //     => FS.file(id.Format(), FS.Csv);

        // public FS.FolderPath Subdir(Scope scope)
        //     => Root + FS.folder(scope.Format());
    }
}