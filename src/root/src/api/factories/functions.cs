//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static FunctionApiClasses;

    partial struct Api
    {
        [KindFactory, Closures(Closure)]
        public static EmitterFunc<T> func<T>(A0<T> rep)
            where T : unmanaged =>  default;

        [KindFactory, Closures(Closure)]
        public static UnaryFunc<T> func<T>(A1<T> rep)
            where T : unmanaged =>  default;

        [KindFactory, Closures(Closure)]
        public static BinaryFunc<T> func<T>(A2<T> rep)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static TernaryFunc<T> func<T>(A3<T> rep)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static UnaryFunc<T> func<T>(A1 rep)
            where T : unmanaged =>  default;

        [KindFactory, Closures(Closure)]
        public static BinaryFunc<T> func<T>(A2 rep)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static TernaryFunc<T> func<T>(A3 rep)
            where T : unmanaged => default;

        public static UnaryFunc<A,R> func<A,R>(A a = default, R r = default)
            => default;

        public static BinaryFunc<A,B,R> func<A,B,R>(A a = default, B b = default, R r = default)
            => default;

        public static TernaryFunc<A,B,C,R> func<A,B,C,R>(A a = default, B b = default, C c = default, R r = default)
            => default;
    }
}