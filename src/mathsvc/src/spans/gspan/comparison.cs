//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    partial class gspan
    {
        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bool> dst)
            where T : unmanaged
                => apply(MSvc.eq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<Bit32> neq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<Bit32> dst)
            where T : unmanaged
                => apply(MSvc.neq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<Bit32> lt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<Bit32> dst)
            where T : unmanaged
                => apply(MSvc.lt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<Bit32> lteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<Bit32> dst)
            where T : unmanaged
                => apply(MSvc.lteq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<Bit32> gt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<Bit32> dst)
            where T : unmanaged
                => apply(MSvc.gt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<Bit32> gteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<Bit32> dst)
            where T : unmanaged
                => apply(MSvc.gteq<T>(), l, r, dst);
    }
}