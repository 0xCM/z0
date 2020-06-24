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

    using static Konst;    
    using static PartRecords;
    using static Root;
    using static ReaderInternals;

    using M = PartRecords;

    
    partial class PartReader
    {        
        internal static M.LiteralRecord record(in ReaderState state, StringHandle handle, int seq)
        {
            var value = state.Reader.GetString(handle);
            var offset = state.Reader.GetHeapOffset(handle);
            var size = state.Reader.GetHeapSize(HeapIndex.String);
            return new M.LiteralRecord(seq, size, offset, value);                    
        }

        internal static M.LiteralRecord name(in ReaderState state, FieldDefinition entry, int seq)
            => record(state, entry.Name, seq);
        
        internal static string format(FieldAttributes src)
            => src.ToString();

        internal static BlobRecord signature(in ReaderState state, FieldDefinition entry, int seq)
            => record(state, entry.Signature, seq);

        internal static ReadOnlySpan<FieldRecord> fields(in ReaderState state)
        {
            var reader = state.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = Spans.alloc<FieldRecord>(count);
            
            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);

                seek(dst,i) = new FieldRecord(
                    Sequence: i,
                    Rva: entry.GetRelativeVirtualAddress(),                    
                    Offset: entry.GetOffset(),
                    Name: name(state, entry, i),
                    Signature: signature(state, entry, i),
                    Attributes: format(entry.Attributes),
                    Marshalling: literal(state, entry.GetMarshallingDescriptor(), i)
                );
            }
            return dst;
        }
    }
}