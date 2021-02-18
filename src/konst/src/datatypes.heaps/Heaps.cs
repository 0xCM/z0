//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct Heaps
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Heap<T> create<T>(T[] content, HeapSegment[] segments)
            where T : unmanaged
                => new Heap<T>(content, segments);

        [MethodImpl(Inline), Op]
        public static HeapSegment segment(uint offset, uint count)
            => new HeapSegment(offset, count);
    }
}