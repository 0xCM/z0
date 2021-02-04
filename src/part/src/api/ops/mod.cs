//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ApiClasses
    {
        [KindFactory]
        public static Mod mod()
            => default;

        [KindFactory, Closures(Closure)]
        public static Mod<T> mod<T>()
            => default;
    }
}