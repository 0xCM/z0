//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ApiClasses
    {
        [KindFactory]
        public static Div div()
            => default;

        [KindFactory, Closures(Closure)]
        public static Div<T> div<T>()
            => default;
    }
}