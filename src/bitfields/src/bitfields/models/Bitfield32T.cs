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

    using api = BitFields;
    using S = System.UInt32;

    public struct Bitfield32<T>
        where T : unmanaged
    {
        public const byte Width = 32;

        S _State;

        [MethodImpl(Inline)]
        public Bitfield32(T state)
            => _State = uint32(state);

        [MethodImpl(Inline)]
        public Bitfield32(S state)
            => _State = state;

        [MethodImpl(Inline)]
        public T Read(byte i0, byte i1)
            => api.read(this, i0, i1);

        [MethodImpl(Inline)]
        public Bitfield32<T> Store(byte i0, byte i1, T src)
        {
            api.store(i0, i1, src, ref this);
            return this;
        }

        public Bitfield16<T> Lo
        {
            [MethodImpl(Inline)]
            get => api.lo(this);
        }

        public Bitfield16<T> Hi
        {
            [MethodImpl(Inline)]
            get => api.hi(this);
        }

        [MethodImpl(Inline)]
        internal void Overwrite(S src)
            => _State = src;

        internal S State
        {
            [MethodImpl(Inline)]
            get => _State;
        }

        [MethodImpl(Inline)]
        public static implicit operator Bitfield32<T>(T src)
            => new Bitfield32<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Bitfield32<T>(S src)
            => new Bitfield32<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator S(Bitfield32<T> src)
            => src._State;
    }
}