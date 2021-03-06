//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    partial struct Sources
    {
        [Op, Closures(Closure)]
        public static IEnumerable<Pair<T>> pairstream<T>(ISource src)
            where T : struct
        {
            while(true)
                yield return pair<T>(src);
        }
    }
}