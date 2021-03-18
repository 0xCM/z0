//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XSource
    {
        public static IEnumerable<T> Stream<T>(this IDomainSource src, Interval<T> domain, Func<T,bool> filter = null)
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

        public static IEnumerable<T> Stream<T>(this ISource src)
        {
            while(true)
                yield return src.Next<T>();
        }
    }
}