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
        public static ref T first<T>(T[] src)
            => ref memory.first(src);
    }
}