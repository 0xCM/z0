//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Flags;

    public readonly struct Flags32<E> : IFlags<Flags32<E>,E,Pow2x32>
        where E : unmanaged, Enum
    {
        public const byte Width = 32;

        public E Value {get;}

        [MethodImpl(Inline)]
        public Flags32(E value)
            => Value = value;
        public byte DataWidth
            => Width;

        public bit this[E flag]
        {
            [MethodImpl(Inline)]
            get => api.state(this, flag);
        }

        public bit this[Pow2x32 flag]
        {
            [MethodImpl(Inline)]
            get => api.state(this, flag);
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Flags32<E>(E src)
            => new Flags32<E>(src);

        [MethodImpl(Inline)]
        public static implicit operator E(Flags32<E> src)
            => src.Value;
    }
}
