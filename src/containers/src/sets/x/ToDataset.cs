//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XCollective
    {
        [Op, Closures(Closure)]
        public static MutableSet<T> ToDataset<T>(this IEnumerable<T> src)
            => new MutableSet<T>(src);

        [Op, Closures(Closure)]
        public static MutableSet<T> ToDataset<T>(this T[] src)
            => new MutableSet<T>(src);

        [Op, Closures(Closure)]
        public static MutableSet<T> ToDataset<T>(this Index<T> src)
            => new MutableSet<T>(src);
    }
}
