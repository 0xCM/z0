//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial struct gAlg
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T length<T>(Interval<T> src)
            where T : unmanaged
                => gmath.abs(gmath.sub(src.Right, src.Left));
    }
}