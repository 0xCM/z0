//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Triple<T> triple<T>(T a, T b, T c)
            => Tuples.triple(a,b,c);
    }
}