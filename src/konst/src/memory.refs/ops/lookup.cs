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
        [MethodImpl(Inline)]
        public static ref readonly MemorySegment lookup<E>(MemorySlots<E> src, E index)
            where E : unmanaged
                => ref src.Data[z.uint8(index)];
    }
}