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

    [ApiHost]
    public readonly struct Heaps
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Heap<T> heap<T>(T[] segments, uint[] offsets)
            => new Heap<T>(segments, offsets);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanHeap<T> cover<T>(Span<T> segments, uint[] offsets)
            => new SpanHeap<T>(segments, offsets);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpanHeap<T> cover<T>(ReadOnlySpan<T> segments, uint[] offsets)
            => new ReadOnlySpanHeap<T>(segments, offsets);

        [MethodImpl(Inline)]
        public static Heap<T,J> cover<T,J>(Index<T> segments, Index<J,uint> offsets)
            where J : unmanaged
                => new Heap<T,J>(segments, offsets);

        public static Heap<T> alloc<S,T>(uint segcount)
            where S : struct
            where T : struct
        {
            var segsize = size<S>();
            var cellsize = size<T>();
            if(cellsize > segsize)
                Throw.sourced("segsize:cellsize ratio invariant fails");
            var entries = alloc<uint>(segcount);
            var segs = alloc<T>(segsize*cellsize);
            return new Heap<T>(segs, entries);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> segment<T>(in Heap<T> src,uint index)
        {
            if(index > src.LastSegment + 1)
                return Span<T>.Empty;
            var start = src.Offsets[index];
            if(index < src.LastSegment)
                return slice(src.Segments.Edit, start, src.Offsets[index + 1] - start);
            else
                return slice(src.Segments.Edit, start);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> segment<T>(in SpanHeap<T> src, uint index)
        {
            if(index > src.LastSegment + 1)
                return Span<T>.Empty;
            var start = src.Offsets[index];
            if(index < src.LastSegment)
                return slice(src.Segments, start, src.Offsets[index + 1] - start);
            else
                return slice(src.Segments, start);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> segment<T>(in ReadOnlySpanHeap<T> src, uint index)
        {
            if(index > src.LastSegment + 1)
                return ReadOnlySpan<T>.Empty;
            var start = src.Offsets[index];
            if(index < src.LastSegment)
                return slice(src.Segments, start, src.Offsets[index + 1] - start);
            else
                return slice(src.Segments, start);
        }
    }
}