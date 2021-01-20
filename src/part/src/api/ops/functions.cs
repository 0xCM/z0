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
        [KindFactory]
        public static EmitterFunc func(N0 n)
            => default;

        [KindFactory]
        public static UnaryFunc func(N1 n)
            => default;

        [KindFactory]
        public static BinaryFunc func(N2 n)
            => default;

        [KindFactory]
        public static TernaryFunc func(N3 rep)
            => default;

        public static UnaryFunc<A,R> func<A,R>(A a = default, R r = default)
            => default;

        public static BinaryFunc<A,B,R> func<A,B,R>(A a = default, B b = default, R r = default)
            => default;

        public static TernaryFunc<A,B,C,R> func<A,B,C,R>(A a = default, B b = default, C c = default, R r = default)
            => default;
    }
}