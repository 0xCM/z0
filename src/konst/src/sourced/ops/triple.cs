//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct Sourced
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triple<T> triple<T>(IValueSource source, T t = default)
            where T : struct
                => Tuples.triple(one(source, t), one(source, t), one(source, t));
    }
}