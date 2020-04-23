//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; 
    using static Memories;
    using static Structured;

    partial class gspan
    {
        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> eq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => apply(MSvc.eq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> neq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => apply(MSvc.neq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> lt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => apply(MSvc.lt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> lteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => apply(MSvc.lteq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> gt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => apply(MSvc.gt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<bit> gteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => apply(MSvc.gteq<T>(), l, r, dst);
    }
}