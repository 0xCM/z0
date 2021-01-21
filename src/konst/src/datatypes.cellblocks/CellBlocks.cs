//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;


    [ApiHost]
    public readonly partial struct CellBlocks
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        internal static ref T copy<T>(ReadOnlySpan<byte> src, ref T dst)
            where T : unmanaged
        {
            dst = first(recover<T>(src));
            return ref dst;
        }
    }
}