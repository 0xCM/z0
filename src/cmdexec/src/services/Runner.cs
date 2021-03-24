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

    using static Part;
    using static memory;

    public ref struct MergeRunner
    {
        readonly Span<string> Buffer;

        readonly IWfShell Wf;

        byte offset;

        IPolyrand Random;

        IAsmContext Asm;

        WfHost Host;

        IWfDb Db;


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


        static void format(ValueType src, StringBuilder dst)
        {
            var type = src.GetType();
            var fields = TableFields.discover(src.GetType()).View;
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
            var fields = TableFields.discover(type).View;
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
            using var map = MemoryFiles.map(ResPack);
            var @base = map.BaseAddress;
            var sig = map.View(0, 2).AsUInt16();
            var info = map.Description;
            Wf.Status(format(info));
        }

        unsafe static void Emit(MemoryRange src, FS.FilePath dst)
        {
            var bpl = 32;
            var line = text.build();
            using var writer = dst.Writer();

            var pSrc = src.Min.Pointer<byte>();
            var last =  src.Max.Pointer<byte>();
            var address = src.Min;
            byte pos = 0;
            var offset = 0u;

            while(pSrc++ <= last)
            {
                address = (MemoryAddress)pSrc;

                if(pos == 0)
                    line.Append(text.format("0x{0}  ", address.Format()));

                line.Append(text.format("{0} ", HexFormat.format<W8,byte>(*pSrc)));

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

        void ListTextResources()
        {
            var rows = Resources.strings(typeof(EnvVarNames)).View;
            var count = rows.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                Wf.Row(row);
            }
        }


        public void Run233()
        {
            var src = Resources.strings<uint>(typeof(EnvVarNames)).View;
            for(var i=0; i<src.Length; i++)
                Wf.Status(skip(src,i).Format());
        }

        public static Type[] DiscoverWfHosts(params Assembly[] src)
            => src.Types().Tagged<WfHostAttribute>();

        public static void delay(uint ms)
            => Task.Run(async delegate {await Task.Delay((int)ms);}).Wait();

        public void Run999()
        {
            var hosts = DiscoverWfHosts(Wf.ApiParts.Components).OrderBy(x => x.Assembly.FullName);
            var wf = Wf;
            root.iter(hosts, h => wf.Status(Seq.delimit(Chars.Pipe, 32, h.Assembly.GetSimpleName(),h.Name)));
        }

        public void Run()
        {

            var api = Wf.Api;
            var catalogs = api.Catalogs;
            if(catalogs.View.Length == 0)
                Wf.Warn("No catalogs");

            foreach(var c in catalogs.View)
                Wf.Row(Seq.delimit(Chars.Pipe, 0, c.PartId, c.ApiHosts.Count));
        }
    }
}