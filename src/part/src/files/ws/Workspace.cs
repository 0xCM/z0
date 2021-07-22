//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static EnvFolders;

    public struct Workspace : IWorkspace<Workspace>
    {
        FS.FolderPath _WsRoot;

        public Workspace(FS.FolderPath root)
        {
            _WsRoot = root;
        }

        public FS.FolderPath Root
        {
            get => _WsRoot;
        }

        public FS.FolderPath WsRoot()
            => _WsRoot;

        public FS.FolderPath WsRoot(FS.FolderPath src)
        {
            _WsRoot = src;
            return WsRoot();
        }

        public string Format()
            => _WsRoot.Format();

        public override string ToString()
            => Format();
    }
}