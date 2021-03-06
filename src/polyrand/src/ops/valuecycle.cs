//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ValueCycle<T> valuecycle<T>(Index<T> src)
            where T : unmanaged
                => new ValueCycle<T>(src);
    }
}