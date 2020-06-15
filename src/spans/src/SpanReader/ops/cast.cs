//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct SpanReader
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : struct
                => Spans.cover(Unsafe.As<byte,T>(ref edit(head(src))), src.Length/Control.size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<ushort> src)
            where T : struct
                => Spans.cover(Unsafe.As<ushort,T>(ref edit(head(src))), (src.Length*2)/Control.size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<uint> src)
            where T : struct
                => Spans.cover(Unsafe.As<uint,T>(ref edit(head(src))), (src.Length*4)/Control.size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> cast<T>(ReadOnlySpan<ulong> src)
            where T : struct
                => Spans.cover(Unsafe.As<ulong,T>(ref edit(head(src))), (src.Length*8)/Control.size<T>());
    }
}