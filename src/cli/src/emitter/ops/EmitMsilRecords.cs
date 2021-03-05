//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;

    partial class ImageDataEmitter
    {
        public uint EmitMsilRecords()
            => EmitMsilRecords(Wf.Components);

        public uint EmitMsilRecords(Assembly src)
        {
            var srcPath = FS.path(src.Location);
            var processing = Wf.Running(srcPath);
            var methods = CliFileReader.cil(srcPath);
            var count = (uint)methods.Length;
            if(count != 0)
            {
                var dst = Wf.Db().Table<MsilRow>(src.GetSimpleName());
                var flow = Wf.EmittingTable<MsilRow>(dst);
                using var writer = dst.Writer();
                writer.WriteLine(CilRowHeader);

                for(var i=0u; i<count; i++)
                    writer.WriteLine(format(skip(methods,i)));

                Wf.EmittedTable<MsilRow>(flow, count);
            }

            Wf.Ran(processing, src);

            return count;
        }

        public uint EmitMsilRecords(ReadOnlySpan<Assembly> src)
        {
            var total = 0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
                total += EmitMsilRecords(skip(src,i));
            return total;
        }

        static string format(in MsilRow src)
        {
            var dst = EmptyString.Build();
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.MethodSig.Format().PadRight(80));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.MethodName.PadRight(50));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Rva.Format().PadRight(12));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Code.Format());
            return dst.ToString();
        }

        static string CilRowHeader
            => text.concat(FieldDelimiter, Space,
                "MethodSig".PadRight(80),  FieldDelimiter,  Space,
                "MethodName".PadRight(50), FieldDelimiter,  Space,
                "Rva".PadRight(12), FieldDelimiter, Space,
                "Il");
    }
}