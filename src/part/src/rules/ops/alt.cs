//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Alt<T> alt<T>(T a, T b)
            => new Alt<T>(a,b);
    }
}