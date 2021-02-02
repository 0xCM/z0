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
        public static Add add()
            => default;

        [KindFactory, Closures(Closure)]
        public static Add<T> add<T>()
            => default;
    }
}