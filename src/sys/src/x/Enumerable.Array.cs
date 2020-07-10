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

    partial class XTend
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T[] Array<T>(this IEnumerable<T> src)
            => proxy.array(src);
    }
}