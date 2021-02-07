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
        public static void iter<T>(IEnumerable<T> src, Action<T> action, bool pll = false)
            => root.iter(src, action, pll);
    }
}