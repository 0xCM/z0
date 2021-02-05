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

    using static Part;

    partial struct Sources
    {

        [Op, Closures(Closure)]
        public static IEnumerable<Pair<T>> pairs<T>(IDataSource src)
            where T : struct
        {
            while(true)
                yield return pair<T>(src);
        }

        [Op, Closures(Closure)]
        public static Pairs<T> pairs<T>(IDataSource src, int count)
            where T : struct
                => pairs<T>(src).Take(count).Array();

        [Op, Closures(Closure)]
        public static Pairs<T> pairs<T>(IDataSource src, Span<Pair<T>> dst)
            where T : struct
                => Sinks.deposit(pairs<T>(src).Take(dst.Length),dst);

        [Op, Closures(Closure)]
        public static Pairs<T> pairs<T>(IDataSource src, Pair<T>[] dst)
            where T : struct
                => Sinks.deposit(pairs<T>(src).Take(dst.Length), dst);
    }
}