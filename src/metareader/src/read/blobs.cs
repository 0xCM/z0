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
    using static MetadataRecords;
    using static Root;
    
    partial class MetadataRead
    {        
        internal static ReadOnlySpan<BlobRecord> blobs(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.Blob);
            if (size == 0)
                return Span<BlobRecord>.Empty;

            var handle = MetadataTokens.BlobHandle(0);
            var i=0;
            var values = new List<BlobRecord>();
            do
            {
                var value = reader.GetBlobBytes(handle);
                values.Add(new BlobRecord(
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