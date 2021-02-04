//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ApiClasses
    {
        [KindFactory]
        public static Mul mul()
            => default;

        [KindFactory, Closures(Closure)]
        public static Mul<T> mul<T>()
            => default;
    }
}