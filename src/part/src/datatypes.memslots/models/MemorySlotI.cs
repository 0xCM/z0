//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = MemorySlots;

    public struct MemorySlot<I>
        where I : unmanaged
    {
        internal I Index;

        [MethodImpl(Inline)]
        public MemorySlot(I value)
            => Index = value;

        [MethodImpl(Inline)]
        public MemorySlot<I> Advance()
            => api.advance(ref this);

        [MethodImpl(Inline)]
        public MemorySlot<I> Retreat()
            => api.retreat(ref this);

        [MethodImpl(Inline)]
        public static MemorySlot<I> operator++(MemorySlot<I> src)
            => src.Advance();

        [MethodImpl(Inline)]
        public static MemorySlot<I> operator--(MemorySlot<I> src)
            => src.Retreat();

        [MethodImpl(Inline)]
        public static implicit operator I(MemorySlot<I> src)
            => src.Index;

        [MethodImpl(Inline)]
        public static implicit operator MemorySlot<I>(I src)
            => new MemorySlot<I>(src);
    }
}