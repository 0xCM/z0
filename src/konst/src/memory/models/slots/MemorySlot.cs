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

    public struct MemorySlot
    {
        internal Hex8Seq Index;

        [MethodImpl(Inline)]
        public MemorySlot(Hex8Seq value)
            => Index = value;

        [MethodImpl(Inline)]
        public MemorySlot(byte value)
            => Index = (Hex8Seq)value;

        [MethodImpl(Inline)]
        public MemorySlot Advance()
            => api.advance(ref this);

        [MethodImpl(Inline)]
        public MemorySlot Retreat()
            => api.retreat(ref this);

        [MethodImpl(Inline)]
        public static MemorySlot operator++(MemorySlot src)
            => src.Advance();

        [MethodImpl(Inline)]
        public static MemorySlot operator--(MemorySlot src)
            => src.Retreat();

        [MethodImpl(Inline)]
        public static implicit operator byte(MemorySlot src)
            => (byte)src.Index;

        [MethodImpl(Inline)]
        public static implicit operator MemorySlot(int src)
            => new MemorySlot((Hex8Seq)src);

        [MethodImpl(Inline)]
        public static implicit operator MemorySlot(byte src)
            => new MemorySlot((Hex8Seq)src);

        internal const Hex8Seq FirstKey = Hex8Seq.x00;

        internal const Hex8Seq LastKey = Hex8Seq.xff;
    }
}