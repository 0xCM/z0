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

    partial struct MemRefs
    {
        [MethodImpl(Inline)]
        public static ref readonly SegRef lookup<E>(MemorySlots<E> src, E index)
            where E : unmanaged
                => ref src.Data[z.uint8(index)];
    }
}