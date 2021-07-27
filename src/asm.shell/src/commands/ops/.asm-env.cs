//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".asm-env")]
        Outcome ShowAsmEnv(CmdArgs args)
        {
            var folders = AsmEnv.Folders;
            iter(folders, f => Write(f));

            return true;
        }
    }
}