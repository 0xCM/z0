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

    partial class XSource
    {
        public static IEnumerable<Triple<T>> TripleStream<T>(this IDataSource src, T t = default)
            where T : struct
                => Sources.triplestream(src, t);
    }
}