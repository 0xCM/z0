//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Heap<T>
    {
        readonly Index<T> Content;

        readonly Index<HeapSegment> Segments;

        [MethodImpl(Inline)]
        public Heap(T[] content, HeapSegment[] segments)
        {
            Content = content;
            Segments = segments;
        }

        [MethodImpl(Inline)]
        public Span<T> Segment(uint index)
        {
            ref readonly var segment = ref Segments[index];
            ref var t0 = ref Content[segment.Offset];
            return memory.cover<T>(t0, segment.Count);
        }
    }
}