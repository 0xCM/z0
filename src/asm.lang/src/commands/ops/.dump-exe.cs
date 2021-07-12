//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".dump-exe")]
        public Outcome DumpExe(CmdArgs args)
        {
            var cmd = Cmd.cmdline(@"C:\Dev\tooling\tools\dumpbin\scripts\dump-exe.cmd");
            var vars = Cmd.vars(3);
            var exeout = Workspace.ExeOut();
            var dumpout = Workspace.DumpOut();
            vars[0] = ("SrcFile", "app2.exe");
            vars[1] = ("SrcDir", exeout.Format(PathSeparator.BS));
            vars[2] = ("DstDir", dumpout.Format(PathSeparator.BS));
            var response = ScriptRunner.RunCmd(cmd, vars);
            return true;
        }
    }
}