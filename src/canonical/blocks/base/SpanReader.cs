//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Seed;
    using static Control;

    [ApiHost]
    public readonly struct SpanReader : IApiHost<SpanReader>
    {
        public static SpanReader Service => default;
                
        [MethodImpl(Inline), Op]
        public ref readonly byte cell(ReadOnlySpan<byte> src, int offset)
            => ref skip(src, offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T cell<T>(ReadOnlySpan<T> src, int offset)
            => ref skip(src, offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> imagine<T>(ReadOnlySpan<byte> src)
            where T : struct
                => Spans.cover(Unsafe.As<byte,T>(ref edit(head(src))), src.Length/size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> imagine<T>(ReadOnlySpan<ushort> src)
            where T : struct
                => Spans.cover(Unsafe.As<ushort,T>(ref edit(head(src))), (src.Length*2)/size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> imagine<T>(ReadOnlySpan<uint> src)
            where T : struct
                => Spans.cover(Unsafe.As<uint,T>(ref edit(head(src))), (src.Length*4)/size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> imagine<T>(ReadOnlySpan<ulong> src)
            where T : struct
                => Spans.cover(Unsafe.As<ulong,T>(ref edit(head(src))), (src.Length*8)/size<T>());

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<byte> src, int offset, int length)
            => src.Slice(offset,length);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<byte> src, int offset)
            => src.Slice(offset);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset)
            => src.Slice(offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> slice<T>(ReadOnlySpan<T> src, int offset, int length)
            => Spans.cover(skip(src,offset), length);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> tslice<T>(ReadOnlySpan<byte> src, int tOffset, int tLength)
            where T : struct
                => slice<T>(cast<T>(src), tOffset, tLength);
    }
}