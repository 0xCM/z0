//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
     using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".ml-build")]
        Outcome BuildMl(CmdArgs args)
            => OmniScript.RunProjectScript(AsmRoot, arg(args,0).Value, MlBuild, false, out var flows);
    }
}