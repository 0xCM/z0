//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".c-build-run")]
        Outcome RunC(CmdArgs args)
        {
            var result = Outcome.Success;
            var home = ProjectHome(State.Project());
            result = OmniScript.RunProjectScript(home, arg(args,0).Value, CBuild, false, out var flows);
            if(result.Fail)
                return result;

            return RunExe(flows);
        }
    }
}