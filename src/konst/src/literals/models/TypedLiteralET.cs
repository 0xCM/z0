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
    /// <typeparam name="T">The numeric type refined by the enum</typeparam>
    public struct TypedLiteral<E,T> : ITypedLiteral<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        public E EVal;

        public T TVal;

        [MethodImpl(Inline)]
        public static implicit operator E(TypedLiteral<E,T> t)
            => t.Class;

        [MethodImpl(Inline)]
        public static implicit operator T(TypedLiteral<E,T> t)
            => t.TVal;

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E,T>(E @class)
            => new TypedLiteral<E,T>(@class);

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E,T>(T value)
            => Literals.typed<E,T>(value);

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E>(TypedLiteral<E,T> src)
            => Literals.typed<E>(src.Class);

        [MethodImpl(Inline)]
        public TypedLiteral(E @class)
        {
            EVal = @class;
            TVal = Literals.numeric<E,T>(@class);
        }

        [MethodImpl(Inline)]
        public TypedLiteral(E @class, T value)
        {
            EVal = @class;
            TVal = value;
        }

        /// <summary>
        /// The classifying literal
        /// </summary>
        public E Class
        {
            [MethodImpl(Inline)]
            get => EVal;
        }

        /// <summary>
        /// The numeric value of the classifier
        /// </summary>
        public T Value
        {
            [MethodImpl(Inline)]
            get => TVal;
        }
    }
}