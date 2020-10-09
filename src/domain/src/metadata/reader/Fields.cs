//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial class PeTableReader
    {
        public ReadOnlySpan<ImageFieldRecord> Fields()
        {
            var reader = State.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = Spans.alloc<ImageFieldRecord>(count);

            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                int offset = entry.GetOffset();

                seek(dst,i) = new ImageFieldRecord(i, name(State, entry, i), sig(State, entry, i), format(entry.Attributes));
            }
            return dst;
        }
    }
}