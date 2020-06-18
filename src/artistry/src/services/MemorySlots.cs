//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemorySlots : IIndexedView<MemorySlot>
    {
        readonly MemorySlot[] Data;

        [MethodImpl(Inline)]
        public static MemorySlots from(Type src)
            => FunctionJit.jit(src).Map(m => new MemorySlot(m.Location, m.Size));

        [MethodImpl(Inline)]
        public static MemorySlots<E> from<E>(Type src)
            where E : unmanaged, Enum
                => new MemorySlots<E>(from(src));

        [MethodImpl(Inline)]
        public static MemorySlots<E> define<E>(params MemorySlot[] slots)
            where E : unmanaged, Enum
                => new MemorySlots<E>(slots);

        [MethodImpl(Inline)]
        public static implicit operator MemorySlots(MemorySlot[] src)
            => new MemorySlots(src);

        [MethodImpl(Inline)]
        public static implicit operator MemorySlot[](MemorySlots src)
            => src.Data;

        [MethodImpl(Inline)]
        public MemorySlots(MemorySlot[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly MemorySlot Lookup(int index)
            => ref Data[index];

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}