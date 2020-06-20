//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;

    public readonly struct @enum<E> : IEnum<E>, IEquatable<@enum<E>>
        where E : unmanaged, Enum
    {
        public readonly E Literal;

        [MethodImpl(Inline)]
        public @enum(E literal)
        {
            Literal = literal;
        }                

        public DataWidth Width 
        {
            [MethodImpl(Inline)]
            get => (DataWidth)bitsize<E>();
        }

        [MethodImpl(Inline)]
        public bool Equals(E src)
            => Literal.Equals(src);

        [MethodImpl(Inline)]
        public bool Equals(@enum<E> src)
            => Literal.Equals(src.Literal);

        E IEnum<E>.Literal 
            => Literal;    
        public string Format()
            => $"{Literal}";

        public override string ToString()
            => Format();            
    }
}