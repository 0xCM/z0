//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    using B = SpanBlocks;

    partial class XSource
    {
        public static IEnumerable<T> Stream<T>(this IDomainSource source, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
        {
            while(true)
            {
                var candidate = source.Next(domain);
                if(filter != null && filter(candidate))
                    yield return candidate;
                else
                    yield return candidate;
            }
        }

        public static IEnumerable<T> Stream<T>(this ISource source)
        {
            while(true)
                yield return source.Next<T>();
        }

    }
}