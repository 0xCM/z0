//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static z;

    partial class PeTableReader
    {
        public ReadOnlySpan<ClrFieldInfo> Fields()
        {
            var reader = State.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = Spans.alloc<ClrFieldInfo>(count);

            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                int offset = entry.GetOffset();
                seek(dst,i) = new ClrFieldInfo(i, FieldName(entry.Name, i), sig(State, entry, i), format(entry.Attributes));
            }
            return dst;
        }

        public CliFieldName FieldName(StringHandle handle, Count seq)
        {
            var value = State.Reader.GetString(handle);
            var offset = State.Reader.GetHeapOffset(handle);
            var size = State.Reader.GetHeapSize(HeapIndex.String);
            return new CliFieldName(seq, size, (Address32)offset, value);
        }

        internal static string format(FieldAttributes src)
            => src.ToString();

        public FieldDefinition Read(FieldDefinitionHandle src)
            => State.Reader.GetFieldDefinition(src);

        public ref FieldDefinition Read(FieldDefinitionHandle src, ref FieldDefinition dst)
        {
            dst = Read(src);
            return ref dst;
        }

        public void Read(ReadOnlySpan<FieldDefinitionHandle> src, Span<FieldDefinition> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(skip(src,i), ref seek(dst,i));
        }
    }
}