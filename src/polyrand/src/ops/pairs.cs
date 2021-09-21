//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    partial struct Sources
    {
        [Op, Closures(Closure)]
        public static IEnumerable<Pair<T>> pairs<T>(ISource src)
            where T : struct
        {
            while(true)
                yield return pair<T>(src);
        }

        [Op, Closures(Closure)]
        public static Pairs<T> pairs<T>(ISource src, int count)
            where T : struct
                => pairs<T>(src).Take(count).Array();
   }
}