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
        public CliGuidHeap GuidHeap()
        {
            var offset = HeapOffset(MetadataTokens.GuidHandle(0));
            var @base = Segment.BaseAddress + offset;
            return new CliGuidHeap(@base, HeapSize(HeapIndex.Guid));
        }
    }
}