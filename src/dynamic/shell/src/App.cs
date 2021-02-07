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

    using Z0.Tools;
    using Z0.Asm;

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

        static void Run32(IWfShell wf)
        {
            var llvm = Llvm.service(wf);
            var cases = llvm.Paths.Test.ModuleDir(ModuleNames.Analysis, TestSubjects.AliasSet);
            var cmd = WinCmd.dir(cases);
            //run(wf, WinCmd.dir(FS.dir(paths.Test.Root)));
            //run(wf, new CmdLine("llvm-mc --help"));

            ToolRunner.run(wf, cmd);
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
            var process = Cmd.process(wf,cmd2).Wait();
            var output = process.Output;
            wf.Status(output);
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

        [Op]
        public static FS.FilePath[] match(FS.FolderPath root, uint max, params FS.FileExt[] ext)
        {
            var files = Archives.create(root, ext).ArchiveFiles().Take(max).Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static FS.FilePath[] match(FS.FolderPath root, params FS.FileExt[] ext)
        {
            var files = Archives.create(root, ext).ArchiveFiles().Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static CmdResult exec(ListFilesCmd cmd)
        {
            var archive = Archives.create(cmd.SourceDir, cmd.Extensions);
            var id = cmd.CmdId();
            var list = cmd.EmissionLimit != 0 ? match(cmd.SourceDir, cmd.EmissionLimit, cmd.Extensions) : match(cmd.SourceDir, cmd.Extensions);
            var outcome = Archives.emit(list, cmd.FileUriMode, cmd.TargetPath);
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

        public void RunPipes()
        {
            using var flow = Wf.Running();
            using var runner = new ToolRunner(Wf, Host);
            root.iter(Wf.Router.SupportedCommands, c => Wf.Status($"{c} enabled"));

            var pipe = Pipes.pipe<ushort>(Wf);
            var count = 10;
            var input = Wf.PolyStream.Span<ushort>(count);
            for(var i=0; i<count; i++)
                pipe.Deposit(skip(input,i));

            var output = root.hashset<ushort>();
            while(pipe.Next(out var dst))
                output.Add(dst);

            z.insist(output.Count, count);

            for(var i=0; i<count; i++)
                z.insist(output.Contains(skip(input,i)));

            Wf.Ran(flow, $"Ran {count} values through pipe");
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
            var path = archive.Root + FS.file("image.content.genapp", FileExtensions.Csv);
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
            var descriptors = Resources.descriptors(Wf.Controller, CmdCases.CoreClrBuildLog);
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

        void ShowApiHex()
        {
            var archive = Archives.extract(Wf);
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
            foreach(var c in api.PartComponents)
                Wf.Row(c.GetSimpleName());

            foreach(var p in api.ManagedSources)
                Wf.Row(string.Format("Managed: {0}", p));
        }


        public void EmitAmsOpCodes()
        {
            var cmd = CmdBuilder.EmitAsmOpCodes(Db.Table("asmopcodes"));
            Wf.Router.Dispatch(cmd);
        }

        public void LoadAsmStore()
        {
            var store = AsmDataStore.create(Wf);
            var patterns = store.XedSummaries();
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


        // void LoadImportRows()
        // {
        //     var etl = AsmCatalogEtl.create(Wf);
        //     var rows = etl.ImportedRows();
        //     var count = rows.Length;
        //     var formatter = Records.formatter<AsmCatalogImportRow>();
        //     var parser = AsmSigParser.create(Wf);
        //     var mnemonics = root.hashset<AsmMnemonicExpr>();
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var row = ref skip(rows,i);

        //         var sigex = AsmExpr.sig(row.Instruction);
        //         if(parser.ParseMnemonic(sigex, out var mnemonic))
        //             mnemonics.Add(mnemonic);

        //     }

        //     var terms = root.terms(mnemonics.OrderBy(x => x.Content).Index().View);

        //     root.iter(terms, r => Wf.Row(r));
        // }



        void GenerateCodes(ReadOnlySpan<AsmMnemonic> src, FS.FilePath dst)
        {
            var buffer = text.buffer();
            var margin = 0u;
            buffer.AppendLine("namespace Z0.Asm");
            buffer.AppendLine("{");
            margin += 4;
            buffer.IndentLine(margin, "public enum AsmMnemonicCode : ushort");
            buffer.IndentLine(margin, "{");
            margin += 4;

            buffer.IndentLine(margin, "None = 0,");
            buffer.AppendLine();

            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var monic = ref skip(src,i);
                buffer.IndentLine(margin, string.Format("{0} = {1},", monic.Name, i+1));
                buffer.AppendLine();
            }
            margin -= 4;
            buffer.IndentLine(margin, "}");

            margin -= 4;
            buffer.IndentLine(margin, "}");

            using var writer = dst.Writer();
            writer.Write(Dev.SourceCodeHeader);
            writer.Write(buffer.Emit());
        }

        void GenerateExpressions(ReadOnlySpan<AsmMnemonic> src, FS.FilePath dst)
        {
            var buffer = text.buffer();
            var margin = 0u;
            buffer.AppendLine("namespace Z0.Asm");
            buffer.AppendLine("{");
            margin += 4;
            buffer.IndentLine(margin, "public readonly struct AsmMnemonics");
            buffer.IndentLine(margin, "{");
            margin += 4;

            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var monic = ref skip(src,i);
                buffer.IndentLine(margin, string.Format("public static AsmMnemonicExpr {0} => nameof({0});", monic.Name));
                buffer.AppendLine();
            }
            margin -= 4;
            buffer.IndentLine(margin, "}");

            margin -= 4;
            buffer.IndentLine(margin, "}");

            using var writer = dst.Writer();
            writer.Write(Dev.SourceCodeHeader);
            writer.Write(buffer.Emit());
        }

        void ShowSpecifiers(AsmCatalogEtl etl)
        {
            var parser = AsmExprParser.create(Wf);
            var specifiers = etl.Specifiers();
            for(var i=0; i<specifiers.Length; i++)
            {
                ref readonly var spec = ref skip(specifiers,i);
                parser.Mnemonic(spec.Sig, out var monic);
                var operands = parser.Operands(spec.Sig).View;
                var opformat = operands.Map(x => x.Format()).Concat(RP.SpacePipe);
                Wf.Row(string.Format(RP.PSx3, spec.OpCode, monic, opformat));

            }
        }

        public void Run()
        {

            var etl = AsmCatalogEtl.create(Wf);
            var records = etl.TransformSource();
            var monics = etl.Mnemonics();
            var maxlen = monics.Select(x => x.Name.Length).Max();
            Wf.Status(maxlen);
            GenerateExpressions(monics, Db.Doc("AsmMnemonics", FileExtensions.Cs));
            GenerateCodes(monics, Db.Doc("AsmMnemonicCode", FileExtensions.Cs));
            ShowSpecifiers(etl);

            // var terms = root.terms(monic.OrderBy(x => x.Content).Index().View);
            // root.iter(terms, r => Wf.Row(r));
        }
    }

    readonly struct Msg
    {
        public static RenderPattern<T> Dispatching<T>()
            where T : struct, ICmd<T> => "Dispatching {0}";

        public static RenderPattern<CmdId> Dispatching() => "Dispatching {0}";
    }

    public static partial class XTend { }
}