//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;

    [ApiHost]
    public readonly partial struct SpanReader : IApiHost<SpanReader>
    {
        public static SpanReader Service => default;


        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<byte> src, int offset, int length)
            => Imagine.cover(Imagine.skip(src,offset), length);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<byte> src, int offset)
            => Imagine.cover(Imagine.skip(src,offset), src.Length - offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : struct
                => Imagine.cover(Imagine.edit<byte,T>(Imagine.first(src)), (src.Length*1)/size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<ushort> src)
            where T : struct
                => Imagine.cover(Imagine.edit<ushort,T>(Imagine.first(src)), (src.Length*2)/size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<uint> src)
            where T : struct
                => Imagine.cover(Imagine.edit<uint,T>(Imagine.first(src)), (src.Length*4)/size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<ulong> src)
            where T : struct
                => Imagine.cover(Imagine.edit<ulong,T>(Imagine.first(src)), (src.Length*8)/size<T>());
    }
}