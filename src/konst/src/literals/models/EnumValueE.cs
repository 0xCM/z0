//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EnumValue<E> : IEnumValue<E>
        where E : unmanaged, Enum
    {
        public  E Literal {get;}

        [MethodImpl(Inline)]
        public static implicit operator EnumValue<E>(E src)
            => new EnumValue<E>(src);

        [MethodImpl(Inline)]
        public static implicit operator E(EnumValue<E> src)
            => src.Literal;

        [MethodImpl(Inline)]
        public EnumValue(E e)
            => Literal = e;

        [MethodImpl(Inline)]
        public string Format()
            => Literal.ToString();

        public override string ToString()
            => Format();
    }
}