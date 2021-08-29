//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".nasm")]
        Outcome AsmNasm(CmdArgs args)
            => OmniScript.RunAsmScript(arg(args,0), "nasm");
    }
}