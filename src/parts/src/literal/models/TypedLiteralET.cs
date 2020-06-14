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
    /// A numeric-parametric typed literal
    /// </summary>
    /// <typeparam name="E">An enumeration type that refines the parametric numeric type</typeparam>
    /// <typeparam name="V">The numeric type refined by the enum</typeparam>
    public readonly struct TypedLiteral<E,V> : ITypedLiteral<E,V>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator E(TypedLiteral<E,V> t)
            => t.Class;

        [MethodImpl(Inline)]
        public static implicit operator V(TypedLiteral<E,V> t)
            => t.Value;

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E,V>(E @class)
            => new TypedLiteral<E,V>(@class);

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E,V>(V value)
            => TypedLiteral.from<E,V>(value);

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E>(TypedLiteral<E,V> src)
            => TypedLiteral.from<E>(src.Class);

        [MethodImpl(Inline)]
        public TypedLiteral(E @class)
        {
            this.Class = @class;
            this.Value = TypedLiteral.numeric<E,V>(@class);
        }

        [MethodImpl(Inline)]
        public TypedLiteral(V value)
        {
            this.Class = TypedLiteral.literal<E,V>(value);
            this.Value = value;
        }

        /// <summary>
        /// The classifying literal
        /// </summary>
        public E Class {get;}

        /// <summary>
        /// The numeric value of the classifier
        /// </summary>
        public V Value {get;}
    }
}