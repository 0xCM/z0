//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public sealed class Reactor : WfSingleton<Reactor,IReactor,int>, IReactor
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
            var process = ToolCmd.run(src).Wait();
            var output = process.Output;
            Wf.Status(output);
        }

        void CmdShell(FS.FilePath target, string args)
        {
            var cmd = new CmdLine($"cmd /c {target.Format(PathSeparator.BS)} {args}");
            var process = ToolCmd.run(cmd);
            var output = process.Output;
            Wf.Status(output);
        }

        void VsCode(string arg)
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

        public void Dispatch(CmdLine cmd)
        {
            ShowSupported();
            var args = cmd.Parts;
            if(args.IsEmpty)
                return;

            var name =  first(args).Content;
            var a0 = args.Length >= 2 ? args[1].Content : EmptyString;
            var a1 = args.Length >= 3 ? args[2].Content : EmptyString;
            var a2 = args.Length >= 4 ? args[3].Content : EmptyString;
            var a3 = args.Length >= 5 ? args[4].Content : EmptyString;

            switch(name)
            {
                case DumpImagesCmd.CmdName:
                    var srcDir = FS.dir(@"K:\cache\symbols\netsdk\shared\Microsoft.NetCore.App\3.1.9");
                    var dstDir = FS.dir(@"K:\cache\symbols\netsdk\shared\Microsoft.NetCore.App\3.1.9.dumps");
                    Run(Builder.DumpImages(srcDir, dstDir));
                break;
                case EmitResDataCmd.CmdName:
                    Builder.EmitResData().RunTask(Wf);
                    break;
                case ShowEnvCmd.CmdName:
                    Builder.ShowEnv().RunTask(Wf);
                    break;
                case RunScriptCmd.CmdName:
                    Builder.RunScript(FS.path(a0)).RunDirect(Wf);
                    break;
                case ShowProcessMemoryCmd.CmdName:
                    Builder.ShowProcessMemory().RunTask(Wf);
                    break;
                case EmitEnumCatalogCmd.CmdName:
                    Builder.EmitEnumCatalog().RunTask(Wf);
                    break;
                case CheckServiceCmd.CmdName:
                    Builder.CheckService(a0).RunTask(Wf);
                    break;
                case JitApiCmd.CmdName:
                    Builder.JitApiCmd().RunTask(Wf);
                    break;
                case ShowRuntimeArchiveCmd.CmdName:
                    Builder.ShowRuntimeArchive().RunTask(Wf);
                    break;
                case EmitImageMapsCmd.CmdName:
                    Builder.EmitImageMaps().RunTask(Wf);
                    break;
                case EmitHexIndexCmd.CmdName:
                    Builder.EmitHexIndex().RunTask(Wf);
                break;
                case EmitAssemblyRefsCmd.CmdName:
                    Builder.EmitAssemblyRefs().RunTask(Wf);
                break;
                case EmitRuntimeIndexCmd.CmdName:
                    Builder.EmitRuntimeIndex().RunTask(Wf);
                break;
                case DumpCliTablesCmd.CmdName:
                    Builder.DumpCliTables(Parts.Part.Assembly).RunTask(Wf);
                break;
                case BuildProjectCmd.CmdName:
                    Builder.Build().RunTask(Wf);
                break;
                case EmitImageContentCmd.CmdName:
                    Builder.EmitImageContent().RunDirect(Wf);
                break;
                case RunPartCmd.CmdName:
                    Builder.RunPart(ApiPartIdParser.single(a0)).Dispatch(Wf).Wait();
                    break;
                default:
                    Wf.Error(string.Format("Processor for {0} not found", name));
                    break;
            }
        }

        public ReadOnlySpan<CmdId> SupportedCommands()
            => Wf.Router.SupportedCommands;

        public void ShowSupported()
            => root.iter(Wf.Router.SupportedCommands, c => Wf.Status(c));

        static string format(MemoryFileInfo file)
            => string.Format("{0} | {1} | {2,-16} | {3}", file.BaseAddress, file.EndAddress, file.Size, file.Path.ToUri());

        void Run(in DumpImagesCmd cmd)
        {
            using var mapped = MemoryFiles.map(cmd.Source);
            var info = mapped.Descriptions;
            var count = info.Count;
            root.iter(info, file => Wf.Row(format(file)));

            for(ushort i=0; i<count; i++)
            {
                ref readonly var file = ref mapped[i];
                var target = cmd.Target + FS.file(file.Path.FileName.Name, FS.Extensions.Csv);
                var flow = Wf.EmittingFile(target);
                var service = MemoryEmitter.create(Wf);
                service.Emit(file.BaseAddress, file.Size, target);
                Wf.EmittedFile(flow,1);
            }
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
            DumpEmitter.emit(Runtime.CurrentProcess, dst.Name, DumpTypeOption.Full);
        }


        void Run(in BuildProjectCmd cmd)
        {
            cmd.Save(Db.JobQueue());
        }

        void Run(in ShowConfigCmd cmd)
        {
            var settings = Wf.Settings;
            Wf.Row(settings.Format());
        }
    }
}