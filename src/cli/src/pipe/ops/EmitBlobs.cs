//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Reflection;

    using static memory;
    using static Images;

    partial class ImageMetaPipe
    {
        public void EmitBlobs()
        {
            var flow = Wf.Running();
            ClearBlobs();
            foreach(var part in Wf.Api.Parts)
                EmitBlobs(part.Owner);
            Wf.Ran(flow);
        }

        public void ClearBlobs()
        {
            Wf.Db().TableDir<MetadataBlob>().Clear();
        }

        public WfExecToken EmitBlobs(FS.FilePath src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<MetadataBlob>(dst);
            //using var reader = PeTableReader.open(src);
            using var reader = ImageMetaReader.create(src);
            var rows = reader.ReadBlobs();
            var count = (uint)rows.Length;
            var formatter = Tables.formatter<MetadataBlob>(16);

            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));

            return Wf.EmittedTable<MetadataBlob>(flow, rows.Length);
        }

        public WfExecToken EmitBlobs(Assembly src)
            => EmitBlobs(FS.path(src.Location), Wf.Db().Table<MetadataBlob>(src.GetSimpleName()));
    }
}