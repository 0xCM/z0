//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [Op, Closures(Closure)]
        public static PinnedIndex<T> pin<T>(T[] src)
            where T : unmanaged
                => new PinnedIndex<T>(src);
    }
}