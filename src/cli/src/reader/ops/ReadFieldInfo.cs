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

    using static Part;
    using static memory;
    using static CliRecords;

    partial class ImageMetaReader
    {
        public ReadOnlySpan<MemberFieldInfo> ReadFieldInfo()
        {
            var reader = MD;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = memory.span<MemberFieldInfo>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                int offset = entry.GetOffset();
                ref var field = ref seek(dst,i);
                var bsig = CliReader.ReadSig(entry);
                var name = ReadFieldName(entry.Name, i);

                field.Token = CliTokens.token(handle);
                field.FieldName = name.Value;
                field.Attribs = format(entry.Attributes);
                field.Sig = bsig;
            }
            return dst;
        }

        public MemberFieldName ReadFieldName(StringHandle handle, Count seq)
        {
            var value = MD.GetString(handle);
            var offset = MD.GetHeapOffset(handle);
            var size = MD.GetHeapSize(HeapIndex.String);
            return new MemberFieldName(seq, size, (Address32)offset, value);
        }
    }
}