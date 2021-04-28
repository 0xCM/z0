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

    public readonly struct MemorySlots
    {
       readonly MemSeg[] Data;

        public static string[] format<E>(MemorySlots<E> src)
            where E : unmanaged
        {
            var dst = alloc<string>(src.Length);
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

        [MethodImpl(Inline)]
        public MemorySlots(MemSeg[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly MemSeg Lookup(byte index)
            => ref Data[index];

        public ref readonly MemSeg this[byte index]
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
        public static implicit operator MemorySlots(MemSeg[] src)
            => new MemorySlots(src);

        [MethodImpl(Inline)]
        public static implicit operator MemorySlots(Index<MemSeg> src)
            => new MemorySlots(src);

        [MethodImpl(Inline)]
        public static implicit operator MemSeg[](MemorySlots src)
            => src.Data;
    }
}