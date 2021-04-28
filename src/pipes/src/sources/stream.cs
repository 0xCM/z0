//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Part;

    partial struct Sources
    {
        [Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(IDomainSource src, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
        {
            while(true)
            {
                var candidate = src.Next(domain);
                if(filter != null && filter(candidate))
                    yield return candidate;
                else
                    yield return candidate;
            }
        }

        [Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(ISource src)
        {
            while(true)
                yield return src.Next<T>();
        }
    }
}