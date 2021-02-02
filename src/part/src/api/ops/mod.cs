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
        public static Mod mod()
            => default;

        [KindFactory, Closures(Closure)]
        public static Mod<T> mod<T>()
            => default;
    }
}