//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;


    public sealed class Reactor : WfSingleton<Reactor, IReactor, int>, IReactor
    {
        CmdBuilder Builder;

        IWfDb Db;

        protected override Reactor Init(out int state)
        {
            state = 32;
            Builder = Wf.CmdBuilder();
            Db = Wf.Db();
            return this;
        }

        public void Run(CmdLine src)
        {
            var process = Cmd.process(Wf, src).Wait();
            var output = process.Output;
            Wf.Status(output);
        }

        void CmdShell(FS.FilePath target, string args)
        {
            var cmd = new CmdLine($"cmd /c {target.Format(PathSeparator.BS)} {args}");
            var process = Cmd.process(Wf, cmd);
            var output = process.Output;
            Wf.Status(output);
            // var cmd2 = new CmdLine("llvm-mc --help");
            // var process = Cmd.process(wf,cmd2).Wait();
            // var output = process.Output;
            // wf.Status(output);
        }

        void VsCode(string arg)
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

        public void Dispatch(CmdLine cmd)
        {
            ShowSupported();
            var args = cmd.Parts;
            if(args.IsEmpty)
                return;

            var name =  first(args).Content;
            var a0 = args.Length >= 2 ? args[1].Content : EmptyString;
            var a1 = args.Length >= 3 ? args[2].Content : EmptyString;


            switch(name)
            {
                case DumpImagesCmd.CmdName:
                    var srcDir = FS.dir(@"K:\cache\symbols\netsdk\shared\Microsoft.NetCore.App\3.1.9");
                    var dstDir = FS.dir(@"K:\cache\symbols\netsdk\shared\Microsoft.NetCore.App\3.1.9.dumps");
                    Run(Builder.DumpImages(srcDir, dstDir));

                break;
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

        public IndexedView<CmdId> SupportedCommands()
            => Wf.Router.SupportedCommands;

        public void ShowSupported()
            => corefunc.iter(Wf.Router.SupportedCommands, c => Wf.Status(c));

        static string format(MemoryFileInfo file)
            => string.Format("{0} | {1} | {2,-16} | {3}", file.BaseAddress, file.EndAddress, file.Size, file.Path.ToUri());

        void Run(in DumpImagesCmd cmd)
        {
            using var mapped = MemoryFiles.map(cmd.Source);
            var info = mapped.Descriptions;
            var count = info.Count;
            corefunc.iter(info, file => Wf.Row(format(file)));

            for(ushort i=0; i<count; i++)
            {
                ref readonly var file = ref mapped[i];
                var target = cmd.Target + FS.file(file.Path.FileName.Name, FileExtensions.Csv);
                var flow = Wf.EmittingFile(target);
                var service = MemoryEmitter.create(Wf);
                service.Emit2(file.BaseAddress, file.Size, target);
                Wf.EmittedFile(flow, target);
            }
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
            cmd.Dispatch(Wf).Wait();
        }

        void EmitProcessDump()
        {
            Wf.Status("Emitting dump");
            var dst = FS.path(@"k:\dumps\run\run.dmp");
            dst.Delete();
            DumpEmitter.emit(Processes.current(), dst.Name, DumpTypeOption.Full);
        }

        void Run(in JitApiCmd cmd)
        {
            Run(Builder.EmitImageMaps("pre-jit"));
            cmd.Dispatch(Wf).Wait();
            Run(Builder.EmitImageMaps("post-jit"));
            EmitProcessDump();
        }

        void Run(in BuildCmd cmd)
        {
            cmd.Save(Db.JobQueue()).OnSuccess(data => Wf.EmittedFile(data)).OnFailure(msg => Wf.Error(msg));
        }

        void Run(in ListFilesCmd cmd)
        {

        }


        void Run(in ShowConfigCmd cmd)
        {
            var settings = Wf.Settings;
            Wf.Row(settings.Format());
        }


        void Run(in CheckServiceCmd cmd)
        {

        }
    }
}