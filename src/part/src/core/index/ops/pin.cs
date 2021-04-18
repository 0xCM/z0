//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    partial struct Index
    {
        [Op, Closures(Closure)]
        public static PinnedIndex<T> pin<T>(T[] src)
            => new PinnedIndex<T>(src);
    }
}