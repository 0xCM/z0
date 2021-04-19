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

    partial class CliDataPipe
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
            Wf.Db().TableDir<CliBlob>().Clear();
        }

        public WfExecToken EmitBlobs(FS.FilePath src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<CliBlob>(dst);
            using var reader = PeTableReader.open(src);
            var rows = reader.Blobs();
            var count = (uint)rows.Length;
            var formatter = Tables.formatter<CliBlob>(16);

            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));

            return Wf.EmittedTable<CliBlob>(flow, rows.Length);
        }

        public WfExecToken EmitBlobs(Assembly src)
            => EmitBlobs(FS.path(src.Location), Wf.Db().Table<CliBlob>(src.GetSimpleName()));
    }
}