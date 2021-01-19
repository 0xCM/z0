//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Api
    {
        [KindFactory]
        public static UnaryClass unary()
            => default;

        [KindFactory, Closures(Closure)]
        public static UnaryClass<T> unary<T>(T t = default)
            where T : unmanaged => default;
    }
}