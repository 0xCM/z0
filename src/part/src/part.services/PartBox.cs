//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public enum PartBoxSlot : byte
    {
        Services = 0,
    }

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
        public ref T Slot<T>(PartBoxSlot slot)
            => ref Unsafe.As<object,T>(ref Slots[(byte)slot]);

        [MethodImpl(Inline)]
        public void Clear<T>(PartBoxSlot index)
            => Slots[(byte)index] = EmptySlot;

        [MethodImpl(Inline)]
        public bool IsEmpty(PartBoxSlot index)
            => Slots[(byte)index] is sbyte x && x == EmptySlot;

        [MethodImpl(Inline)]
        public ref T Slot<T>(PartBoxSlot index, Func<T> factory)
        {
            ref var slot = ref Unsafe.As<object,T>(ref Slots[(byte)index]);
            if(IsEmpty(index))
                slot = factory();
            return ref slot;
        }
    }
}