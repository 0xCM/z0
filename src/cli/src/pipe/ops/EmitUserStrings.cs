//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;

    partial class ImageMetaPipe
    {
        public Index<CliUserString> EmitUserStrings()
            => EmitUserStrings(Wf.Components);

        public Index<CliUserString> EmitUserStrings(ReadOnlySpan<Assembly> src)
        {
            var buffer = DataList.create<CliUserString>();
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitUserStrings(skip(src,i), buffer);
            return buffer.Emit();
        }

        public void EmitUserStrings(Assembly src, DataList<CliUserString> buffer)
        {
            using var reader = ImageMetadata.reader(FS.path(src.Location));
            var records = reader.ReadUserStrings();
            buffer.Add(records);
            Db.EmitTable<CliUserString>(records, src.GetSimpleName());
        }
    }
}