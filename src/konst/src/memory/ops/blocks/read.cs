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
        public static ref StorageBlock<T> read<T>(ReadOnlySpan<byte> src, out StorageBlock<T> dst)
            where T : unmanaged
        {
            dst = first(recover<StorageBlock<T>>(src));
            return ref dst;
        }
    }
}