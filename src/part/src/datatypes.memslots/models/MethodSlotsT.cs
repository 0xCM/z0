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

    /// <summary>
    /// Defines a key-parametric indexed view over <see cref='MethodSlot'/> values
    /// </summary>
    public readonly struct MethodSlots<E>
        where E : unmanaged
    {
        readonly MethodSlot[] Data;

        [MethodImpl(Inline)]
        public MethodSlots(MethodSlot[] slots)
            => Data = slots;

        [MethodImpl(Inline)]
        public ref readonly MethodSlot Lookup(E index)
            => ref skip(Data, uint32(index));

        public ref readonly MethodSlot this[E index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public ref MethodSlot First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public MethodSlot[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref MethodSlot this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}