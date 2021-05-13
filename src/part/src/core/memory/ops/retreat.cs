//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline), Op]
        public static ref MemorySlot retreat(ref MemorySlot slot)
        {
            if(slot.Index == MemorySlot.FirstKey)
                slot.Index = MemorySlot.LastKey;
            else
                slot.Index -= 1;
            return ref slot;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref MemorySlot<I> retreat<I>(ref MemorySlot<I> slot)
            where I : unmanaged
        {
            memory.sub(slot.Index, 1);
            return ref slot;
        }
    }
}