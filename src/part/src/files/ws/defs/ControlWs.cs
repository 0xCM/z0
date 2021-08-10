//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class ControlWs : IWorkspace<ControlWs>
    {
        [MethodImpl(Inline)]
        public static ControlWs create(FS.FolderPath root)
            => new ControlWs(root);

        FS.FolderPath _WsRoot;

        [MethodImpl(Inline)]
        ControlWs(FS.FolderPath root)
        {
            _WsRoot = root;
        }

        public FS.FolderPath Root
        {
            [MethodImpl(Inline)]
            get => _WsRoot;
        }

        public string Format()
            => _WsRoot.Format();

        public override string ToString()
            => Format();
    }
}