//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    partial struct Intervals
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T grain<T>(in ClosedInterval<T> src, ulong width = 100ul)
            where T : unmanaged
                => generic<T>(src.Width/min(src.Width, 100ul));
    }
}