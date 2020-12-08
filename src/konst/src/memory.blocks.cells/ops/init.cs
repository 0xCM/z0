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

    partial struct CellBlocks
    {
        [MethodImpl(Inline)]
        public static ref T init<T>(ReadOnlySpan<byte> src, out T dst)
            where T : unmanaged, ICellBlock<T>
        {
            dst = default;
            return ref copy(src, ref dst);
        }

        [MethodImpl(Inline)]
        public static ref T init<T>(ReadOnlySpan<byte> src, in T t0, out T dst)
            where T : unmanaged, ICellBlock<T>
        {
            dst = t0;
            return ref copy(src, ref dst);
        }
    }
}