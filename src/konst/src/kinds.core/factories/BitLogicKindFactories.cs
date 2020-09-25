//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
        [KindFactory]
        public static And and()
            => default;

        [KindFactory]
        public static Nand nand()
            => default;

        [KindFactory]
        public static Or or()
            => default;

        [KindFactory]
        public static Nor nor()
            => default;

        [KindFactory]
        public static Xor xor()
            => default;

        [KindFactory]
        public static Xnor xnor()
            => default;

        [KindFactory]
        public static LNot lnot()
            => default;

        [KindFactory]
        public static RNot rnot()
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
    }
}