//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct api
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EQ<T> eq<T>(T a, T b)
            => new EQ<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NEQ<T> neq<T>(T a, T b)
            => new NEQ<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GT<T> gt<T>(T a, T b)
            => new GT<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GE<T> gte<T>(T a, T b)
            => new GE<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LT<T> lt<T>(T a, T b)
            => new LT<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LE<T> lte<T>(T a, T b)
            => new LE<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> eq<T>(T a, T b, bit result)
            => eval<T>(eq(a,b),result);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> neq<T>(T a, T b, bit result)
            => eval<T>(neq(a,b),result);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> lt<T>(T a, T b, bit result)
            => eval<T>(lt(a,b),result);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> lte<T>(T a, T b, bit result)
            => eval<T>(lte(a,b),result);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> gt<T>(T a, T b, bit result)
            => eval<T>(gt(a,b),result);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> gte<T>(T a, T b, bit result)
            => eval<T>(gte(a,b),result);
    }
}