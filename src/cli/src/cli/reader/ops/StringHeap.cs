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
        public CliStringHeap StringHeap(CliStringKind kind)
            => kind switch
            {
                CliStringKind.User => UserStringHeap(),
                CliStringKind.System => SystemStringHeap(),
                _ => CliStringHeap.Empty
            };

        [Op]
        CliStringHeap UserStringHeap()
        {
            var offset = HeapOffset(MetadataTokens.UserStringHandle(0));
            var @base = Segment.BaseAddress + offset;
            return new CliStringHeap(@base, HeapSize(HeapIndex.UserString), CliHeapKind.UserString);
        }

        [Op]
        CliStringHeap SystemStringHeap()
        {
            var offset = HeapOffset(MetadataTokens.StringHandle(0));
            var @base = Segment.BaseAddress + offset;
            return new CliStringHeap(@base, HeapSize(HeapIndex.String), CliHeapKind.String);
        }
    }
}