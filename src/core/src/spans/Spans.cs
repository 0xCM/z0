//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct Spans
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint copy<T>(in MemoryCells<T> src, uint offset, uint cells, Span<T> dst)
            where T : unmanaged
        {
            var j=0u;
            var max = min(offset + cells, dst.Length);
            for(var i=offset; i<max; i++)
                seek(dst,j++) = skip(src.View, i);
            return j;
        }


        [MethodImpl(Inline), Op]
        public static SpanWriter writer(Span<byte> dst)
            => new SpanWriter(dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SortedReadOnlySpan<T> sorted<T>(ReadOnlySpan<T> src)
            where T : IComparable<T>
                => new SortedReadOnlySpan<T>(src);
    }
}