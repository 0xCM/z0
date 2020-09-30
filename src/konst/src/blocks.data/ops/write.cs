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
        public static ref ReadOnlySpan<byte> write<T>(in DataBlock<T> src, out ReadOnlySpan<byte> dst)
            where T : unmanaged
        {
            dst = bytes(src);
            return ref dst;
        }
    }
}