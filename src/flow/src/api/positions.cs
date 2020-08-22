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

    partial struct Flow
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ClosedInterval<ulong> positions<S>(S min, S max)
            where S : unmanaged
                => Intervals.closed(uint64(min), uint64(max));
    }
}