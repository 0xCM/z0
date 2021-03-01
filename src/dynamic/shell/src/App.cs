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

    using Z0.Tooling;

    using static Part;
    using static Toolsets;
    using static memory;
    using static Tooling.Llvm;

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


        void ShowHandlers()
        {
            root.iter(Wf.Router.SupportedCommands, c => Wf.Status(c));
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
            var process = ToolCmd.run(cmd2).Wait();
            var output = process.Output;
            wf.Status(output);
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

        public CmdResult Run(ICmd spec)
        {
            Wf.Status(Msg.Dispatching().Format(spec.CmdId));
            return Wf.Router.Dispatch(spec);
        }

        public CmdResult Run<T>(T spec)
            where T : struct, ICmd<T>
        {
            Wf.Status(Msg.Dispatching<T>().Format(spec));
            return Wf.Router.Dispatch(spec);
        }

        void RunFxWorkflows()
        {
            FunctionWorkflows.run(Wf);
        }


        public void Dispose()
        {
            Wf.Disposed();
        }

        public ListFilesCmd EmitFileListCmdSample()
        {
            var cmd = new ListFilesCmd();
            cmd.ListName = "tests";
            cmd.SourceDir = FS.dir(@"J:\lang\net\runtime\artifacts\tests\coreclr\windows.x64.Debug");
            cmd.TargetPath = Db.IndexTable("clrtests");
            cmd.FileUriMode = true;
            cmd.WithExt(FS.Extensions.Cmd);
            //cmd.WithLimit(20);
            return cmd;
        }

        CmdResult EmitFileList()
            => Wf.Router.Dispatch(EmitFileListCmdSample());

        void ListCommands()
        {
            root.iter(Wf.Router.SupportedCommands, c => Wf.Status($"{c} enabled"));

        }

        public void RunPipes()
        {
            using var flow = Wf.Running();
            var data = Wf.PolyStream.Span<ushort>(2400);

            var input = Pipes.pipe<ushort>(Wf);
            var incount = Pipes.flow(data, input);
            var output = Pipes.pipe<ushort>(Wf);
            var outcount = Pipes.flow(input,output);

            Wf.Ran(flow, $"Ran {incount} -> {outcount} values through pipe");
        }

        void EmitImageHeaders()
        {
            var svc = ImageDataEmitter.create(Wf);
            svc.EmitSectionHeaders(Archives.build(Wf));
        }

        void Receive(in ImageContent src)
        {
            Wf.Row(src.Data);
        }

        public void PipeImageData()
        {
            var dst = Records.sink<ImageContent>(Receive);
            var archive = ImageArchives.tables(Wf);
            var path = archive.Root + FS.file("image.content.genapp", FS.Extensions.Csv);
            ImageArchives.pipe(Wf, path, dst);
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
            //var json = JsonDepsLoader.json(src);
            var deps = JsonDepsLoader.from(src);
            var libs = deps.Libs();
            var options = deps.Options();
            var target = deps.Target();
            root.iter(libs, lib => Wf.Row(lib.Name));
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

        void ShowOptions()
        {
            const string @case = @"llvm-pdbutil dump --streams J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.streams.log";
            var result = ToolCmd.parse(@case);
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
            const string LogName = "CoreCLR_Windows_NT__x64__Debug.log";
            var descriptors = Resources.descriptors(Wf.Controller, LogName);
            if(descriptors.ResourceCount == 1)
            {
                var data = descriptors[0].Utf8();
                using var reader = new StringReader(data.ToString());
                var line = reader.ReadLine();
                while(line != null)
                {
                    term.print(line);
                    line = reader.ReadLine();
                }
            }
        }

        void Summarize(ApiCodeBlock src)
        {
            Wf.Status(Host, src.OpUri);
        }

        void Show(ListedFiles src)
        {
            for(var i=0; i<src.Count; i++)
                Wf.Row(src[i]);
        }

        void ShowDebugFlags()
        {
            var archive = RuntimeArchive.create();
            var src = archive.ManagedLibraries.Select(x => Assembly.LoadFrom(x.Name));
            var rows = root.map(src, f => Seq.delimit(f.GetSimpleName(), Seq.delimit(f.DebugFlags())));
            Wf.Rows(rows);
        }

        void ShowPartSummary()
        {
            var api = Wf.ApiParts;
            foreach(var c in api.PartComponents)
                Wf.Row(c.GetSimpleName());

            foreach(var p in api.ManagedSources)
                Wf.Row(string.Format("Managed: {0}", p));
        }

        public void LoadXedSummaries()
        {
            var catalog = Wf.AsmCatalog();
            var patterns = catalog.XedSummaries();
            Wf.Status($"{patterns.Length}");
        }

        void ShowPartComponents()
        {
            var src = Clr.adapt(Wf.Api.PartComponents);
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var item = ref skip(src,i);
                var info = new {
                    item.SimpleName,
                    item.FilePath,
                    item.PdbPath,
                    item.DocPath,
                };
                Wf.Row(info.ToString());
            }
        }



        public void Run()
        {

        }
    }

    readonly struct Msg
    {
        public static MsgPattern<T> Dispatching<T>()
            where T : struct, ICmd<T> => "Dispatching {0}";

        public static MsgPattern<CmdId> Dispatching() => "Dispatching {0}";
    }

    public static partial class XTend { }
}