//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class GenWs : IWorkspace<GenWs>
    {
        [MethodImpl(Inline)]
        public static GenWs create(FS.FolderPath root)
            => new GenWs(root);

        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        GenWs(FS.FolderPath root)
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