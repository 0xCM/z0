//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Reflection;

    using Z0.Schemas.Ecma;

    using static z;

    partial class ImageDataEmitter
    {
        public static void EmitApiBlobs(IWfShell wf)
        {
            var flow = wf.Running();
            var service = ImageDataEmitter.init(wf);
            service.ClearBlobs();
            var parts = wf.Api.Parts;
            foreach(var part in parts)
                service.EmitBlobs(part.Owner);
            wf.Ran(flow);
        }

        public void ClearBlobs()
        {
            Wf.Db().TableDir<BlobRow>().Clear();
        }

        public WfExecToken EmitBlobs(FS.FilePath src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<BlobRow>(dst);
            using var reader = PeTableReader.open(src);
            var rows = reader.Blobs();
            var count = (uint)rows.Length;
            var formatter = Records.formatter<BlobRow>(16);

            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));

            return Wf.EmittedTable<BlobRow>(flow, rows.Length, dst);
        }

        public WfExecToken EmitBlobs(Assembly src)
            => EmitBlobs(FS.path(src.Location), Wf.Db().Table<BlobRow>(src.GetSimpleName()));
    }
}