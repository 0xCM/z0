//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct MemRefs
    {
        [MethodImpl(Inline), Op]
        public static MemorySlot slot(byte index)
            => new MemorySlot(index);

        [MethodImpl(Inline), Op]
        public static MemorySlot slot(Hex8Seq index)
            => new MemorySlot(index);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemorySlot<I> slot<I>(I index)
            where I : unmanaged
                => new MemorySlot<I>(index);
    }
}