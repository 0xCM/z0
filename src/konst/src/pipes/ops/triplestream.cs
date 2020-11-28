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
    using static z;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static IEnumerable<Triple<T>> triplestream<T>(ISource source, T t = default)
            where T : struct
        {
            while(true)
                yield return triple(source, t);
        }
    }
}