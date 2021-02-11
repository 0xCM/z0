//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using Z0.Tools;

    using static Part;
    using static memory;
    using static TextRules;
    using static AsmExpr;


    class App : WfService<App,App>
    {
        public App()
        {

        }

        protected override void OnInit()
        {
            Etl = AsmEtl.catalog(Wf);
            AsmParser = AsmExpr.parser(Wf);
            TextBuffer = text.buffer();
            Asm = AsmServices.context(Wf);
        }

        AsmCatalogEtl Etl;

        AsmExprParser AsmParser;

        ITextBuffer TextBuffer;

        IAsmContext Asm;

        void ShowSigOpTokens()
        {
            var tokens = AsmExpr.SigOpTokens();
            root.iter(tokens, item => Wf.Row(item.Format()));
        }

        [Op]
        Index<ApiAddressRecord> Summarize(MemoryAddress @base, ReadOnlySpan<ApiMember> members)
        {
            var count = members.Length;
            var buffer = alloc<ApiAddressRecord>(count);
            ref var dst = ref first(buffer);
            var rebase = first(members).BaseAddress;
            for(uint seq=0; seq<count; seq++)
            {
                ref var record = ref seek(dst,seq);
                ref readonly var member = ref skip(members, seq);
                record.Sequence = seq;
                record.ProcessBase = @base;
                record.MemberBase = member.BaseAddress;
                record.MemberOffset = member.BaseAddress - @base;
                record.MemberRebase = member.BaseAddress - rebase;
                record.MaxSize = seq < count - 1 ? (ulong)(skip(members, seq + 1).BaseAddress - record.MemberBase) : 0ul;
                record.HostName = member.Host.Name;
                record.PartName = member.Host.Owner.Format();
                record.Identifier = member.Id;
            }
            return buffer;
        }

        public Index<ApiAddressRecord> EmitCatalog(BasedApiMembers src)
        {
            var dst = Db.IndexTable<ApiAddressRecord>();
            Wf.Status($"Summarizing {src.MemberCount} members");
            var summaries = Summarize(src.Base, src.Members.View);
            Wf.Status($"Summarized {summaries.Count} members");
            var emitting = Wf.EmittingTable<ApiAddressRecord>(dst);
            var emitted = Records.emit<ApiAddressRecord>(summaries, dst);
            Wf.EmittedTable<ApiAddressRecord>(emitting, emitted, dst);
            return summaries;
        }

        void Jit()
        {
            var jitter = ApiServices.create(Wf).ApiJit();
            var members = jitter.JitApi();
            Wf.Status($"Jitted {members.MemberCount}");
            var records = EmitCatalog(members);
        }

        void EmitApiClasses()
        {
            var dst = Db.IndexTable("api.classes");
            var flow = Wf.EmittingTable<EnumLiteral>(dst);
            var service = ApiCatalogs.classes(Wf);
            var formatter = Records.formatter<EnumLiteral>();
            var classifiers = service.Classifiers();
            var literals = classifiers.SelectMany(x => x.Literals);
            var count = Records.emit(literals,dst);
            Wf.EmittedTable(flow, count);
        }

        void CreateLookup()
        {
            var tokens = AsmExpr.SigOpTokens();
            var lu = SymbolTables.create(tokens, t => t.Symbol);
            var count = tokens.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var token = ref tokens[i];
                if(token.IsNonEmpty)
                {
                    if(!lu.Index(token.Symbol, out var index))
                    {
                        Wf.Error($"Index for {token.Name} not found");
                    }
                    ref readonly var found = ref lu.Entry(index);

                    Wf.Row(found.Format());
                }
                else
                {
                    if(token.Index!=0)
                        Wf.Error($"Empty token has a nonzero index!");
                }
            }
        }

        void ShowMnemonicLiterals()
        {
            const string FormatPattern = "{0, -8} | {1, -8} | {2}";
            var literals = Etl.MnemonicLiterals();
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

        void EmitSpecifiers()
        {
            var specifiers = Etl.Specifiers();
            Etl.Emit(specifiers);
        }

        void ParseSpec(OperationSpec src)
        {
            var sig = src.Sig;
            TextBuffer.Clear();
            TextBuffer.AppendFormat("{0,-12}", src.Seq);
            if(AsmParser.Mnemonic(sig, out var monic))
            {
                TextBuffer.AppendFormat(" | {0,-16}", monic);
                if(Parse.after(sig.Content, monic.Name, out var remainder))
                {
                    var operands = AsmParser.Operands(remainder).View;
                    var count = operands.Length;
                    for(var i=0; i<count; i++)
                    {
                        ref readonly var op = ref skip(operands,i);

                        if(AsmParser.Decompose(op, out var pair))
                            TextBuffer.AppendFormat(" | (({0} // {1}))", pair.Left, pair.Right);
                        else
                            TextBuffer.AppendFormat(" | {0}", op.Content);
                    }
                }
            }

            Wf.Row(TextBuffer.Emit());
        }

        void ParseSigs()
        {
            var specifiers = Etl.Specifiers();
            var tokens = AsmExpr.SigOpTokens();
            var count = specifiers.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref skip(specifiers, i);
                var sig = spec.Sig;
                ParseSpec(spec);
            }
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


        void ProcessCatalog()
        {
            var records = Etl.TransformSource();
            var monics = Etl.Mnemonics();
            var maxlen = monics.Select(x => x.Name.Length).Max();
            Wf.Status(maxlen);
            GenerateExpressions(monics, Db.Doc("AsmMnemonics", FileExtensions.Cs));
            GenerateCodes(monics, Db.Doc("AsmMnemonicCode", FileExtensions.Cs));
            ShowSpecifiers(Etl);
        }


        void ShowEncodingKindNames()
        {
            root.iter(Etl.EncodingKindNames(), Wf.Row);
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
                    Wf.Status($"Jmp RAX found at {location.Format(NumericWidth.W16)}");
                    break;
                }
                address++;
            }
            return 0;
        }

        public unsafe void Run()
        {
            //ShowMnemonicLiterals();
            //ProcessCatalog();
            //var clang = Clang.create(Wf);
            //Wf.Status(clang.print_targets().Format());
            //var set = RunCapture(typeof(Clang));
            var package = Db.Package("z0/respack");
            var dllpath = package + FS.file("z0.respack.dll");

            var exists = dllpath.Exists ? "Exists" : "Missing";
            Wf.Status($"{dllpath} | {exists}");
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(WfShell.parts(Index<PartId>.Empty), args).WithRandom(Rng.@default());
                App.create(wf).Run();

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    public static partial class XTend { }
}