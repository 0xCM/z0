//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;

    partial class ImageDataEmitter
    {
        public Index<CliSystemStringInfo> EmitSystemStrings()
            => EmitSystemStrings(Wf.Components);

        public Index<CliSystemStringInfo> EmitSystemStrings(ReadOnlySpan<Assembly> src)
        {
            var count = src.Length;
            var dst = RecordList.create<CliSystemStringInfo>(16404);
            for(var i=0; i<count; i++)
                EmitSystemStrings(skip(src,i), dst);
            return dst.Emit();
        }

        public uint EmitSystemStrings(Assembly src, RecordList<CliSystemStringInfo> dst)
        {
            var srcPath = FS.path(src.Location);
            using var reader = PeTableReader.open(srcPath);
            var records = reader.SystemStrings();
            dst.Add(records);
            Db.EmitTable<CliSystemStringInfo>(records, src.GetSimpleName());
            return records.Count;
        }
    }
}