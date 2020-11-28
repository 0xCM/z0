//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Collections.Generic;

    using static Konst;

    [ApiHost]
    public readonly struct Streams
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static IEnumerable<Pair<T>> pairs<T>(ISource source, T t = default)
            where T : struct
        {
            while(true)
                yield return Sources.pair(source,t);
        }
    }
}