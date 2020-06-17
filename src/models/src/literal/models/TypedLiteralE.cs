//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Lifts an enumeration literal to a type
    /// </summary>
    public readonly struct TypedLiteral<E> : ITypedLiteral<E>
        where E : unmanaged, Enum
    {
        [MethodImpl(Inline)]
        public static implicit operator E(TypedLiteral<E> t)
            => t.Class;

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E>(E @class)
            => new TypedLiteral<E>(@class);
        
        [MethodImpl(Inline)]
        public TypedLiteral(E @class)
        {
            this.Class = @class;
        }

        public E Class {get;}
    }
}