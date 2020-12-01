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

    partial struct SFx
    {
        /// <summary>
        /// Computes z := y |> f x := f(x,y) for a binary operator f
        /// </summary>
        /// <param name="x">The left domain value</param>
        /// <param name="y">The right domain value</param>
        /// <param name="f">The binary operator</param>
        /// <typeparam name="F">The binary operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static T apply<F,T>(T x, T y, F f)
            where F : IBinaryOp<T>
                => f.Invoke(x,y);

        // [MethodImpl(Inline)]
        // public static Span<Bit32> apply<F,T>(F f, ReadOnlySpan<T> src, Span<Bit32> dst)
        //     where F : IFunc<T,Bit32>
        // {
        //     var count = dst.Length;
        //     ref readonly var input = ref first(src);
        //     ref var target = ref first(dst);
        //     for(var i=0u; i<count; i++)
        //         seek(target, i) = f.Invoke(skip(in input, i));
        //     return dst;
        // }

        // [MethodImpl(Inline)]
        // public static Span<bit> apply<F,T>(F f, ReadOnlySpan<T> src, Span<bit> dst)
        //     where F : IFunc<T,bit>
        // {
        //     var count = dst.Length;
        //     ref readonly var input = ref first(src);
        //     ref var target = ref first(dst);
        //     for(var i=0u; i<count; i++)
        //         seek(target, i) = f.Invoke(skip(in input, i));
        //     return dst;
        // }

        [MethodImpl(Inline)]
        public static Span<T> apply<F,T>(F f, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
            where F : IBinaryOp<T>
        {
            var count = lhs.Length;
            var dst = span<T>(count);
            ref readonly var lSrc = ref first(lhs);
            ref readonly var rSrc = ref first(rhs);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = f.Invoke(skip(lSrc, i), skip(rSrc, i));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> apply<F,T>(F f, Span<T> lhs, Span<T> rhs)
            where T : unmanaged
            where F : IBinaryOp<T>
                => apply(f, lhs.ReadOnly(), rhs.ReadOnly());

        [MethodImpl(Inline)]
        public static Span<Bit32> apply<F,T>(F f, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<Bit32> dst)
            where F : IFunc<T,T,Bit32>
        {
            var count = dst.Length;
            ref readonly var lSrc = ref first(lhs);
            ref readonly var rSrc = ref first(rhs);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = f.Invoke(skip(lSrc, i), skip(rSrc, i));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T3> apply<F,T0,T1,T2,T3>(F f, ReadOnlySpan<T0> A, ReadOnlySpan<T1> B, ReadOnlySpan<T2> C,  Span<T3> dst)
            where F : IFunc<T0,T1,T2,T3>
        {
            var count = dst.Length;
            ref readonly var a = ref first(A);
            ref readonly var b = ref first(B);
            ref readonly var c = ref first(C);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = f.Invoke(skip(a, i), skip(b, i), skip(c, i));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T2> apply<F,T0,T1,T2>(F f, ReadOnlySpan<T0> lhs, ReadOnlySpan<T1> rhs, Span<T2> dst)
            where F : IFunc<T0,T1,T2>
        {
            var count = dst.Length;
            ref readonly var lSrc = ref first(lhs);
            ref readonly var rSrc = ref first(rhs);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = f.Invoke(skip(lSrc, i), skip(rSrc, i));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T2> apply<F,T1,T2>(F f, ReadOnlySpan<T1> src, Span<T2> dst)
            where F : IFunc<T1,T2>
        {
            var count = dst.Length;
            ref readonly var input = ref first(src);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = f.Invoke(skip(input, i));
            return dst;
        }
    }
}