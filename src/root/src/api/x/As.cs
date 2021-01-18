//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static FunctionApiClasses;

    partial class XApi
    {
        [MethodImpl(Inline)]
        public static UnaryFunc<A,R> As<A,R>(this UnaryFunc f,A a = default, R r = default)
            => default;

        [MethodImpl(Inline)]
        public static BinaryFunc<A,B,R> As<A,B,R>(this BinaryFunc f,A a = default, B b = default, R r = default)
            => default;

        [MethodImpl(Inline)]
        public static TernaryFunc<A,B,C,R> As<A,B,C,R>(this TernaryFunc f,A a = default, B b = default, C c = default,  R r = default)
            => default;
    }
}