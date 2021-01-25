//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Api
    {
        [KindFactory]
        public static TernaryOperatorClass ternary()
            => default;

        [KindFactory, Closures(Closure)]
        public static TernaryOperatorClass<T> ternary<T>(T t = default)
            where T : unmanaged => default;
    }
}