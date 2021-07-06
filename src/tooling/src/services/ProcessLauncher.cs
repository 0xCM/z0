//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class ProcessLauncher : AppService<ProcessLauncher>
    {
        public ScriptProcess Launch(FS.FilePath path, string args)
        {
            var cmd = new CmdLine(string.Format("{0} \"{1}\"", path.Format(PathSeparator.BS), args));
            var flow = Running(string.Format("Launching {0}", cmd.Format()));
            var process = ScriptProcess.run(cmd);
            Ran(flow, string.Format("Launched {0}", process.ProcessId));
            return process;
        }
    }
}