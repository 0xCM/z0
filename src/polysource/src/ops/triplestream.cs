//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<Triple<T>> triplestream<T>(ISource source)
            where T : struct
        {
            while(true)
                yield return triple<T>(source);
        }
    }
}