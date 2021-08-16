//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static WsAtoms;

    partial class AsmCmdService
    {
        FS.FolderPath GetProjectOut(string id)
            => OutWs.Root + FS.folder("projects") + FS.folder(State.Project().Format()) + FS.folder(id);
    }
}