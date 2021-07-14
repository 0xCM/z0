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
        public static Triple<T> triple<T>(ISource src)
            where T : struct
                => Tuples.triple(next<T>(src), next<T>(src), next<T>(src));
    }
}