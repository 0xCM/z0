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
    using static ReaderInternals;

    partial class PeTableReader
    {
        public static ReadOnlySpan<ImageFieldRvaRecord> fieldrva(in ReaderState state)
        {
            var reader = state.Reader;
            var offset = reader.GetTableMetadataOffset(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);
            var rowcount = reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);
            var rowsize = reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);

            var rvaCount = FieldRvaCount(state);
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = sys.alloc<ImageFieldRvaRecord>(count);

            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref z.skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                var td = reader.GetTypeDefinition(entry.GetDeclaringType());
                var tName = reader.GetString(td.Name);
                var sig = signature(state, entry, i);
                var name = reader.GetString(entry.Name);
                var va = entry.GetRelativeVirtualAddress();
                dst[i] = new ImageFieldRvaRecord((Address32)va, tName, name, sig);
            }

            return dst.OrderBy(x => x.Rva);
        }

        public static ImageLiteralFieldTable record(in ReaderState state, StringHandle handle, Count32 seq)
        {
            var value = state.Reader.GetString(handle);
            var offset = state.Reader.GetHeapOffset(handle);
            var size = state.Reader.GetHeapSize(HeapIndex.String);
            return new ImageLiteralFieldTable(seq, size, (Address32)offset, value);
        }

        public static ImageLiteralFieldTable name(in ReaderState state, FieldDefinition entry, Count32 seq)
            => record(state, entry.Name, seq);

        internal static string format(FieldAttributes src)
            => src.ToString();

        internal static ImgBlobRecord signature(in ReaderState state, FieldDefinition entry, Count32 seq)
            => blob(state, entry.Signature, seq);

        public static ReadOnlySpan<ImageFieldTable> fields(in ReaderState state)
        {
            var reader = state.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = Spans.alloc<ImageFieldTable>(count);

            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                int offset = entry.GetOffset();

                seek(dst,i) = new ImageFieldTable(i, name(state, entry, i), signature(state, entry, i), format(entry.Attributes));
            }
            return dst;
        }
    }
}