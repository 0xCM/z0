//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemorySlots<E> : IIndexedView<E,MemorySlot>
        where E : unmanaged, Enum
    {
        readonly MemorySlot[] Data;

        [MethodImpl(Inline)]
        public MemorySlots(MemorySlot[] slots)
        {
            Data = slots;
        }

        [MethodImpl(Inline)]
        public ref readonly MemorySlot Lookup(E index)
            => ref Data[Control.e8u(index)];
        
        public ref readonly MemorySlot this[E index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        ref readonly MemorySlot IIndexedView<MemorySlot>.Lookup(int index)
            => ref Data[index];

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }        
    }
}