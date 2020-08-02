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
    using static Root;
    using static ReaderInternals;
    
    partial class ImgMetadataReader
    {        
        internal static ReadOnlySpan<ImgFieldRva> fieldrva(in ReaderState state)        
        {                
            var reader = state.Reader;                
            var offset = reader.GetTableMetadataOffset(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);
            var rowcount = reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);
            var rowsize = reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);

            var rvaCount = FieldRvaCount(state);
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = sys.alloc<ImgFieldRva>(count);
            
            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref z.skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                var td = reader.GetTypeDefinition(entry.GetDeclaringType());
                var tName = reader.GetString(td.Name);
            
                var sig = signature(state, entry, i);
                var name = reader.GetString(entry.Name);
                var va = entry.GetRelativeVirtualAddress();
                dst[i] = new ImgFieldRva(tName, name, sig, (uint)va);                    
            }
            
            return dst.OrderBy(x => x.Rva);
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

        internal static ImgLiteralFieldRecord record(in ReaderState state, StringHandle handle, int seq)
        {
            var value = state.Reader.GetString(handle);
            var offset = state.Reader.GetHeapOffset(handle);
            var size = state.Reader.GetHeapSize(HeapIndex.String);
            return new ImgLiteralFieldRecord(seq, size, offset, value);                    
        }

        internal static ImgLiteralFieldRecord name(in ReaderState state, FieldDefinition entry, int seq)
            => record(state, entry.Name, seq);
        
        internal static string format(FieldAttributes src)
            => src.ToString();

        internal static ImgBlobRecord signature(in ReaderState state, FieldDefinition entry, int seq)
            => record(state, entry.Signature, seq);

        internal static ReadOnlySpan<ImgFieldRecord> fields(in ReaderState state)
        {
            var reader = state.Reader;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = Spans.alloc<ImgFieldRecord>(count);
            
            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                int offset = entry.GetOffset();

                seek(dst,i) = new ImgFieldRecord(
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