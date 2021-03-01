//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;
    using static Toolsets;

    class App : WfService<App>
    {
        public App()
        {

        }

        protected override void OnInit()
        {
            var flow = Wf.Creating(nameof(Catalog));
            Catalog = AsmCatalogService.create(Wf);
            Wf.Created(flow);

            flow = Wf.Creating(nameof(AsmParser));
            AsmParser = AsmExpr.parser(Wf);
            Wf.Created(flow);

            flow = Wf.Creating(nameof(Asm));
            Asm = AsmServices.context(Wf);
            Wf.Created(flow);

            flow = Wf.Creating(nameof(ApiServices));
            ApiServices = Wf.ApiServices();
            Wf.Created(flow);

            flow = Wf.Creating(nameof(AsmServices));
            AsmServices = Wf.AsmServices();
            Wf.Created(flow);
        }

        AsmCatalogService Catalog;

        AsmExprParser AsmParser;

        IAsmContext Asm;

        ApiServices ApiServices;

        AsmServices AsmServices;

        void ShowSigOpTokens()
        {
            var tokens = AsmSigs.tokens();
            root.iter(tokens, item => Wf.Row(item.Format()));
        }

        void EmitApiClasses()
            => ApiServices.EmitApiClasses();

        void ShowMnemonicSymbols()
        {
            const string FormatPattern = "{0, -8} | {1, -8} | {2}";
            var literals = Catalog.MnemonicSymbols();
            var count = literals.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var literal = ref skip(literals, i);
                var format = string.Format(FormatPattern, literal.Index, literal.Kind, literal.Name);
                Wf.Row(format);
            }
        }

        void ShowSpecifiers()
        {
            var specifiers = Catalog.Specifiers();
            var count = specifiers.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref skip(specifiers,i);
                Wf.Row(spec.Format());
            }
        }

        void EmitSpecifiers()
        {
            var specifiers = Catalog.Specifiers();
            Catalog.Emit(specifiers);
        }

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


        void ShowEncodingKindNames()
        {
            root.iter(Catalog.EncodingKindNames(), Wf.Row);
        }


        void CheckAsmSymbols()
        {
            var table = AsmSigs.table();
            var tokens = table.Tokens;;
            root.iter(tokens, e => Wf.Row(e));
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
            var dllpath = package + FS.file("z0.respack.dll");
            var exepath = package + FS.file("z0.respack.dll");
            var dll = dllpath.Exists ? "Exists" : "Missing";
            var exe = exepath.Exists ? "Exists"  : "Missing";
            Wf.Status($"{dllpath} | {dll}");
            Wf.Status($"{exepath} | {exe}");
            var capture = Wf.ApiResCapture();
            var assembly = Assembly.LoadFrom(exepath.Name);
            var accessors = Resources.accessors(assembly);
            var definitions = Resources.definitions(accessors);
            Wf.Status(definitions.BlockCount);
        }


        void CheckIndexDecoder()
        {
            var decoder = AsmServices.IndexDecoder();
            var indexer = ApiServices.HexIndexService();
            var blocks = indexer.IndexApiBlocks();
            var dataset = decoder.Decode(blocks);
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

            var archive = ApiArchives.hex(Wf);
            archive.CodeBlocks(part, accept);
        }

        void RunEvaluate()
        {
            var catalogs = Wf.Api.PartCatalogs();
            ApiServices.Correlate(catalogs);
            // var flow = Wf.Running("Evaluator");
            // var evaluate = Evaluate.control(Wf, Rng.@default(), Wf.Paths.AppCaptureRoot, Pow2.T14);
            // evaluate.Execute(Wf.Api.PartIdentities);
            // Wf.Ran(flow);
        }

        void ExportAsmCatRows()
        {
            Catalog.CreateExportRows();
        }

        void CheckInterfaceMaps()
        {
            var imap = Clr.imap(typeof(Prototypes.ContractedEvaluator), typeof(Prototypes.IEvaluator));
            Wf.Row(imap.Format());
        }

        void ShowCatalogSymbols()
        {
            var symbols =  Catalog.CatalogSymbols;
            root.iter(symbols.Flags, f => Wf.Row(f));
        }

        void EmitResBytes()
        {
            Wf.ResBytesEmitter().Emit();
        }


        static void indices(string src)
        {
            Span<int> dst = stackalloc int[12];
            var gt = TextRules.Query.indices(src, ">", dst);
            for(var i=0; i<gt; i++)
            {

            }

            dst.Clear();
            var lt = TextRules.Query.indices(src, "<", dst);
            for(var i=0; i<gt; i++)
            {

            }
        }


        // static void Run32(IWfShell wf)
        // {
        //     var llvm = Llvm.service(wf);
        //     var cases = llvm.Paths.Test.ModuleDir(ModuleNames.Analysis, TestSubjects.AliasSet);
        //     var cmd = WinCmd.dir(cases);
        //     var runner = ScriptRunner.create();
        //     runner.Run(cmd);
        // }

        void RunScripts()
        {
            var runner = ScriptRunner.create(Wf.Env);
            runner.RunCmdScript(clang.name, "codegen");
            runner.RunCmdScript(clang.name, "parse");
            runner.RunPsScript(clang.name, "fast-math");
            runner.RunPsScript(llvm.ml, "lex");
        }

        void EmitIntrinsicsInfo()
        {
            var doc = IntelIntrinsics.doc();
            Db.AppLog("intrinsics", FS.Extensions.Xml).Overwrite(doc.Content);
            var intrinsics = Wf.IntelIntrinsics();

            var elements = intrinsics.Parse(doc).View;
            var count = elements.Length;
            using var writer = Db.AppLog("intrinsics").Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var element = ref skip(elements,i);
                writer.WriteLine(element.Format());
            }
        }

        public unsafe void Run()
        {
            //EmitIntrinsicsInfo();
            //RunScripts();

            using var xed = XedWf.create(Wf);
            xed.Run();

            // var settings = EtlSettings.@default();
            // var saved = Db.EmitSettings(settings);
            // Wf.Row(settings);

            //var test = "adfadfaldfkadsf&>";

            //FilterApiBlocks();

            //Resources.accessors()
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