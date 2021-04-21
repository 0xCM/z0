//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;
    using static Images;

    partial class ImageMetaPipe
    {
        public Index<UserString> EmitUserStrings()
            => EmitUserStrings(Wf.Components);

        public Index<UserString> EmitUserStrings(ReadOnlySpan<Assembly> src)
        {
            var buffer = RecordList.create<UserString>();
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitUserStrings(skip(src,i), buffer);
            return buffer.Emit();
        }

        public void EmitUserStrings(Assembly src, RecordList<UserString> buffer)
        {
            using var reader = PeTableReader.open(FS.path(src.Location));
            var records = reader.UserStrings();
            buffer.Add(records);
            Db.EmitTable<UserString>(records, src.GetSimpleName());
        }
    }
}