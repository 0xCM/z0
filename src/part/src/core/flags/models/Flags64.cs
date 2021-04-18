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

    public readonly struct Flags64<E> : IFlags<Flags64<E>,E,Pow2x64>
        where E : unmanaged, Enum
    {
        public const byte Width = 64;

        readonly E Data;

        [MethodImpl(Inline)]
        public Flags64(E value)
            => Data = value;

        public byte DataWidth
            => Width;

        public bit this[E flag]
        {
            [MethodImpl(Inline)]
            get => api.state(this, flag);
        }

        public bit this[Pow2x64 flag]
        {
            [MethodImpl(Inline)]
            get => api.state(this, flag);
        }

        public E Value
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Flags64<E>(E src)
            => new Flags64<E>(src);

        [MethodImpl(Inline)]
        public static implicit operator E(Flags64<E> src)
            => src.Data;
    }
}
