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
    }
}