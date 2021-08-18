//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        FS.FolderPath GetProjectOut(string id)
            => OutWs.Root + FS.folder("projects") + FS.folder(State.Project().Format()) + FS.folder(id);
    }
}