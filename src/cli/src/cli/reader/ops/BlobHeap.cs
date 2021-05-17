//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    using static Root;

    partial class CliReader
    {
        [Op]
        public CliBlobHeap BlobHeap()
        {
            var offset = HeapOffset(MetadataTokens.BlobHandle(0));
            var @base = Segment.BaseAddress + offset;
            return new CliBlobHeap(@base, HeapSize(HeapIndex.Blob));
        }
    }
}