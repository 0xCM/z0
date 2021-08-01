//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct Workspace : IWorkspace<Workspace>
    {
        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        public Workspace(FS.FolderPath root)
        {
            _WsRoot = root;
        }

        public FS.FolderPath Root
        {
            [MethodImpl(Inline)]
            get => _WsRoot;
        }

        [MethodImpl(Inline)]
        public FS.FolderPath WsRoot()
            => _WsRoot;

        [MethodImpl(Inline)]
        public FS.FolderPath WsRoot(FS.FolderPath src)
        {
            _WsRoot = src;
            return WsRoot();
        }

        public FS.FolderPath Subdir(string name)
            => Root + FS.folder(name);

        public string Format()
            => _WsRoot.Format();

        public override string ToString()
            => Format();
    }
}