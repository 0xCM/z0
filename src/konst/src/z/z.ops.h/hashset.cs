//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static HashSet<T> hashset<T>(params T[] src)
            => root.hashset(src);

        [MethodImpl(Inline)]
        public static HashSet<T> hashset<T>(IEnumerable<T> src)
            => root.hashset(src);
    }
}