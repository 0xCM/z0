//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    partial class XSource
    {
        public static IEnumerable<Triple<T>> TripleStream<T>(this IDataSource src)
            where T : struct
                => Sources.triplestream<T>(src);
    }
}