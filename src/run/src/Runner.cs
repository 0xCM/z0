//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;

    using System.Text;

    using Z0.Asm;

    using static Konst;
    using static z;
    using static ArchiveFileKinds;

    public static partial class XTend
    {

    }

    public ref struct Runner
    {
        readonly WfCaptureState State;

        readonly Span<string> Buffer;

        IWfShell Wf => State.Wf;

        CorrelationToken Ct;

        byte offset;

        IPolyrand Random;

        IAsmContext Asm;

        WfHost Host;

        [MethodImpl(Inline)]
        public Runner(WfCaptureState wf)
        {
            Ct = wf.Ct;
            State = wf;
            Buffer = z.span<string>(256);
            offset = 0;
            Asm = wf.Asm;
            Random = wf.App.Random;
            Host = WfSelfHost.create(typeof(Runner));
        }

        public void Run<C,S,T>(in WfRunSpec<C,S,T> spec)
        {

        }

        void RunCalc()
        {
            CalcDemo.compute();

            var pos = offset;
            CalcDemo.run(Buffer, ref offset);
            for(var i=pos; i<offset; i++)
                term.print(Buffer[i]);

        }


        void RunFsm()
        {
            using var step = new RunFsm(Wf);
            step.Run();
        }

        public void Dispose()
        {

        }

        void Status<T>(T message)
            => Wf.Status(Host, message);

        void Status<T>(WfStepId step, T message)
        {
            Wf.Status(step, message);
        }

        static void format(ValueType src, StringBuilder dst)
        {
            var type = src.GetType();
            var fields = TableFields.index(src.GetType()).View;
            var count = fields.Length;
            for(var i=0; i<count; i++)
            {
                var v = skip(fields,i).Definition.Value(src).ValueOrDefault();
                dst.Append("| ");

                if(type.IsPrimitive)
                    dst.Append(src.ToString());
                else if(v is ITextual t)
                    dst.Append(t.Format());
                else if(v is ValueType x)
                    format(x, dst);
                else if(v != null)
                    dst.Append(v.ToString());
            }
        }

        static void format(object src, StringBuilder dst)
        {
            if(src == null)
                return;

            var type = src.GetType();
            var fields = TableFields.index(type).View;
            var count = fields.Length;
            for(var i=0; i<count; i++)
            {
                var v = skip(fields,i).Definition.Value(src).ValueOrDefault();
                dst.Append("| ");

                if(type.IsPrimitive)
                    dst.Append(src.ToString());
                else if(v is ITextual t)
                    dst.Append(t.Format());
                else if(v is ValueType x)
                    format(x, dst);
                else if(v != null)
                    dst.Append(v.ToString());
            }

        }

        void SaveCilOpCodes()
        {
            var cil = CilApi.init();
        }

        static string format<T>(in T src)
            where T : struct
        {
            var dst = text.build();
            format(src, dst);
            return dst.ToString();
        }

        FS.FilePath ResPack
            => FS.path("J:/dev/projects/z0-logs/builds/respack/lib/netcoreapp3.1/z0.respack.exe");

        void ReadRes()
        {
            using var map = MemoryFile.open(ResPack);
            var @base = map.BaseAddress;
            var sig = map.Read(@base, 2).AsUInt16();
            var info = map.Description;
            Status(format(info));
        }

        // void ListCaptureFiles()
        // {
        //     var paths = Shells.paths();
        //     var files = AppFilePaths.create(paths, PartId.Control);

        //     Status(paths.Logs);
        //     Status(paths.Archives);
        //     Status(paths.BuildPub);
        //     Status(paths.BuildStage);
        //     Status(files.CaptureRoot);

        //     foreach(var file in FS.list((FS.FolderPath)files.AsmDir))
        //     {
        //         Status(file);
        //     }
        // }

        unsafe static void Emit(MemoryRange src, FilePath dst)
        {
            var bpl = 32;
            var line = text.build();
            using var writer = dst.Writer();

            var pSrc = src.Start.Pointer<byte>();
            var last =  src.End.Pointer<byte>();
            var address = src.Start;
            byte pos = 0;
            var offset = 0u;

            while(pSrc++ <= last)
            {
                address = (MemoryAddress)pSrc;

                if(pos == 0)
                    line.Append(text.format("0x{0}  ", address.Format()));

                line.Append(text.format("{0} ", Hex.format<W8,byte>(*pSrc)));

                pos += 3;

                if(offset != 0 && offset % bpl == 0)
                {
                    writer.WriteLine(line.ToString());
                    line.Clear();
                    pos = 0;
                }

                offset++;
            }
        }

        void Capture()
        {
            var component = Parts.Canonical.Assembly;
            var part = Parts.Canonical.Resolved;
            var id = component.Id();

            using var step = new CapturePartStep(Wf, State.Asm, new CapturePartHost());
            var captured = step.Capture(part);
            var dst = Wf.Paths.AppCaptureRoot + FileName.define(id.Format(), FileExtensions.Asm);
            using var writer = dst.Writer();
            var count = captured.Length;
            // if(count != 0)
            // {
            //     ref readonly var f0 = ref first(captured);
            //     ref readonly var fn = ref skip(f0, count - 1);

            //     for(var i=0u; i<count; i++)
            //     {
            //         ref readonly var fx = ref skip(f0,i);
            //         writer.Write(fx);
            //     }

            //     var seg = new MemoryRange(f0.Base, fn.Base + fn.Size);
            //     Emit(seg, dst.ChangeExtension(FileExtensions.HexLine));
            // }
        }

        void Run59()
        {
            {
                var src = typeof(RP);
                var dst = FS.dir(Wf.IndexRoot.Name) + FS.file("format-patterns", "csv");
                var host = EmitRenderPatternsHost.create();
                host.Run(Wf, flow(src,dst));
            }

            {
                new CheckResources().Run(Wf);
            }

            // {
            //     var host = new EmitLiterals();
            //     using var step = new EmitLiteralsStep(Wf, Parts.Konst.Assembly, host);
            //     step.Run();
            // }

            {
                EmitAsmSymbols.create().Run(Wf);
            }

            {
                using var step = new CheckCredits(Wf, new CheckCreditsHost());
                step.Run();
            }


            {
                Wf.Running(Host);

                using var kernel = Native.kernel32();
                Wf.Row(kernel);

                var f = Native.func<OS.Delegates.GetProcAddress>(kernel, nameof(OS.Delegates.GetProcAddress));
                Wf.Row(f);

                var a = (MemoryAddress)f.Invoke(kernel, "CreateDirectoryA");
                Wf.Row(a);

                Wf.Ran(Host);
            }
        }

        void IceStuff()
        {
            Wf.Running(Host);

            var bitfield = Ice.IceInstructionBits.init();
            var indices = bitfield.Indices;
            var info = indices.Map(i => paired(i, (byte)i));
            foreach(var i in info)
                Wf.Row(i);

            Wf.Ran(Host);
        }

        void EmitOpCodes()
        {
            new EmitAsmOpCodes().Configure(Wf.Db().DbPaths.DbRoot + FS.file("AsmOpcodes", Csv)).Run(Wf);
        }

        ReadOnlySpan<ApiCaptureBlock> Blocks(MethodInfo[] src)
        {
            var methods = src.Select(m =>  new IdentifiedMethod(m.Identify(),m));
            var results = CaptureAlt.capture(methods);
            return results;
        }

        ReadOnlySpan<ApiCaptureBlock> Blocks(Type src)
            => Blocks(src.DeclaredMethods());


        ReadOnlySpan<AsmRoutineCode> Capture(MethodInfo[] src, string label)
        {
            var results = Blocks(src);
            var target = Wf.Paths.AppLogRoot + FS.file(label, ArchiveFileKinds.Asm);
            return Decode(results, target);
        }

        void Decode(ReadOnlySpan<ApiCaptureBlock> src, Span<AsmRoutineCode> dst)
        {
            var count = src.Length;
            var decoder = Asm.RoutineDecoder;
            var formatter = Asm.Formatter;
            for(var i=0u; i<count; i++)
            {
                ref readonly var captured = ref skip(src,i);
                if(decoder.Decode(captured, out var fx))
                {
                    var asm = formatter.FormatFunction(fx);

                    seek(dst,i) = new AsmRoutineCode(fx,captured);
                }
            }
        }

        ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<ApiCaptureBlock> src, FS.FilePath target)
        {
            var count = src.Length;
            var dst = span<AsmRoutineCode>(count);
            var decoder = Asm.RoutineDecoder;
            var formatter = Asm.Formatter;

            using var writer = target.Writer();
            for(var i=0u; i<count; i++)
            {
                ref readonly var captured = ref skip(src,i);
                if(decoder.Decode(captured, out var fx))
                {
                    seek(dst,i) = new AsmRoutineCode(fx,captured);
                    Wf.Row(fx.BaseAddress);
                    var asm = formatter.FormatFunction(fx);
                    writer.Write(asm);
                }
            }
            return dst;

        }
        void CheckBitMasks()
        {
            var methods = typeof(CheckBitMasks).Methods().WithNameStartingWith("CheckLoMask");
            var routines = Capture(methods, "bitmasks");
            CheckBitMasksHost.control(Wf, Random);
        }


        void ListTextResources()
        {
            var rows = Resources.rows(Resources.strings(typeof(Db.Literals))).View;
            var count = rows.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                Wf.Row(row);
            }
        }

        void Run77()
        {
            var build = FS.dir("J:/dev/labs/blend/App01/bin/x64/Release/net5.0/win-x64");
            var dllFiles = build.Files(false).Where(f => f.Ext.Name.Contains("dll"));
            var dllTarget = FS.path("J:/dev/projects/z0-logs/db/images.dll.csv");
            var exeFiles = build.Files(false).Where(f => f.Ext.Name.Contains("exe"));
            var exeTarget = FS.path("J:/dev/projects/z0-logs/db/images.exe.csv");
            EmitImageHeaders.create(dllFiles, dllTarget).Run(Wf);
            EmitImageHeaders.create(exeFiles, exeTarget).Run(Wf);
        }

        public void Run89(params Assembly[] src)
        {
            for(var i=0; i<src.Length; i++)
            {
                EmitEnums.create().Run(Wf, src[i]);

            }
        }

        public void Run93()
        {
            ListTextResources();
            Run77();
            Run89(Parts.Konst.Assembly, Parts.Asm.Assembly);

            var blocks = Blocks(typeof(Switch16));
            var count = blocks.Length;
            Wf.Row((Count)count);

            for(var i=0; i<count; i++)
            {

            }
        }

        public void Run87()
        {
            var build = FS.dir(@"k:\z0\builds\nca.3.1.win-x64");
            var cmd = new ClrCmd.EmitAssemblyReferences();
            cmd.Source = build + FS.file("z0.konst.dll");
            cmd.Target = Wf.AppData + FS.file("AssemblyReferences", "csv");
            ClrCmd.exec(Wf,cmd);
        }

        public void Run233()
        {
            var src = @readonly(Resources.strings<uint>(typeof(Db.Literals)));
            for(var i=0; i<src.Length; i++)
            {
                Status(skip(src,i).Format());
            }

        }

        public static Type[] DiscoverWfHosts(params Assembly[] src)
            => src.Types().Tagged<WfHostAttribute>();

        public static void delay(uint ms)
            => Task.Run(async delegate {await Task.Delay((int)ms);}).Wait();

        public void Run()
        {
            var hosts = DiscoverWfHosts(Wf.ApiParts.Components).OrderBy(x => x.Assembly.FullName);
            var wf = Wf;
            iter(hosts, h => wf.Status(delimit(h.Assembly.GetSimpleName(),h.Name)));
        }
    }
}