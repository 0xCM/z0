//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static ApiClassKind;

    public readonly partial struct ScalarCalcs
    {
        const NumericKind Closure = Integers;


        // [MethodImpl(Inline), Factory(Add), Closures(Closure)]
        // public static Add<T> add<T>()
        //     where T : unmanaged
        //         => default;

        // [MethodImpl(Inline), Add, Closures(Closure)]
        // public static Span<T> add<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
        //     where T : unmanaged
        //         => gcalc.apply(add<T>(), a, b, dst);

        // [MethodImpl(Inline), Factory(Abs), Closures(SignedInts)]
        // public static Abs<T> abs<T>()
        //     where T : unmanaged
        //         => default;

        // [MethodImpl(Inline), Abs, Closures(SignedInts)]
        // public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
        //     where T : unmanaged
        //         => gcalc.apply(abs<T>(), src, dst);

        [MethodImpl(Inline), Factory(And), Closures(Closure)]
        public static And<T> and<T>()
            where T : unmanaged
                => default(And<T>);

        [MethodImpl(Inline), And, Closures(Closure)]
        public static Span<T> and<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => gcalc.apply(and<T>(), a,b,dst);

        // [Closures(AllNumeric), Add]
        // public readonly struct Add<T> : IBinaryOp<T>, IBinarySpanOp<T>
        //     where T : unmanaged
        // {
        //     [MethodImpl(Inline)]
        //     public readonly T Invoke(T a, T b)
        //         => gmath.add(a, b);

        //     [MethodImpl(Inline)]
        //     public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
        //         => add(a, b, dst);
        // }

        // [Closures(AllNumeric), Abs]
        // public readonly struct Abs<T> : IUnaryOp<T>, IUnarySpanOp<T>
        //     where T : unmanaged
        // {
        //     [MethodImpl(Inline)]
        //     public readonly T Invoke(T a)
        //         => gmath.abs(a);

        //     [MethodImpl(Inline)]
        //     public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
        //         => abs(src,dst);
        // }

        [Closures(Integers), And]
        public readonly struct And<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged
        {
            public T Invoke(T a, T b)
                => gmath.and(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => and(l,r,dst);
        }
    }
}