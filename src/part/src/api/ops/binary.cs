//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Api
    {
        [KindFactory]
        public static BinaryOperatorClass binary()
            => default;

        [KindFactory, Closures(Closure)]
        public static BinaryOperatorClass<T> binary<T>(T t = default)
            where T : unmanaged => default;
    }
}