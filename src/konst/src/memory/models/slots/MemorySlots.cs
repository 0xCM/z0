//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MemorySlots
    {
        readonly MemorySegment[] Data;

        [MethodImpl(Inline)]
        public MemorySlots(MemorySegment[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly MemorySegment Lookup(byte index)
            => ref Data[index];

        public ref readonly MemorySegment this[byte index]
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
        public static implicit operator MemorySlots(MemorySegment[] src)
            => new MemorySlots(src);

        [MethodImpl(Inline)]
        public static implicit operator MemorySegment[](MemorySlots src)
            => src.Data;
    }
}