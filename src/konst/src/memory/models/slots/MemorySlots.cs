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

    public readonly struct MemorySlots
    {
        readonly SegRef[] Data;

        [MethodImpl(Inline)]
        public MemorySlots(SegRef[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly SegRef Lookup(byte index)
            => ref Data[index];

        public ref readonly SegRef this[byte index]
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
        public static implicit operator MemorySlots(SegRef[] src)
            => new MemorySlots(src);

        [MethodImpl(Inline)]
        public static implicit operator SegRef[](MemorySlots src)
            => src.Data;
    }
}