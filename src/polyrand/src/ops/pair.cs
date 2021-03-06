//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Pair<T> pair<T>(ISource src)
            where T : struct
                => Tuples.pair(next<T>(src), next<T>(src));
    }
}