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
    /// Defines a key-parametric indexed view over <see cref='MemorySegment'/> values
    /// </summary>
    public readonly struct MemorySlots<E>
        where E : unmanaged
    {
        readonly MemorySegment[] Data;

        [MethodImpl(Inline)]
        public MemorySlots(MemorySegment[] slots)
            => Data = slots;

        [MethodImpl(Inline)]
        public ref readonly MemorySegment Lookup(E index)
            => ref skip(Data, uint32(index));

        public ref readonly MemorySegment this[E index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public ref MemorySegment First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public MemorySegment[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref MemorySegment this[uint index]
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