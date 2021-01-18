//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
        [KindFactory]
        public static Add add()
            => default;

        [KindFactory]
        public static Sub sub()
            => default;

        [KindFactory]
        public static Mul mul()
            => default;

        [KindFactory]
        public static Div div()
            => default;

        [KindFactory]
        public static Mod mod()
            => default;

        [KindFactory, Closures(Closure)]
        public static Add<T> add<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Sub<T> sub<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Mul<T> mul<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Div<T> div<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Mod<T> mod<T>()
            => default;
    }
}