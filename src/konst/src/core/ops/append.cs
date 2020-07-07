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

    partial struct core
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void append<T>(List<T> dst, T item)
            => dst.Add(item);
    }
}