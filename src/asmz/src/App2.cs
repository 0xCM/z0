//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Linq;

    using static Part;
    using static memory;
    using static Toolsets;
    using static AsmExpr;

    class App : WfService<App>
    {
        public App()
        {

        }

        protected override void OnInit()
        {
            var flow = Wf.Creating(nameof(Catalog));
            Catalog = AsmCatalogEtl.create(Wf);
            Wf.Created(flow);

            flow = Wf.Creating(nameof(Asm));
            Asm = Wf.AsmContext();
            Wf.Created(flow);

            flow = Wf.Creating(nameof(ApiServices));
            ApiServices = Wf.ApiServices();
            Wf.Created(flow);

            flow = Wf.Creating(nameof(AsmServices));
            AsmServices = Wf.AsmServices();
            Wf.Created(flow);
        }

        AsmCatalogEtl Catalog;

        IAsmContext Asm;

        ApiServices ApiServices;

        AsmServices AsmServices;

        public void GenBits()
        {
            var factory = BitStoreFactory.create(Wf);
            var blocks = factory.ByteCharBlocks().View;
            var count = blocks.Length;
            var buffer = alloc<ByteSpanProp>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                var b = @bytes(block.Data);
                seek(dst,i) = ByteSpans.property(string.Format("Block{0:X2}", i), b.ToArray());
            }
            var merge = ByteSpans.merge(buffer, "CharBytes");
            var s0 = recover<char>(merge.Segment(16,16));
            Wf.Row(s0.ToString());
        }


        ApiHostCaptureSet RunCapture(Type host)
        {
            var capture = AsmServices.HostCapture(Wf);
            return capture.Capture(host);
        }

        public static ReadOnlySpan<byte> TestCase01 => new byte[44]{0x0f,0x1f,0x44,0x00,0x00,0x49,0xb8,0x68,0xd5,0x9e,0x18,0x36,0x02,0x00,0x00,0x4d,0x8b,0x00,0x48,0xba,0x28,0xd5,0x9e,0x18,0x36,0x02,0x00,0x00,0x48,0x8b,0x12,0x48,0xb8,0x90,0x2c,0x8b,0x64,0xfe,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static bool TestJmpRax(ReadOnlySpan<byte> src, int offset, out byte delta)
        {
            delta = 0;
            if(offset >= 3)
            {
                ref readonly var s2 = ref skip(src,offset - 2);
                ref readonly var s1 = ref skip(src,offset - 1);
                ref readonly var s0 = ref skip(src,offset - 0);
                if(s2 == 0x48 && s1 == 0xff && s0 == 0xe0)
                {
                    delta = 2;
                    return true;
                }
            }
            return false;
        }

        void ShowPartComponents()
        {

            var src = Clr.adapt(Wf.Api.PartComponents);
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var item = ref skip(src,i);
                var info = new {
                    item.SimpleName,
                    item.Location,
                    item.PdbPath,
                    item.DocPath,
                    MetadataSize = ((ByteSize)item.RawMetadata.Length).Kb
                };
                Wf.Row(info.ToString());
            }
        }

        public int TestJmpRax()
        {
            var tc = TestCase01;
            var count = tc.Length;
            var address = MemoryAddress.Zero;
            for(var i=0; i<count; i++)
            {
                var result = TestJmpRax(tc, i, out var delta);
                if(result)
                {
                    var location = address - delta;
                    Wf.Status($"Jmp RAX found at {location.Format()}");
                    break;
                }
                address++;
            }
            return 0;
        }

        void CheckApiSigs()
        {
            var t0 = ApiSigs.type("uint");
            var t1 = ApiSigs.type("uint");
            var t2 = ApiSigs.type("bool");
            var op0 = ApiSigs.operand("a", t0);
            var op1 = ApiSigs.operand("b", t1);
            var r = ApiSigs.@return(t2);
            Wf.Row(ApiSigs.operation("equals", r, op0, op1));
        }

        void CheckResPack()
        {
            var package = Db.Package("respack");
            var path = package + FS.file("z0.respack.dll");
            var exists = path.Exists ? "Exists" : "Missing";
            Wf.Status($"{path} | {exists}");
            var assembly = Assembly.LoadFrom(path.Name);
            var accessors = Resources.accessors(assembly).View;
            var count = accessors.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var accessor = ref skip(accessors,i);
                var description = Resources.description(accessor);
                var resource = Resources.resource(accessor);
                Wf.Row(string.Format("{0} | {1,-8} | {2}", resource.Address, resource.Size, resource.Accessor.Member.Name));
                //Wf.Row(string.Format("{0} | {1} ", description.FormatHex(), accessor.Member.Name));
            }

            //var dst = Db.AppLog("respack", FS.Extensions.Asm);
            //var capture = Wf.ApiResCapture();
            //var captured = capture.CaptureAccessors(accessors, dst);
            //Wf.Status(definitions.BlockCount);
        }

        void CheckIndexDecoder()
        {
            var blocks = ApiServices.HexIndexer().IndexApiBlocks();
            var dataset = Wf.ApiIndexDecoder().Decode(blocks);
        }

        void TestRel32()
        {
            var cases = AsmCases.load(AsmInstructions.call(), AsmSigTokenList.Rel32).View;
            var count = cases.Length;
            var errors = text.buffer();
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(cases,i);
                Wf.Row(c.Format());
                Wf.Row(RP.PageBreak40);
                if(!c.Validate(errors))
                    Wf.Error(errors.Emit());
            }
        }

        void ListDescriptors()
        {
            var descriptors = ApiCode.descriptors(Wf);
            Wf.Row($"Loaded {descriptors.Count} descriptors");
        }

        void TestTextProps()
        {
            var a0 = text.prop("name0", "value0");
            Wf.Row(a0);
        }

        void ShowMemory()
        {
            var info = memory.basic();
            var buffer = text.buffer();
            buffer.AppendLine(text.prop(nameof(info.BaseAddress), info.BaseAddress));
            buffer.AppendLine(text.prop(nameof(info.AllocationBase), info.AllocationBase));
            buffer.AppendLine(text.prop(nameof(info.RegionSize), info.RegionSize));
            buffer.AppendLine(text.prop(nameof(info.StackSize), info.StackSize));
            buffer.AppendLine(text.prop(nameof(info.Protection), info.Protection));
            Wf.Row(buffer.Emit());
        }

        void FilterApiBlocks()
        {
            var blocks = ApiServices.Correlate();
            var f1 = blocks.Filter(ApiClass.And);
            root.iter(f1,f => Wf.Row(f.Uri));
        }

        void CheckApiHexArchive()
        {
            var part = PartId.Math;
            var component = Wf.Api.FindComponent(part).Require();
            var catalog = ApiCatalogs.PartCatalog(component);

            void accept(in ApiCodeBlock block)
            {
                if(catalog.Host(block.Uri.Host, out var host))
                {
                    Wf.Row(string.Format("{0} | {1}", host.Uri, block.OpUri));
                }
            }

            var archive = Wf.ApiHexArchive();
            archive.CodeBlocks(part, accept);
        }

        void CheckDataReader()
        {
            var reader = Wf.AsmDataReader();
            var calls = reader.LoadCallRows();
            Wf.Status($"Loaded {calls.Count} call rows");
        }

        void CheckInterfaceMaps()
        {
            var imap = Clr.imap(typeof(Prototypes.ContractedEvaluator), typeof(Prototypes.IEvaluator));
            Wf.Row(imap.Format());
        }

        void RunScripts()
        {
            var runner = ScriptRunner.create(Wf.Env);
            runner.RunCmdScript(clang.name, "codegen");
            runner.RunCmdScript(clang.name, "parse");
            runner.RunPsScript(clang.name, "fast-math");
            runner.RunPsScript(llvm.ml, "lex");
        }


        void SplitFiles()
        {
            var limit = new Mb(15);
            var root = Db.ToolOutDir(dia2dump);
            var descriptions = Db.ToolOutFiles(dia2dump).Descriptions().Where(f => f.Size.Mb >= limit).Array();
            var splitter = TextFileSplitter.create(Wf);
            foreach(var description in descriptions)
            {
                var path = description.Path;
                var target = root + FS.folder(path.FileName.WithoutExtension.Name);
                target.Delete();
                var spec = new FileSplitSpec(path, 50000, target);
                splitter.Run(spec);
            }

        }

        void ShowCases()
        {
            var cases = AsmCases.mov().View;
            var count = cases.Length;
            for(var i=0; i<count; i++)
                Wf.Row(skip(cases,i).Format());
        }

        /// <summary>
        /// ModRM = [Mod:[7:6] | Reg:[5:3] | Rm:[2:0]]
        /// </summary>

        void ShowModRmBits()
        {
            var parts = new byte[2]{2,5};
            var codes = AsmBytes.modrm().View;
            var count = codes.Length;
        }

        OpCodeLookup OpCodes;

        SignatureLookup Sigs;

        FormLookup Forms;


        static MsgPattern<Count,Count,Count> CollectedForms => "Collected {0} distinct opcodes, {1} distinct signatures and {2} distinct combined forms";

        static MsgPattern<FS.FileUri> LoadingStatements => "Loading statements from {0}";

        static MsgPattern<Count,FS.FileUri> LoadedStatments => "Loading {0} statements from {1}";

        static MsgPattern<Count,FS.FileUri> ProcessingStatments => "Processing {0} statements from {1}";

        static MsgPattern<Count,FS.FileUri> ProcessedStatements => "Processed {0} statements from {1}";


        void ProcessStatements()
        {
            var distiller = Wf.AsmDistiller();
            var paths = distiller.Distillations();
            var flow = Wf.Running("Processing current statement set");
            OpCodes = OpCodeLookup.create();
            Sigs = SignatureLookup.create();
            Forms = FormLookup.create();
            foreach(var path in paths)
            {
                var loading = Wf.Running(LoadingStatements.Format(path));
                var data = distiller.LoadDistillation(path).View;
                var count = data.Length;
                Wf.Ran(loading, LoadedStatments.Format(count,path));

                var processing = Wf.Running(ProcessingStatments.Format(count,path));
                ProcessStatements(data);
                Wf.Ran(processing,ProcessedStatements.Format(count,path));
            }

            Wf.Ran(flow, CollectedForms.Format(OpCodes.Count, Sigs.Count, Forms.Count));
            var sorted = Forms.Values.OrderBy(x => x.OpCode).Array();
            var pipe = AsmFormPipe.create(Wf);
            var target = Db.IndexTable<AsmFormRecord>();
            pipe.Emit(sorted,target);
        }


        void ProcessStatements(ReadOnlySpan<AsmStatementInfo> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(src,i);
                if(statement.OpCode.IsEmpty || statement.Sig.IsEmpty)
                    continue;
                else
                {
                    OpCodes.AddIfMissing(statement.OpCode);
                    Sigs.AddIfMissing(statement.Sig);
                    Forms.AddIfMissing(asm.form(statement.OpCode, statement.Sig));
                }
            }
        }

        public void Run()
        {
            // var commands = WfCmdGlobals.create(Wf);
            // commands.Run(GlobalWfCmd.ShowByteConversions);
            var src = FS.path(Parts.Konst.Assembly.Location);
            var dst = Db.AppDataFile(src.FileName.ChangeExtension(FS.Extensions.Txt));
            var flow = Wf.EmittingFile(dst);
            Cil.visualize(src,dst);
            Wf.EmittedFile(flow);

            //CliTables.create(Wf).DumpMetadata(src,dst);
            //ProcessStatements();
            //Wf.AsmWfCmd().Run(AsmWfCmdKind.ShowSigOpComposites);
            //Wf.CliWfCmd().Run(CliWfCmdKind.EmitImageHeaders);
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(WfShell.parts(Index<PartId>.Empty), args).WithRandom(Rng.@default());
                var app = App.create(wf);
                app.Run();

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

    }

    public static partial class XTend { }
}