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
    using S = System.Byte;

    public struct Bitfield8<T>
        where T : unmanaged
    {
        public const byte Width = 8;

        S _State;

        [MethodImpl(Inline)]
        public Bitfield8(T state)
            => _State = uint8(state);

        [MethodImpl(Inline)]
        public Bitfield8(S state)
            => _State = state;

        [MethodImpl(Inline)]
        public T Read(byte i0, byte i1)
            => api.read(this, i0, i1);

        [MethodImpl(Inline)]
        public Bitfield8<T> Store(byte i0, byte i1, T src)
        {
            api.store(i0, i1, src, ref this);
            return this;
        }

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(_State);
        }

        internal S State
        {
            [MethodImpl(Inline)]
            get => _State;
        }

        [MethodImpl(Inline)]
        internal void Overwrite(S src)
            => _State = src;

        [MethodImpl(Inline)]
        public static implicit operator Bitfield8<T>(T src)
            => new Bitfield8<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Bitfield8<T>(S src)
            => new Bitfield8<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator S(Bitfield8<T> src)
            => src._State;
    }
}