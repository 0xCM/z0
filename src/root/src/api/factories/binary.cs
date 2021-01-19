//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Api
    {
        [KindFactory]
        public static BinaryClass binary()
            => default;

        [KindFactory, Closures(Closure)]
        public static BinaryClass<T> binary<T>(T t = default)
            where T : unmanaged => default;
    }
}