//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.Tools;

    using static Part;
    using static memory;

    using static TextRules;

    class App : WfService<App>
    {
        public App()
        {

        }

        protected override void OnInit()
        {
            var flow = Wf.Creating(nameof(Etl));
            Etl = AsmCatalogEtl.create(Wf);
            Wf.Created(flow, nameof(Etl));

            flow = Wf.Creating(nameof(AsmParser));
            AsmParser = AsmExpr.parser(Wf);
            Wf.Created(flow, nameof(AsmParser));

            flow = Wf.Creating(nameof(Asm));
            Asm = AsmServices.context(Wf);
            Wf.Created(flow, nameof(Asm));

            flow = Wf.Creating(nameof(ApiServices));
            ApiServices = Wf.ApiServices();
            Wf.Created(flow, nameof(ApiServices));

            flow = Wf.Creating(nameof(AsmServices));
            AsmServices = Wf.AsmServices();
            Wf.Created(flow, nameof(ApiServices));


        }

        AsmCatalogEtl Etl;

        AsmExprParser AsmParser;

        IAsmContext Asm;

        IApiServices ApiServices;

        AsmServices AsmServices;

        void ShowSigOpTokens()
        {
            var tokens = AsmSigs.tokens();
            root.iter(tokens, item => Wf.Row(item.Format()));
        }

        void Jit()
        {
            var jitter = ApiServices.ApiJit();
            var members = jitter.JitApi();
            Wf.Status($"Jitted {members.MemberCount}");
            var records = ApiServices.EmitCatalog(members);
        }

        void EmitApiClasses()
            => ApiServices.EmitApiClasses();

        void ShowMnemonicSymbols()
        {
            const string FormatPattern = "{0, -8} | {1, -8} | {2}";
            var literals = Etl.MnemonicSymbols();
            var count = literals.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var literal = ref skip(literals, i);
                var format = string.Format(FormatPattern, literal.Index, literal.Scalar, literal.Name);
                Wf.Row(format);
            }
        }

        void ShowSpecifiers()
        {
            var specifiers = Etl.Specifiers();
            var count = specifiers.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref skip(specifiers,i);
                Wf.Row(spec.Format());
            }
        }

        void LoadCatalogRows()
        {
            var rows = Etl.LoadCatalogRows();
            Wf.Status($"Loaded {rows.Length} catalog rows");
        }

        void EmitSpecifiers()
        {
            var specifiers = Etl.Specifiers();
            Etl.Emit(specifiers);
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
            root.iter(Etl.EncodingKindNames(), Wf.Row);
        }


        void CheckAsmSymbols()
        {
            var symbols = AsmSigs.table(Wf);
            var entries = symbols.Entries;
            root.iter(entries, e => Wf.Row(e));
        }

        ApiHostCaptureSet RunCapture(Type host)
        {
            var capture = AsmServices.HostCapture(Wf);
            return capture.EmitCaptureSet(host);
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
            var package = Db.Package("z0/respack");
            var dllpath = package + FS.file("z0.respack.dll");
            var exists = dllpath.Exists ? "Exists" : "Missing";
            Wf.Status($"{dllpath} | {exists}");
        }

        void CheckWinSdk()
        {
            var sdk = WinSdk.latest();
            Wf.Row(sdk);

        }

        void CheckIndexDecoder()
        {
            var decoder = AsmServices.IndexDecoder();
            var indexer = ApiServices.IndexService();
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

        void CheckApiHexArchive()
        {
            var archive = ApiArchives.hex(Wf);

        }
        public unsafe void Run()
        {
            //ShowMnemonicLiterals();
            //ShowSpecifiers();
            //var clang = Clang.create(Wf);
            //Wf.Status(clang.print_targets().Format());
            //var set = RunCapture(typeof(Clang));
            //ProcessCatalog();
            //CheckIndexDecoder();

            CheckApiHexArchive();
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