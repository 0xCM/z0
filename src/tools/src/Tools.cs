//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Tooling;

    using static Part;

    [ApiHost]
    public sealed class Tools : WfService<Tools>
    {
        public void Run(CmdLine src)
        {
            var process = ToolCmd.run(src).Wait();
            var output = process.Output;
            Wf.Status(output);
        }

        public void RunCmd(FS.FilePath target, string args)
        {
            var cmd = new CmdLine($"cmd /c {target.Format(PathSeparator.BS)} {args}");
            var process = ToolCmd.run(cmd);
            var output = process.Output;
            Wf.Status(output);
        }

        public void LaunchVsCode(string arg)
        {
            var dir = FS.dir(Environment.CurrentDirectory) + FS.folder(arg);
            var app = FS.file("code", FS.Extensions.Exe);
            var path = dir.Format(PathSeparator.BS);
            var cmd = new CmdLine(string.Format("{0} \"{1}\"", app.Format(), path));
            Wf.Status(string.Format("Launching {0} for {1}", app, path));
            Wf.Status(string.Format("CmdLine: {0}", cmd.Format()));
            var process = ToolCmd.run(cmd);
            Wf.Status(string.Format("Launched process {0}", process.ProcessId));
        }

        public static ToolCmdArgs args<T>(T src)
            where T : struct, ICmd<T>
                => typeof(T).DeclaredInstanceFields().Select(f => new ToolCmdArg(f.Name, f.GetValue(src)?.ToString() ?? EmptyString));

        public void Running(ToolExecSpec cmd)
            => Wf.Raise(new ToolRunningEvent(cmd.CmdId, Wf.Ct));

        public static IToolResultProcessor processor(IEnvPaths paths, FS.FilePath script)
            => new ToolResultProcessor(paths, script);
    }
}