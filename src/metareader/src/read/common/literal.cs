//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Seed;    
    using static MetadataRecords;
    using static Control;
    
    partial class MetaRead
    {        
        internal static string Literal(in MetaReaderState state, NamespaceDefinitionHandle handle)
            => Literal(state, handle, (r, h) => "'" + r.GetString((NamespaceDefinitionHandle)h) + "'");

        internal static string Literal(in MetaReaderState state, GuidHandle handle)
            => Literal(state, handle, (r, h) => "{" + r.GetGuid((GuidHandle)h) + "}");

        internal static string Literal(in MetaReaderState state, StringHandle handle)
            => Literal(state, handle, (r, h) => "'" + r.GetString((StringHandle)h) + "'");

        internal static string Literal(in MetaReaderState state, BlobHandle handle)
            => Literal(state, handle, (r, h) => BitConverter.ToString(r.GetBlobBytes((BlobHandle)h)));
        
        internal static LiteralValue LiteralValue(in MetaReaderState state, StringHandle handle)
        {
            var value = state.Reader.GetString(handle);
            var offset = state.Reader.GetHeapOffset(handle);
            return new LiteralValue(offset, value);                    
        }

        internal static BlobValue LiteralValue(in MetaReaderState state, BlobHandle handle)
        {
            var offset = state.Reader.GetHeapOffset(handle);
            var value = state.Reader.GetBlobBytes(handle) ?? Control.array<byte>();
            return new BlobValue(0,offset,value);                    
        }

        internal static string Literal(in MetaReaderState state, Handle handle, Func<MetadataReader, Handle, string> getValue)
        {
            if (handle.IsNil)
                return "null";

            if (state.Aggregator)
                return Literal(state, handle, state.Aggregator.Value, getValue);

            var offset = state.Reader.GetHeapOffset(handle);
            var offsetFmt = PaddedHex(offset);

            if (state.Reader.GetTableRowCount(TableIndex.EncLog) > 0)
                return offsetFmt;

            var value = getValue(state.Reader, handle);
            return $"{offsetFmt} | {value}";            
        }

        internal static string Literal(in MetaReaderState state, Handle handle, MetadataAggregator aggregator, Func<MetadataReader, Handle, string> getValue)
        {        
            int generation;
            Handle generationHandle = aggregator.GetGenerationHandle(handle, out generation);

            var generationReader = state.Readers[generation];
            string value = getValue(generationReader, generationHandle);
            int offset = generationReader.GetHeapOffset(handle);
            int generationOffset = generationReader.GetHeapOffset(generationHandle);

            if (offset == generationOffset)
                return string.Format("{0} (#{1:x})", value, offset);
            else
                return string.Format("{0} (#{1:x}/{2:x})", value, offset, generationOffset);            
        }
    }
}