//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".mc")]
        Outcome Mc(CmdArgs args)
            => OmniScript.RunAsmScript(arg(args,0), ToolScriptId.mc);
    }
}