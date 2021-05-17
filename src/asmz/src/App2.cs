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
    using static ProcessMemory;

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

        public ListFilesCmd EmitFileListCmdSample()
        {
            var cmd = new ListFilesCmd();
            cmd.ListName = "tests";
            cmd.SourceDir = FS.dir(@"J:\lang\net\runtime\artifacts\tests\coreclr\windows.x64.Debug");
            cmd.TargetPath = Db.IndexTable("clrtests");
            cmd.FileUriMode = true;
            cmd.WithExt(FS.Cmd);
            return cmd;
        }

        CmdResult EmitFileList()
            => Wf.Router.Dispatch(EmitFileListCmdSample());

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

        void CheckCpuid()
        {
            var cpuid = CpuId.request(0u,0u);
            var result = Cells.cell128(0x00000015, 0x756E6547, 0x6C65746E, 0x49656E69);
            CpuId.response(result, ref cpuid);
            Wf.Row(cpuid.Format());

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
            var dst = Db.IndexTable<MemoryRegion>();
            var flow = Wf.EmittingTable<MemoryRegion>(dst);
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

        void RunExtractor()
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

        public unsafe void EmitRawMetadata(Assembly src, FS.FilePath dst)
        {
            var segment = Clr.metadata(src);
            using var writer = dst.Writer();
            Hex.emit(segment, 64, writer);

            // var emitter = Wf.MemoryEmitter();
            // emitter.Emit(segment, 32, dst);
        }

        public unsafe void EmitRawMetadata(Assembly src)
        {
            var dst = Db.AppLog(src.GetSimpleName() + ".metadata", FS.Csv);
            EmitRawMetadata(src, dst);
        }


        public void Run()
        {
            var extractor = Wf.ApiExtractor();
            extractor.Run();
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