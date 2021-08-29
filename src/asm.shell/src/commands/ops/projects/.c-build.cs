//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".c-build")]
        Outcome BuildC(CmdArgs args)
            => OmniScript.RunProjectScript(AsmRoot, arg(args,0).Value, CBuild, false, out var flows);
    }
}