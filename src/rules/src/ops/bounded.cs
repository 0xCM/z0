//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bounded<T> bounded<T>(T min, T max)
            where T : unmanaged
                => new Bounded<T>(min,max);
    }
}