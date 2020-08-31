//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Linq;
    using System.Text;

    using Z0.Asm;

    using static Konst;
    using static z;

    public ref struct Runner
    {
        readonly WfCaptureState State;

        readonly Span<string> Buffer;

        IWfContext Wf => State.Wf;

        CorrelationToken Ct;

        WfActor Actor;

        WfStepId StepId;

        byte offset;

        [MethodImpl(Inline)]
        public Runner(WfCaptureState wf)
        {
            Ct = wf.Ct;
            StepId = AB.step(typeof(Runner));
            Actor = Flow.actor(nameof(Runner));
            State = wf;
            Buffer = z.span<string>(256);
            offset = 0;
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

        void RunChecks()
        {
            var log = text.build();
            using var step = new CheckBitMasks(Wf,log);
            step.Run();
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
        {
            Wf.Status(StepId, message, Ct);
        }

        void Status<T>(WfStepId step, T message)
        {
            Wf.Status(step, message, Ct);
        }

        static void format(ValueType src, StringBuilder dst)
        {
            var type = src.GetType();
            var fields = Table.fields(src.GetType()).View;
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
            var fields = Table.fields(type).View;
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
            var cil = Cil.init();
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
            var magic = Z0.Image.PeLiterals.Magical;
            var info = map.Description;
            Status(format(info));
        }

        void ListCaptureFiles()
        {
            var paths = Shells.paths();
            var files = AppFilePaths.create(paths, PartId.Control);

            Status(paths.Logs);
            Status(paths.Archives);
            Status(paths.BuildPub);
            Status(paths.BuildStage);
            Status(files.CaptureRoot);

            foreach(var file in FS.list((FS.FolderPath)files.AsmDir))
            {
                Status(file);
            }
        }

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
            var part = Parts.Canonical.Assembly;
            var id = part.Id();

            using var step = new CapturePart(Wf, State.Asm);
            var captured = step.Capture(part);
            var dst = Wf.AppPaths.AppCaptureRoot + FileName.define(id.Format(), FileExtensions.Asm);
            using var writer = dst.Writer();
            var count = captured.Length;
            if(count != 0)
            {
                ref readonly var f0 = ref first(captured);
                ref readonly var fn = ref skip(f0, count - 1);

                for(var i=0u; i<count; i++)
                {
                    ref readonly var fx = ref skip(f0,i);
                    writer.Write(fx.Asm);
                }

                var seg = new MemoryRange(f0.Base, fn.Base + fn.Size);
                Emit(seg, dst.ChangeExtension(FileExtensions.HexLine));
            }
        }

        public void Run()
        {
            {
                var src = typeof(RenderPatterns);
                var dst = FS.dir(Wf.IndexRoot.Name) + FS.file("format-patterns", "csv");
                using var step = new EmitFormatPatterns(State.Wf, (src, dst));
                step.Run();
            }

            {
                using var step = new CheckResources(Wf);
                step.Run();
            }

            {
                using var step = new EmitLiterals(Wf, Parts.Konst.Assembly);
                step.Run();
            }

            {
                using var step = new EmitAsmSymbols(Wf);
                step.Run();
            }

            //Capture();
        }
    }
}