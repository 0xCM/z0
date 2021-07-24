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

        public FS.FolderPath WsRoot(FS.FolderPath src)
        {
            _WsRoot = src;
            return WsRoot();
        }

        public FS.FilePath Path(string id, FS.FileExt ext)
            => Root + FS.file(id,ext);

        public FS.FilePath Path<T>(FS.FileExt ext)
            where T : struct, IRecord<T>
                => Path(TableId<T>().Format(), ext);

        public FS.FilePath Path(Scope scope, TableId id)
            => Subdir(scope) + Name(id);

        public FS.FilePath Path(TableId id)
            => Root + Name(id);

        public FS.FilePath Path<T>()
            where T : struct
                => Path(TableId<T>().Format(), FS.Csv);

        public FS.FilePath Path<T>(Scope scope)
            where T : struct
                => Subdir(scope) + Name<T>();

        public FS.FileName Name<T>()
            where T : struct
                => FS.file(TableId<T>().Format(), FS.Csv);

        public FS.FileName Name(TableId id)
            => FS.file(id.Format(), FS.Csv);

        public FS.FileName Name(TableId id, string suffix)
            => FS.file(string.Format("{0}.{1}", id, suffix), FS.Csv);

        TableId TableId<T>()
            where T : struct
                => Z0.TableId.identify<T>();

        public FS.FolderPath Subdir(Scope scope)
            => Root + FS.folder(scope.Format());
    }
}