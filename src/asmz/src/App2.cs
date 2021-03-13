//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

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

            Forms = root.hashset<AsmFormExpr>();

            Sigs = Wf.AsmSigs();

        }

        AsmCatalogEtl Catalog;

        IAsmContext Asm;

        ApiServices ApiServices;

        AsmServices AsmServices;

        public void GenerateInstructions()
        {
            var monics = Catalog.Mnemonics();
            var gen = AsmGen.create(Wf);
            gen.GenerateModels(monics);
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
            var cases = AsmCases.load(AsmInstructions.call(), AsmTokens.Rel32).View;
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
            var cases = AsmCases.create(Wf);
            var mov = cases.MovCases().View;
            var count = mov.Length;
            for(var i=0; i<count; i++)
                Wf.Row(skip(mov,i).Format());

        }

        /// <summary>
        /// ModRM = [Mod:[7:6] | Reg:[5:3] | Rm:[2:0]]
        /// </summary>

        void ShowModRmBits()
        {
            var parts = new byte[2]{2,5};
            var codes = ModRm.create(Wf).Table;
            var count = codes.Length;
        }

        AsmOpCodeLookup OpCodes;

        AsmSigExprLookup SigLookup;

        HashSet<AsmFormExpr> Forms;

        SymbolTable<AsmMnemonicCode> Mnemonics;

        AsmSigs Sigs;

        static MsgPattern<Count,Count,Count> CollectedForms
            => "Collected {0} distinct opcodes, {1} distinct signatures and {2} distinct combined forms";

        static MsgPattern<FS.FileUri> LoadingStatements
            => "Loading statements from {0}";

        static MsgPattern<Count,FS.FileUri> LoadedStatments
            => "Loading {0} statements from {1}";

        static MsgPattern<Count,FS.FileUri> ProcessingStatments
            => "Processing {0} statements from {1}";

        static MsgPattern<Count,FS.FileUri> ProcessedStatements
            => "Processed {0} statements from {1}";

        void Process(params Action<AsmStatementInfo>[] receivers)
        {
            var distiller = Wf.AsmDistiller();
            var paths = distiller.Distillations();
            var flow = Wf.Running("Processing current statement set");
            OpCodes = AsmOpCodeLookup.create();
            SigLookup = AsmSigExprLookup.create();
            Forms.Clear();
            Mnemonics = SymbolStores.table<AsmMnemonicCode>();
            foreach(var path in paths)
            {
                var loading = Wf.Running(LoadingStatements.Format(path));
                var data = distiller.LoadDistillation(path).View;
                var count = data.Length;
                Wf.Ran(loading, LoadedStatments.Format(count,path));

                var processing = Wf.Running(ProcessingStatments.Format(count,path));
                foreach(var receiver in receivers)
                    ProcessStatements(data, receiver);
                Wf.Ran(processing,ProcessedStatements.Format(count,path));
            }

            Wf.Ran(flow, CollectedForms.Format(OpCodes.Count, SigLookup.Count, Forms.Count));
            var sorted = Forms.OrderBy(x => x.OpCode).Array();
            var pipe = AsmFormPipe.create(Wf);
            var target = Db.IndexTable<AsmFormRecord>();
            pipe.Emit(sorted,target);
        }

        void ProcessStatements(ReadOnlySpan<AsmStatementInfo> src, Action<AsmStatementInfo> receiver)
        {
            var count = src.Length;
            var invalid = root.hashset<string>();
            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(src,i);
                if(statement.OpCode.IsEmpty || statement.Sig.IsEmpty)
                    continue;
                else
                {
                    var opcode = statement.OpCode;
                    if(opcode.IsValid)
                    {
                        receiver(statement);
                        SigLookup.AddIfMissing(statement.Sig);
                        Forms.Add(asm.form(opcode, statement.Sig));
                    }
                }
            }
        }

        static bool parse(string src, out CilRow dst)
        {
            var parts = @readonly(src.SplitClean(Chars.Pipe));
            var count = parts.Length;
            if(count != 3)
            {
                dst = default;
                return false;
            }
            else
            {
                Records.parse(skip(parts,0), out dst.BaseAddress);
                Records.parse(skip(parts,1), out dst.Uri);
                Records.parse(skip(parts,2), out dst.CilCode);
                return true;
            }
        }

        void EmitCilBlocks()
        {
            var service = Cil.visualizer();
            var input = Db.CilDataFiles().View;
            var count = input.Length;
            var builder = text.build();
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(input,i);
                var output = Db.CilCodeFile(path.FileName.WithoutExtension);
                using var reader = path.Reader();
                using var writer = output.Writer();
                var flow = Wf.EmittingFile(output);
                while(!reader.EndOfStream)
                {
                    builder.Clear();
                    var line = reader.ReadLine();
                    if(parse(line, out var row))
                    {
                        var code = row.CilCode;
                        service.DumpILBlock(code, code.Length, builder);
                        writer.WriteLine(string.Format("// {0} {1}", row.BaseAddress, row.Uri));
                        writer.WriteLine("{");
                        writer.WriteLine(builder.ToString());
                        writer.WriteLine("}");
                        writer.WriteLine();
                    }
                    else
                        Wf.Warn($"The content {line} could not be parsed");

                }
                Wf.EmittedFile(flow);
            }
        }

        static string FormatAttributes(IXmlElement src)
            => src.Attributes.Select(x => string.Format("{0}={1}",x.Name, x.Value)).Delimit(Chars.Comma).Format();

        void ConvertPdbXml()
        {
            var dir = Db.ToolOutDir(Toolsets.pdb2xml);
            var file = PartId.Math.Component(FS.Extensions.Pdb, FS.Extensions.Xml);
            var srcPath = dir + file;
            var buffer = text.buffer();

            var dstPath = Db.AppDataFile(file.WithExtension(FS.Extensions.Log));
            using var writer = dstPath.Writer();

            const string Pattern = "{0}/{1}:{2}";

            void HandleFiles(IXmlElement src)
                => writer.WriteLine(string.Format(Pattern, src.Ancestor, src.Name, FormatAttributes(src)));

            void HandleMethods(IXmlElement src)
                => writer.WriteLine(string.Format(Pattern, src.Ancestor, src.Name, FormatAttributes(src)));

            void HandleSequencePointEntry(IXmlElement src)
                => writer.WriteLine(string.Format(Pattern, src.Ancestor, src.Name, FormatAttributes(src)));


            var handlers = new ElementHandlers();
            handlers.AddHandler("file", HandleFiles);
            handlers.AddHandler("method", HandleMethods);
            handlers.AddHandler("entry", HandleMethods);

            var flow = Wf.EmittingFile(dstPath);
            using var xml = XmlSource.create(Wf, srcPath);
            xml.Read(handlers);
            Wf.EmittedFile(flow);
        }

        Index<string> CollectFormExpressions()
        {
            var pipe = AsmFormPipe.create(Wf);
            var src = Db.IndexTable<AsmFormRecord>();
            var records = pipe.Load(src).View;
            var count = records.Length;
            var expressions = alloc<string>(count);
            ref var block = ref first(expressions);
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                seek(block, i) = record.Expression;
                root.require(skip(block,i) != null, () => $"Row {i} is null");
            }
            return expressions;
        }

        void HashPerfect(Index<string> src)
        {
            var perfect = HashFunctions.perfect(src);
            root.iter(perfect, p => Wf.Row(p));

        }

        void ParseMnemonics()
        {

        }

        void HashPerfect()
        {
            HashPerfect(CollectFormExpressions());
        }

        void EmitMsil()
        {
            var pipe = Wf.IlPipe();
            var members = Wf.Api.ApiHosts.Where(h => h.HostType == typeof(math)).Single().Methods;
            var buffer = text.buffer();
            var methods = Cil.methods(members);
            root.iter(methods, m => pipe.Render(m,buffer));
            using var writer = Db.AppDataFile(FS.file(nameof(math), FS.Extensions.Il)).Writer();
            writer.Write(buffer.Emit());
            //root.iter(methods, m => pipe.Render(m,buffer));
        }


        void ProcessStatements()
        {
            var table = SymbolStores.table<AsmMnemonicCode>();
            var counter = 0u;
            var mnemonics = root.hashset<AsmMnemonicCode>();
            var failures = root.hashset<string>();
            var opcodes = root.hashset<AsmOpCodeExpr>();

            var ocpath = Db.AppDataFile(FS.file("statement-opcodes", FS.Extensions.Csv));
            using var ocwriter = ocpath.Writer();


            void CountStatements(AsmStatementInfo src)
            {
                counter++;
            }

            void CollectOpCodes(AsmStatementInfo src)
            {
                var encoded = src.Encoded;
                if(AsmQuery.HasRexPrefix(src.OpCode))
                {
                    ocwriter.WriteLine(string.Format("{0,-24} | {1, -24} | {2,-16} | {3}", src.Expression, src.Sig, src.OpCode, src.Encoded));
                }
            }

            void CollectMnemonics(AsmStatementInfo src)
            {
                var symbol = src.Mnemonic.Name.ToLower();
                if(table.TokenFromSymbol(symbol, out var t))
                    mnemonics.Add(t.Kind);
                else
                    failures.Add(symbol);
            }

            Process(CountStatements, CollectMnemonics, CollectOpCodes);
            Wf.Status($"{counter} statements were processed)");
            Wf.Status($"{mnemonics.Count} known mnemonics were encountered along with {failures.Count} unknown mnemonics: {failures.FormatList()}");
            Wf.Status($"{opcodes.Count} distinct opcodes were collected");

        }
        public void Run()
        {
            //var commands = Wf.AsmWfCmd();
            //commands.Run(AsmWfCmdKind.EmitFormCatalog);
            //commands.Run(AsmWfCmdKind.ShowRexBits);

            var commands = Wf.AsmLangCmd();
            commands.Run(AsmLangCmdKind.ShowRegisterCodes);
            // commands.Run(AsmSigCmdKind.ShowMnemonicSymbols);

            //ProcessStatements();

            // var dst = span<char>(32);
            // var vsib = AsmBytes.vsib(0b11_100_111);
            // Wf.Status(AsmBytes.format(vsib));

            //ProcessDistilledStatements();


            //GenerateInstructions();
            //ConvertPdbXml();
            // var commands = Wf.AsmWfCmd();
            // commands.Run(AsmWfCmdKind.EmitAsmRows);
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