//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiClasses;

    partial struct Api
    {
        [KindFactory]
        public static UnaryOperatorClass unary()
            => default;

        [KindFactory, Closures(Closure)]
        public static UnaryOperatorClass<T> unary<T>(T t = default)
            where T : unmanaged => default;

    }
}