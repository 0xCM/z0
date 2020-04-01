//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Core;

    partial class gspan
    {
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> eq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.eq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> neq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.neq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> lt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.lt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> lteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.lteq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> gt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.gt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> gteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.gteq<T>(), l, r, dst);
    }
}