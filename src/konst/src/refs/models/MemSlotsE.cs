//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemSlots<E> : IIndexedView<E,MemSlot>
        where E : unmanaged, Enum
    {
        readonly MemSlot[] Data;

        [MethodImpl(Inline)]
        public MemSlots(MemSlot[] slots)
        {
            Data = slots;
        }

        [MethodImpl(Inline)]
        public ref readonly MemSlot Lookup(E index)
            => ref Data[z.uint8(index)];
        
        public ref readonly MemSlot this[E index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        ref readonly MemSlot IIndexedView<MemSlot>.Lookup(int index)
            => ref Data[index];

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }        
    }
}