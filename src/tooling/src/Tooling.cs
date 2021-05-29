//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public sealed class Tooling : AppService<Tooling>
    {
        public void Run(CmdLine src)
        {
            var process = ToolCmd.run(src).Wait();
            var output = process.Output;
            Wf.Status(output);
        }

        public void ShowVendorManuals(string vendor, FS.FileExt ext)
        {
            var docs = Db.VendorDocs();
            var files = docs.VendorManuals(vendor,ext).View;
            var count = files.Length;
            using var log = ShowLog(FS.Md);
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var link = Markdown.item(0, Markdown.link(file), Markdown.ListStyle.Bullet);
                log.Show(link);
            }
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
            var app = FS.file("code", FS.Exe);
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

        public static IToolResultProcessor processor(IEnvPaths paths, FS.FilePath script, Index<IToolResultHandler> handlers)
            => new ToolResultProcessor(paths, script, handlers);
    }
}