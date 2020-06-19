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
    using static MetadataRecords;
    using static Control;

    using M = MetadataRecords;
    
    partial class MetadataRead
    {        
        internal static M.LiteralRecord name(in ReaderState state, FieldDefinition entry, int seq)
        {
            return LiteralValue(state, entry.Name, seq);
        }
        
        internal static string format(FieldAttributes src)
        {
            return src.ToString();
        }

        internal static BlobRecord signature(in ReaderState state, FieldDefinition entry, int seq)
        {
            return LiteralValue(state, entry.Signature, seq);
        }

        internal static ReadOnlySpan<FieldRecord> fields(in ReaderState state)
        {
            var reader = state.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = alloc<FieldRecord>(count);
            

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
                    Marshalling: Literal(state, entry.GetMarshallingDescriptor(), i)
                );
            }
            return dst;
        }
    }
}