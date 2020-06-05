//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Seed;    
    using static MetadataRecords;
    using static Control;
    using MR = MetadataRecords;
    
    partial class MetaRead
    {        
        internal static ReadOnlySpan<MemberField> fields(in MetaReaderState state)
        {
            var reader = state.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = alloc<MemberField>(count);

            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);

                seek(dst,i) = new MemberField(
                    Sequence: i,
                    Rva: entry.GetRelativeVirtualAddress(),                    
                    Offset: entry.GetOffset(),
                    Name: LiteralValue(state, entry.Name),
                    Signature: LiteralValue(state, entry.Signature),
                    Attributes: ReadEnum(entry.Attributes),
                    Marshalling: Literal(state, entry.GetMarshallingDescriptor())
                );
            }
            return dst;
        }
    }
}