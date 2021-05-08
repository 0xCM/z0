//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;
    using static ImageRecords;
    using static CliRecords;

    partial class ImageMetaPipe
    {
        public Index<CliSystemString> EmitSystemStrings()
            => EmitSystemStrings(Wf.Components);

        public Index<CliSystemString> EmitSystemStrings(ReadOnlySpan<Assembly> src)
        {
            var count = src.Length;
            var dst = DataList.create<CliSystemString>(16404);
            for(var i=0; i<count; i++)
                EmitSystemStrings(skip(src,i), dst);
            return dst.Emit();
        }

        public uint EmitSystemStrings(Assembly src, DataList<CliSystemString> dst)
        {
            var srcPath = FS.path(src.Location);
            using var reader = PeTableReader.open(srcPath);
            var records = reader.SystemStrings();
            dst.Add(records);
            Db.EmitTable<CliSystemString>(records, src.GetSimpleName());
            return records.Count;
        }
    }
}