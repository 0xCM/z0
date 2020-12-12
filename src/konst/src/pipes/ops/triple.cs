//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Triple<T> triple<T>(ISource src, T t = default)
            where T : struct
                => Tuples.triple(one(src, t), one(src, t), one(src, t));
    }
}