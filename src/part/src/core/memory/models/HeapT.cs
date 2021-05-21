//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    using api = Heaps;

    public readonly struct Heap<T>
    {
        internal readonly Index<T> Segments;

        internal readonly Index<uint> Offsets;

        internal readonly uint LastSegment;

        [MethodImpl(Inline)]
        internal Heap(Index<T> segs, uint[] offsets)
        {
            Segments = segs;
            Offsets = offsets;
            LastSegment = (uint)offsets.Length - 1;
        }

        [MethodImpl(Inline)]
        public Span<T> Segment(uint index)
            => api.segment(this, index);
    }

    /// <summary>
    /// Defines a <typeparamref name='J'/> indexed <typeparamref name='T'/>-heap
    /// </summary>
    public readonly struct Heap<T,J>
        where J : unmanaged
    {
        internal readonly Index<T> Segments;

        internal readonly Index<J,uint> Offsets;

        internal readonly uint LastSegment;

        [MethodImpl(Inline)]
        internal Heap(Index<T> segs, Index<J,uint> offsets)
        {
            Segments = segs;
            Offsets = offsets;
            LastSegment = (uint)offsets.Length - 1;
        }

        [MethodImpl(Inline)]
        public Span<T> Segment(J index)
        {
            var _index = bw32(index);
            var _next = @as<uint,J>(_index + 1);
            if(_index > LastSegment + 1)
                return Span<T>.Empty;
            var start = Offsets[index];
            if(_index < LastSegment)
                return slice(Segments.Edit, start, Offsets[_next] - start);
            else
                return slice(Segments.Edit, start);
        }
    }
}