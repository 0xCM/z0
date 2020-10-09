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
    using static z;

    partial class PeTableReader
    {
        public static ImageBlobRecord sig(in ReaderState state, FieldDefinition src, Count seq)
            => blob(state, src.Signature, seq);

        public static ReadOnlySpan<FieldRvaRecord> rva(in ReaderState state)
        {
            var reader = state.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = sys.alloc<FieldRvaRecord>(count);

            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref z.skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                var td = reader.GetTypeDefinition(entry.GetDeclaringType());
                var tName = reader.GetString(td.Name);
                var sig = PeTableReader.sig(state, entry, i);
                var name = reader.GetString(entry.Name);
                var va = entry.GetRelativeVirtualAddress();
                dst[i] = new FieldRvaRecord((Address32)va, tName, name, sig);
            }

            return dst.OrderBy(x => x.Rva);
        }

        public static ImageLiteralRecord literal(in ReaderState state, StringHandle handle, Count seq)
        {
            var value = state.Reader.GetString(handle);
            var offset = state.Reader.GetHeapOffset(handle);
            var size = state.Reader.GetHeapSize(HeapIndex.String);
            return new ImageLiteralRecord(seq, size, (Address32)offset, value);
        }

        public static ImageLiteralRecord name(in ReaderState state, FieldDefinition entry, Count seq)
            => literal(state, entry.Name, seq);

        internal static string format(FieldAttributes src)
            => src.ToString();
    }
}