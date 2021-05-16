//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;

    partial class CliPipe
    {
        public Index<CliSystemString> EmitSystemStringInfo()
            => EmitSystemStringInfo(Wf.Components);

        public Index<CliSystemString> EmitSystemStringInfo(ReadOnlySpan<Assembly> src)
        {
            var count = src.Length;
            var dst = DataList.create<CliSystemString>(16404);
            for(var i=0; i<count; i++)
                EmitSystemStringInfo(skip(src,i), dst);
            return dst.Emit();
        }

        public uint EmitSystemStringInfo(Assembly src, DataList<CliSystemString> dst)
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