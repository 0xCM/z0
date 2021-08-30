//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".cpp-build-run")]
        Outcome BuildRunCpp(CmdArgs args)
        {
           var result = Outcome.Success;
            var home = ProjectHome(State.Project());
            result = OmniScript.RunProjectScript(home, arg(args,0).Value, CppBuild, false, out var flows);
            if(result.Fail)
                return result;

            return RunExe(flows);
         }
    }
}