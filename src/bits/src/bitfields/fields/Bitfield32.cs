//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = Bitfields;
    using S = System.UInt32;

    public struct Bitfield32
    {
        public const byte Width = 32;

        S _State;

        [MethodImpl(Inline)]
        public Bitfield32(S state)
            => _State = state;

        [MethodImpl(Inline)]
        public S Read(byte i0, byte i1)
            => api.read(this, i0, i1);

        [MethodImpl(Inline)]
        public Bitfield32 Store(byte i0, byte i1, S src)
        {
            api.store(i0, i1, src, ref this);
            return this;
        }

        public Bitfield16 Lo
        {
            [MethodImpl(Inline)]
            get => api.lo(this);
        }

        public Bitfield16 Hi
        {
            [MethodImpl(Inline)]
            get => api.hi(this);
        }

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(_State);
        }

        public override string ToString()
            => Format();

        public string Format()
            => api.format(this);

        [MethodImpl(Inline)]
        internal void Overwrite(S src)
            => _State = src;

        internal S State
        {
            [MethodImpl(Inline)]
            get => _State;
        }

        [MethodImpl(Inline)]
        public static implicit operator Bitfield32(S src)
            => new Bitfield32(src);

        [MethodImpl(Inline)]
        public static explicit operator S(Bitfield32 src)
            => src.State;
    }
}