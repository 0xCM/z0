//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = MemRefs;

    /// <summary>
    /// Defines a key-parametric indexed view over <see cref='MemorySegment'/> values
    /// </summary>
    public readonly struct MemorySlots<E>
        where E : unmanaged
    {
        internal readonly MemorySegment[] Data;

        [MethodImpl(Inline)]
        public MemorySlots(MemorySegment[] slots)
            => Data = slots;

        [MethodImpl(Inline)]
        public ref readonly MemorySegment Lookup(E index)
            => ref api.lookup(this, index);

        public ref readonly MemorySegment this[E index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public MemorySegment[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref readonly MemorySegment this[uint index]
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