//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ArithmeticClasses;

    partial struct Api
    {
        [KindFactory]
        public static Mul mul()
            => default;

        [KindFactory, Closures(Closure)]
        public static Mul<T> mul<T>()
            => default;
    }
}