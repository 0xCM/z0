//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class ImageDataEmitter
    {
        public void EmitFieldMetadata()
        {
            var count = 0u;
            var parts = Wf.ApiParts.Components;
            var flow = Wf.Running(parts.Length);

            foreach(var part in parts)
            {
                try
                {
                    count += EmitFieldMetadata(part);
                }
                catch(Exception e)
                {
                    Wf.Error(Host.Id,e);
                }
            }

            Wf.Ran(flow, count);
        }

        public uint EmitFieldMetadata(Assembly src)
        {
            var target = Db.Table(ClrFieldInfo.TableId, src.Id());
            var flow = Wf.EmittingTable<ClrFieldInfo>(target);
            using var reader = PeTableReader.open(FS.path(src.Location));
            var fields = reader.Fields();
            var count = (uint)fields.Length;

            var formatter = Records.formatter<ClrFieldInfo>(FieldMetadataWidths);
            using var writer = target.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var item in fields)
                writer.WriteLine(formatter.Format(item));

            Wf.EmittedTable(flow, count);
            return count;
        }

        public static ReadOnlySpan<byte> FieldMetadataWidths
            => new byte[ClrFieldInfo.FieldCount]{16,60,12,12,16,40,30};
    }
}