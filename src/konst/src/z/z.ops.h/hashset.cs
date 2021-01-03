//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static HashSet<T> hashset<T>(params T[] src)
            => corefunc.hashset(src);

        [MethodImpl(Inline)]
        public static HashSet<T> hashset<T>(IEnumerable<T> src)
            => corefunc.hashset(src);
    }
}