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
        public ReadOnlySpan<CliFieldRecord> Fields()
        {
            var reader = State.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = Spans.alloc<CliFieldRecord>(count);

            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                int offset = entry.GetOffset();

                seek(dst,i) = new CliFieldRecord(i, name(State, entry, i), sig(State, entry, i), format(entry.Attributes));
            }
            return dst;
        }

        public static CliBlobRecord sig(in ReaderState state, FieldDefinition src, Count seq)
            => blob(state, src.Signature, seq);

        public static ReadOnlySpan<CliFieldRvaRecord> rva(in ReaderState state)
        {
            var reader = state.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = sys.alloc<CliFieldRvaRecord>(count);

            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref z.skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                var td = reader.GetTypeDefinition(entry.GetDeclaringType());
                var tName = reader.GetString(td.Name);
                var sig = PeTableReader.sig(state, entry, i);
                var name = reader.GetString(entry.Name);
                var va = entry.GetRelativeVirtualAddress();
                dst[i] = new CliFieldRvaRecord((Address32)va, tName, name, sig);
            }

            return dst.OrderBy(x => x.Rva);
        }

        public static CliLiteralRecord literal(in ReaderState state, StringHandle handle, Count seq)
        {
            var value = state.Reader.GetString(handle);
            var offset = state.Reader.GetHeapOffset(handle);
            var size = state.Reader.GetHeapSize(HeapIndex.String);
            return new CliLiteralRecord(seq, size, (Address32)offset, value);
        }

        public static CliLiteralRecord name(in ReaderState state, FieldDefinition entry, Count seq)
            => literal(state, entry.Name, seq);

        internal static string format(FieldAttributes src)
            => src.ToString();
    }
}