//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct gAlg
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T grain<T>(in ClosedInterval<T> src, ulong width = 100ul)
            where T : unmanaged, IComparable<T>
                => generic<T>(src.Width/root.min(src.Width, width));
    }
}