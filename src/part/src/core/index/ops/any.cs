//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Index
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool any<T>(Index<T> src)
            => src.Count != 0;
    }
}