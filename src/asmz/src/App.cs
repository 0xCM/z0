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

    using Z0.Tools;

    using static Root;
    using static core;
    using static Toolspace;

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
            var runner = Wf.ScriptRunner();
            runner.RunToolCmd(clang, "codegen");
            runner.RunToolCmd(clang, "parse");
            runner.RunToolPs(clang, "fast-math");
            runner.RunToolPs(llvm_ml, "lex");
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

        string CreateXedCase(string opcode)
        {
            var tool = Wf.XedTool();
            var dir = Db.CaseDir("asm.assembled", opcode);
            var dst = dir + FS.file(string.Format("{0}.{1}", opcode, tool.Id), FS.Cmd);
            var @case = tool.DefineCase(opcode.ToString(), dir);
            var content = tool.CreateScript(@case);
            return content;
            //return new ToolScript(Toolspace.xed, opcode, ;
        }

        public void EmitApiImageContent()
        {
            Wf.CliEmitter().EmitImageContent();
        }

        public ReadOnlySpan<string> LoadMnemonics()
            => Wf.IntelXed().ClassNames();

        void EmitRuntimeMembers()
        {
            var service = ApiRuntime.create(Wf);
            var members = service.EmitRuntimeIndex();
        }

        public void ProccessCultFiles()
        {
            Wf.CultProcessor().Process();
        }

        void JitApiCatalog()
        {
            Wf.ApiJit().JitCatalog();
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
            var dst = Db.AppLogRoot() + FS.folder("capture");
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
        static Address32 rel32(BinaryCode src, byte skip)
            => core.u32(slice(src.View, skip));

        void TestRel32()
        {
            var @base = 0x7fff328f9430;
            var ip = @base + 0x36;
            var sz = 5;
            var nip = ip + sz;
            var code = new byte[]{0xe8, 0x25, 0xe4, 0xb2, 0x5f};
            const string Statement = "0036h call 7fff92427890h; e8 25 e4 b2 5f";
            var dx = rel32(code,1);
            Wf.Row(dx);
        }

        public void ParseDump()
        {
            using var clrmd = ClrMdSvc.create(Wf);
            clrmd.ParseDump();
        }

        void EmitAsmAsssetCatalog()
        {
            var catalogs = Wf.Assets();
            catalogs.EmitIndex(AsmData.Assets, Db.Root);
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
            writer.WriteLine(string.Format("label={0}", RP.enquote("Assembly Dependencies")));
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

        ReadOnlySpan<ApiHostRes> EmitResPack()
        {
            var blocks = LoadApiBlocks();
            var dst = Db.AppLogDir("Respack");
            return Wf.ResPackEmitter().Emit(blocks.View,dst);
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

        void EmitPdbDocInfo(PartId part)
        {
            var dst =Db.AppLog(string.Format("{0}.pdbinfo", part.Format()), FS.Csv);
            var modules = Wf.AppModules();
            var catalog = Wf.ApiCatalog.PartCatalogs(part).Single();
            var assembly = catalog.Component;
            var module = assembly.ManifestModule;
            using var source = modules.SymbolSource(FS.path(catalog.ComponentPath));
            Wf.Row(string.Format("{0} | {1}", source.PePath, source.PdbPath));

            var pdbReader = Wf.PdbReader(source);
            //var clrMethods = catalog.Methods.View;
            //var pdbMethods = pdbReader.Methods;
            var emitting = Wf.EmittingFile(dst);
            var counter = 0u;
            using var writer = dst.Writer();
            var docs = pdbReader.Documents;
            var count = docs.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var doc = ref skip(docs,i);
                var row = string.Format("{0}", doc.Path.ToUri());
                writer.WriteLine(row);
            }
            //var count = pdbMethods.Length;
            // for(var i=0; i<count; i++)
            // {
            //     ref readonly var pdbMethod = ref skip(pdbMethods,i);
            //     var info = pdbMethod.Describe();
            //     var docs = info.Documents.View;
            //     var doc = docs.Length >=1 ? first(docs).Path : FS.FilePath.Empty;
            //     var token = info.Token;
            //     var methodBase = Clr.method(module,token);
            //     var name = methodBase.Name;
            //     var sig = methodBase is MethodInfo method ? method.DisplaySig().Format() : EmptyString;
            //     writer.WriteLine(string.Format("{0,-12} | {1,-24} | {2,-68} | {3}", token, name, doc.ToUri(), sig));
            //     counter++;
            // }

            Wf.EmittedFile(emitting, counter);
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
            var src = FS.path(@"C:\Data\zdb\tools\dumpbin\output\xxhsum.exe.disasm.asm");
            var dir = Db.AppLogRoot();
            var parser = Wf.DumpBinProcesor();
            var dst = dir + FS.file("xxhsum", FS.Asm);
            parser.ParseDisassembly(src,dst);
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

        public void LoadStanfordForms()
        {
            var catalog = Wf.StanfordCatalog();
            var rows = catalog.LoadAsset();
            var count = rows.Length;
            var dst = list<string>();
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                AsmParser.sigxpr(row.Instruction, out var sig);
                var form = new AsmFormExpr(asm.ocexpr(row.OpCode), sig);
                var spec = string.Format("{0,-32} | {1,-42} | {2,-42}", form.Sig.Mnemonic, form.OpCode, form.Sig);
                dst.Add(spec);
            }

            dst.Sort();
            iter(dst.ViewDeposited(), x => Wf.Row(x));
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

            var settings = ApiExtractSettings.init(Db.CapturePackRoot(), now());
            Wf.ApiExtractWorkflow().Run(settings);
        }

        void ReadSymbols()
        {
            var reader = SOS.SymbolReader.create();
            reader.ShowSymbolStore(data => Wf.Row(data));
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

        public void Run()
        {
            Dispatch();
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