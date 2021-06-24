//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class RunScript : CmdReactor<RunScriptCmd>
    {
        protected override CmdResult Run(RunScriptCmd cmd)
        {
            var result = ScriptProcess.run(WinCmd.script(cmd.ScriptPath)).Wait();
            return Cmd.ok(cmd);
        }
    }
}