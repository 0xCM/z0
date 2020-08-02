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
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;    
    using static PartRecords;
        
    partial class ImgMetadataReader
    {        
        internal static ImgBlobRecord record(in ReaderState state, BlobHandle handle, int seq)
        {
            var offset = state.Reader.GetHeapOffset(handle);            
            var value = state.Reader.GetBlobBytes(handle) ?? Root.array<byte>();
            var size = state.Reader.GetHeapSize(HeapIndex.Blob);
            return new ImgBlobRecord(seq, size,offset,value);                    
        }

        internal static ReadOnlySpan<ImgBlobRecord> blobs(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.Blob);
            if (size == 0)
                return Span<ImgBlobRecord>.Empty;

            var handle = MetadataTokens.BlobHandle(0);
            var i=0;
            var values = new List<ImgBlobRecord>();
            do
            {
                var value = reader.GetBlobBytes(handle);
                values.Add(new ImgBlobRecord(
                    Sequence: i++,
                    HeapSize: size, 
                    Offset: reader.GetHeapOffset(handle), 
                    Value: reader.GetBlobBytes(handle)
                    ));

                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
    }
}