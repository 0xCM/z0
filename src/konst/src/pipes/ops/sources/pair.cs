//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Pair<T> pair<T>(ISource src)
            where T : struct
                => Tuples.pair(one<T>(src), one<T>(src));
    }
}