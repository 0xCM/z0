//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Delta<T> delta<T>(T a, T b)
            => new Delta<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Delta untype<T>(Delta<T> src)
            => src;
    }
}