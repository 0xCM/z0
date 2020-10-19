//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using VS = Sourced;

    [ApiHost]
    public ref struct PolySource
    {

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pair<T> pair<T>(IValueSource source, T t = default)
            where T : struct
                => Tuples.pair(VS.one(source, t), VS.one(source, t));
    }
}