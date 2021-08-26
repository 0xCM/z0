//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".mc-hex")]
        Outcome McHex(CmdArgs args)
            => OmniScript.RunAsmScript(arg(args,0), ToolScriptId.mc_hex);
    }
}