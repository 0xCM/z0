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

    public readonly struct Flags8<E> : ITextual
        where E : unmanaged, Enum
    {
         public const byte Width = 8;

         readonly E Data;

        [MethodImpl(Inline)]
        internal Flags8(E value)
            => Data = value;

        public bit this[E flag]
        {
            [MethodImpl(Inline)]
            get => BitStates.test(u8(Data), Pow2.log2(u8(flag)));
        }

        public bit this[Pow2x8 flag]
        {
            [MethodImpl(Inline)]
            get => BitStates.test(u8(Data), Pow2.log2(flag));
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
        public static implicit operator Flags8<E>(E src)
            => new Flags8<E>(src);

        [MethodImpl(Inline)]
        public static implicit operator E(Flags8<E> src)
            => src.Data;
    }
}
