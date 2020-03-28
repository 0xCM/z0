//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static SFuncs;
    using static refs;

    partial class gspan
    {
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> add<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.add<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> sub<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.sub<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> mul<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.mul<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> div<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.div<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> mod<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.mod<T>(), l, r, dst);

        [MethodImpl(Inline), NumericClosures(NumericKind.Integers)]
        public static Span<T> modmul<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.modmul<T>(), a,b,c, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.negate<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.inc<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.dec<T>(), src, dst);

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

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> clamp<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.clamp<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> square<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.square<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.abs<T>(), src, dst);

        [MethodImpl(Inline)]
        public static Span<bit> even<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.even<T>(), src,dst);

        [MethodImpl(Inline)]
        public static Span<bit> odd<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => SFuncs.apply(MathServices.odd<T>(), src,dst);
    }
}