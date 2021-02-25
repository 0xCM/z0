//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;
    using static z;

    partial class ImageDataEmitter
    {
        public uint EmitCilRecords()
            => EmitCilRecords(Wf.Components);

        public uint EmitCilRecords(Assembly src)
        {
            var srcPath = FS.path(src.Location);
            var processing = Wf.Running(srcPath);
            var methods = CliFileReader.cil(srcPath);
            var count = (uint)methods.Length;
            if(count != 0)
            {
                var dst = Wf.Db().Table<CilDataRow>(src.GetSimpleName());
                var flow = Wf.EmittingTable<CilDataRow>(dst);
                using var writer = dst.Writer();
                writer.WriteLine(CilRowHeader);

                for(var i=0u; i<count; i++)
                    writer.WriteLine(format(skip(methods,i)));

                Wf.EmittedTable<CilDataRow>(flow, count);
            }

            Wf.Ran(processing, src);

            return count;
        }

        public uint EmitCilRecords(ReadOnlySpan<Assembly> src)
        {
            var total = 0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
                total += EmitCilRecords(skip(src,i));
            return total;
        }

        static string format(in CilDataRow src)
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
            dst.Append(src.Cil.Format());
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