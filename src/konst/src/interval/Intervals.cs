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

    [ApiHost]
    public readonly partial struct Intervals
    {
        [MethodImpl(Inline)]
        static ulong left<T>(in ClosedInterval<T> src)
            where T : unmanaged
                => uint64(src.Left);

        [MethodImpl(Inline)]
        static ulong right<T>(in ClosedInterval<T> src)
            where T : unmanaged
                => uint64(src.Right);
    }
}