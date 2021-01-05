//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;

    using F = CliStringRecord.Fields;
    using W = CliStringRecord.RenderWidths;


    partial class ImageEmitters
    {
        public void EmitUserStrings()
        {
            EmitUserStrings(Wf.Components);
        }

        public void EmitUserStrings(ReadOnlySpan<Assembly> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitUserStrings(skip(src,i));
        }

        public void EmitUserStrings(Assembly src)
        {
            var srcPath = FS.path(src.Location);
            using var reader = PeTableReader.open(srcPath);
            var data = reader.UserStrings();
            var EmissionCount = (uint)data.Length;

            var dstPath = Wf.Db().Table<CliUserString>(src.GetSimpleName(), FileExtensions.Csv);
            var formatter = Table.formatter<F,W>();
            using var writer = dstPath.Writer();
            formatter.EmitHeader();

            for(var i=0u; i<EmissionCount; i++)
                format(skip(data,i), formatter);
            writer.Write(formatter.Render());
        }

        [Op]
        static ref readonly DatasetFormatter<F,W> format(in CliUserString src, in DatasetFormatter<F,W> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Content);
            dst.EmitEol();
            return ref dst;
        }

    }
}