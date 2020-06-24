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

    partial struct ReaderInternals
    {
        internal static string literal(in ReaderState state, NamespaceDefinitionHandle handle, int seq)
            => literal(state, handle, seq, (r, h) => "'" + r.GetString((NamespaceDefinitionHandle)h) + "'");

        internal static string literal(in ReaderState state, GuidHandle handle, int seq)
            => literal(state, handle,seq, (r, h) => "{" + r.GetGuid((GuidHandle)h) + "}");

        internal static string literal(in ReaderState state, StringHandle handle, int seq)
            => literal(state, handle,seq, (r, h) => "'" + r.GetString((StringHandle)h) + "'");

        internal static string literal(in ReaderState state, BlobHandle handle, int seq)
            => literal(state, handle, seq, (r, h) => BitConverter.ToString(r.GetBlobBytes((BlobHandle)h)));
        
        internal static string literal(in ReaderState state, Handle handle, int seq, Func<MetadataReader, Handle, string> getValue)
        {
            if (handle.IsNil)
                return "null";

            if (state.Aggregator)
                return literal(state, handle, state.Aggregator.Value, getValue);

            var offset = state.Reader.GetHeapOffset(handle);
            var offsetFmt = PaddedHex(offset);

            if (state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.EncLog) > 0)
                return offsetFmt;

            var value = getValue(state.Reader, handle);
            return $"{offsetFmt} | {value}";            
        }

        internal static string literal(in ReaderState state, Handle handle, MetadataAggregator aggregator, Func<MetadataReader, Handle, string> getValue)
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