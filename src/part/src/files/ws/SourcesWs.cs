//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class SourcesWs : IWorkspace<SourcesWs>
    {
        [MethodImpl(Inline)]
        public static SourcesWs create(FS.FolderPath root)
            => new SourcesWs(root);

        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        SourcesWs(FS.FolderPath root)
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
    }
}