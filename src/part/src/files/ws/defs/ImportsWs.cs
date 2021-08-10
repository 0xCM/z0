//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class ImportsWs : IWorkspace<ImportsWs>
    {
        [MethodImpl(Inline)]
        public static ImportsWs create(FS.FolderPath root)
            => new ImportsWs(root);

        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        ImportsWs(FS.FolderPath root)
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