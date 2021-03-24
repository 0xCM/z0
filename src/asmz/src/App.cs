//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;

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
                    Name = item.SimpleName,
                    Location = ClrAssemblies.location(item),
                    PdbPath = ClrAssemblies.pdbpath(item, out var _),
                    XmlDocPath = ClrAssemblies.xmlpath(item, out var _),
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

        void CheckSigParser()
        {
            var success = root.hashset<string>();
            var fail = root.hashset<string>();

            void parse(AsmApiStatement src)
            {
                var expr = src.Sig;
                var operands = src.Sig.Operands;
                var exprText = expr.Format();
                if(exprText.Contains(Chars.FSlash))
                {
                    var parts = exprText.SplitClean(Chars.FSlash);
                    var count = parts.Length;
                    if(count != 2)
                    {
                        Wf.Warn($"Unexpected composite {exprText}");
                    }
                    else
                    {
                        var opformat = $"{parts[0]}/{parts[1]}";
                        if(success.Add(opformat))
                        {
                            Wf.Status($"Parse succeeded for {exprText} with composite operands {opformat}");
                        }
                    }
                }
            }

            Wf.ApiStatementPipe().LoadStatements(parse);

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

        void ShowSymbols()
        {
            var components = Wf.Api.PartComponents.Storage;
            var sources = components.Enums().Tagged<SymbolSourceAttribute>();
            using var log = OpenShowLog("symbols", FS.Extensions.Csv);
            foreach(var source in sources)
            {
                var symbols = SymbolStores.table(source);
                foreach(var token in symbols.Tokens)
                {
                    Show(token.Format(), log);
                }
            }
        }


        HashSet<AsmFormExpr> Forms;

        AsmSigs Sigs;

        public static MsgPattern<T> Dispatching<T>()
            where T : struct, ICmd<T> => "Dispatching {0}";

        public static MsgPattern<CmdId> Dispatching() => "Dispatching {0}";

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
                Tables.parse(skip(parts,0), out dst.BaseAddress);
                Tables.parse(skip(parts,1), out dst.Uri);
                Tables.parse(skip(parts,2), out dst.CilCode);
                return true;
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
            Wf.EmittedFile(flow,1);
        }

        void EmitMsil()
        {
            var pipe = Wf.IlPipe();
            var members = Wf.Api.ApiHosts.Where(h => h.HostType == typeof(math)).Single().Methods;
            var buffer = text.buffer();
            var methods = MsilServices.methods(members);
            root.iter(methods, m => pipe.Render(m,buffer));
            using var writer = Db.AppDataFile(FS.file(nameof(math), FS.Extensions.Il)).Writer();
            writer.Write(buffer.Emit());
            //root.iter(methods, m => pipe.Render(m,buffer));
        }

        void EmitStatementCases()
        {
            var cases = root.dict<AsmHexCode,AsmStatementCase>();

            void Collect(AsmStatementDetail src)
            {
                var encoded = src.Encoded;
                if(!cases.ContainsKey(encoded))
                {
                    var dst = new AsmStatementCase();
                    dst.Encoded = encoded;
                    dst.Expression = src.Expression.Format();
                    dst.OpCode = src.OpCode;
                    dst.Sig = src.Sig;
                    cases[encoded] = dst;
                }
            }

            Wf.AsmStatementDetailPipe().Run(Collect);

            var collected = @readonly(cases.Values.OrderBy(x => x.Encoded).Array());
            var dst = Db.IndexTable<AsmStatementCase>();
            var flow = Wf.EmittingTable<AsmStatementCase>(dst);
            var count = Tables.emit(collected, dst, 42);
            Wf.EmittedTable(flow,count);

            var id = Db.TableId<AsmStatementCase>();

            var asmcases = Db.IndexRoot() + FS.file(id, FS.Extensions.Asm);
            var asmflow = Wf.EmittingFile(asmcases);
            using var writer = asmcases.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var @case = ref skip(collected,i);
                var line = string.Format("{0,-36} ; ({1})[{2}] => {3}", @case.Expression, @case.Sig.Format(), @case.OpCode, @case.Encoded);
                writer.WriteLine(line);
            }

            Wf.EmittedFile(asmflow, count);

        }

        FS.Files EmitSymbolPaths()
        {
            var symbols = Wf.PdbSymbolStore();
            var src = Db.DefaultSymbolCache();
            var paths = symbols.SymbolPaths(src);
            var view = paths.View;
            var count = view.Length;
            var dst = Db.AppDataFile(FS.file("pdbsymbols", FS.Extensions.Csv));
            using var writer = dst.Writer();
            writer.WriteLine(string.Format("{0,-6} | {1}", "Seq", "Path"));
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(view,i);
                var row = string.Format("{0,-6} | {1}", i.Format(4), path.ToUri());
                writer.WriteLine(row);
            }
            return paths;
        }

        void ShowHandlers()
        {
            root.iter(Wf.Router.SupportedCommands, c => Wf.Status(c));
        }

        public static void show(IWfShell wf, CmdLine cmd)
        {
            wf.Status(cmd.Format());
        }

        static void ShowConfig(IWfShell wf)
        {
            wf.Status(wf.Settings.FormatList());
            wf.Status(wf.Db().Root);
        }

        static void RunInterpreter(IWfShell wf)
        {
            var cmd = WinCmdShell.create(wf);
            cmd.Submit("dir J:\\");
            cmd.Run();
            cmd.WaitForExit();
        }

        static void TestCmdLine(params string[] args)
        {
            var cmd1 = new CmdLine("cmd /c dir j:\\");
            var cmd2 = new CmdLine("llvm-mc --help");
            using var wf = WfShell.create(args).WithRandom(Rng.@default());
            var process = ToolCmd.run(cmd2).Wait();
            var output = process.Output;
            wf.Status(output);
        }

        void CheckFlags()
        {
            var flags = Clr.@enum<Windows.MinidumpType>();
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
            Wf.Status(call.Format());
        }

        public void ShowCommands()
        {
            var models = @readonly(Cmd.cmdtypes(Wf));
            var count = models.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var model = ref skip(models,i);
                Wf.Row(string.Format("{0,-3} {1}", i, model.DataType.Name));
            }
        }

        public CmdResult Run(ICmd spec)
        {
            Wf.Status(Dispatching().Format(spec.CmdId));
            return Wf.Router.Dispatch(spec);
        }

        public CmdResult Run<T>(T spec)
            where T : struct, ICmd<T>
        {
            Wf.Status(Dispatching<T>().Format(spec));
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
            cmd.WithExt(FS.Extensions.Cmd);
            //cmd.WithLimit(20);
            return cmd;
        }

        CmdResult EmitFileList()
            => Wf.Router.Dispatch(EmitFileListCmdSample());

        void ListCommands()
        {
            root.iter(Wf.Router.SupportedCommands, c => Wf.Status($"{c} enabled"));
        }

        public void RunPipes()
        {
            using var flow = Wf.Running();
            var data = Wf.PolyStream.Span<ushort>(2400);

            var input = Pipes.pipe<ushort>();
            var incount = Pipes.flow(data, input);
            var output = Pipes.pipe<ushort>();
            var outcount = Pipes.flow(input,output);

            Wf.Ran(flow, $"Ran {incount} -> {outcount} values through pipe");
        }

        void EmitImageHeaders()
        {
            var svc = ImageDataEmitter.create(Wf);
            svc.EmitImageHeaders(Archives.runtime(Wf));
        }

        void Receive(in ImageContent src)
        {
            Wf.Row(src.Data);
        }

        public void PipeImageData()
        {
            var emitter = Wf.ImageDataEmitter();
            root.iter(Wf.Api.PartComponents, c => emitter.EmitImageContent(c));

            // var archive = ImageArchives.tables(Wf);
            // var path = archive.Root + FS.file("image.content.genapp", FS.Extensions.Csv);
            // ImageArchives.pipe(Wf, path, Receive);
        }


        void ShowLetters()
        {
            using var flow = Wf.Running();
            var resources = Resources.strings(typeof(AsciLetterLoText));
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

        void ShowCmdModels()
        {
            var models = @readonly(Cmd.cmdtypes(Wf));
            var buffer = Buffers.text();
            for(var i=0; i<models.Length; i++)
            {
                Cmd.render(skip(models,i), buffer);
                Wf.Row(buffer.Emit());
            }
        }

        void ShowOptions()
        {
            const string @case = @"llvm-pdbutil dump --streams J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.streams.log";
            var result = CmdParser.parse(@case);
            if(result.Succeeded)
            {
                var value = result.Value;
                Wf.Status(Cmd.format(value));
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


        void EmitApiStatements()
        {
            var pipe = Wf.ApiStatementPipe();
            var store = Wf.AsmDataStore();
            var statements = pipe.BuildStatements(store.CodeBlocks());
            pipe.EmitStatements(statements);
            ProcessStatements(statements);
        }

        void ProcessStatements(ReadOnlySpan<AsmApiStatement> src)
        {
            var count = src.Length;
            var distinct = root.hashset<AsmThumbprintExpr>();
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(src,i);
                if(s.OpCode.IsValid)
                    distinct.Add(s.Thumbprint());
            }

            var output = distinct.ToArray();
            Wf.Status($"Observed {output.Length} distinct statements");
            Array.Sort(output);
            var path = Db.TableDir<AsmApiStatement>() + FS.file("thumbprints", FS.Extensions.Asm);
            using var writer = path.Writer();
            root.iter(output, o => writer.WriteLine(o));
        }

        /// <summary>
        /// ModRM = [Mod:[7:6] | Reg:[5:3] | Rm:[2:0]]
        /// </summary>
        void ShowModRmBits2()
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
                    var m1 = AsmEncoding.modrm(skip(f0, a), skip(f1, b), skip(f2, c));
                    var m2 = AsmEncoding.modrm((byte)i);
                    AsmEncoding.render(m1, dst.Buffer);
                    dst.Buffer.Append(" ^ ");
                    AsmEncoding.render(m2, dst.Buffer);
                    dst.Buffer.Append(" = ");
                    dst.Buffer.Append((m1^m2).Encoded.FormatBits());
                    dst.ShowBuffer();
                }

           }

            Show("modrm", FS.Extensions.Log, emit);
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
            Wf.Row($"1: {bits.View(w1)}");
            Wf.Row($"2: {bits.View(w2)}");
            Wf.Row($"3: {bits.View(w3)}");
            Wf.Row($"4: {bits.View(w4)}");
            Wf.Row($"5: {bits.View(w5)}");
            Wf.Row($"6: {bits.View(w6)}");
            Wf.Row($"7: {bits.View(w7)}");
            Wf.Row($"8: {bits.View(w8)}");

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
                Wf.EmittedFile(flow,1);
            }
        }

        void DumpImages()
        {
            var emitter = MemoryEmitter.create(Wf);
            var src = Db.DotNetSymbolDir(3,1,12);
            var dst = Db.DotNetImageDumpDir(3,1,12);
            dst.Clear();
            emitter.DumpImages(src,dst);
        }

        public void Run()
        {
            //Wf.AsmCatalogEtl().EmitMnemonicInfo();

            //Wf.AsmFormPipe().EmitFormHashes();

            var src = ImageMaps.current();
            var dst = Db.AppLog("imagemap", FS.Extensions.Csv);
            ImageMaps.emit(Wf, src, dst);
            //Sigs.ShowSymbols();
            //PipeImageData();
            //CheckBitSpans();
            //CheckBitView();
            //var api = Wf.ApiCmdRunner();
            //var asmlang = Wf.AsmLangCmdRunner();
            //var asmcmd = Wf.AsmCmdRunner();

            // root.iter(loaded, x => Wf.Row(x));

            //CheckRel32();

            //Wf.ApiStatementPipe().EmitStatements(Wf.AsmDataStore().CodeBlocks());

            //Wf.BitCmd().Run(BitCmdKind.GenBitSequences);

            //Wf.AsmLangCmd().Run(AsmLangCmdKind.ShowRexBits);

            //RunFunctionWorkflows();

            //Capture.run(Wf, PartId.AsmZ);
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

    public static partial class XTend
    {

    }
}