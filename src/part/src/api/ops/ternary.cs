//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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