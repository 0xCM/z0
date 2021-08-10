//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class ApiWs : IWorkspace<ApiWs>
    {
        [MethodImpl(Inline)]
        public static ApiWs create(FS.FolderPath root)
            => new ApiWs(root);

        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        ApiWs(FS.FolderPath root)
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