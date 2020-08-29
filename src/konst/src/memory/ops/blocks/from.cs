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
        public static ref StorageBlock<T> from<T>(in Pair<T> src)
            where T : unmanaged
                => ref @as<Pair<T>,StorageBlock<T>>(edit(src));
    }
}