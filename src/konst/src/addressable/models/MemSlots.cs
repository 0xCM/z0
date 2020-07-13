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

    public readonly struct MemSlots : IIndexedView<MemSlot>
    {
        readonly MemSlot[] Data;

        [MethodImpl(Inline)]
        public static MemSlots from(Type src)
            => FunctionJit.jit(src).Map(m => new MemSlot(m.Location, m.Size));

        [MethodImpl(Inline)]
        public static MemSlots<E> from<E>(Type src)
            where E : unmanaged, Enum
                => new MemSlots<E>(from(src));

        [MethodImpl(Inline)]
        public static MemSlots<E> define<E>(params MemSlot[] slots)
            where E : unmanaged, Enum
                => new MemSlots<E>(slots);

        [MethodImpl(Inline)]
        public static implicit operator MemSlots(MemSlot[] src)
            => new MemSlots(src);

        [MethodImpl(Inline)]
        public static implicit operator MemSlot[](MemSlots src)
            => src.Data;

        [MethodImpl(Inline)]
        public MemSlots(MemSlot[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly MemSlot Lookup(int index)
            => ref Data[index];

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}