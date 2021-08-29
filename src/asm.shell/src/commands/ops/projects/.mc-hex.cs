//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".mc-hex")]
        Outcome McHexRun(CmdArgs args)
            => OmniScript.RunProjectScript(AsmRoot, arg(args,0).Value, McHex, false, out var flows);
    }
}