//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".show-tool-env")]
        Outcome ShowToolEnv(CmdArgs args)
        {
            var path = State.Tools().Script("show-env-config");
            var cmd = Cmd.cmdline(path.Format(PathSeparator.BS));
            var response = ScriptRunner.RunCmd(cmd);
            var settings = Settings.parse(response);
            iter(settings, s => RowStatus(s));
            return true;
        }
    }
}