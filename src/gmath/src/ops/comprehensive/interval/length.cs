//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class gmath
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T length<T>(Interval<T> src)
            where T : unmanaged
                => abs(sub(src.Right, src.Left));
    }
}

