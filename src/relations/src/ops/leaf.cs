//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Relations
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Leaf<T> leaf<T>(T src)
            => new Leaf<T>(src);
    }
}