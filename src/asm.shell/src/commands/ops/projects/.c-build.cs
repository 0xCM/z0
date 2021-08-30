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
        Outcome BuildCProj(CmdArgs args)
        {
            var result = Outcome.Success;
            var home = ProjectHome(State.Project());
            result = OmniScript.RunProjectScript(home, arg(args,0).Value, CBuild, false, out var flows);
            return result;
        }
    }
}