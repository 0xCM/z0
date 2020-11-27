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

    partial class XTend
    {
        public static IEnumerable<Pair<T>> PairStream<T>(this IValueSource source, T t = default)
            where T : struct
                => Sources.pairstream(source,t);
    }
}