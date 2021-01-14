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
    public readonly struct MemorySlots
    {
        public static string[] format<E>(MemorySlots<E> src)
            where E : unmanaged
        {
            var dst = sys.alloc<string>(src.Length);
            format(src,dst);
            return dst;
        }

        [Op, Closures(UnsignedInts)]
        public static void format<E>(MemorySlots<E> src, Span<string> dst)
            where E : unmanaged
        {
            var count = src.Length;
            ref readonly var lead = ref src.Lookup(default(E));
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(lead,i).Format();
        }

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
        readonly MemorySegment[] Data;

        [MethodImpl(Inline)]
        public MemorySlots(MemorySegment[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly MemorySegment Lookup(byte index)
            => ref Data[index];

        public ref readonly MemorySegment this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public byte Length
        {
            [MethodImpl(Inline)]
            get => (byte)Data.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator MemorySlots(MemorySegment[] src)
            => new MemorySlots(src);

       [MethodImpl(Inline)]
        public static implicit operator MemorySlots(Index<MemorySegment> src)
            => new MemorySlots(src);

        [MethodImpl(Inline)]
        public static implicit operator MemorySegment[](MemorySlots src)
            => src.Data;
    }
}