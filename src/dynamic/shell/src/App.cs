//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.IO;
    using System.Linq;

    using Z0.Images;
    using Z0.Tools;

    using static z;
    using static Tools.Llvm;

    class App : IDisposable
    {
        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args).WithRandom(Rng.@default());
                using var runner = new App(wf);
                runner.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly IWfDb Db;

        readonly CmdBuilder CmdBuilder;

        readonly CmdLine Args;

        public App(IWfShell wf)
        {
            Host = WfShell.host(typeof(App));
            Wf = wf.WithHost(Host);
            CmdBuilder = wf.CmdBuilder();
            Db = Wf.Db();
            Args = wf.Args;
        }

        public static void run(IWfShell wf, CmdLine cmd)
        {
            var process = Cmd.process(wf, cmd).Wait();
            var output = process.Output;
            wf.Status(output);
        }

        static void Run32(IWfShell wf)
        {
            var llvm = Llvm.service(wf);
            var paths = llvm.Paths();
            var cases = paths.Test.ModuleDir(ModuleNames.Analysis, TestSubjects.AliasSet);
            var cmd = WinCmd.dir(cases);
            //run(wf, WinCmd.dir(FS.dir(paths.Test.Root)));
            //run(wf, new CmdLine("llvm-mc --help"));

            run(wf,cmd);
        }

        void ShowHandlers()
        {
            corefunc.iter(Wf.Router.SupportedCommands, c => Wf.Status(c));
        }

        public static void show(IWfShell wf, CmdLine cmd)
        {
            wf.Status(cmd.Format());
        }

        static void ShowConfig(IWfShell wf)
        {
            wf.Status(wf.Settings.FormatList());
            wf.Status(wf.Db().Root);
        }

        static void RunInterpreter(IWfShell wf)
        {
            var cmd = WinCmdShell.create(wf);
            cmd.Submit("dir J:\\");
            cmd.Run();
            cmd.WaitForExit();
        }

        static void TestCmdLine(params string[] args)
        {
            var cmd1 = new CmdLine("cmd /c dir j:\\");
            var cmd2 = new CmdLine("llvm-mc --help");
            using var wf = WfShell.create(args).WithRandom(Rng.@default());
            var process = Cmd.process(wf,cmd2).Wait();
            var output = process.Output;
            wf.Status(output);
        }


        static void ListRuntimeFiles(IWfShell wf, FS.FilePath dst)
        {
            var archive = wf.RuntimeArchive();
            using var writer = dst.Writer();
            ListFiles(wf, archive.DllFiles, writer);
            ListFiles(wf, archive.ExeFiles, writer);
            ListFiles(wf, archive.PdbFiles, writer);
            ListFiles(wf, archive.JsonFiles, writer);
            ListFiles(wf, archive.XmlFiles, writer);
        }

        static void ListFiles(IWfShell wf, FS.Files src, StreamWriter dst)
        {
            foreach(var file in src)
                wf.Status(file.ToUri().Format());
        }

        public void ShowCommands()
        {
            var models = @readonly(Cmd.cmdtypes(Wf));
            var count = models.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var model = ref skip(models,i);
                Wf.Row(string.Format("{0,-3} {1}", i, model.DataType.Name));
            }
        }

        public void Run(ICmdSpec spec)
        {
            Wf.Status(Msg.Dispatching().Format(spec.CmdId));
            Wf.Router.Dispatch(spec);
        }

        public void Run<T>(T spec)
            where T : struct, ICmdSpec<T>
        {
            Wf.Status(Msg.Dispatching<T>().Format(spec));
            Wf.Router.Dispatch(spec);
        }

        void RunFxWorkflows()
        {
            FxWf.run(Wf);
        }


        public void Dispose()
        {
            Wf.Disposed();
        }

        CmdResult EmitPatterns()
            => EmitRenderPatterns.run(Wf, Wf.CmdBuilder().EmitRenderPatterns(typeof(RP)));

        [Op]
        public static FS.FilePath[] match(FS.FolderPath root, uint max, params FS.FileExt[] ext)
        {
            var files = FileArchives.create(root, ext).ArchivedFiles().Take(max).Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static FS.FilePath[] match(FS.FolderPath root, params FS.FileExt[] ext)
        {
            var files = FileArchives.create(root, ext).ArchivedFiles().Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static CmdResult exec(ListFilesCmd cmd)
        {
            var archive = FileArchives.create(cmd.SourceDir, cmd.Extensions);
            var id = cmd.CmdId();
            var list = cmd.EmissionLimit != 0 ? match(cmd.SourceDir, cmd.EmissionLimit, cmd.Extensions) : match(cmd.SourceDir, cmd.Extensions);
            var outcome = FileArchives.emit(list, cmd.FileUriMode, cmd.TargetPath);
            return outcome ? Cmd.ok(cmd) : Cmd.fail(cmd,outcome.Format());
        }

        public static ListFilesCmd EmitFileListCmdSample(IWfShell wf)
        {
            var cmd = new ListFilesCmd();
            cmd.ListName = "tests";
            cmd.SourceDir = FS.dir(@"J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug");
            cmd.TargetPath = wf.Db().JobPath(FS.file("coreclr.tests", FileExtensions.Cmd));
            cmd.FileUriMode = false;
            cmd.WithExt(FileExtensions.Cmd);
            cmd.WithLimit(20);
            return cmd;
        }


        CmdResult EmitFileList()
            => exec(EmitFileListCmdSample(Wf));

        public void DispatchCommands()
        {
            using var flow = Wf.Running();
            using var runner = new ToolRunner(Wf, Host);
            iter(Wf.Router.SupportedCommands.Storage, c => Wf.Status($"{c} enabled"));

            PipeChecks.check(Wf);
        }

        CmdResult EmitAsmMnemonics()
            => Wf.Router.Dispatch(CmdBuilder.EmitAsmMnemonics());

        CmdResult EmitAsmRefs()
        {
            var srcDir = FS.dir("k:/z0/builds/nca.3.1.win-x64");
            var sources = array(srcDir + FS.file("z0.konst.dll"), srcDir + FS.file("z0.asm.dll"));
            var dst = Db.Doc("AssemblyReferences", FileExtensions.Csv);
            var cmd = EmitAssemblyRefs.specify(Wf, sources, dst);
            return EmitAssemblyRefs.run(Wf,cmd);
        }

        void EmitPeHeaders()
        {
            var build = BuildArchives.create(Wf);
            var db = Wf.Db();
            var dllTarget = db.Table(ImageSectionHeader.TableId, "z0.dll.headers");
            var exeTarget = db.Table(ImageSectionHeader.TableId, "z0.exe.headers");

            var cmd = CmdBuilder.EmitImageHeaders();
            cmd.Source = build.DllFiles().Array();
            cmd.Target = db.Table(ImageSectionHeader.TableId, "z0.dll.headers");
            EmitImageHeaders.run(Wf, cmd);

            cmd.Source = build.ExeFiles().Array();
            cmd.Target = db.Table(ImageSectionHeader.TableId, "z0.exe.headers");
            EmitImageHeaders.run(Wf, cmd);
        }

        public static void PipeImageData(IWfShell wf)
        {
            var root = wf.Db().TableRoot<ImageContentRecord>();
            var archive = ImageArchives.csv(wf);
            var path = archive.Root + FS.file("image.content.advapi32", FileExtensions.Csv);
            ImageArchives.PipeImageData(wf, path);

        }
        // CmdResult EmitOpCodes()
        // {
        //     var spec = EmitAsmOpCodes.Spec();
        //     spec.WithTarget(Wf.Db().RefDataPath("asm.opcodes"));
        //     return Wf.Router.Dispatch(spec);
        // }


        void WriteJson()
        {
            var db = Wf.Db();
            // var commands = Commands();
            // foreach(var c in commands)
            // {
            //     var dst = db.TmpFile(FS.file(c.CmdName.Format(), FileExtensions.Json));
            //     var data = JsonData.serialize(c,dst);
            // }
        }

        void ShowLetters()
        {
            using var flow = Wf.Running();
            var data = Resources.strings(typeof(AsciLetterLoText));
            var resources = @readonly(data);
            var rows = Resources.rows(data).View;
            var count = resources.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var res = ref skip(resources,i);
                ref readonly var row = ref skip(rows,i);
                Wf.Row(row);
            }
        }

        void ShowDependencies()
        {
            ShowDependencies(Wf.Controller);
        }

        void ShowDependencies(Assembly src)
        {
            var deps = JsonDeps.dependencies(src);
            var libs = deps.Libraries();


            //Wf.Row(JsonDeps.json(src));
        }


        void ShowCmdModels()
        {
            var models = @readonly(Cmd.cmdtypes(Wf));
            var buffer = Buffers.text();
            for(var i=0; i<models.Length; i++)
            {
                Cmd.render(skip(models,i), buffer);
                Wf.Row(buffer.Emit());
            }
        }

        public readonly struct CmdCases
        {
            public const string CoreClrBuildLog = "CoreCLR_Windows_NT__x64__Debug.log";

            public const string Case0 = @"llvm-pdbutil dump --streams J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.streams.log";
        }

       void ShowOptions()
        {
            var result = Cmd.parse(CmdCases.Case0);
            if(result.Succeeded)
            {
                var value = result.Value;
                Wf.Status(Cmd.format(value));

            }
            else
                Wf.Error(result.Message);
        }

        void ShowCases()
        {
            var query = Resources.query(Wf.Controller, CmdCases.CoreClrBuildLog);
            if(query.ResourceCount == 1)
            {
                var data = query.Descriptor(0).Utf8();
                using var reader = new StringReader(data.ToString());
                var line = reader.ReadLine();
                while(line != null)
                {
                    term.print(line);
                    line = reader.ReadLine();
                }
            }
        }

        // static void EmitCilTables(IWfShell wf, params string[] components)
        // {
        //     var runtime = wf.RuntimeArchive();
        //     var srcdir = runtime.Root;
        //     foreach(var component in components)
        //     {
        //         var srcpath = srcdir + FS.file(component);
        //         if(!srcpath.Exists)
        //             wf.Warn($"The {component} component was not found");
        //         else
        //         {
        //             var cmd = new DumpCliTablesCmd();
        //             var dstfile = FS.file($"{component}.metadata.cli");
        //             var dstdir = wf.Db().Output(new ToolId("ztool"), cmd.Id()).Create() + dstfile;
        //             cmd.Source = srcpath;
        //             cmd.Target = dstdir;
        //             (var success, var msg) = MetadataTableEmitter.emit(cmd.Source.Name, cmd.Target.Name);
        //             if(success)
        //                 wf.Status(msg);
        //             else
        //                 wf.Error(msg);
        //         }
        //     }
        // }

        void Summarize(ApiCodeBlock src)
        {
            Wf.Status(Host, src.OpUri);
        }

        void Show(ListedFiles src)
        {
            for(var i=0; i<src.Count; i++)
                Wf.Row(src[i]);
        }

        void ShowApiHex()
        {
            var archive = WfArchives.hex(Wf);
            var listing = archive.List();
            if(listing.Count == 0)
                Wf.Warn(Host, $"No files found in archive with root {archive.Root}");
            Show(listing);
        }


        void ShowDebugFlags()
        {
            var archive = RuntimeArchive.create();
            var src = archive.ManagedLibraries.Select(x => Assembly.LoadFrom(x.Name));
            var rows = map(src, f => Seq.delimit(f.GetSimpleName(), Seq.delimit(f.DebugFlags())));
            Wf.Rows(rows);
        }


        void ShowPartSummary()
        {
            var api = Wf.ApiParts;
            foreach(var c in api.Components)
                Wf.Row(c.GetSimpleName());

            foreach(var p in api.ManagedSources)
                Wf.Row(string.Format("Managed: {0}", p));
        }


        public void Run(CmdLine cmd)
        {
            var args = cmd.Parts;
            var count = args.Length;
            var commands = Commands.service(Wf);
            for(var i=0; i<count; i++)
            {
                ref readonly var arg = ref skip(args,i);
                if(arg.IsNonEmpty)
                {
                    switch(arg.Content)
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
                        default:
                            Wf.Status(string.Format("Not processor found for {0}", arg));
                            break;
                    }
                }

                //Wf.Status(string.Format("({0}) {1}", i, arg.Format()));
            }
        }


        void Jit()
        {
            var catalog = Wf.ApiParts.Api;
            var parts = catalog.Parts;
            foreach(var part in parts)
            {
                var flow = Wf.Running(string.Format("Jitting {0}", part.Name));
                var members = ApiJit.jit(part);
                Wf.Ran(flow, string.Format("Jitted {0} {1} members", members.Count, part.Name));
            }

        }
        public void Run()
        {
            //ShowHandlers();

            //Run(Args);
            //EmitProcessImages(Wf);
            //EmitAsmMnemonics();
            //EmitAsmOpCodes();
            //EmitBuildArchiveList(Wf.Db().BuildArchiveRoot(), "zbuild");
            //EmitCilTables(Wf, "z0.bitcore.dll");

            //ShowPartSummary();
            //EmitDocComments().Wait();

            //EmitResData();
            // var component = Wf.Api.FindComponent(PartId.BitCore).Require();
            // var result = Cli.EmitCilTableDoc(Wf, component);

            // var cmd = new LocateImagesCmd();
            // cmd.Target = Wf.Db().IndexFile(LocatedImageRow.TableId);
            // Dispatch(cmd);
        }
    }

    readonly struct Msg
    {
        public static RenderPattern<uint,ApiHostUri,uint> IndexedHost => "{2} | {0} | {1} | Api summary accumulation";

        public static RenderPattern<uint,FS.FilePath> EmittedOpIndex => "Emitted operation index for {0} hosts to {1}";

        public static RenderPattern<T> Dispatching<T>()
            where T : struct, ICmdSpec<T> => "Dispatching {0}";

        public static RenderPattern<CmdId> Dispatching() => "Dispatching {0}";
    }

    public static partial class XTend { }
}