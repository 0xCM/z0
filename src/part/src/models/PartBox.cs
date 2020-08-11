//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
            
    public class PartBox
    {        
        const sbyte EmptySlot = sbyte.MinValue;

        const byte SlotCount = byte.MaxValue;
        
        object[] Slots;

        public PartBox()
        {
            Slots = new object[SlotCount];
            Span<object> dst =  Slots;
            dst.Fill(EmptySlot);            
        }

        public ReadOnlySpan<object> View
        {
            [MethodImpl(Inline)]
            get => Slots;
        }
        
        public Span<object> Edit
        {
            [MethodImpl(Inline)]
            get => Slots;
        }
        
        [MethodImpl(Inline)]
        public ref T Slot<T>(byte index)
            => ref Unsafe.As<object,T>(ref Slots[index]);

        [MethodImpl(Inline)]
        public void Clear<T>(byte index)
            => Slots[index] = EmptySlot;

        [MethodImpl(Inline)]
        public bool IsEmpty(byte index)
            => Slots[index] is sbyte x && x == EmptySlot;

        [MethodImpl(Inline)]
        public ref T Slot<T>(byte index, Func<T> factory)
        {
            ref var slot = ref Unsafe.As<object,T>(ref Slots[index]);
            if(IsEmpty(index))
                slot = factory();
            return ref slot;
        }
    }
}