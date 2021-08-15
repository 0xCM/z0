//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".mc")]
        Outcome AsmLl(CmdArgs args)
            => RunAsmScript(arg(args,0), "mc");
    }
}