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
    using System.IO;
    using Z0.Tooling;
    using System.Runtime.InteropServices;

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
            Catalog = StanfordAsmCatalog.create(Wf);

            Forms = root.hashset<AsmFormExpr>();
            Sigs = Wf.AsmSigs();

        }

        HashSet<AsmFormExpr> Forms;

        AsmSigs Sigs;

        StanfordAsmCatalog Catalog;

        public void GenerateInstructionModels()
        {
            Wf.AsmCodeGenerator().GenerateModelsInPlace();
        }

        public void GenerateInstructionModelPreview()
        {
            Wf.AsmCodeGenerator().GenerateModels(Db.AppLogDir() + FS.folder("asm.lang.g"));
        }

        void ShowSigSymbols()
        {
            Sigs.ShowSymbols();
        }

        void EmitFormHashes()
        {
            Wf.AsmFormPipe().EmitFormHashes();
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


        void EmitByteCode()
        {
            var package = Db.Package("respack");
            var path = package + FS.file("z0.respack.dll");
            var exists = path.Exists ? "Exists" : "Missing";
            Wf.Status($"{path} | {exists}");
            var assembly = Assembly.LoadFrom(path.Name);
            var provider = Wf.ApiResProvider();
            var accessors = provider.PackagedCode().View;
            var count = accessors.Length;
            var dst = Db.AppLog("respack", FS.Asm);
            var decoder = Wf.AsmDecoder();
            var buffer = text.buffer();
            var sequence = 0u;
            var segments = root.list<MemorySegment>(30000);
            using var writer = dst.Writer();
            using var hexout = dst.ChangeExtension(FS.Hex).Writer();
            for(var i=0; i<count; i++)
            {
                var seqlabel = sequence.ToString("d6") + ": ";
                ref readonly var accessor = ref skip(accessors,i);
                var raw = Resources.definition(accessor).ToArray();
                var bytes = @readonly(raw);
                var decoded = decoder.Decode(raw, MemoryAddress.Zero).View;
                var name = accessor.DeclaringType.Name + "/" + accessor.Member.Name;
                writer.WriteLine(asm.comment(seqlabel + name));
                AsmFormatter.render(raw,decoded,buffer);
                writer.Write(buffer.Emit());

                var offset = z16;
                var mov = AsmHexCode.Empty;
                var movsize = AsmHexCode.Empty;
                hexout.Write(seqlabel);
                for(var j=0; j<decoded.Length; j++)
                {
                    ref readonly var fx = ref skip(decoded,j);
                    var size = (byte)fx.ByteLength;
                    var code = AsmBytes.hexcode(slice(bytes,offset,size));

                    if(j !=0)
                        hexout.Write(Chars.Space);
                    hexout.Write(code.Format());
                    if(size == 10)
                        mov = code;
                    else if(size == 7)
                        movsize = code;
                    offset += size;
                }

                var imm64 = Imm64.from(slice(mov.Bytes,2));
                var imm32 = Imm32.from(slice(movsize.Bytes,3));
                hexout.Write(string.Format(" ## {0:X} ## {1:X}", imm64, imm32));
                hexout.WriteLine();

                segments.Add(Resources.capture(accessor));

                sequence++;
            }

            using var proplog = Db.AppLog("respack.props").Writer();
            foreach(var prop in segments)
            {
                proplog.WriteLine(string.Format("{0}[{1}]:{2}", prop.BaseAddress, prop.Size, prop.Buffer.FormatHex()));
            }
        }


        void CheckIndexDecoder()
        {
            var blocks = Wf.ApiIndexBuilder().IndexApiBlocks();
            var dataset = Wf.ApiDecoder().Decode(blocks);
        }

        void TestRel32()
        {
            var builder = new AsmStatementBuilder();
            var cases = AsmCases.loadRel32(builder.call()).View;
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
            buffer.AppendLine(text.prop(nameof(info.AllocProtect), info.AllocProtect));
            Wf.Row(buffer.Emit());
        }

        void FilterApiBlocks()
        {
            var blocks = Wf.ApiCatalogs().Correlate();
            var f1 = blocks.Filter(ApiClass.And);
            root.iter(f1,f => Wf.Row(f.Uri));
        }

        void CheckApiHexArchive()
        {
            var part = PartId.Math;
            var component = Wf.Api.FindComponent(part).Require();
            var catalog = ApiCatalogs.catalog(component);

            void accept(in ApiCodeBlock block)
            {
                if(catalog.Host(block.OpUri.Host, out var host))
                {
                    Wf.Row(string.Format("{0} | {1}", host.Uri, block.OpUri));
                }
            }

            var archive = Wf.ApiHexArchive();
            archive.CodeBlocks(part, accept);
        }

        void ShowInterfaceMaps()
        {
            var calc8 = Clr.imap(typeof(Prototypes.Calc8), typeof(Prototypes.ICalc8));
            var calc64 = Clr.imap(typeof(Prototypes.Calc64), typeof(Prototypes.ICalc64));
            using var log = ShowLog("imap",FS.Log);
            log.Show(calc8.Format());
            log.Show(calc64.Format());
        }

        void RunScripts()
        {
            var runner = ScriptRunner.create(Db);
            runner.RunToolCmd(clang.name, "codegen");
            runner.RunToolCmd(clang.name, "parse");
            runner.RunToolPs(clang.name, "fast-math");
            runner.RunToolPs(llvm.ml, "lex");
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


        public static MsgPattern<T> DispatchingCmd<T>()
            where T : struct, ICmd<T> => "Dispatching {0}";

        public static MsgPattern<CmdId> DispatchingCmd() => "Dispatching {0}";


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

        public static Index<OpMsil> msil(MethodInfo[] src)
        {
            var count = src.Length;
            var buffer = alloc<OpMsil>(count);
            var methods = @readonly(src);
            var target = span(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                var address = ApiJit.jit(method);
                var located = new LocatedMethod(method.Identify(), method, address);
                var uri = ApiUri.located(method.DeclaringType.HostUri(), method.Name, method.Identify());
                var body = method.GetMethodBody();
                var sig = method.ResolveSignature();
                if(body != null)
                {
                    var ilbytes = body.GetILAsByteArray() ?? Array.Empty<byte>();
                    var length = ilbytes.Length;
                    seek(target,i) = new OpMsil(method.MetadataToken, address, uri, sig, ilbytes, method.MethodImplementationFlags);
                }
            }

            return buffer;
        }

        void EmitMsil()
        {
            var pipe = Wf.MsilPipe();
            var members = Wf.Api.ApiHosts.Where(h => h.HostType == typeof(math)).Single().Methods;
            var buffer = text.buffer();
            var methods = msil(members);
            root.iter(methods, m => pipe.Render(m,buffer));
            using var writer = Db.AppDataFile(FS.file(nameof(math), FS.Il)).Writer();
            writer.Write(buffer.Emit());
        }

        FS.Files EmitPdbSymbolPaths()
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

        public void Display(CmdLine cmd)
        {
            Wf.Status(cmd.Format());
        }

        public void DisplayConfig()
        {
            Wf.Status(Wf.Settings.FormatList());
            Wf.Status(Db.Root);
        }

        static void TestCmdLine(params string[] args)
        {
            var cmd1 = new CmdLine("cmd /c dir j:\\");
            var cmd2 = new CmdLine("llvm-mc --help");
            using var wf = WfRuntime.create(ApiCatalogs.parts(root.controller(), args), args).WithSource(Rng.@default());
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

        void ListCommands()
        {
            root.iter(Wf.Router.SupportedCommands, c => Wf.Status($"{c} enabled"));
        }

        public void RunPipes()
        {
            using var flow = Wf.Running();
            var data = Wf.Polysource.Span<ushort>(2400);

            var input = Pipes.pipe<ushort>();
            var incount = Pipes.flow(data, input);
            var output = Pipes.pipe<ushort>();
            var outcount = Pipes.flow(input,output);

            Wf.Ran(flow, $"Ran {incount} -> {outcount} values through pipe");
        }

        void EmitImageHeaders()
        {
            var svc = CliDataPipe.create(Wf);
            svc.EmitSectionHeaders(WfRuntime.RuntimeArchive(Wf));
        }

        void Receive(in ImageContent src)
        {
            Wf.Row(src.Data);
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
                    var m1 = AsmEncoder.modrm(skip(f0, a), skip(f1, b), skip(f2, c));
                    var m2 = AsmEncoder.modrm((byte)i);
                    AsmEncoder.render(m1, dst.Buffer);
                    dst.Buffer.Append(" ^ ");
                    AsmEncoder.render(m2, dst.Buffer);
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
            Wf.Row($"1: {bits.View(w1, 0)}");
            Wf.Row($"2: {bits.View(w2, 0)}");
            Wf.Row($"3: {bits.View(w3, 0)}");
            Wf.Row($"4: {bits.View(w4, 0)}");
            Wf.Row($"5: {bits.View(w5, 0)}");
            Wf.Row($"6: {bits.View(w6, 0)}");
            Wf.Row($"7: {bits.View(w7, 0)}");
            Wf.Row($"8: {bits.View(w8, 0)}");
        }

        static bool parse(string src, out CilCapture dst)
        {
            var parts = @readonly(src.SplitClean(Chars.Pipe));
            var count = parts.Length;
            if(count != CilCapture.FieldCount)
            {
                dst = default;
                return false;
            }
            else
            {
                var i=0;
                DataParser.parse(skip(parts,i++), out dst.MemberId);
                DataParser.parse(skip(parts,i++), out dst.BaseAddress);
                DataParser.parse(skip(parts,i++), out dst.Uri);
                DataParser.parse(skip(parts,i++), out dst.CilCode);
                return true;
            }
        }

        Index<CilCapture> LoadCapturedCil()
        {
            var flow = Wf.Running($"Loading cil data rows");
            var input = Db.CilDataPaths().View;
            var count = input.Length;
            var dst = RecordList.create<CilCapture>();
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(input,i);
                using var reader = path.Reader();
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if(parse(line, out var row))
                        dst.Add(row);
                    else
                        Wf.Warn($"The content {line} could not be parsed");
                }
            }
            Wf.Ran(flow,$"Loaded {dst.Count} cil rows");
            return dst.Emit();
        }

        void DumpImages()
        {
            var emitter = MemoryEmitter.create(Wf);
            var src = Db.DotNetSymbolDir(3,1,12);
            var dst = Db.DotNetImageDumpDir(3,1,12);
            dst.Clear();
            emitter.DumpImages(src,dst);
        }

        void DumpImages(byte major, byte minor, byte revision)
        {
            var emitter = MemoryEmitter.create(Wf);
            var src = Db.DotNetSymbolDir(major,minor,revision);
            if(!src.Exists)
            {
                Wf.Error($"The specified source directory does not exist: {src}");
                return;
            }
            var dst = Db.DotNetImageDumpDir(major,minor,revision);
            dst.Clear();
            emitter.DumpImages(src,dst);
        }

        // void EmitImageMaps()
        // {
        //     var src = ImageMaps.current();
        //     var dst = Db.AppLog("imagemap", FS.Extensions.Csv);
        //     ImageMaps.emit(Wf, src, dst);
        // }

        void ShowThumprintCatalog()
        {
            var pipe = Wf.AsmThumbprints();
            pipe.ShowThumprintCatalog();
        }

        void ShowXedInstructions()
        {
            var pipe = Wf.XedCatalog();
            var records = pipe.LoadFormSummaries().View;
            var count = records.Length;
            if(count !=0 )
            {
                using var log = ShowLog("xed-instructions", FS.Extensions.Csv);
                for(var i=0; i<count; i++)
                {
                    ref readonly var record = ref skip(records,i);
                    var id = record.Form;
                    var components = id.Split(Chars.Underscore).Delimit(Chars.Pipe, -16);
                    log.Show(string.Format("{0,-64} | {1}", id, components));
                }
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

        void ShowXedForms()
        {
            var pipe = Wf.XedCatalog();
            var forms = pipe.LoadFormDetails();
            using var log = ShowLog("xed-forms", FS.Extensions.Csv);
            log.Show(XedModels.FormDetail.Header);
            root.iter(forms, form => log.Show(form));
        }

        public void EmitApiImageContent()
        {
            Wf.CliDataPipe().EmitImageContent();
        }

        void ShowRegKinds(RegKind src, ShowLog dst)
        {
            if(src.IsNonZero())
                dst.Show(src);
        }

        public void ShowRegKinds()
        {
            var converter = RegKindConverter.create();
            using var log = ShowLog("registers", FS.Csv);
            log.Show("Register");
            root.iter(converter.Kinds, k => ShowRegKinds(k,log));
        }

        static Index<ApiHostUri> NestedHosts(Type src)
        {
            var dst = root.list<ApiHostUri>();
            var nested = @readonly(src.GetNestedTypes());
            var count = nested.Length;
            for(var i=0; i<count; i++)
            {
                var candidate = skip(nested,i);
                var uri = candidate.HostUri();
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

        void CaptureParts(params PartId[] parts)
        {
            var dst = Db.AppLogDir() + FS.folder("capture");
            dst.Clear();
            Wf.CaptureRunner().Capture(parts, dst);
        }

        public void EmitXedCatalog()
        {
            Wf.XedCatalog().EmitCatalog();
        }

        public void EmitBitstrings()
        {
            var thumbprints = Wf.AsmThumbprints().LoadThumbprints().View;
            Wf.AsmStatementPipe().EmitBitstrings(thumbprints);
        }

        void CheckCpuid()
        {
            var cpuid = CpuId.request(0u,0u);
            var result = Cells.cell128(0x00000015, 0x756E6547, 0x6C65746E, 0x49656E69);
            CpuId.response(result, ref cpuid);
            Wf.Row(cpuid.Format());

        }

        void CheckFenceParser()
        {
            var input = FenceExprCases.CaseA;
            var parser = FenceExprPaser.create((Chars.LParen, Chars.RParen));
            var output = parser.Parse(input);
            var delimiter = string.Format(" {0} ", SymNotKind.Right.ToChar());
            for(var i=0; i<output.Length; i++)
            {
                ref readonly var x = ref skip(output,i);
                //if(text.nonempty(x.Right))
                Wf.Row(x.Format(delimiter));
            }

        }

        void EmitRuntimeMembers()
        {
            var service = ApiRuntime.create(Wf);
            var members = service.EmitRuntimeIndex();
        }

        void LoadCurrentCatalog()
        {
            var entries = Wf.ApiCatalogs().Current();
        }

        void ProcessInstructions()
        {
            var blocks = LoadApiBlocks();
            var clock = Time.counter(true);
            var traverser = Wf.ApiCodeBlockTraverser();
            var receiver  = new AsmDetailProducer(Wf,750000);
            traverser.Traverse(blocks, receiver);
            var duration = clock.Elapsed.Ms;
            var productions = receiver.Productions;
            Wf.Status(string.Format("Processed {0} instructions in {1} ms", productions.Length, (ulong)duration));
        }

        static ReadOnlySpan<byte> mul_ᐤ8uㆍ8uᐤ
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0xc3};

        public void t_digit_parser()
        {
            ReadOnlySpan<char> input = "754d91";
            Span<uint4> output = new uint4[256];
            var count = input.Length;
            var dst = EmptyString;
            var j=0;

            for(var i=count-1; i>=0; i--)
            {
                ref readonly var c = ref skip(input,i);
                if(DigitParser.digit(@base16, c, out var d))
                    seek(output,j++) = d;
                else
                    Wf.Error(c.ToString());
            }

             var value = 0u;
             value = ((uint)skip(output,0) << 0);
             value |= ((uint)skip(output,1) << 4);
             value |= ((uint)skip(output,2) << 8);
             value |= ((uint)skip(output,3) << 12);
             value |= ((uint)skip(output,4) << 16);
             value |= ((uint)skip(output,5) << 20);

            Wf.Row(value.ToString("x"));
        }

        public void ProccessCultFiles()
        {
            Wf.CultProcessor().Run();

        }

        public void CheckClrKeys()
        {
            var types = Wf.Api.PartComponents.Storage.Types();
            var unique = root.hashset<Type>();
            var count = unique.Include(types).Where(x => x).Count();
            Wf.Row($"{types.Length} ?=? {count}");

            var fields = Wf.Api.PartComponents.Storage.DeclaredStaticFields();
            root.iter(fields, f => Wf.Row(f.Name + ": " + f.FieldType.Name));

        }

        public Index<ApiCodeBlock> LoadApiBlocks()
        {
            return Wf.ApiHex().ReadBlocks();
        }

        void ShowSymbols()
        {
            var symbols = Symbols.cache<AsmMnemonicCode>().View;
            var count = symbols.Length;
            var expressions = alloc<SymExpr>(count);
            Symbols.expressions(symbols, expressions);

            for(var i=0; i<count; i++)
            {
                Wf.Row(skip(expressions,i));
            }
        }

        void CheckEntryPoints()
        {
            const ulong Target = 0x7ffa77aa1460;

            var points = EntryPoints.create(Wf);
            if(points.Create<ulong>(0))
            {
                var encoded = points.EncodeDispatch(0,Target);
                Wf.Status(encoded.FormatHexData());
            }
        }

        ToolScript<XedCase> CreateXedCase(AsmOc id)
        {
            var tool = Wf.XedTool();
            var dir = Db.CaseDir("asm.assembled", id);
            var dst = dir + FS.file(string.Format("{0}.{1}", id, tool.Id), FS.Cmd);
            var @case = tool.DefineCase(id, dir);
            return tool.CreateScript(@case, dst);
        }


        void CheckHeap()
        {
            const string segments = "A" + "BB" + "CCC" + "DDDD";
            var entries = array<uint>(0,   1,    3,     6);
            var heap = Heaps.cover(text.span(segments), entries);
            for(var i=0u; i<entries.Length; i++)
            {
                var seg = text.format(heap.Segment(i));
                Wf.Row(seg);

            }
        }

        void CheckAssets()
        {
            var assets = Parts.AsmLang.AssetSet;
            foreach(var descriptor in assets.Descriptors)
            {
                Wf.Row(descriptor.Format());
            }
        }

        void EmitCpuIntrinsics()
        {
            Wf.IntrinsicsCatalog().Emit();
        }

        void EmitXedSources()
        {
            Wf.XedCatalog().EmitSources();
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
            var dst = Db.IndexTable<MemoryRegion>();
            var flow = Wf.EmittingTable<MemoryRegion>(dst);
            var segments = SystemMemory.regions();
            Tables.emit(segments,dst);
            Wf.EmittedTable(flow, segments.Count);
        }

        public void ParseXedForms()
        {
            var parser = XedFormParser.create(Wf.EventSink);
            var parsed = parser.ParseSummaries();
            Wf.Status($"Parsed {parsed.Length} summaries");
            Wf.XedCatalog().Emit(parsed);
        }

        static uint decode(ReadOnlySpan<AsciCharCode> src, Span<char> dst)
        {
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                seek(dst,i) = Asci.decode(code);
            }
            return count;
        }

        void ShowChars(ReadOnlySpan<AsciCharCode> src, Span<char> buffer)
        {
            var count = decode(src,buffer);
            var decoded = slice(buffer,0,count);
            var @string = text.format(decoded);
            Wf.Row(@string);
        }

        void CheckMullo(IDomainSource Source)
        {
            var @class = ApiClass.MulLo;
            var count = 12;
            var left = Source.Array<uint>(count,100,200);
            var right = Source.Array<uint>(count,100,200);
            var buffer = alloc<uint>(count);
            ref readonly var x = ref first(left);
            ref readonly var y = ref first(right);
            ref var dst = ref first(buffer);
            var results = alloc<ApiCall>(count);
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
                seek(calls, i) = ApiCalls.result(@class,a,b,actual);
            }

            for(var i=0; i<count; i++)
            {
                ref readonly var call = ref skip(calls,i);
                ref readonly var expect = ref skip(expected,i);
                Wf.Row(call.Format() + " ?=? " + expect.ToString());
            }
        }

        public void CheckAsciTables()
        {
            var chars = span<char>(128);
            ShowChars(AsciTables.letters(LowerCase).Codes, chars);
            ShowChars(AsciTables.letters(UpperCase).Codes, chars);
            ShowChars(AsciTables.digits().Codes, chars);
        }

        public Index<AsmHostStatements> EmitHostStatements()
        {
            var pipe = Wf.AsmStatementPipe();
            return pipe.EmitHostStatements();
        }

        // void Capture(params PartId[] parts)
        // {
        //     var dst = Db.AppLogDir() + FS.folder("capture");
        //     dst.Clear();
        //     var runner = Wf.CaptureRunner();
        //     runner.Capture(parts, dst);
        //     var ts = root.timestamp();

        //     Wf.ProcessContextPipe().Emit(Db.ProcessContextRoot(),ts);
        // }

        public void CheckMemoryLookup()
        {
            var blocks = Wf.ApiHex().ReadBlocks().View;
            var count = blocks.Length;
            var distinct = blocks.Map(b => b.BaseAddress).ToArray().ToHashSet();
            if(distinct.Count != count)
            {
                Wf.Warn(string.Format("There should be {0} distinct base addresses and yet there are {1}", count, distinct.Count));
            }

            var symbols = MemorySymbols.alloc(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                symbols.Deposit(block.BaseAddress, block.Size, block.OpUri.Format());
            }

            var lookup = symbols.ToLookup();
            var dst = Db.AppLog("addresses.lookup", FS.Csv);
            var emitting = Wf.EmittingTable<MemorySymbol>(dst);
            var emitted = Tables.emit(lookup.Symbols,dst);
            Wf.EmittedTable(emitting,emitted);
            var found = 0;

            var hashes = lookup.Symbols.Map(x => x.HashCode).ToArray().ToHashSet();
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

        static ReadOnlySpan<byte> x7ffaa76f0ae0 => new byte[32]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xd1,0x48,0xb9,0x50,0x0f,0x24,0xa5,0xfa,0x7f,0x00,0x00,0x48,0xb8,0x30,0xdd,0x99,0xa6,0xfa,0x7f,0x00,0x00,0x48,0xff,0xe0,0};

        void CheckV()
        {
            const byte count = 32;
            var mask = cpu.vindices(cpu.vload(w256,x7ffaa76f0ae0), 0x48);
            var bits = recover<bit>(Cells.alloc(w256).Bytes);
            var buffer = Cells.alloc(w256).Bytes;
            BitPack.unpack(mask,bits);
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


        void LoadRegions()
        {
            var ts0 = root.timestamp();
            var ts1 = ts0.Format();
            var ts2 = Timestamp.Zero;
            var outcome = DataParser.parse(ts1, out ts2);
            if(!outcome)
                Wf.Error(outcome.Message);
            else
                Wf.Status(ts1);

            var pipe = Wf.ProcessContextPipe();

        }



        void RenderMovzx()
        {
            static string semantic(in AsmRow src)
            {
                return EmptyString;
            }

            var render = Wf.AsmRender();
            var code = AsmMnemonicCode.MOVZX;
            var rows = @readonly(Wf.AsmRowPipe().LoadAsmRows(code).OrderBy(x => x.Statement).Array());
            var count = rows.Length;
            var dst = Db.AppLog(code.ToString(),FS.Asm);
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                writer.WriteLine(render.FormatRow(row, semantic));
            }
        }

        void RenderJmp()
        {
            var code = AsmMnemonicCode.JMP;
            var render = Wf.AsmRender();
            var dst = Db.AppLog(code.ToString(), FS.Asm);
            render.RenderRows(code, dst);
        }


        [Record(TableId)]
        public struct JmpStub : IRecord<JmpStub>
        {
            public const string TableId = "jmp.stub";

            public OpIdentity Method;

            public MemoryAddress StubAddress;

            public MemoryAddress TargetAddress;

            public AsmHexCode StubCode;

            public Address32 Displacement;

            public Address32 Offset;

        }

        unsafe ReadOnlySpan<JmpStub> JmpStubs()
        {
            var source = typeof(Prototypes.Calc64);
            var host = source.HostUri();
            var methods = source.DeclaredMethods();
            var count = methods.Length;
            var entries = alloc<MemoryAddress>(count);
            var located = span<JmpStub>(count);
            ApiJit.jit(methods, entries);
            var j=0;
            for(var i=0; i< count; i++)
            {
                var encoded = Cells.alloc(w64).Bytes;
                ref readonly var method = ref skip(methods,i);
                ref readonly var entry = ref skip(entries,i);

                ref var data = ref entry.Ref<byte>();
                ByteReader.read5(data, encoded);
                if(JmpRel32.test(encoded))
                {
                    var target = JmpRel32.target(entry, encoded);
                    ref var info = ref seek(located,j++);
                    info.Method = method.Identify();
                    info.StubAddress = entry;
                    info.TargetAddress = target;
                    info.StubCode =  AsmBytes.hexcode(slice(encoded,0,5));
                    info.Displacement = JmpRel32.dx(encoded);
                    info.Offset = JmpRel32.offset(entry,entry,encoded);
                    //seek(located,j++) = //new LocatedMethod(method.Identify(), method, target);
                }
            }

            return slice(located,0,j);
        }

        void DoJumpStubs()
        {
            CaptureParts(PartId.AsmCases);
            ShowInterfaceMaps();
            var located = JmpStubs();
            using var log = ShowLog("jumptargets",FS.Csv);
            Tables.emit(located,log.Buffer);
            log.ShowBuffer();

        }

        public void Run()
        {
            var images = Wf.CliDataPipe();
            images.EmitMsilRows();


            //CheckV();
            //EmitHostStatements();
            //LoadCapturedCil();
            //CheckMemoryLookup();

            //Wf.ApiHex().EmitHexPack(false);
            // var packed = HexPack(true).View;
            // var dst = Db.AppLog("api",FS.ext("xpack"));
            // HexPack(dst,true);

            // var emitting = Wf.EmittingFile(dst);
            // using var writer = dst.Writer();
            // var count = packed.Length;
            // for(var i=0; i<count; i++)
            // {
            //     writer.WriteLine(skip(packed,i).Format());
            // }
            // Wf.EmittedFile(emitting, count);

            // var source = Rng.@default();
            // CheckMullo(source);


            //CaptureSelectedRoutines();

            // var a0 = Prototypes.Calls.call(n0);
            // var a1 = Prototypes.Calls.call(n1);
            // var a2 = Prototypes.Calls.call(n2);
            // var a3 = Prototypes.Calls.call(n3);

            //EmitXedCatalog();

            // JitApiCatalog();
            // MapMemory();
            //AsmExprCases.create(Wf).Create();

            //var script = CreateXedCase(AsmOc.mov_r64_imm64);

            // var tool = Wf.NasmTool();
            // tool.EmitInstructionAssets();

            // var inxs = ParseNasmInstructions();
            // ShowRecords(inxs.View);

            //ProccessCultFiles();
            //Wf.AsmDb().ShowSourceDocs();
            // var cases = AsmExprCases.create(Wf);
            // cases.Run(AsmSigKind.and_r8_r8);
            //ProccessCultFiles();

            //CaptureSelectedRoutines();
            //Wf.AsmCodeGenerator().GenerateModelsInPlace();
            //cases.Run(AsmSigKind.mov_r64_imm64);

        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfRuntime.create(ApiCatalogs.parts(Index<PartId>.Empty), args).WithSource(Rng.@default());
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