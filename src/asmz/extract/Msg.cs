//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Msg
    {
        public static MsgPattern<MemoryAddress> TraversingSegments => "Traversing memory segments above the process base address {0}";

        public static MsgPattern<ByteSize,Count> TraversedSegments => "Traversed {0} bytes from {1} accessible regions";

        public static MsgPattern<ProcessMemoryRegion> TraversingRegion => "Traversing {0}";

        public static MsgPattern<MemoryRange> TraversingRange => "Traversing {0}";

        public static MsgPattern<MemoryRange> TraversedRange => "Traversed {0}";

        public static MsgPattern<ByteSize,ProcessMemoryRegion> TraversedRegion => "Traversed {0} bytes from {0}";

        public static MsgPattern<Count> LocatingSegments => "Locating segments for {0} methods";

        public static MsgPattern<Count,Count> LocatedSegments => "Computed {0} segment entries for {0} methods";

        public static MsgPattern<Address16> SegSelectorNotFound => "Selector {0} not found";

    }
}