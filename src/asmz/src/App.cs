//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Diagnostics.Tracing;

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
            var svc = CliEmitter.create(Wf);
            svc.EmitSectionHeaders(WfRuntime.RuntimeArchive(Wf));
        }

        public void EmitApiImageContent()
        {
            Wf.CliEmitter().EmitImageContent();
        }

        public void EmitXedCatalog()
        {
            Wf.IntelXed().EmitCatalog();
        }

        public ReadOnlySpan<string> LoadMnemonics()
            => Wf.IntelXed().MnemonicNames();

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
            Wf.CliEmitter().EmitMetaBlocks();
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
            Require.invariant(opcode == 0xe8, () => $"Expected an opcode of e8h, but instead there is {opcode.FormatAsmHex()}");
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
            Utf8.decode(descriptor.ResBytes, out var content);
            var pipe = Wf.AsmRowPipe();
            using var reader = content.Reader();
            var rows = pipe.LoadCpuIdRows(reader);
            var formatter = rows.RecordFormatter(CpuIdRow.RenderWidths);
            Wf.Row(formatter.FormatHeader());
            core.iter(rows, row => Wf.Row(formatter.Format(row)));
        }

        void EmitAsmAsssetCatalog()
        {
            var catalogs = Wf.AsmCatalogs();
            catalogs.EmitAssets();
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


        void ShowMemory()
        {
            var info = WinMem.basic();
            var formatter = info.Formatter();
            Wf.Row(formatter.Format(info,RecordFormatKind.KeyValuePairs));
        }

        public ApiCodeBlocks LoadApiBlocks()
        {
            return Wf.ApiHex().ReadBlocks();
        }

        void EmitDependencyGraph()
        {
            var svc = Wf.CliEmitter();
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


        void ShowRegOps()
        {
            var reg = asm.reg(RegWidth.W32, RegClass.GP, RegIndex.r2);
            Wf.Row(string.Format("{0}{1}/{2}", reg.Width, reg.Index, reg.RegClass));
        }

        void ShowRegExpr()
        {
            Wf.Row(RegExprCases.expr1());

        }

        public void ShowRexTable()
        {
            var bits = AsmEncoderPrototype.RexPrefixBits();
            using var log = OpenShowLog("rexbits");
            var count = bits.Length;
            for(var i=0; i<count; i++)
                Show(AsmRender.describe(skip(bits,i)), log);
        }

        public void ShowModRmTable()
        {
            var f0 = BitSeq.bits(n3);
            var f1 = BitSeq.bits(n3);
            var f2 = BitSeq.bits(n2);
            var i=0;
            var buffer = span<char>(256);
            for(var c=0u; c<f2.Length; c++)
            for(var b=0u; b<f1.Length; b++)
            for(var a=0u; a<f0.Length; a++,i++)
            {
                buffer.Clear();
                var modrm = asm.modrm(skip(f0, a), skip(f1, b), skip(f2, c));
                var k = AsmRender.bitfield(modrm, buffer);
                seek(buffer, k++) = Chars.Space;
                seek(buffer, k++) = Chars.Eq;
                seek(buffer, k++) = Chars.Space;

                var bits = modrm.Encoded.FormatBits();
                SymbolicTools.copy(bits, ref k, buffer);
                var content = text.format(slice(buffer,0,k));
                Wf.Row(content);
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
        }

        void ProcessStatementIndex()
        {
            var counter = 0u;
            var dst = Db.AppLog("statements.rex", FS.Csv);
            var packs = Wf.ApiPacks();
            var pipe = Wf.AsmIndexPipe();
            var current = packs.Current();
            var archive = ApiPackArchive.create(current.Root);
            var path = archive.StatementIndexPath();
            var flow = Wf.Running(string.Format("Loading statement index from {0}", path.ToUri()));
            var index = pipe.LoadIndex(path);
            var count = index.Length;
            Wf.Ran(flow, string.Format("Loded {0} statement records", index.Length));

            var collection = list<AsmIndex>();
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(index,i);
                if(AsmQuery.HasRexPrefix(s.OpCode))
                {
                    collection.Add(s);
                }
            }

            var sorted = @readonly(collection.ToArray().OrderBy(x => x.Encoded));
            TableEmit(sorted, AsmIndex.RenderWidths, dst);
        }

        public void ShowVendorManuals(string vendor, FS.FileExt ext)
        {
            var docs = Db.VendorManuals();
            var files = docs.VendorDocs(vendor,ext).View;
            var count = files.Length;
            using var log = ShowLog(FS.Md);
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var link = Markdown.item(0, Markdown.link(file), Markdown.ListStyle.Bullet);
                log.Show(link);
            }
        }

        void ProcessManuals()
        {
            const char c = '•';

            Wf.Row(string.Format("{0}:{1:x4}", c, (ushort)c));

            var docs = Db.VendorManuals();
            var files = docs.VendorDocs(VendorNames.Intel, FS.Txt).View;
            var count = files.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                if(file.Size == 0)
                    continue;

                var flow = Wf.Running(string.Format("Processing {0}", file.ToUri()));

                var positions = list<uint>();
                using var map = file.MemoryMap();
                var data = map.View();
                var size = data.Length;
                var unicodes = hashset<byte>();
                for(var j=0u; j<size - 1; j++)
                {
                    ref readonly var b0 = ref skip(data, j);
                    ref readonly var b1 = ref skip(data, j+1);
                    if(SymbolicQuery.bullet(b0,b1))
                    {
                        positions.Add(j);
                    }
                }
                Wf.Ran(flow);
            }
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
            var processor = AsmIndexProcessor.create(Wf, Receive);
            var path = archive.StatementIndexPath();
            processor.ProcessFile(path);
        }

        void EmitPdbMethodInfo(PartId part, FS.FilePath dst)
        {
            var modules = Wf.AppModules();
            var catalog = Wf.ApiCatalog.PartCatalogs(part).Single();
            var assembly = catalog.Component;
            var module = assembly.ManifestModule;
            using var source = modules.SymbolSource(catalog.ComponentPath);
            Wf.Row(string.Format("{0} | {1}", source.PePath, source.PdbPath));
            var pdbReader = Wf.PdbReader(source);
            var clrMethods = catalog.Methods.View;
            var pdbMethods = pdbReader.Methods;
            var emitting = Wf.EmittingFile(dst);
            var counter = 0u;
            using var writer = dst.Writer();
            var count = pdbMethods.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var pdbMethod = ref skip(pdbMethods,i);
                var info = pdbMethod.Describe();
                var docs = info.Documents.View;
                var doc = docs.Length >=1 ? first(docs).Path : FS.FilePath.Empty;
                var token = info.Token;
                var methodBase = Clr.method(module,token);
                var name = methodBase.Name;
                var sig = methodBase is MethodInfo method ? method.DisplaySig().Format() : EmptyString;
                writer.WriteLine(string.Format("{0,-12} | {1,-24} | {2,-68} | {3}", token, name, doc.ToUri(), sig));
                counter++;
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
            SymbolicRender.render(modrm, ref offset, dst, SegRenderStyle.Intel);
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

        void ParseBdDisassembly()
        {
            var src = FS.path(@"C:\Dev\awb\.output\dis\and.bd.asm");
            var dir = Db.AppLogDir();
            var parser = Wf.DbDiasmProcessor();
            parser.ParseDisassembly(src,dir);
        }

        public void ParseDisassembly()
        {
            var src = FS.path(@"C:\Data\zdb\tools\dumpbin\output\xxhsum.exe.disasm.asm");
            var dir = Db.AppLogDir();
            var parser = Wf.DumpBinProcesor();
            var dst = dir + FS.file("xxhsum", FS.Asm);
            parser.TransformFile(src,dst);
        }

        public void RunAsmCases()
        {
            var opcode = AsmCases.PINSRB.OpCodeSig();
        }

        Index<AsciCode> IndexIdentifiers()
        {
            var symbols = Symbols.index<XedModels.IFormType>().View;
            var count = symbols.Length;
            var size = ByteSize.Zero;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(symbols,i);
                var id = s.Kind;
                var name = s.Name;
                size += ((uint)name.Length + 1);
            }

            var buffer = alloc<AsciCode>(size);

            Wf.Status(string.Format("Allocated {0} bytes for {1} symbols", size, count));

            ref var dst = ref first(buffer);
            var k=0;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(symbols,i);
                var name = @span(s.Name);
                for(var j=0; j<name.Length; j++)
                    seek(dst,k++) = (AsciCode)skip(name,j);
                seek(dst,k++) = AsciCode.Null;
            }
            return buffer;
        }

        public void Emit(ReadOnlySpan<AsciCode> src, FS.FilePath dst)
        {
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.AsciWriter();
            var i=0;
            var lines = 0u;
            var count = src.Length;
            while(i++<count)
            {
                ref readonly var c = ref skip(src,i);
                if(c == AsciCode.Null)
                {
                    writer.WriteLine();
                    lines++;
                }
                else
                    writer.Write((char)c);
            }
            Wf.EmittedFile(emitting, lines);
        }

        public void RunAsmToolChain(string name)
        {
            var workspace = Wf.AsmWorkspace();
            var toolchain = Wf.AsmToolchain();
            var spec = workspace.ToolchainSpec(Toolsets.nasm, Toolsets.bddiasm, name);
            toolchain.Run(spec);
        }

        void EmitAsciByteSpan(string content)
        {
            var lookups = Wf.AsciLookups();
            var bytes = Wf.AsciBytes();
            var dst = TextTools.buffer();
            var spec = bytes.DefineAsciBytes("Uppercase", content);
            var data = spec.Format();
            Wf.Row(data);

        }

        void EmitSymbolIndex<E>(Identifier container)
            where E : unmanaged, Enum
        {
            var buffer = TextTools.buffer();
            SpanRes.symrender<E>(container, buffer);
            Wf.Row(buffer.Emit());
        }

        string RenderAsciByteSpan(Identifier name, string data)
        {
            var dst = TextTools.buffer();
            SpanRes.ascirender(8, name, data, dst);
            return dst.Emit();
        }

        void EmitAsciBytes(Identifier name, string content, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var bytespan = RenderAsciByteSpan(name, content);
            Wf.Row(bytespan);
            writer.WriteLine(bytespan);
            Wf.EmittedFile(flow,content.Length);
        }

        public void EmitAsciBytes()
        {
            var name = "Uppercase";
            EmitAsciBytes(name, "ABCDEFGHIJKLMNOPQRSTUVWXYZ", Db.AppLog(name, FS.Cs));
        }

        public void LoadForms()
        {
            var catalog = Wf.StanfordCatalog();
            var rows = catalog.LoadAsset();
            var count = rows.Length;
            var dst = list<string>();
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                AsmParser.sig(row.Instruction, out var sig);
                var form = asm.form(asm.opcode(row.OpCode), sig);
                var spec = string.Format("{0,-32} | {1,-42} | {2,-42}", form.Sig.Mnemonic, form.OpCode, form.Sig);
                dst.Add(spec);
            }

            dst.Sort();
            iter(dst.ViewDeposited(), x => Wf.Row(x));

        }

        void MapChips()
        {
            var xed = Wf.IntelXed();
            var path = xed.EmitChipIsaAsset();
            var outcome = xed.ParseChipMap(path, out var map);
            if(outcome.Fail)
                Wf.Error(outcome.Message);
            else
            {
                var kinds = map.Kinds;
                var chips = map.Chips;
                foreach(var c in chips)
                {
                    var mapped = map[c];
                    var delimited = mapped.Delimit(Chars.Comma).Format();
                    Wf.Row(string.Format("{0}:{1}", c, delimited));
                }
            }
        }

        void Dispatch(string cmd)
        {
            var commands = Wf.GlobalCommands();
            var result = commands.Dispatch(cmd);
            if(result.Fail)
                Wf.Error(result.Message);
        }

        void Dispatch()
        {
            var args = Wf.Args;
            iter(args, arg => Dispatch(arg));
        }

        void ShowRegNames()
        {
            var regs = AsmRegs.list(AsmDsl.GP);
            iter(regs, reg => Wf.Row(reg));
            var bytespan = SpanRes.specify("GpRegNames", recover<RegOp,byte>(regs).ToArray());
            Wf.Row(bytespan.Format());
        }

        static void render(EventWrittenEventArgs src, ITextBuffer dst)
        {
            dst.AppendLine(src.EventName);
            dst.AppendLine(RP.PageBreak80);
            var count = src.Payload.Count;
            for (int i = 0; i<count; i++)
            {
                var name = string.Format("{0,-32}:",src.PayloadNames[i]);
                var payload = string.Format("{0}",src.Payload[i]);
                var message = string.Concat(name,payload);
                dst.AppendLine(message);
            }

        }

        static async void emit(EventWrittenEventArgs src, StreamWriter dst)
        {
            var buffer = TextTools.buffer();
            render(src,buffer);
            await dst.WriteLineAsync(buffer.Emit());
        }

        void Capture()
        {
            using var dst = Db.AppLog("clr-events", FS.Log).Writer();
            void receive(in EventWrittenEventArgs src)
            {
                emit(src,dst);
            }

            using var listener = ClrEventListener.create(receive);

            var settings = ApiExtractSettings.init(Db.CapturePackRoot());
            Wf.ApiExtractWorkflow().Run(settings);
        }

        void movzx(RegOp dst, RegOp src, Span<char> buffer)
        {

        }

        void GetMethodInfo()
        {
            var path = Parts.Math.Assembly.Location;
            var catalog = Wf.ApiCatalog.PartCatalogs(PartId.Math).Single();
            var methods = catalog.Methods;
            SOS.SymbolReader.InitializeSymbolReader("");
            foreach(var method in methods)
            {
                if(SOS.SymbolReader.GetInfoForMethod(path, method.MetadataToken, out var info))
                {
                    var size = info.size;
                    Wf.Row($"{method.Name} | {size}");
                }
            }
        }

        void CheckStringTables()
        {
            var input = @readonly(new string[]{"one","two","three", "four", "five", "six", "seven", "eight", "nine","ten"});
            var table = StringTables.create<byte>("Counts",input);
            var count = Require.equal(input.Length, (int)table.EntryCount);
            for(var i=0; i<count; i++)
            {
                var data = table[i];
                ref readonly var s0 = ref skip(input,i);
                var s1 = new string(data);
                Require.equal(s0,s1);
            }

            Wf.Row(table.Format());
        }

        public void Run()
        {
            Dispatch();

            //CheckStringTables();
            //EmitSymbolIndex<AsmSigTokens.Regs>("SigRegs")
            // var part = PartId.Math;
            // var log = Db.AppLog(string.Format("{0}.pdbinfo", part.Format()), FS.Csv);
            // EmitPdbMethodInfo(part,log);

            //RunAsmToolChain("and");
            //ParseBdDisassembly();
            //Wf.GlobalCommands().ShowCommands();
            //ShowOps();
            //ParseDisassembly();
            //CheckDocProcessor();
            //CheckAsciByteSpans();
            //Wf.GlobalCommands().CaptureV2(CmdArgs.Empty);
            //CaptureParts(PartId.AsmLang, PartId.AsmCases, PartId.AsmCore);
            //EmitXedCatalog();
            //CheckAsciLookups();
            // var xpr = expression(AsmMnemonics.AND, AsmOp.al, AsmOp.imm8(0x16));
            // Wf.Row(xpr);
            //GenerateInstructionModels();
            //iteri(LoadMnemonics(), (i,m) => Wf.Row(string.Format("{0:D3} {1}", i, m)));
            //EmitXedCatalog();
            //CheckTools();
            //RunExtractWorkflow();
            //ProcessStatementIndex();
            //ParseDisassembly();
            //CheckCodeFactory();
            //EmitSymbolicliterals();
            //EmitPartSelection();
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
                var parts = ApiRuntimeLoader.parts(controller(), array<string>());
                using var wf = WfAppLoader.load(parts);
                var app = App.create(wf.WithSource(Rng.@default()));
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