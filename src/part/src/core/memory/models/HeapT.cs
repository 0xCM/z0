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

    public readonly struct Heaps
    {
        public static Heap<T> alloc<S,T>(uint segcount)
            where S : struct
            where T : struct
        {
            var segsize = size<S>();
            var cellsize = size<T>();
            if(cellsize > segsize)
                root.@throw("segsize:cellsize ratio invariant fails");
            var entries = alloc<uint>(segcount);
            var segs = alloc<T>(segsize*cellsize);
            return new Heap<T>(segs, entries);
        }

        [MethodImpl(Inline)]
        public static Heap<T> cover<T>(Index<T> segments, Index<uint> entries)
            => new Heap<T>(segments, entries);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static SpanHeap<T> cover<T>(Span<T> segments, Index<uint> entries)
            => new SpanHeap<T>(segments, entries);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpanHeap<T> cover<T>(ReadOnlySpan<T> segments, Index<uint> entries)
            => new ReadOnlySpanHeap<T>(segments, entries);

        [MethodImpl(Inline)]
        public static Heap<T,J> cover<T,J>(Index<T> segments, Index<J,uint> entries)
            where J : unmanaged
                => new Heap<T,J>(segments, entries);
    }

    public readonly struct Heap<T>
    {
        readonly Index<T> Segments;

        readonly Index<uint> Entries;

        readonly uint LastSegment;

        internal Heap(Index<T> segs, Index<uint> entries)
        {
            Segments = segs;
            Entries = entries;
            LastSegment = (uint)entries.Length - 1;
        }

        [MethodImpl(Inline)]
        public Span<T> Segment(uint index)
        {
            if(index > LastSegment + 1)
                return Span<T>.Empty;
            var start = Entries[index];
            if(index < LastSegment)
                return slice(Segments.Edit, start, Entries[index + 1] - start);
            else
                return slice(Segments.Edit, start);
        }
    }

    public readonly ref struct SpanHeap<T>
    {
        readonly Span<T> Segments;

        readonly Index<uint> Entries;

        readonly uint LastSegment;

        internal SpanHeap(Span<T> segs, Index<uint> entries)
        {
            Segments = segs;
            Entries = entries;
            LastSegment = (uint)entries.Length - 1;
        }

        [MethodImpl(Inline)]
        public Span<T> Segment(uint index)
        {
            if(index > LastSegment + 1)
                return Span<T>.Empty;
            var start = Entries[index];
            if(index < LastSegment)
                return slice(Segments, start, Entries[index + 1] - start);
            else
                return slice(Segments, start);
        }
    }

    public readonly ref struct ReadOnlySpanHeap<T>
    {
        readonly ReadOnlySpan<T> Segments;

        readonly Index<uint> Entries;

        readonly uint LastSegment;

        internal ReadOnlySpanHeap(ReadOnlySpan<T> segs, Index<uint> entries)
        {
            Segments = segs;
            Entries = entries;
            LastSegment = (uint)entries.Length - 1;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Segment(uint index)
        {
            if(index > LastSegment + 1)
                return ReadOnlySpan<T>.Empty;
            var start = Entries[index];
            if(index < LastSegment)
                return slice(Segments, start, Entries[index + 1] - start);
            else
                return slice(Segments, start);
        }
    }

    /// <summary>
    /// Defines a <typeparamref name='J'/> indexed <typeparamref name='T'/>-heap
    /// </summary>
    public readonly struct Heap<T,J>
        where J : unmanaged
    {
        readonly Index<T> Segments;

        readonly Index<J,uint> Entries;

        readonly uint LastSegment;

        [MethodImpl(Inline)]
        internal Heap(Index<T> segs, Index<J,uint> entries)
        {
            Segments = segs;
            Entries = entries;
            LastSegment = (uint)entries.Length - 1;
        }

        [MethodImpl(Inline)]
        public Span<T> Segment(J index)
        {
            var _index = bw32(index);
            var _next = @as<uint,J>(_index + 1);
            if(_index > LastSegment + 1)
                return Span<T>.Empty;
            var start = Entries[index];
            if(_index < LastSegment)
                return slice(Segments.Edit, start, Entries[_next] - start);
            else
                return slice(Segments.Edit, start);
        }
    }
}