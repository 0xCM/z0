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
        public static Sub sub()
            => default;

        [KindFactory, Closures(Closure)]
        public static Sub<T> sub<T>()
            => default;
    }
}