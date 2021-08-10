//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct LogWs : IWorkspace<LogWs>
    {
        [MethodImpl(Inline)]
        public static LogWs create(FS.FolderPath root)
            => new LogWs(root);

        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        LogWs(FS.FolderPath root)
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