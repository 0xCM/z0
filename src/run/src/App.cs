//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    class Runner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        Runner(IWfShell wf)
        {
            Host = WfShell.host(typeof(Runner));
            Wf = wf.WithHost(Host);
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(WfShell.parts(Index<PartId>.Empty), args);
                var app = new Runner(wf);
                if(args.Length == 0)
                {
                    wf.Status("usage: run <command> [options]");
                    app.Run(new ShowConfigCmd());
                }
                else
                {
                    CmdLine cmd = args;
                    app.Run(cmd);
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

        void LaunchCode(string arg)
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

        void ShowHandlers()
        {
            corefunc.iter(Wf.Router.SupportedCommands, c => Wf.Status(c));
        }

        public void Run(CmdLine cmd)
        {
            ShowHandlers();
            var args = cmd.Parts;
            if(args.IsEmpty)
            return;

            var commands = Commands.service(Wf);
            var name =  first(args).Content;

            switch(name)
            {
                case EmitApiIndexCmd.CmdName:
                    commands.EmitApiIndex().Wait();
                break;
                case EmitRuntimeIndexCmd.CmdName:
                    commands.EmitRuntimeIndex().Wait();
                break;
                case DumpCliTablesCmd.CmdName:
                    commands.DumpCliTables(Parts.Commands.Assembly).Wait();
                break;
                case RunStepCmd.CmdName:
                    commands.RunStep(slice(args,1)).Wait();
                break;
                default:
                    Wf.Error(string.Format("Processor for {0} not found", name));
                    break;
            }

        }

        void Run(ListFilesCmd cmd)
        {

        }

        void Run(ShowConfigCmd cmd)
        {
            var settings = Wf.Settings;
            Wf.Row(settings.Format());
        }

        void Run(ShowVerbsCmd cmd)
        {
            var verbs = AppCmdNames.index();
            for(var i=0u; i<verbs.Count; i++)
            {
                Wf.Status(verbs[i]);
            }
        }
    }
}