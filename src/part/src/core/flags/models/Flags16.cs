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

    using api = Flags;

    public struct Flags16<E> : IFlags<Flags16<E>,E,Pow2x16>
        where E : unmanaged
    {
        public const byte Width = 16;

        public E Value {get;}

        [MethodImpl(Inline)]
        public Flags16(E value)
            => Value = value;

        public byte DataWidth
            => Width;

        public bit this[E flag]
        {
            [MethodImpl(Inline)]
            get => api.state(this, flag);
        }

        public bit this[Pow2x16 flag]
        {
            [MethodImpl(Inline)]
            get => api.state(this, flag);
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Flags16<E>(E src)
            => new Flags16<E>(src);

        [MethodImpl(Inline)]
        public static implicit operator E(Flags16<E> src)
            => src.Value;
    }
}