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
    using static As;

    [ApiHost]
    public readonly partial struct SpanReader : IApiHost<SpanReader>
    {
        public static SpanReader Service => default;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<byte> src, int offset, int length)
            => cover(Root.skip(src,offset), length);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<byte> src, int offset)
            => cover(Root.skip(src,offset), src.Length - offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : struct
                => cover(As.edit<byte,T>(first(src)), (src.Length*1)/Root.size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<ushort> src)
            where T : struct
                => cover(As.edit<ushort,T>(As.first(src)), (src.Length*2)/Root.size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<uint> src)
            where T : struct
                => cover(As.edit<uint,T>(first(src)), (src.Length*4)/Root.size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<ulong> src)
            where T : struct
                => cover(As.edit<ulong,T>(first(src)), (src.Length*8)/Root.size<T>());
    }
}