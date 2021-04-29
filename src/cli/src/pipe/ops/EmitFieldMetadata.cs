//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Images;

    partial class ImageMetaPipe
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

        public FS.FilePath FieldMetadataPath(Assembly src)
            => Db.Table(MemberField.TableId, src.Id());

        public uint EmitFieldMetadata(Assembly src)
        {
            var dst = FieldMetadataPath(src);
            var flow = Wf.EmittingTable<MemberField>(dst);
            using var reader = ImageMetadata.reader(FS.path(src.Location));
            var fields = reader.ReadFields();
            var count = (uint)fields.Length;
            var formatter = Tables.formatter<MemberField>(MemberField.RenderWidths);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var item in fields)
                writer.WriteLine(formatter.Format(item));
            Wf.EmittedTable(flow, count);
            return count;
        }
    }
}