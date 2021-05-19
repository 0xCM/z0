//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static Part;
    using static memory;
    using static Toolsets;

    class App : AppService<App>
    {
        public App()
        {

        }

        protected override void OnInit()
        {
            Catalog = StanfordAsmCatalog.create(Wf);

            Forms = root.hashset<AsmFormExpr>();
            Sigs = Wf.AsmSigs();

        }

        HashSet<AsmFormExpr> Forms;

        AsmSigs Sigs;

        StanfordAsmCatalog Catalog;

        public void GenerateInstructionModels()
        {
            Wf.AsmCodeGenerator().GenerateModelsInPlace();
        }

        public void GenerateInstructionModelPreview()
        {
            Wf.AsmCodeGenerator().GenerateModels(Db.AppLogDir() + FS.folder("asm.lang.g"));
        }

        void EmitFormHashes()
        {
            Wf.AsmFormPipe().EmitFormHashes();
        }

        void RunScripts()
        {
            var runner = ScriptRunner.create(Db);
            runner.RunToolCmd(clang.name, "codegen");
            runner.RunToolCmd(clang.name, "parse");
            runner.RunToolPs(clang.name, "fast-math");
            runner.RunToolPs(llvm.ml, "lex");
        }

        void ShowCases()
        {
            var cases = AsmCases.create(Wf);
            var mov = cases.MovCases().View;
            var count = mov.Length;
            for(var i=0; i<count; i++)
                Wf.Row(skip(mov,i).Format());
        }

        public static MsgPattern<T> DispatchingCmd<T>()
            where T : struct, ICmd<T> => "Dispatching {0}";

        public static MsgPattern<CmdId> DispatchingCmd() => "Dispatching {0}";

        public CmdResult Run(ICmd spec)
        {
            Wf.Status(DispatchingCmd().Format(spec.CmdId));
            return Wf.Router.Dispatch(spec);
        }

        public CmdResult Run<T>(T spec)
            where T : struct, ICmd<T>
        {
            Wf.Status(DispatchingCmd<T>().Format(spec));
            return Wf.Router.Dispatch(spec);
        }

        void RunFunctionWorkflows()
        {
            FunctionWorkflows.run(Wf);
        }

        void ListCommands()
        {
            root.iter(Wf.Router.SupportedCommands, c => Wf.Status($"{c} enabled"));
        }

        void EmitImageHeaders()
        {
            var svc = CliPipe.create(Wf);
            svc.EmitSectionHeaders(WfRuntime.RuntimeArchive(Wf));
        }

        public void EmitApiImageContent()
        {
            Wf.CliPipe().EmitImageContent();
        }

        public void EmitXedCatalog()
        {
            Wf.XedCatalog().EmitCatalog();
        }

        public void EmitBitstrings()
        {
            var thumbprints = Wf.AsmThumbprints().LoadThumbprints().View;
            Wf.AsmBitstringEmitter().EmitBitstrings(thumbprints);
        }

        void EmitRuntimeMembers()
        {
            var service = ApiRuntime.create(Wf);
            var members = service.EmitRuntimeIndex();
        }

        void LoadCurrentCatalog()
        {
            var entries = Wf.ApiCatalogs().Entries();
        }


        static ReadOnlySpan<byte> mul_ᐤ8uㆍ8uᐤ
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0xc3};


        public void ProccessCultFiles()
        {
            Wf.CultProcessor().Run();
        }

        void JitApiCatalog()
        {
            Wf.ApiJit().JitCatalog();
        }

        void EmitNasmInstructions()
        {
            Wf.NasmCatalog().EmitInstructionCatalog();
        }

        void MapMemory()
        {
            var dst = Db.IndexTable<ProcessMemoryRegion>();
            var flow = Wf.EmittingTable<ProcessMemoryRegion>(dst);
            var segments = ImageMemory.regions();
            Tables.emit(segments,dst);
            Wf.EmittedTable(flow, segments.Count);
        }

        void CaptureSelf()
        {
            Wf.CaptureRunner().Capture(Assembly.GetExecutingAssembly().Id());
        }

        void CaptureParts(params PartId[] parts)
        {
            var dst = Db.AppLogDir() + FS.folder("capture");
            dst.Clear();
            Wf.CaptureRunner().Capture(parts, dst);
        }

        void RunExtractWorkflow()
        {
            var wf = ApiExtractWorkflow.create(Wf);
            wf.Run();
            // var receivers = new ApiExtractReceivers();
            // receivers.PartResolved += (source, e) => OnEvent(e);
            // receivers.HostResolved += (source, e) => OnEvent(e);
            // receivers.MemberParsed += (source, e) => OnEvent(e);
            // receivers.MemberDecoded += (source, e) => OnEvent(e);
            // receivers.ExtractError += (source, e) => OnEvent(e);
            // var extractor = Wf.ApiExtracor();
            // extractor.Run(receivers);
        }

        void DescribeHeaps()
        {
            var components = Wf.ApiCatalog.Components.View;
            var heaps = CliHeaps.strings(components).View;
            var count = heaps.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var heap = ref skip(heaps,i);
                Wf.Row(CliHeaps.describe(heap));
            }

        }

        void ReadCliHeader()
        {
            var reader = Cli.reader(Parts.Cpu.Assembly);
            var header = reader.Header();
            if(header)
            {
                var data = header.Data;
                Wf.Row(data.Version);
            }
            else
            {
                Wf.Error(header.Message);
            }

        }

        FS.FilePath DefineDisassemblyJob()
        {
            var tool = Wf.NDisasm();
            var srcDir = Db.TableDir("image.bin");
            var outDir = Db.TableDir("image.bin.asm").Create();
            var src = srcDir.Files(FS.Bin);
            var scripts = tool.Scripts(src,outDir);
            var count = scripts.Length;
            var jobDir = Db.JobRoot() + FS.folder(tool.Id.Format());
            jobDir.Clear();

            var paths = span<FS.FilePath>(count);
            var runner = jobDir + FS.file("run", FS.Cmd);
            using var writer = runner.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var script = ref skip(scripts,i);
                ref var path = ref seek(paths,i);
                path = jobDir + FS.file(script.Id.Format(), FS.Cmd);
                path.Overwrite(script.Format());
                writer.WriteLine(string.Format("call {0}", path.Format(PathSeparator.BS)));
            }
            return runner;
        }


        void ResolveApi(params PartId[] parts)
        {
            var resolver = Wf.ApiResolver();
            resolver.ResolveParts(parts);
        }

        void RunExtractor(params PartId[] parts)
        {
            Wf.ApiExtractor().Run();
        }

        void IndexApiPdbFiles(params PartId[] parts)
        {
            var builder = Wf.PdbIndexBuilder();
            builder.IndexParts(parts);
        }

        void EmitMetadataBlocks()
        {
            var pipe = Wf.CliPipe();
            pipe.EmitMetaBlocks();

        }

        public void Run()
        {
            CaptureSelf();
        }


        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfRuntime.create(ApiQuery.parts(Index<PartId>.Empty), args).WithSource(Rng.@default());
                var app = App.create(wf);
                app.Run();

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }


    public static partial class XTend
    {

    }
}