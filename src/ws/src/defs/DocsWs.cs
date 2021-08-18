//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class DocsWs : IWorkspace<DocsWs>
    {
        [MethodImpl(Inline)]
        public static DocsWs create(FS.FolderPath root)
            => new DocsWs(root);

        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        DocsWs(FS.FolderPath root)
        {
            _WsRoot = root;
        }

        public FS.FolderPath Root
        {
            [MethodImpl(Inline)]
            get => _WsRoot;
        }
    }
}