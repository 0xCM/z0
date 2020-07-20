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
        internal static ReadOnlySpan<FieldRvaRecord> fieldrva(in ReaderState state)        
        {                
            var reader = state.Reader;                
            var offset = reader.GetTableMetadataOffset(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);
            var rowcount = reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);
            var rowsize = reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);

            var rvaCount = FieldRvaCount(state);
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = sys.alloc<FieldRvaRecord>(count);
            
            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref Root.skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);

                var sig = signature(state, entry, i);
                dst[i] = new FieldRvaRecord(
                    Sequence: i, 
                    Signature: sig, 
                    Rva: (uint)entry.GetRelativeVirtualAddress()
                );                    
            }
            
            return dst;
        }

        internal static Pairings<string,Address32> methods(in ReaderState state)
        {
            var reader = state.Reader;
            var defs = reader.MethodDefinitions.ToReadOnlySpan();
            var methods = Spans.alloc<Paired<string,Address32>>(defs.Length);
            for(var i=0; i<defs.Length; i++)
            {
                var def = reader.GetMethodDefinition(skip(defs, i));
                var rva = (Address32)(uint)def.RelativeVirtualAddress;
                var name = reader.GetString(def.Name);
                seek(methods,i) = (name,rva);            
            }
            return methods;
        }

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
                int offset = entry.GetOffset();

                seek(dst,i) = new FieldRecord(
                    Sequence: i,
                    Name: name(state, entry, i),
                    SigCode: signature(state, entry, i),
                    Attributes: format(entry.Attributes)                    
                );
            }
            return dst;
        }
    }
}