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

    partial struct StorageBlocks
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static StorageBlock<T> init<T>(in T lo, in T hi)
            where T : unmanaged
                => pair(lo, hi);
    }
}