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

    public readonly struct Flags16<E> : ITextual
        where E : unmanaged, Enum
    {
         public const byte Width = 8;

         readonly E Data;

        [MethodImpl(Inline)]
        internal Flags16(E value)
            => Data = value;

        public bit this[E flag]
        {
            [MethodImpl(Inline)]
            get => bit.test(u16(Data), (byte)Pow2.log2(u16(flag)));
        }

        public bit this[Pow2x16 flag]
        {
            [MethodImpl(Inline)]
            get => bit.test(u16(Data), Pow2.log2(flag));
        }

        public E Value
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public string Format()
            => Flags.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Flags16<E>(E src)
            => new Flags16<E>(src);

        [MethodImpl(Inline)]
        public static implicit operator E(Flags16<E> src)
            => src.Data;
    }
}
