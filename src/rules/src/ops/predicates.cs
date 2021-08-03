//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline)]
        public static CmpEval<T> eval<T>(T pred, bit eval)
            where T : ICmpPred
                => new CmpEval<T>(pred,eval);

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
        public static GTE<T> gte<T>(T a, T b)
            => new GTE<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LT<T> lt<T>(T a, T b)
            => new LT<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LTE<T> lte<T>(T a, T b)
            => new LTE<T>(a,b);

        [MethodImpl(Inline)]
        public static CmpEval<EQ<T>> eq<T>(T a, T b, bit result)
            => eval(eq(a,b),result);

        [MethodImpl(Inline)]
        public static CmpEval<NEQ<T>> neq<T>(T a, T b, bit result)
            => eval(neq(a,b),result);

        [MethodImpl(Inline)]
        public static CmpEval<LT<T>> lt<T>(T a, T b, bit result)
            => eval(lt(a,b),result);

        [MethodImpl(Inline)]
        public static CmpEval<LTE<T>> lte<T>(T a, T b, bit result)
            => eval(lte(a,b),result);

        [MethodImpl(Inline)]
        public static CmpEval<GT<T>> gt<T>(T a, T b, bit result)
            => eval(gt(a,b),result);

        [MethodImpl(Inline)]
        public static CmpEval<GTE<T>> gte<T>(T a, T b, bit result)
            => eval(gte(a,b),result);
    }
}