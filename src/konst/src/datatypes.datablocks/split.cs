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
        public static ref Pair<T> split<T>(in DataBlock<T> src)
            where T : unmanaged
                => ref @as<DataBlock<T>,Pair<T>>(edit(src));
    }
}
