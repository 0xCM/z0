//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = Kinds;

    partial class Kinds
    {
        [KindFactory]
        public static K.EmitterFunc func(N0 n)
            => default;

        [KindFactory]
        public static K.UnaryFunc func(N1 n)
            => default;

        [KindFactory]
        public static K.BinaryFunc func(N2 n)
            => default;

        [KindFactory]
        public static K.TernaryFunc func(N3 rep)
            => default;

        [KindFactory, Closures(Closure)]
        public static K.EmitterFunc<T> func<T>(A0<T> rep)
            where T : unmanaged =>  default;

        [KindFactory, Closures(Closure)]
        public static K.UnaryFunc<T> func<T>(A1<T> rep)
            where T : unmanaged =>  default;

        [KindFactory, Closures(Closure)]
        public static K.BinaryFunc<T> func<T>(A2<T> rep)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static K.TernaryFunc<T> func<T>(A3<T> rep)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static K.UnaryFunc<T> func<T>(A1 rep)
            where T : unmanaged =>  default;

        [KindFactory, Closures(Closure)]
        public static K.BinaryFunc<T> func<T>(A2 rep)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static K.TernaryFunc<T> func<T>(A3 rep)
            where T : unmanaged => default;

        public static K.UnaryFunc<A,R> func<A,R>(A a = default, R r = default)
            => default;

        public static K.BinaryFunc<A,B,R> func<A,B,R>(A a = default, B b = default, R r = default)
            => default;

        public static K.TernaryFunc<A,B,C,R> func<A,B,C,R>(A a = default, B b = default, C c = default, R r = default)
            => default;
    }
}