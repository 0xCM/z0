//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static SFx;

    partial class gspan
    {
        [MethodImpl(Inline), Add, Closures(Integers)]
        public static Span<T> add<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.add<T>(), l, r, dst);

        [MethodImpl(Inline), Sub, Closures(Integers)]
        public static Span<T> sub<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.sub<T>(), l, r, dst);

        [MethodImpl(Inline), Mul, Closures(Integers)]
        public static Span<T> mul<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.mul<T>(), l, r, dst);

        [MethodImpl(Inline), Div, Closures(Integers)]
        public static Span<T> div<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.div<T>(), l, r, dst);

        [MethodImpl(Inline), Mod, Closures(Integers)]
        public static Span<T> mod<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.mod<T>(), l, r, dst);

        [MethodImpl(Inline), ModMul, Closures(Integers)]
        public static Span<T> modmul<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.modmul<T>(), a,b,c, dst);

        [MethodImpl(Inline), Negate, Closures(Integers)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.negate<T>(), src, dst);

        [MethodImpl(Inline), Inc, Closures(Integers)]
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.inc<T>(), src, dst);

        [MethodImpl(Inline), Dec, Closures(Integers)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.dec<T>(), src, dst);

        [MethodImpl(Inline), Clamp, Closures(Integers)]
        public static Span<T> clamp<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.clamp<T>(), l, r, dst);

        [MethodImpl(Inline), Square, Closures(Integers)]
        public static Span<T> square<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.square<T>(), src, dst);

        [MethodImpl(Inline), Abs, Closures(Integers)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.abs<T>(), src, dst);

        [MethodImpl(Inline), Even, Closures(Integers)]
        public static Span<bit> even<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => apply(MSvc.even<T>(), src,dst);

        [MethodImpl(Inline), Odd, Closures(Integers)]
        public static Span<bit> odd<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => apply(MSvc.odd<T>(), src,dst);

        [MethodImpl(Inline), Sum, Closures(Integers)]
        public static T sum<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            checked
            {
                var count = src.Length;
                ref readonly var input = ref first(src);
                var result = default(T);

                for(var i=0; i<src.Length; i++)
                    result = gmath.add(result, skip(input,i));
                return result;
            }
        }

        [MethodImpl(Inline)]
        public static T sum<T>(Span<T> src)
            where T : unmanaged
                => sum(src.ReadOnly());
    }
}