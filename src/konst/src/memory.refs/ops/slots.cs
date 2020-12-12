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
            add(slot.Index, 1);
            return ref slot;
        }

        [MethodImpl(Inline), Op]
        public static ref MemorySlot retreat(ref MemorySlot slot)
        {
            if(slot.Index == MemorySlot.FirstKey)
                slot.Index = MemorySlot.LastKey;
            else
                slot.Index -= 1;
            return ref slot;
        }

        [MethodImpl(Inline), Op]
        public static ref MemorySlot<I> retreat<I>(ref MemorySlot<I> slot)
            where I : unmanaged
        {
            memory.sub(slot.Index, 1);
            return ref slot;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemorySlots<I> slots<I>(Type src)
            where I : unmanaged
                => new MemorySlots<I>(slots(src));

        [MethodImpl(Inline), Op]
        public static MemorySlots slots(Type src)
            => ClrDynamic.jit(src).Map(m => new MemorySegment(m.Address, m.Size));

        [MethodImpl(Inline)]
        public static MemorySlots<E> slots<E,T>(T src)
            where E : unmanaged
                => slots<E>(typeof(T));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemorySlots<E> slots<E>(params MemorySegment[] src)
            where E : unmanaged
                => new MemorySlots<E>(src);
    }
}