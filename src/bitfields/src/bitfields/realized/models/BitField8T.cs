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

    using api = BitFields;


    public struct Bitfield8<T>
        where T : unmanaged
    {
        byte _State;

        [MethodImpl(Inline)]
        public Bitfield8(T state)
            => _State = uint8(state);

        [MethodImpl(Inline)]
        public Bitfield8(byte state)
            => _State = state;

        [MethodImpl(Inline)]
        public T Read(byte i0, byte i1)
            => api.read(this, i0, i1);

        [MethodImpl(Inline)]
        internal void Overwrite(byte src)
        {
            _State = src;
        }

        [MethodImpl(Inline)]
        public Bitfield8<T> Store(byte i0, byte i1, T src)
        {
            api.store(i0, i1, src, ref this);
            return this;
        }

        [MethodImpl(Inline)]
        public static implicit operator Bitfield8<T>(T src)
            => new Bitfield8<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Bitfield8<T>(byte src)
            => new Bitfield8<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator byte(Bitfield8<T> src)
            => src._State;
    }
}