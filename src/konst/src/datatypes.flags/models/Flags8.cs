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

    public readonly struct Flags8<E> : IFlags<Flags8<E>,E,Pow2x8>
        where E : unmanaged, Enum
    {
        public const byte Width = 8;

        public E Value {get;}

        [MethodImpl(Inline)]
        public Flags8(E value)
            => Value = value;

        public byte DataWidth
            => Width;

        public bit this[E flag]
        {
            [MethodImpl(Inline)]
            get => api.state(this, flag);
        }

        public bit this[Pow2x8 flag]
        {
            [MethodImpl(Inline)]
            get => api.state(this, flag);
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Flags8<E>(E src)
            => new Flags8<E>(src);

        [MethodImpl(Inline)]
        public static implicit operator E(Flags8<E> src)
            => src.Value;
    }
}
