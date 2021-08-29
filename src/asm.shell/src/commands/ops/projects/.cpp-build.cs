//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".cpp-build")]
        Outcome BuildCpp(CmdArgs args)
            => OmniScript.RunProjectScript(AsmRoot, arg(args,0).Value, CppBuild, false, out var flows);
    }
}