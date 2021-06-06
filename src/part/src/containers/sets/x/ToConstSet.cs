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
        public static ConstSet<T> ToConstSet<T>(this IEnumerable<T> src)
            => new ConstSet<T>(src);

        [Op, Closures(Closure)]
        public static ConstSet<T> ToConstSet<T>(this T[] src)
            => new ConstSet<T>(src);

        [Op, Closures(Closure)]
        public static ConstSet<T> ToConstSet<T>(this Index<T> src)
            => new ConstSet<T>(src);
    }
}
