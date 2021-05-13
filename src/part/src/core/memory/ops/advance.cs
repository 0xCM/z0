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
        public static ref MemorySlot advance(ref MemorySlot slot)
        {
            if(slot.Index == MemorySlot.LastKey)
                slot.Index = MemorySlot.FirstKey;
            else
                slot.Index += 1;
            return ref slot;
        }

        [MethodImpl(Inline), Op]
        public static ref MemorySlot<I> advance<I>(ref MemorySlot<I> slot)
            where I : unmanaged
        {
            memory.add(slot.Index, 1);
            return ref slot;
        }
    }
}