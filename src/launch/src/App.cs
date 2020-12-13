//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    readonly struct Launch
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        Launch(IWfShell wf)
        {
            Host = WfShell.host(typeof(Launch));
            Wf = wf.WithHost(Host);
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args);
                if(args.Length == 0)
                    wf.Status("usage: launch <dir>");
                else
                {
                    var app = new Launch(wf);
                    app.Run(args[0]);
                }

                // var cmd1 = new CmdLine("cmd /c code.exe j:\\");
                // var cmd2 = new CmdLine("llvm-mc --help");
                // var process = Cmd.process(wf,cmd2).Wait();
                // var output = process.Output;
                // wf.Status(output);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Run(string arg)
        {
            var dir = FS.dir(Environment.CurrentDirectory) + FS.folder(arg);
            var app = FS.file("code", FileExtensions.Exe);
            var path = dir.Format(PathSeparator.BS);
            var cmd = new CmdLine(string.Format("{0} \"{1}\"", app.Format(), path));
            Wf.Status(string.Format("Launching {0} for {1}", app, path));
            Wf.Status(string.Format("CmdLine: {0}", cmd.Format()));
            var process = Cmd.process(Wf,cmd);
            Wf.Status(string.Format("Launched process {0}", process.ProcessId));
        }
    }
}