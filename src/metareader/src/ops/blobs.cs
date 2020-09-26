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

    using static Konst;

    partial class PeTableReader
    {
        [Op]
        public static ImageBlob blob(in ReaderState state, BlobHandle handle, Count seq)
        {
            var offset = (Address32)state.Reader.GetHeapOffset(handle);
            var value = state.Reader.GetBlobBytes(handle) ?? sys.empty<byte>();
            var size = state.Reader.GetHeapSize(HeapIndex.Blob);
            return new ImageBlob(seq, size, offset,value);
        }

        public static ReadOnlySpan<ImageBlob> blobs(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.Blob);
            if (size == 0)
                return Span<ImageBlob>.Empty;

            var handle = MetadataTokens.BlobHandle(0);
            var i=0;
            var values = new List<ImageBlob>();
            do
            {
                var value = reader.GetBlobBytes(handle);
                values.Add(new ImageBlob(i++, size, (Address32)reader.GetHeapOffset(handle), reader.GetBlobBytes(handle)));
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
    }
}