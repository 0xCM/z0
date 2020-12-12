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
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<Pair<T>> pairs<T>(ISource src)
            where T : struct
        {
            while(true)
                yield return Sources.pair<T>(src);
        }
    }
}