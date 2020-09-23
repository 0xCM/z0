//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Sourced
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pair<T> pair<T>(IValueSource source, T t = default)
            where T : struct
                => Tuples.pair(one(source, t), one(source, t));
    }
}