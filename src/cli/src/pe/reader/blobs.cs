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

    using Z0.Schemas.Ecma;

    partial class PeTableReader
    {
        [Op]
        public BlobRow Blob(BlobHandle handle, Count seq)
        {
            var offset = (Address32)State.Reader.GetHeapOffset(handle);
            var value = State.Reader.GetBlobBytes(handle) ?? sys.empty<byte>();
            var size = State.Reader.GetHeapSize(HeapIndex.Blob);
            var row = new BlobRow();
            row.Sequence = seq;
            row.HeapSize = size;
            row.Offset = offset;
            row.Data = value;
            row.DataSize = row.Data.Length;
            return row;
        }

        public ReadOnlySpan<BlobRow> Blobs()
        {
            var reader = State.Reader;
            int size = reader.GetHeapSize(HeapIndex.Blob);
            if (size == 0)
                return Span<BlobRow>.Empty;

            var handle = MetadataTokens.BlobHandle(1);
            var i=0;
            var values = new List<BlobRow>();
            do
            {
                var value = reader.GetBlobBytes(handle);
                var row = new BlobRow();
                row.Sequence = i++;
                row.HeapSize = size;
                row.Offset = (Address32)reader.GetHeapOffset(handle);
                row.Data = reader.GetBlobBytes(handle);
                row.DataSize = row.Data.Length;
                values.Add(row);
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
    }
}