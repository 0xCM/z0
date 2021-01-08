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

        readonly CmdBuilder Builder;

        readonly IWfDb Db;

        Runner(IWfShell wf)
        {
            Host = WfShell.host(typeof(Runner));
            Wf = wf.WithHost(Host);
            Builder = wf.CmdBuilder();
            Db = wf.Db();
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

            var name =  first(args).Content;
            var a0 = args.Length >= 2 ? args[1].Content : EmptyString;
            var a1 = args.Length >= 3 ? args[2].Content : EmptyString;


            switch(name)
            {
                case CheckServiceCmd.CmdName:
                    Run(Builder.CheckService(a0));
                    break;
                case JitApiCmd.CmdName:
                    Run(Builder.JitApiCmd());
                    break;
                case ShowRuntimeArchiveCmd.CmdName:
                    Run(Builder.ShowRuntimeArchive());
                    break;
                case EmitImageMapsCmd.CmdName:
                    Run(Builder.EmitImageMaps());
                    break;
                case EmitHexIndexCmd.CmdName:
                    Run(Builder.EmitHexIndex());
                break;
                case EmitRuntimeIndexCmd.CmdName:
                    Run(Builder.EmitRuntimeIndex());
                break;
                case DumpCliTablesCmd.CmdName:
                    Run(Builder.DumpCliTables(Parts.Part.Assembly));
                break;
                case BuildCmd.CmdName:
                    Run(Builder.Build());
                break;
                case EmitImageContentCmd.CmdName:
                    Run(Builder.EmitImageContent());
                break;
                default:
                    Wf.Error(string.Format("Processor for {0} not found", name));
                    break;
            }

        }

        void EmitDump()
        {
            Wf.Status("Emitting dump");
            var dst = FS.path(@"k:\dumps\run\run.dmp");
            dst.Delete();
            DumpEmitter.emit(Processes.current(), dst.Name, DumpTypeOption.Full);
        }

        void Run(in CheckServiceCmd cmd)
        {
             cmd.Dispatch(Wf).Wait();
        }

        void Run(in EmitHexIndexCmd cmd)
        {
            cmd.Dispatch(Wf).Wait();
        }

        void Run(in ShowRuntimeArchiveCmd cmd)
        {
            cmd.Dispatch(Wf).Wait();
        }

        void Run(in EmitRuntimeIndexCmd cmd)
        {
            cmd.Dispatch(Wf).Wait();
        }

        void Run(in DumpCliTablesCmd cmd)
        {
            cmd.Dispatch(Wf).Wait();
        }

        void Run(in EmitImageContentCmd cmd)
        {
            cmd.Dispatch(Wf).Wait();
        }

        void Run(in EmitImageMapsCmd cmd)
        {
            //ImageMaps.emit(Wf, ImageMaps.map(), cmd.Target);
            cmd.Dispatch(Wf).Wait();
        }

        void Run(in JitApiCmd cmd)
        {
            Run(Builder.EmitImageMaps("pre-jit"));
            cmd.Dispatch(Wf).Wait();
            Run(Builder.EmitImageMaps("post-jit"));
            EmitDump();
        }

        void Run(in BuildCmd cmd)
        {
            cmd.Save(Db.JobQueue()).OnSuccess(data => Wf.EmittedFile(data)).OnFailure(msg => Wf.Error(msg));
        }

        void Run(ListFilesCmd cmd)
        {

        }

        void Run(ShowConfigCmd cmd)
        {
            var settings = Wf.Settings;
            Wf.Row(settings.Format());
        }
    }
}