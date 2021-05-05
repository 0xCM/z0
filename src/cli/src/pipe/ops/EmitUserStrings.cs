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
        public Index<UserString> EmitUserStrings()
            => EmitUserStrings(Wf.Components);

        public Index<UserString> EmitUserStrings(ReadOnlySpan<Assembly> src)
        {
            var buffer = DataList.create<UserString>();
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitUserStrings(skip(src,i), buffer);
            return buffer.Emit();
        }

        public void EmitUserStrings(Assembly src, DataList<UserString> buffer)
        {
            using var reader = ImageMetadata.reader(FS.path(src.Location));
            var records = reader.ReadUserStrings();
            buffer.Add(records);
            Db.EmitTable<UserString>(records, src.GetSimpleName());
        }
    }
}