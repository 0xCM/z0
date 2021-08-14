//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class AsmWs : IAsmWorkspace, IWorkspace<AsmWs>
    {
        [MethodImpl(Inline)]
        public static AsmWs create(FS.FolderPath root)
            => new AsmWs(root);

        FS.FolderPath _WsRoot;

        EnvData _Env;

        [MethodImpl(Inline)]
        AsmWs(FS.FolderPath root)
        {
            _WsRoot = root;
            _Env = Env.load().Data;
        }

        public FS.FolderPath Root
        {
            [MethodImpl(Inline)]
            get => _WsRoot;
        }

        public FS.FolderPath WsRoot()
            => _WsRoot;

        public FS.FilePath ToolPath(ToolId id)
        {
            if(id == Toolspace.bddiasm)
                return FS.path(@"j:\source\bddisasm\build\bddisasm.exe");
            else if(id == Toolspace.nasm)
                return FS.path(@"c:\tools\nasm\nasm.exe");
            else
                throw no(id);
        }
    }
}