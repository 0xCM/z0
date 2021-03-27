//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Part;

    partial class XCollective
    {
        [Op, Closures(Closure)]
        public static DataSet<T> ToDataset<T>(this IEnumerable<T> src)
            => new DataSet<T>(src);

        [Op, Closures(Closure)]
        public static DataSet<T> ToDataset<T>(this T[] src)
            => new DataSet<T>(src);

        [Op, Closures(Closure)]
        public static DataSet<T> ToDataset<T>(this Index<T> src)
            => new DataSet<T>(src);
    }
}
