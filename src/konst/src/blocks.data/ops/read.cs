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
        public static ref DataBlock<T> read<T>(ReadOnlySpan<byte> src, out DataBlock<T> dst)
            where T : unmanaged
        {
            dst = first(recover<DataBlock<T>>(src));
            return ref dst;
        }
    }
}