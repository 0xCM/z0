//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = TypedLiterals;

    /// <summary>
    /// A numeric-parametric typed literal
    /// </summary>
    /// <typeparam name="E">An enumeration type that refines the parametric numeric type</typeparam>
    /// <typeparam name="T">The numeric type refined by the enum</typeparam>
    public struct TypedLiteral<E,T> : ITypedLiteral<E,T>
        where E : unmanaged
        where T : unmanaged
    {
        public E Class {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator E(TypedLiteral<E,T> src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator T(TypedLiteral<E,T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E,T>(E @class)
            => api.define<E,T>(@class);

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E,T>(T value)
            => api.define<E,T>(value);

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E>(TypedLiteral<E,T> src)
            => api.define<E>(src.Class);

        [MethodImpl(Inline)]
        public TypedLiteral(E @class, T value)
        {
            Class = @class;
            Value = value;
        }
    }
}