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

    partial struct DataBlocks
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ref DataBlock<T> from<T>(in Pair<T> src)
            where T : unmanaged
                => ref @as<Pair<T>,DataBlock<T>>(edit(src));
    }
}