//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    partial struct Index
    {
        [Op, Closures(Closure)]
        public static IEnumerable<T> enumerate<T>(ReadOnlySpan<T> src)
            => src.ToArray();
        // {
        //     var e = src.GetEnumerator();
        //     while(e.MoveNext())
        //         yield return e.Current;
        // }


        [Op, Closures(Closure)]
        public static IEnumerator<T> enumerator<T>(ReadOnlySpan<T> src)
            => enumerate(src).GetEnumerator();
    }
}
