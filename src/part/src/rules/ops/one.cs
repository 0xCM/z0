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
        public static One<T> one<T>(T term)
            => new One<T>(term);
    }
}