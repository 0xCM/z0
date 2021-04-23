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

    using static Part;
    using static Images;

    partial class ImageMetaReader
    {
        [Op]
        public MetadataBlob ReadBlob(BlobHandle handle, Count seq)
        {
            var offset = (Address32)MD.GetHeapOffset(handle);
            var value = MD.GetBlobBytes(handle) ?? sys.empty<byte>();
            var size = MD.GetHeapSize(HeapIndex.Blob);
            var row = new MetadataBlob();
            row.Sequence = seq;
            row.HeapSize = size;
            row.Offset = offset;
            row.Data = value;
            row.DataSize = row.Data.Length;
            return row;
        }

        public ReadOnlySpan<MetadataBlob> ReadBlobs()
        {
            int size = MD.GetHeapSize(HeapIndex.Blob);
            if (size == 0)
                return Span<MetadataBlob>.Empty;

            var handle = MetadataTokens.BlobHandle(1);
            var i=0;
            var values = new List<MetadataBlob>();
            do
            {
                var value = MD.GetBlobBytes(handle);
                var row = new MetadataBlob();
                row.Sequence = i++;
                row.HeapSize = size;
                row.Offset = (Address32)MD.GetHeapOffset(handle);
                row.Data = MD.GetBlobBytes(handle);
                row.DataSize = row.Data.Length;
                values.Add(row);
                handle = MD.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }

        [MethodImpl(Inline), Op]
        public BinaryCode ReadBlobData(BlobHandle src)
            => MD.GetBlobBytes(src);

        [MethodImpl(Inline), Op]
        public ref BinaryCode ReadBlobData(BlobHandle src, ref BinaryCode dst)
        {
            dst = ReadBlobData(src);
            return ref dst;
        }
    }
}