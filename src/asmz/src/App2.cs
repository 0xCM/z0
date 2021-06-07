//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static core;
    using static Toolsets;

    partial class App : AppService<App>
    {
        public App()
        {

        }

        protected override void OnInit()
        {

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

        void EmitRuntimeMembers()
        {
            var service = ApiRuntime.create(Wf);
            var members = service.EmitRuntimeIndex();
        }

        void LoadCurrentCatalog()
        {
            var entries = Wf.ApiCatalogs().LoadCatalog().View;
        }

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
            Tables.emit(segments.View, dst);
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

        public void LoadHexPacks()
        {
            var svc = Wf.ApiPacks();
            var pack = svc.List().Last;
            var hex = Wf.ApiHexPacks();
            var packs = hex.LoadParsed(pack.HexPackRoot());
        }

        public void RunOldXedWf()
        {
            var xed = XedWf.create(Wf);
            xed.Run();
        }

        public void UnpackRespack()
        {
            var unpacker = ResPackUnpacker.create(Wf);
            unpacker.Emit(Db.AppLogDir());
        }

        public MemoryFile OpenResPack()
        {
            var path = Wf.Db().Package("respack") + FS.file("z0.respack", FS.Dll);
            return MemoryFiles.map(path);
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

        void IndexApiPdbFiles(params PartId[] parts)
        {
            var builder = Wf.PdbIndexBuilder();
            builder.IndexParts(parts);
        }

        void EmitMetadataBlocks()
        {
            Wf.CliPipe().EmitMetaBlocks();
        }

        ReadOnlySpan<FileType> ListFileTypes()
        {
            var src = FileTypes.supported().View;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var type = ref skip(src,i);
                Wf.Row(type);
            }
            return src;
        }


        void ListFiles()
        {
            var catalog = Db.AsmCaptureRoot().Catalog();
            catalog.Enumerate(path => Wf.Row(path.ToUri()));

        }

        void CheckHeap()
        {
            const string Seg0 = "This";
            const string Seg1 = "is";
            const string Seg2 = "a";
            const string Seg3 = "HeapString";
            const string segments = "This" + "is" + "a" + "HeapString";

            var s0 = (uint)Seg0.Length;
            var s1 = (uint)Seg1.Length;
            var s2 = (uint)Seg2.Length;
            var s3 = (uint)Seg3.Length;

            var offsets = array<uint>(
                0,
                s0,
                s0 + s1,
                s0 + s1 + s2
                );

            var heap = Heaps.cover(text.span(segments), offsets);
            for(var i=0u; i<offsets.Length; i++)
            {
                var seg = text.format(heap.Segment(i));
                Wf.Row(seg);
            }
        }

        void EmitTableReport(FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var emitting = Wf.EmittingFile(dst);
            var tables = Tables.discover(Wf.ApiCatalog.Components);
            var count = tables.Length;
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    writer.WriteLine();

                var table = skip(tables,i);
                writer.WriteLine(string.Format("{0,-8} | {1,-22} | {2}", i, table.Id.Identifier, table.Id.Identity));
                writer.WriteLine(RP.PageBreak80);

                var fields = @readonly(table.Fields);
                for(var j=0; j<fields.Length; j++)
                {
                    ref readonly var field = ref skip(fields,j);
                    writer.WriteLine(string.Format("{0,-8} | {1,-22} | {2}", field.FieldIndex, field.Name, field.DataType));
                }
            }

            Wf.EmittedFile(emitting, count);
        }

        void EmitTableReport()
        {
            EmitTableReport(Db.ReportRoot() + FS.file("tabledefs", "rpt"));
        }

        void CorrelateApi()
        {
            var dst = Db.AppTablePath<ApiCorrelationEntry>();
            Wf.ApiCatalogs().Correlate(dst);

        }

        [Op]
        static Address32 rel32dx(BinaryCode src)
        {
            var opcode = src.First;
            root.require(opcode == 0xe8, () => $"Expected an opcode of e8h, but instead there is {opcode.FormatAsmHex()}");
            var bytes = slice(src.View, 1);
            return core.u32(bytes);
        }

        void TestRel32()
        {
            var @base = 0x7fff328f9430;
            var ip = @base + 0x36;
            var sz = 5;
            var nip = ip + sz;
            var code = new byte[]{0xe8, 0x25, 0xe4, 0xb2, 0x5f};
            const string Statement = "0036h call 7fff92427890h; e8 25 e4 b2 5f";
            var dx = rel32dx(code);
            Wf.Row(dx);
        }

        void StatementRountTrip()
        {
            var blocks = Wf.ApiHex().ReadBlocks().View;
            var pipe = Wf.AsmStatementPipe();
            var root = Db.AppLogDir("statements");
            pipe.EmitHostStatements(blocks, root);
            var parsed = pipe.ParseStatementData(root);
        }

        public void ParseDump()
        {
            using var clrmd = ClrMdSvc.create(Wf);
            clrmd.ParseDump();
        }

        PeRecords.CoffHeaderRow ReadCoffHeader(FS.FilePath src)
        {
            using var reader = PeReader.create(src);
            var header = reader.ReadCoffHeader();
            return header;
        }

        void ShowCoffHeader(FS.FilePath src)
        {
            var header = ReadCoffHeader(src);
            var formatter = header.Formatter();
            var id = formatter.TableId;
            using var log = ShowLog(string.Format("{0}.{1}", formatter.TableId, src.FileName), FS.Log);
            log.Show(formatter.Format(header, RecordFormatKind.KeyValuePairs));
        }


        void FormatBits(ReadOnlySpan<CpuIdRow> src, ITextBuffer dst)
        {
            var count = src.Length;
            var j = 0u;
            var w = n8;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(src,i);
                dst.AppendFormat("eax: {0} [{1}] | ", row.Eax, row.Eax.FormatBitstring(w));
                var ebx = row.Ebx.FormatBitstring(w);
                dst.AppendFormat("ebx: {0} [{1}] | ", row.Ebx, row.Ebx.FormatBitstring(w));
                var ecx = row.Ecx.FormatBitstring(w);
                dst.AppendFormat("ebx: {0} [{1}] | ", row.Ecx, row.Ecx.FormatBitstring(w));
                var edx = row.Edx.FormatBitstring(w);
                dst.AppendFormat("edx: {0} [{1}]", row.Edx, row.Edx.FormatBitstring(w));
                Wf.Row(dst.Emit());
            }

        }

        void CheckCpuid()
        {
            var descriptor = Parts.AsmCases.Assets.CpuIdRows();
            var content = text.utf8(descriptor.ResBytes);
            var pipe = Wf.AsmRowPipe();
            using var reader = content.Reader();
            var rows = pipe.LoadCpuIdRows(reader);
            var formatter = rows.RecordFormatter(CpuIdRow.RenderWidths);
            Wf.Row(formatter.FormatHeader());
            core.iter(rows, row => Wf.Row(formatter.Format(row)));

            // var buffer = text.buffer();
            // FormatBits(rows, buffer);

        }

        void EmitAssetCatalog()
        {
            var catalogs = Wf.AsmCatalogs();
            var assets = AsmData.Assets;
            var host = assets.DataSource;
            var descriptors = assets.Descriptors;
            var count = descriptors.Length;
            var dst = Db.Table<AssetCatalogEntry>(host.GetSimpleName());
            var flow = Wf.EmittingTable<AssetCatalogEntry>(dst);
            using var writer = dst.Writer();
            var formatter = Tables.formatter<AssetCatalogEntry>(AssetCatalogEntry.RenderWidths);
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var descriptor = ref skip(descriptors,i);
                var entry = descriptor.CatalogEntry;
                writer.WriteLine(formatter.Format(entry));
            }
            Wf.EmittedTable(flow,count);
        }

        void EmitCatalogAssets()
        {
            const byte fieldCount = 4;
            var delimiter = Tables.DefaultDelimiter;
            var widths = new byte[fieldCount]{14,14,14,64};
            var dst = Db.AppLog("assets.features", FS.Csv);
            var assets = AsmData.Assets;
            var features = assets.FeatureMnemonics();
            var emitting = Wf.EmittingFile(dst);
            var result = Tables.normalize(features, delimiter, widths, dst);
            if(result.Fail)
                Wf.Error(result.Message);
            else
                Wf.EmittedFile(emitting, result.Data);
        }

        void EmitMethodDefs(CliPipe pipe)
        {
            pipe.EmitMethodDefs(Wf.ApiCatalog.Components, Db.IndexTable<MethodDefInfo>());
        }

        void EmitFieldDefs(CliPipe pipe)
        {
            pipe.EmitFieldDefs(Wf.ApiCatalog.Components, Db.IndexTable<FieldDefInfo>());
        }

        void EmitRowStats(CliPipe pipe)
        {
            pipe.EmitRowStats(Wf.ApiCatalog.Components, Db.IndexTable<CliRowStats>());
        }

        void EmitCliMetadata()
        {
            var pipe = Wf.CliPipe();
            EmitRowStats(pipe);
            EmitMethodDefs(pipe);
            EmitFieldDefs(pipe);
        }

        void ShowMemory()
        {
            var info = WinMem.basic();
            var formatter = info.Formatter();
            Wf.Row(formatter.Format(info,RecordFormatKind.KeyValuePairs));
        }

        public void EmitCpuIntrinsics()
        {
            Wf.IntrinsicsCatalog().Emit();
        }

        public void EmitXedSources()
        {
            Wf.XedCatalog().EmitSourceAssets();
        }

        public void EmitSymbolicliterals()
        {
            var service = Wf.Symbolism();
            var dst = Db.AppTablePath<SymLiteral>();
            service.EmitLiterals(dst);
        }

        public ReadOnlySpan<CilOpCode> EmitCilOpCodes(FS.FilePath dst)
        {
            var codes = Cil.opcodes();
            TableEmit(codes,dst);
            return codes;
        }

        public ReadOnlySpan<CilOpCode> EmitCilOpCodes()
        {
            var dst = Db.IndexTable<CilOpCode>();
            return EmitCilOpCodes(dst);
        }


        public ApiCodeBlocks LoadApiBlocks()
        {
            return Wf.ApiHex().ReadBlocks();
        }


        void EmitDependencyGraph()
        {
            var svc = Wf.CliPipe();
            var refs = svc.ReadAssemblyRefs();
            var dst = Db.AppLog("dependencies", FS.Dot);
            var flow = Wf.EmittingFile(dst);
            var count = refs.Length;
            var parts = Wf.ApiCatalog.ComponentNames.ToHashSet();
            using var writer = dst.Writer();
            writer.WriteLine("digraph dependencies{");
            writer.WriteLine(string.Format("label={0}", text.enquote("Assembly Dependencies")));
            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref skip(refs,i);
                if(parts.Contains(x.Target.Name))
                {
                    var source = x.Source.Name.Replace(Chars.Dot, Chars.Underscore);
                    var target = x.Target.Name.Replace(Chars.Dot, Chars.Underscore);
                    var arrow = string.Format("{0}->{1}", source, target);
                    writer.WriteLine(arrow);
                }
            }
            writer.WriteLine("}");
            Wf.EmittedFile(flow, count);
        }

        void CalcRelativePaths()
        {
            var @base = Db.DbRoot();
            var files = Db.AsmCapturePaths().View;
            var relative = files.Map(f => f.Relative(@base));
            var count = relative.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(relative,i);
                var link = Markdown.link(path);
                Wf.Row(link);
            }
        }

        void ParseDump2()
        {
            using var clrmd = ClrMdSvc.create(Wf);
            clrmd.ParseDump();
        }

        void GenSlnScript()
        {
            const string Pattern = "dotnet sln add {0}";
            var src = FS.dir(@"C:\Dev\z0");
            var dst = Db.AppLog("create-sln", FS.Cmd);
            var projects = src.Files(FS.CsProj, true);
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            root.iter(projects,project => writer.WriteLine(string.Format(Pattern, project.Format(PathSeparator.BS))));
            Wf.EmittedFile(flow,projects.Length);
        }

        void Symbolize()
        {
            var assemblies = Wf.ApiCatalog.Components;
            var flow = Wf.Running(string.Format("Collecting method symbols for {0} assemblies", assemblies.Length));
            var symbolic = Wf.SourceSymbolic();
            var collector = new MethodSymbolCollector();
            symbolic.SymbolizeMethods(assemblies, collector.Deposit);
            var collected = collector.Collected;
            var count = collected.Length;
            Wf.Ran(flow, string.Format("Collected {0} method symbols", count));
            var dst = Db.AppLog("methods", FS.Cs);
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(collected,i);
                var doc = method.Docs;
                writer.WriteLine(string.Format("{0}; {1}", method.Format(), doc != null ? "//" + doc.SummaryText : EmptyString));
            }
            Wf.EmittedFile(emitting, count);
        }

        void ProcessInstructions()
        {
            var blocks = LoadApiBlocks();
            var clock = Time.counter(true);
            var traverser = Wf.ApiCodeBlockTraverser();
            var receiver  = new AsmDetailProducer(Wf,750000);
            traverser.Traverse(blocks, receiver);
            var duration = clock.Elapsed().Ms;
            var productions = receiver.Productions;
            Wf.Status(string.Format("Processed {0} instructions in {1} ms", productions.Length, (ulong)duration));
        }

        void RunExtractWorkflow()
        {
           ApiExtractWorkflow.run(Wf);
        }


        [Record(TableId)]
        public struct PartSelection : IRecord<PartSelection>
        {
            public const string TableId = "selected-parts";

            public string Part;

            public bool Selected;
        }

        ReadOnlySpan<ApiHostRes> EmitResPack()
        {
            var blocks = LoadApiBlocks();
            var dst = Db.AppLogDir("Respack");
            return Wf.ResPackEmitter().Emit(blocks.View,dst);
        }

        public void GenerateInstructionModels()
        {
            Wf.AsmCodeGenerator().GenerateModelsInPlace();
        }

        public void GenerateInstructionModelPreview()
        {
            Wf.AsmCodeGenerator().GenerateModels(Db.AppLogDir() + FS.folder("asm.lang.g"));
        }

        void ShowRegOps()
        {
            var reg = AsmOp.reg(RegWidth.W32, RegClass.GP, RegIndex.r2);
            Wf.Row(string.Format("{0}{1}/{2}", reg.Width, reg.Index, reg.RegClass));
        }

        public void ShowRexTable()
        {
            var bits = AsmEncoder.RexPrefixBits();
            using var log = OpenShowLog("rexbits");
            var count = bits.Length;
            for(var i=0; i<count; i++)
                Show(AsmRender.describe(skip(bits,i)), log);
        }

        public void ShowModRmTable()
        {
            using var dst = ShowLog(FS.Log);
            var f0 = BitSeq.bits(n3);
            var f1 = BitSeq.bits(n3);
            var f2 = BitSeq.bits(n2);
            var i=0;
            for(var c=0u; c<f2.Length; c++)
            for(var b=0u; b<f1.Length; b++)
            for(var a=0u; a<f0.Length; a++,i++)
            {
                var modrm = asm.modrm(skip(f0, a), skip(f1, b), skip(f2, c));
                AsmRender.bitfield(modrm, dst.Buffer);
                dst.Buffer.Append(" = ");
                dst.Buffer.Append(modrm.Encoded.FormatBits());
                dst.ShowBuffer();
            }
        }

        /// <summary>
        /// ModRM = [Mod:[7:6] | Reg:[5:3] | Rm:[2:0]]
        /// </summary>
        public void CheckModRmBits()
        {
            void emit(ShowLog dst)
            {
                var f0 = BitSeq.bits(n3);
                var f1 = BitSeq.bits(n3);
                var f2 = BitSeq.bits(n2);
                var i=0;

                for(var c=0u; c<f2.Length; c++)
                for(var b=0u; b<f1.Length; b++)
                for(var a=0u; a<f0.Length; a++,i++)
                {
                    var m1 = asm.modrm(skip(f0, a), skip(f1, b), skip(f2, c));
                    var m2 = asm.modrm((byte)i);
                    AsmRender.bitfield(m1, dst.Buffer);
                    dst.Buffer.Append(" ^ ");
                    AsmRender.bitfield(m2, dst.Buffer);
                    dst.Buffer.Append(" = ");
                    dst.Buffer.Append((m1^m2).Encoded.FormatBits());
                    dst.ShowBuffer();
                }
           }

            Show("modrm", FS.Log, emit);
        }


        void CompareBitstrings()
        {
            var buffer = Cells.alloc(n128).Bytes;
            var count = Hex.parse("80C116",buffer);
            var data = slice(buffer,0,count);
            Wf.Row(data.FormatHex());

            // AsmBytes.parse("80C116", out var a);
            // var bsA = AsmBitstrings.bitchars(a).Format();
            // var xA = a.Format();

            // AsmBytes.parse("80C216", out var b);
            // var bsB = AsmBitstrings.bitchars(b).Format();
            // var xB = b.Format();

            // Wf.Row(string.Format("{0,-14} | [{1}]", xA, bsA));
            // Wf.Row(string.Format("{0,-14} | [{1}]", xB, bsB));
        }

        void ProcessStatementIndex()
        {
            var counter = 0u;

            var totalSize = ByteSize.Zero;

            var dst = Db.AppLog("statements.bitstrings", FS.Csv);
            using var receiver = new AsmIndexReceiver(dst);
            var processor = AsmIndexProcessor.create(Wf.EventSink, receiver.Deposit);
            var packs = Wf.ApiPacks();
            var current = packs.Current();
            var archive = ApiPackArchive.create(current.Root);
            var path = archive.StatementIndexPath();
            processor.ProcessFile(path);
        }

        void CheckRowFormat()
        {
            var counter = 0u;

            void Receive(in AsmIndex src)
            {
                counter++;
            }

            var packs = Wf.ApiPacks();
            var current = packs.Current();
            var archive = ApiPackArchive.create(current.Root);
            var processor = AsmIndexProcessor.create(DevNull.BlackHole, Receive);
            var path = archive.StatementIndexPath();
            processor.ProcessFile(path);
        }

        void ListPdbMethods()
        {
            var modules = Wf.AppModules();
            var catalog = Wf.ApiCatalog.PartCatalogs(PartId.Cpu).Single();
            using var source = modules.SymbolSource(catalog.ComponentPath);
            Wf.Row(string.Format("{0} | {1}", source.PePath, source.PdbPath));
            var reader = Wf.PdbReader(source);
            var methods = catalog.Methods;
            var log = Db.AppLog(string.Format("{0}.tokens", catalog.PartId.Format()), FS.Csv);
            var emitting = Wf.EmittingFile(log);
            var counter = 0u;
            using var writer = log.Writer();
            foreach(var info in methods)
            {
                var method = reader.Method(info.MetadataToken);
                if(method)
                {
                    writer.WriteLine(method.Payload.Token.Format());
                    counter++;
                }
            }
            Wf.EmittedFile(emitting, counter);
        }

        void CheckProvidedLiterals()
        {
            var service = Wf.ApiTypes();
            var providers = service.LiteralProviders();
            var count = providers.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var provider = ref skip(providers,i);
                Wf.Row(provider.Name);
                var literals = service.Literals(provider);
                for(var j=0; j<literals.Length; j++)
                {
                    ref readonly var literal = ref skip(literals,j);
                    Wf.Row(literal.Format());
                }
            }
        }

        public void ShowAsmBitfields()
        {
            var modrm = AsmBitfields.modrm();
            var dst = span<char>(128);
            var offset = 0u;
            modrm.Render(ref offset, dst, SegRenderStyle.Intel);
            Wf.Row(slice(dst,0,offset));
        }

        public static Outcome require(string a, string b)
        {
            var success = a.Equals(b);
            var op = success ? "==" : "!=";
            return (success,string.Format("{0} {1} {2}", a, op, b));
        }


        void CheckCodeFactory()
        {
            // 4080C416                add spl,22
            var buffer = span<char>(20);
            var input1 = "40 80 c4 16";
            var input2 = "4080C416";
            HexNumericParser.parse64u(input2, out var input3);

            var code1 = asm.code(input1);
            var code2 = asm.code(input2);
            var code3 = asm.code(input3);

            var text1 = code1.Format();
            var text2 = code2.Format();
            var text3 = code3.Format();

            Wf.Row(code1.Format());
            Wf.Row(code2.Format());
            Wf.Row(code3.Format());

            var check1 = require(text1,text2);
            if(check1.Fail)
                Wf.Error(check1.Message);
            else
                Wf.Status(check1.Message);

            var check2 = require(text1,text3);
            if(check2.Fail)
                Wf.Error(check2.Message);
            else
                Wf.Status(check2.Message);

        }

        public void ParseDisassembly()
        {
            var src = FS.path(@"C:\Dev\awb\.build\dis\avx512f.asm");
            var dir = Db.AppLogDir();
            var parser = Wf.DisassemblyParser();
            parser.ParseDisassembly(src,dir);

        }

        public void RunAsmCases()
        {
            var opcode = AsmCases.PINSRB.OpCodeSig();
        }

        public void Run()
        {
            RunExtractWorkflow();
            //CheckCodeFactory();
            //EmitSymbolicliterals();
            //GenerateInstructionModels();
            //EmitPartSelection();
            //ListPdbMethods();
            //CompareBitstrings();
            //EmitCliMetadata();
            //CaptureParts(PartId.AsmCore);
            //CheckCpuid();
            //CheckRowFormat();
            //RunExtractWorkflow();
            //ProcessStatementIndex();
            //ShowModRmTable();
            //EmitSymbolicliterals();
            //ListVendorManuals("intel", FS.Txt);
            //EmitMethodDefs();
            //EmitFieldDefs();
            //EmitCilOpCodes();
            //LoadHexPacks();
            //CheckCpuid();
            //Wf.AsmCatalogs().EmitAssetCatalog();
            //CheckCpuid();
            // var src = FS.path(@"C:\Dev\tooling\tools\nasm\avx2.obj");
            // ShowCoffHeader(src);
            //ParseDump();
            //StatementRountTrip();
            //TestBitfields();
            //TestRel32();
            //CaptureSelf();
            // var dir = Db.AppLogDir();
            // EmitAsmRows(dir);
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