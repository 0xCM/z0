//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class OutputWs : IWorkspace<OutputWs>
    {
        [MethodImpl(Inline)]
        public static OutputWs create(FS.FolderPath root)
            => new OutputWs(root);

        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        OutputWs(FS.FolderPath root)
        {
            _WsRoot = root;
        }

        public WsKind Kind
            => WsKind.Output;

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