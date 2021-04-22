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

    using static memory;
    using static Images;
    using static Part;

    partial class ImageMetaReader
    {
        public ReadOnlySpan<MemberField> ReadFields()
        {
            var reader = MetadataReader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = memory.span<MemberField>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                int offset = entry.GetOffset();
                ref var field = ref seek(dst,i);
                var bsig = ReadSig(entry,i);
                var name = ReadFieldName(entry.Name, i);

                field.Token = Clr.token(handle);
                field.FieldName = name.Value;
                field.Attribs = format(entry.Attributes);
                field.Sig = bsig.Data;
            }
            return dst;
        }

        public MemberFieldName ReadFieldName(StringHandle handle, Count seq)
        {
            var value = MetadataReader.GetString(handle);
            var offset = MetadataReader.GetHeapOffset(handle);
            var size = MetadataReader.GetHeapSize(HeapIndex.String);
            return new MemberFieldName(seq, size, (Address32)offset, value);
        }
    }
}