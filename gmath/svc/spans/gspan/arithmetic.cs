//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; using static Memories;

    partial class gspan
    {
        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> add<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.add<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> sub<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.sub<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> mul<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.mul<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> div<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.div<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> mod<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.mod<T>(), l, r, dst);

        [MethodImpl(Inline), Closures(Integers)]
        public static Span<T> modmul<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.modmul<T>(), a,b,c, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.negate<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.inc<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.dec<T>(), src, dst);

        [MethodImpl(Inline)]
        public static T sum<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            checked
            {
                var count = src.Length;
                ref readonly var input = ref head(src);
                var result = default(T);

                for(var i=0; i< src.Length; i++)
                    result = gmath.add(result, skip(input,i));
                return result;
            }
        }

        [MethodImpl(Inline)]
        public static T sum<T>(Span<T> src)
            where T : unmanaged
                => sum(src.ReadOnly());

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> clamp<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.clamp<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> square<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.square<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.abs<T>(), src, dst);

        [MethodImpl(Inline)]
        public static Span<bit> even<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.even<T>(), src,dst);

        [MethodImpl(Inline)]
        public static Span<bit> odd<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.odd<T>(), src,dst);
    }
}