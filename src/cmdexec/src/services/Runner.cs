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

    public ref struct MergeRunner
    {
        readonly WfCaptureState State;

        readonly Span<string> Buffer;

        readonly IWfShell Wf;

        byte offset;

        IPolyrand Random;

        IAsmContext Asm;

        WfHost Host;

        IWfDb Db;

        [MethodImpl(Inline)]
        public MergeRunner(WfCaptureState wf)
        {
            Host = WfShell.host(typeof(MergeRunner));
            Wf = wf.Wf.WithHost(Host);
            Db = Wf.Db();
            State = wf;
            Buffer = z.span<string>(256);
            offset = 0;
            Asm = wf.Asm;
            Random = wf.App.Random;
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        void RunCalc()
        {
            CalcDemo.compute();

            var pos = offset;
            CalcDemo.run(Buffer, ref offset);
            for(var i=pos; i<offset; i++)
                term.print(Buffer[i]);
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
            using var map = MemoryFiles.open(ResPack);
            var @base = map.BaseAddress;
            var sig = map.View(0, 2).AsUInt16();
            var info = map.Description;
            Status(format(info));
        }

        unsafe static void Emit(MemoryRange src, FS.FilePath dst)
        {
            var bpl = 32;
            var line = text.build();
            using var writer = dst.Writer();

            var pSrc = src.BaseAddress.Pointer<byte>();
            var last =  src.EndAddress.Pointer<byte>();
            var address = src.BaseAddress;
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


        void IceStuff()
        {
            var flow = Wf.Running(Host);

            var bitfield = Ice.IceInstructions.init();
            var indices = bitfield.Indices;
            var info = indices.Map(i => paired(i, (byte)i));
            foreach(var i in info)
                Wf.Row(i);

            Wf.Ran(flow, Host);
        }


        // public static ReadOnlySpan<AsmRoutineCode> decode(IAsmWf asmWf, MethodInfo[] src, FS.FilePath target)
        //     => decode(asmWf, CaptureAlt.capture(src), target);

        // public static void decode(IAsmWf asmWf, ReadOnlySpan<ApiCaptureBlock> src, Span<AsmRoutineCode> dst)
        // {
        //     var count = src.Length;
        //     var decoder = asmWf.Decoder;
        //     var formatter = asmWf.Formatter;
        //     for(var i=0u; i<count; i++)
        //     {
        //         ref readonly var captured = ref skip(src,i);
        //         if(decoder.Decode(captured, out var fx))
        //         {
        //             var asm = formatter.FormatFunction(fx);
        //             seek(dst,i) = new AsmRoutineCode(fx,captured);
        //         }
        //     }
        // }

        // public static ReadOnlySpan<AsmRoutineCode> decode(IAsmWf asmWf, ReadOnlySpan<ApiCaptureBlock> src, FS.FilePath target)
        // {
        //     var count = src.Length;
        //     var dst = span<AsmRoutineCode>(count);
        //     var decoder = asmWf.Decoder;
        //     var formatter = asmWf.Formatter;

        //     using var writer = target.Writer();
        //     for(var i=0u; i<count; i++)
        //     {
        //         ref readonly var captured = ref skip(src,i);
        //         if(decoder.Decode(captured, out var fx))
        //         {
        //             seek(dst,i) = new AsmRoutineCode(fx,captured);
        //             var asm = formatter.FormatFunction(fx);
        //             writer.Write(asm);
        //         }
        //     }
        //     return dst;
        // }


        void ListTextResources()
        {
            var rows = Resources.rows(Resources.strings(typeof(EnvVarNames))).View;
            var count = rows.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                Wf.Row(row);
            }
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
            Run89(Parts.Konst.Assembly, Parts.Asm.Assembly);

            var blocks = CaptureAlt.capture(typeof(Switch16));
            var count = blocks.Length;
            Wf.Row((Count)count);

            for(var i=0; i<count; i++)
            {

            }
        }

        public void Run233()
        {
            var src = @readonly(Resources.strings<uint>(typeof(EnvVarNames)));
            for(var i=0; i<src.Length; i++)
                Status(skip(src,i).Format());
        }

        public static Type[] DiscoverWfHosts(params Assembly[] src)
            => src.Types().Tagged<WfHostAttribute>();

        public static void delay(uint ms)
            => Task.Run(async delegate {await Task.Delay((int)ms);}).Wait();

        public void Run999()
        {
            var hosts = DiscoverWfHosts(Wf.ApiParts.PartComponents).OrderBy(x => x.Assembly.FullName);
            var wf = Wf;
            iter(hosts, h => wf.Status(Seq.delimit(h.Assembly.GetSimpleName(),h.Name)));
        }

        public void Run()
        {

            var api = Wf.Api;
            var catalogs = api.Catalogs;
            if(catalogs.Terms.Length == 0)
                Wf.Warn("No catalogs");

            foreach(var c in catalogs.Terms)
                Wf.Row(Seq.delimit(c.PartId, c.ApiHosts.Count));
        }
    }
}