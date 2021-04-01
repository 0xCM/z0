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
        public Index<CliUserStringInfo> EmitUserStrings()
        {
            return EmitUserStrings(Wf.Components);
        }

        public Index<CliUserStringInfo> EmitUserStrings(ReadOnlySpan<Assembly> src)
        {
            var buffer = RecordList.create<CliUserStringInfo>();
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitUserStrings(skip(src,i), buffer);
            return buffer.Emit();
        }


        public void EmitUserStrings(Assembly src, RecordList<CliUserStringInfo> buffer)
        {
            using var reader = PeTableReader.open(FS.path(src.Location));
            var records = reader.UserStrings();
            buffer.Add(records);
            Db.EmitTable<CliUserStringInfo>(records, src.GetSimpleName());
        }
    }
}