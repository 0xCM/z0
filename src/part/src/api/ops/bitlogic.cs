//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ApiClasses
    {
        [KindFactory]
        public static And and()
            => default;

        [KindFactory]
        public static Or or()
            => default;

        [KindFactory]
        public static Xor xor()
            => default;

        [KindFactory]
        public static Nand nand()
            => default;

        [KindFactory]
        public static Nor nor()
            => default;

        [KindFactory]
        public static Xnor xnor()
            => default;

        [KindFactory]
        public static Not not()
            => default;

        [KindFactory]
        public static Impl impl()
            => default;

        [KindFactory]
        public static NonImpl nonimpl()
            => default;

        [KindFactory]
        public static CImpl cimpl()
            => default;

        [KindFactory]
        public static CNonImpl cnonimpl()
            => default;

        [KindFactory]
        public static LNot lnot()
            => default;

        [KindFactory]
        public static RNot rnot()
            => default;

        [KindFactory]
        public static Select select()
            => default;

        [KindFactory, Closures(Closure)]
        public static And<T> and<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Nand<T> nand<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Or<T> or<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Nor<T> nor<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Impl<T> impl<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static NonImpl<T> nonimpl<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static CImpl<T> cimpl<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static CNonImpl<T> cnonimpl<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Not<T> not<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Select<T> select<T>()
            => default;
    }
}