//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.IO;
    using Z0.Tools;

    using static Root;
    using static core;
    using static Typed;

    public class Tests : AppService<Tests>
    {
        public void ProcessMsDocs()
        {
            var src = FS.dir(@"J:\docs\msdocs-sdk-api\sdk-api-src\content\dbghelp");
            var dst = Db.AppLog("dbghelp", FS.ext("yml"));
            var tool = Wf.MsDocs();
            tool.Process(src,dst);
        }

        void CheckMetadata(PartId part)
        {
            var tool = Wf.Roslyn();
            if(Wf.ApiCatalog.FindComponent(part, out var assembly))
            {
                var name = string.Format("z0.{0}.compilation", part.Format());
                var metadata = Cli.metaref(assembly);
                var comp = tool.Compilation(name, metadata);
                var symbol = comp.GetAssemblySymbol(metadata);
                var gns = symbol.GlobalNamespace;
                var types = gns.GetTypes();
                root.iter(types, show);
            }

            void show(CodeSymbolModels.TypeSymbol src)
            {
                Wf.Row(src);
                root.iter(src.GetMembers(), m => Wf.Row(m));
            }
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

        void RenderJmp()
        {
            var code = AsmMnemonicCode.JMP;
            var pipe = Wf.AsmRowPipe();
            var dst = Db.AppLog(code.ToString(), FS.Asm);
            pipe.RenderRows(code, dst);
        }

        void CheckSettingsParser()
        {
            var a = "A:603";
            DataParser.parse(a, out Setting<ushort> _a);
            Wf.Row(_a);


            var b = "B:true";
            DataParser.parse(b, out Setting<bool> _b);
            Wf.Row(_b);
        }

        const byte FieldCount = 2;

        public static ReadOnlySpan<byte> SlotWidths
            => new byte[FieldCount]{8,32};

        public static byte labels(Span<string> dst)
        {
            var j=z8;
            seek(dst,j++) = "Index";
            seek(dst,j++) = "IClass";
            return j;
        }

        public static string pattern()
        {
            var sbuffer = span<char>(1024);
            return text.format(slice(sbuffer, 0, text.slot(SlotWidths, Chars.Pipe, sbuffer)));
        }

        public static Index<string> headers()
        {
            var buffer = alloc<string>(FieldCount);
            labels(buffer);
            return buffer;
        }

        void CollectMemStats()
        {
            var dst = Db.ProcessContextRoot();
            var pipe = Wf.ProcessContextPipe();
            var ts = root.timestamp();
            var flags = ProcessContextFlag.Detail | ProcessContextFlag.Summary | ProcessContextFlag.Hashes;
            var prejit = pipe.Emit(dst, ts, "prejit", flags);
            var members = Wf.ApiJit().JitCatalog();
            var postjit = pipe.Emit(dst, ts, "postjit", flags);
        }

        static ReadOnlySpan<byte> x7ffaa76f0ae0
            => new byte[32]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xd1,0x48,0xb9,0x50,0x0f,0x24,0xa5,0xfa,0x7f,0x00,0x00,0x48,0xb8,0x30,0xdd,0x99,0xa6,0xfa,0x7f,0x00,0x00,0x48,0xff,0xe0,0};

        void CheckV()
        {
            const byte count = 32;
            var mask = cpu.vindices(cpu.vload(w256,x7ffaa76f0ae0), 0x48);
            var bits = recover<bit>(Cells.alloc(w256).Bytes);
            var buffer = Cells.alloc(w256).Bytes;
            BitPack.unpack1x32(mask, bits);
            var j=z8;
            for(byte i=0; i<count; i++)
            {
                if(skip(bits,i))
                    seek(buffer,j++) = i;
            }

            var indices = slice(buffer,0,j);


            // Span<byte> dst = stackalloc byte[count];
            // for(byte i=0; i<count; i++)
            //     seek(dst,i) = bit.test(indices,i) ? i : z8;

            Wf.Row(indices.FormatList());
        }


        void RenderMovzx()
        {
            static string semantic(in AsmDetailRow src)
            {
                return EmptyString;
            }

            var pipe = Wf.AsmRowPipe();
            var code = AsmMnemonicCode.MOVZX;
            var rows = @readonly(pipe.LoadDetails(code).OrderBy(x => x.Statement).Array());
            var count = rows.Length;
            var dst = Db.AppLog(code.ToString(),FS.Asm);
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                writer.WriteLine(pipe.FormatRow(row, semantic));
            }
        }


        public void DeriveMsil()
        {
            var pipe = Wf.MsilPipe();
            var files = pipe.MetadataFiles().View;
            var count = files.Length;
            for(var i=0; i<count; i++)
            {
                var src = skip(files,i);
                var dst = Db.AppLogDir() + src.FileName.ChangeExtension(FS.Il);
                var records = pipe.LoadMetadata(src);
                pipe.EmitCode(records, dst);
            }
        }

        void CreateSymbolHeap()
        {
            var symbolic = Wf.Symbolism();
            var literals = symbolic.DiscoverLiterals();
            Wf.Status($"Creating heap for {literals.Length} literals");
            var heap = SymHeaps.specify(literals);
            var count = heap.SymbolCount;
            var dst = Db.AppLog("heap", FS.Csv);
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            for(ushort i=0; i<count; i++)
            {
                var expr = heap.Expression(i);
                var id = heap.Identifier(i);
                writer.WriteLine(string.Format("{0:D6} | {1,-32} | {2}", i, id, expr));
            }
            Wf.EmittedFile(emitting,count);
        }

        public void CollectEntryPoints()
        {
            var catalog = Wf.ApiCatalog;
            var jit = Wf.ApiJit();
            var members = jit.JitCatalog(catalog);
            var flow = Wf.Running("Creating method table");
            var table = MethodEntryPoints.create(root.controller().Id(), members);
            Wf.Ran(flow, $"Created method table with {table.View.Length} entries");
        }

        public void CheckAsciTables()
        {
            var buffer = span<char>(128);
            Wf.Row(Asci.format(AsciTables.letters(LowerCase).Codes, buffer));
            buffer.Clear();
            Wf.Row(Asci.format(AsciTables.letters(UpperCase).Codes, buffer));
            buffer.Clear();
            Wf.Row(Asci.format(AsciTables.digits().Codes, buffer));
            buffer.Clear();
        }

        void CheckMullo(IDomainSource Source)
        {
            var @class = ApiClassKind.MulLo;
            var count = 12;
            var left = Source.Array<uint>(count,100,200);
            var right = Source.Array<uint>(count,100,200);
            var buffer = alloc<uint>(count);
            ref readonly var x = ref first(left);
            ref readonly var y = ref first(right);
            ref var dst = ref first(buffer);
            var results = alloc<TextBlock>(count);
            var output = alloc<uint>(count);
            ref var expected = ref first(output);
            ref var calls = ref first(results);
            for(var i=0; i<count; i++)
            {
                ref readonly var a = ref skip(x,i);
                ref readonly var b = ref skip(y,i);
                ref var actual = ref seek(dst,i);
                ref var expect = ref seek(expected,i);
                actual = cpu.mullo(a,b);
                expect = math.mul(a,b);
                //seek(calls, i) = ApiCalls.result(@class,a,b,actual);
            }

            for(var i=0; i<count; i++)
            {
                ref readonly var call = ref skip(calls,i);
                ref readonly var expect = ref skip(expected,i);
                Wf.Row(call.Format() + " ?=? " + expect.ToString());
            }
        }

        public void CheckMemoryLookup()
        {
            var capacity = Pow2.T15;
            var blocks = Wf.ApiHex().ReadBlocks().View;
            var count = blocks.Length;

            if(count > capacity)
                Wf.Error("Not enout capacity");

            var distinct = blocks.Map(b => b.BaseAddress).ToArray().ToHashSet();
            if(distinct.Count != count)
            {
                Wf.Warn(string.Format("There should be {0} distinct base addresses and yet there are {1}", count, distinct.Count));
            }

            var symbols = MemorySymbols.alloc(capacity);

            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                symbols.Deposit(block.BaseAddress, block.Size, block.OpUri.Format());
            }

            Wf.Status("Creating lookup");

            var lookup = symbols.ToLookup();
            var entries = slice(lookup.Symbols, 0,symbols.EntryCount);
            var dst = Db.AppLog("addresses.lookup", FS.Csv);
            var emitting = Wf.EmittingTable<MemorySymbol>(dst);
            var emitted = Tables.emit(entries, dst);
            Wf.EmittedTable(emitting,emitted);
            var found = 0;

            var hashes = entries.Map(x => x.HashCode).ToArray().ToHashSet();
            if(hashes.Count != count)
            {
                Wf.Warn(string.Format("There should be {0} distinct hash codes and yet there are {1}", count, hashes.Count));
            }

            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                if(lookup.FindIndex(block.BaseAddress, out var index))
                {
                    found++;
                }
            }

            Wf.Status(string.Format("Blocks: {0}", count));
            Wf.Status(string.Format("Found: {0}", found));
        }

        ToolScript<XedCase> CreateXedCase(AsmOcPrototype id)
        {
            var tool = Wf.XedTool();
            var dir = Db.CaseDir("asm.assembled", id);
            var dst = dir + FS.file(string.Format("{0}.{1}", id, tool.Id), FS.Cmd);
            var @case = tool.DefineCase(id.ToString(), dir);
            return tool.CreateScript(@case, dst);
        }

        public void CheckClrKeys()
        {
            var types = Wf.ApiCatalog.Components.Storage.Types();
            var unique = hashset<Type>();
            var count = unique.Include(types).Where(x => x).Count();
            Wf.Row($"{types.Length} ?=? {count}");
            var fields = Wf.ApiCatalog.Components.Storage.DeclaredStaticFields();
            iter(fields, f => Wf.Row(f.Name + ": " + f.FieldType.Name));
        }

        public bool parse32u(ReadOnlySpan<char> input, out uint dst)
        {
            const byte MaxDigitCount = 8;
            var storage = 0ul;
            var output = recover<uint4>(bytes(storage));
            dst = 0;
            var count = core.min(input.Length, MaxDigitCount);
            var j=0;
            var outcome = true;
            for(var i=count-1; i>=0; i--)
            {
                ref readonly var c = ref skip(input,i);
                if(DigitParser.digit(@base16, c, out var d))
                    seek(output, j++) = d;
                else
                    return false;
            }

            for(var k=0; k<j; k++)
                dst |= ((uint)skip(output, k) << k*4);
            return true;
        }

        static Index<ApiHostUri> NestedHosts(Type src)
        {
            var dst = list<ApiHostUri>();
            var nested = @readonly(src.GetNestedTypes());
            var count = nested.Length;
            for(var i=0; i<count; i++)
            {
                var candidate = skip(nested,i);
                var uri = candidate.ApiHostUri();
                if(uri.IsNonEmpty)
                    dst.Add(uri);
            }
            return dst.ToArray();
        }

        void Produce()
        {
            var producer = Wf.AsmStatementProducer();
            var hosts = NestedHosts(typeof(Prototypes));
            var count = producer.Produce(Toolsets.nasm, hosts);
        }

        void ShowRegKinds(RegKind src, ShowLog dst)
        {
            if(src.IsNonZero())
                dst.Show(src);
        }


        void CheckBitSpans()
        {
            var options = BitFormat.Default.WithBlockWidth(4);
            var v1 = VMask.veven<byte>(w128,n2,n1);
            var b1 = v1.ToBitSpan();
            Wf.Row(b1.Format(options));
        }

        void CheckBitView()
        {
            var m1 = BitMasks.odd<ulong>();
            var bits = BitView.create(m1);
            Wf.Row($"1: {bits.View(w1, 0)}");
            Wf.Row($"2: {bits.View(w2, 0)}");
            Wf.Row($"3: {bits.View(w3, 0)}");
            Wf.Row($"4: {bits.View(w4, 0)}");
            Wf.Row($"5: {bits.View(w5, 0)}");
            Wf.Row($"6: {bits.View(w6, 0)}");
            Wf.Row($"7: {bits.View(w7, 0)}");
            Wf.Row($"8: {bits.View(w8, 0)}");
        }

        void ShowOptions()
        {
            const string @case = @"llvm-pdbutil dump --streams J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.streams.log";
            var result = CmdParser.parse(@case);
            if(result.Succeeded)
            {
                var value = result.Value;
                Wf.Status(value.Format());
            }
            else
                Wf.Error(result.Message);
        }

        void ShowCases2()
        {
            const string LogName = "CoreCLR_Windows_NT__x64__Debug.log";
            var descriptors = Resources.descriptors(Wf.Controller, LogName);
            if(descriptors.ResourceCount == 1)
            {
                var data = descriptors[0].Utf8();
                using var reader = new StringReader(data.ToString());
                var line = reader.ReadLine();
                while(line != null)
                {
                    term.print(line);
                    line = reader.ReadLine();
                }
            }
        }

        void ShowLetters()
        {
            using var flow = Wf.Running();
            var resources = Resources.strings(typeof(AsciCharText));
            var rows = Resources.rows(resources).View;
            var count = resources.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var res = ref skip(resources,i);
                ref readonly var row = ref skip(rows,i);
                Wf.Row(row);
            }
        }

        void ShowDependencies()
        {
            ShowDependencies(Wf.Controller);
        }

        void ShowDependencies(Assembly src)
        {
            var deps = JsonDepsLoader.from(src);
            var libs = deps.Libs();
            var rtlibs = deps.RuntimeLibs();
            var options = deps.Options();
            var target = deps.Target();
            var graph = deps.Graph;
            Wf.Row(string.Format("Target: {0} {1} {2}", target.Framework, target.Runtime, target.RuntimeSignature));
            root.iter(libs, lib => Wf.Row(lib.Name));
            var buffer = text.buffer();
            root.iter(rtlibs, lib => lib.Render(buffer));
            Wf.Row(buffer.Emit());
        }

        void CalcAddress()
        {
            // ; BaseAddress = 7ffc56862280h
            // 0025h call 7ffc52e94420h                      ; CALL rel32                       | E8 cd                            | 5   | e8 76 21 63 fc
            // Expected: 7ffc56862310h
            const ulong FunctionBase = 0x7ffc56862280;
            const ushort InstructionOffset = 0x25;
            const byte InstructionSize = 0x5;
            const ulong Displacement = 0xfc632176;
            var instruction = array<byte>(0xe8, 0x76, 0x21, 0x63, 0xfc);
            MemoryAddress Encoded =  0x7ffc52e94420;
            MemoryAddress nextIp = asm.nextip(FunctionBase,  InstructionOffset, InstructionSize);
            MemoryAddress target = nextIp + Displacement;
        }

        void CheckRel32()
        {
            const ulong FunctionBase = 0x7ffc56862280;
            const ushort InstructionOffset = 0x25;
            const uint Displacement = 0xfc632176;

            MemoryAddress client = FunctionBase + InstructionOffset;
            var call = asm.call(client,Displacement);
            Wf.Status(AsmRender.format(call));
        }


        static void TestCmdLine(params string[] args)
        {
            var cmd1 = new CmdLine("cmd /c dir j:\\");
            var cmd2 = new CmdLine("llvm-mc --help");
            using var wf = WfAppLoader.load(args).WithSource(Rng.@default());
            var process = ToolCmd.run(cmd2).Wait();
            var output = process.Output;
            wf.Status(output);
        }

        void CheckFlags()
        {
            var flags = Clr.@enum<MinidumpRecords.MinidumpType>();
            var summary = flags.Describe();
            var count = summary.FieldCount;
            var details = summary.LiteralDetails;

            if(count == 0)
                Wf.Error("No flags");

            for(var i=0; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                var description = string.Format("{0,-12} | {1,-48} | {2}", detail.Position, detail.Name, detail.ScalarValue.FormatHex());
                Wf.Row(description);
            }
        }

        [Op]
        public static CmdTypeInfo[] cmdtypes(IWfRuntime wf)
            => wf.Components.Types().Tagged<CmdAttribute>().Select(Cmd.cmdtype).ToArray();

        public void ShowCommands()
        {
            var models = @readonly(cmdtypes(Wf));
            var count = models.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var model = ref skip(models,i);
                Wf.Row(string.Format("{0,-3} {1}", i, model.DataType.Name));
            }
        }

        void EmitMsil()
        {
            var pipe = Wf.MsilPipe();
            var members = Wf.ApiCatalog.ApiHosts.Where(h => h.HostType == typeof(math)).Single().Methods;
            var buffer = text.buffer();
            var methods = ApiCode.msil(members);
            root.iter(methods, m => pipe.RenderCode(m,buffer));
            using var writer = Db.AppDataFile(FS.file(nameof(math), FS.Il)).Writer();
            writer.Write(buffer.Emit());
        }

        static string FormatAttributes(IXmlElement src)
            => src.Attributes.Select(x => string.Format("{0}={1}",x.Name, x.Value)).Delimit(Chars.Comma).Format();

        void ConvertPdbXml()
        {
            var dir = Db.ToolOutDir(Toolsets.pdb2xml);
            var file = PartId.Math.Component(FS.Pdb, FS.Xml);
            var srcPath = dir + file;
            var buffer = text.buffer();

            var dstPath = Db.AppDataFile(file.WithExtension(FS.Log));
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
            using var xml = XmlSource.create(srcPath);
            xml.Read(handlers);
            Wf.EmittedFile(flow,1);
        }

        public void Display(CmdLine cmd)
        {
            Wf.Status(cmd.Format());
        }

        public void DisplayConfig()
        {
            Wf.Status(Wf.Settings.FormatList());
            Wf.Status(Db.Root);
        }

        public void RunPipes()
        {
            using var flow = Wf.Running();
            var data = Wf.Polysource.Span<ushort>(2400);

            // var input = Pipes.pipe<ushort>();
            // var incount = Pipes.flow(data, input);
            // var output = Pipes.pipe<ushort>();
            // var outcount = Pipes.flow(input,output);

            //Wf.Ran(flow, $"Ran {incount} -> {outcount} values through pipe");
        }

        MemoryAddress GetKernel32Proc(string name = "CreateDirectoryA")
        {
            var flow = Wf.Running();
            using var kernel = NativeModules.kernel32();
            Wf.Row(kernel);

            var f = NativeModules.func<OS.Delegates.GetProcAddress>(kernel, nameof(OS.Delegates.GetProcAddress));
            Wf.Row(f);

            var address = (MemoryAddress)f.Invoke(kernel, name);
            Wf.Row(address);

            Wf.Ran(flow);

            return address;
        }

        public static ReadOnlySpan<byte> TestCase01
            => new byte[44]{0x0f,0x1f,0x44,0x00,0x00,0x49,0xb8,0x68,0xd5,0x9e,0x18,0x36,0x02,0x00,0x00,0x4d,0x8b,0x00,0x48,0xba,0x28,0xd5,0x9e,0x18,0x36,0x02,0x00,0x00,0x48,0x8b,0x12,0x48,0xb8,0x90,0x2c,0x8b,0x64,0xfe,0x7f,0x00,0x00,0x48,0xff,0xe0};

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
            var t0 = ApiSigBuilder.type("uint");
            var t1 = ApiSigBuilder.type("uint");
            var t2 = ApiSigBuilder.type("bool");
            var op0 = ApiSigBuilder.operand("a", t0);
            var op1 = ApiSigBuilder.operand("b", t1);
            var r = ApiSigBuilder.@return(t2);
            Wf.Row(ApiSigBuilder.operation("equals", r, op0, op1));
        }

        ReadOnlySpan<byte> Input => new byte[]{0x44, 0x01, 0x58,0x04};

        const string InputBits = "0100 0100 0000 0001 0101 1000 0000 0100";

        public void CheckBitstrings()
        {
            CharBlocks.alloc(n128, out var block);
            var count = AsmBitstrings.render(Input, block.Data);
            var chars = slice(block.Data,0,count);
            var bits = text.format(chars);
            Wf.Row(InputBits);
            Wf.Row(bits);

        }

        void GetMethodInfo()
        {
            var path = Parts.Math.Assembly.Location;
            var catalog = Wf.ApiCatalog.PartCatalogs(PartId.Math).Single();
            var methods = catalog.Methods;
            var method = methods.First;
            var token = method.MetadataToken;
            var result = SOS.SymbolReader.InitializeSymbolReader("");
            if(SOS.SymbolReader.GetInfoForMethod(path, token, out var info))
            {
                var size = info.size;
                Wf.Row($"{method.Name} | {size}");
            }
        }


        void CheckEntryPoints()
        {
            const ulong Target = 0x7ffa77aa1460;

            var points = JmpStubSynthetics.create(Wf);
            if(points.Create<ulong>(0))
            {
                var encoded = points.EncodeDispatch(0,Target);
                Wf.Status(encoded.FormatHexData());
            }
        }

        public Index<ApiCodeBlock> Jumpers()
        {
            var jumpers = root.list<ApiCodeBlock>();
            var buffer = root.list<ApiCodeBlock>();
            var hex = Wf.ApiHex();
            var files = hex.Files().View;
            var flow = Wf.Running(string.Format("Processing {0} hex files", files.Length));
            for(var i=0; i<files.Length; i++)
            {
                var file = skip(files,i);
                var reading = Wf.Running(string.Format("Processing {0}", file.ToUri()));
                buffer.Clear();
                var count = hex.ReadBlocks(file, buffer);
                var k = 0;
                for(var j=0; j<count; j++)
                {
                    var block = buffer[j];
                    if(JmpRel32.test(block.Encoded))
                    {
                        jumpers.Add(block);
                        k++;
                    }
                }
                Wf.Ran(reading, string.Format("Collected {0} jump stub candidates from {1}", k, file.ToUri()));

            }
            Wf.Ran(flow, string.Format("Collected {0} jump stub candidates", jumpers.Count));
            return jumpers.ToArray();
        }

        void ShowThumprintCatalog()
        {
            var pipe = Wf.AsmThumbprints();
            pipe.ShowThumprintCatalog();
        }

        void ShowXedInstructions()
        {
            var pipe = Wf.IntelXed();
            var records = pipe.LoadFormSummaries().View;
            var count = records.Length;
            if(count !=0 )
            {
                using var log = ShowLog("xed-instructions", FS.Csv);
                for(var i=0; i<count; i++)
                {
                    ref readonly var record = ref skip(records,i);
                    var id = record.Form;
                    var components = id.Split(Chars.Underscore).Delimit(Chars.Pipe, -16);
                    log.Show(string.Format("{0,-64} | {1}", id, components));
                }
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

       void EmitPartSymbols()
        {
            var svc = Wf.Symbolism();
            svc.EmitLiterals<PartId>();
        }

        public void ParseXedForms()
        {
            var parser = XedSummaryParser.create(Wf.EventSink);
            var parsed = parser.ParseSummaries();
            Wf.Status($"Parsed {parsed.Length} summaries");
            Wf.IntelXed().EmitFormSummaries(parsed);
        }

        void FilterApiBlocks()
        {
            var blocks = Wf.ApiCatalogs().Correlate();
            var f1 = CodeBlocks.filter(blocks,ApiClassKind.And);
            root.iter(f1,f => Wf.Row(f.Uri));
        }

        void CheckApiHexArchive()
        {
            var part = PartId.Math;
            Wf.ApiCatalog.FindComponent(part, out var component);
            var catalog = ApiRuntimeLoader.catalog(component);

            void accept(in ApiCodeBlock block)
            {
                if(catalog.Host(block.OpUri.Host, out var host))
                {
                    Wf.Row(string.Format("{0} | {1}", host.HostUri, block.OpUri));
                }
            }

            var archive = Wf.ApiHexArchive();
            archive.CodeBlocks(part, accept);
        }


        public void ListEnvVars()
        {
            var src = Resources.strings<uint>(typeof(EnvVarNames)).View;
            for(var i=0; i<src.Length; i++)
                Wf.Status(skip(src,i).Format());
        }

    }
}