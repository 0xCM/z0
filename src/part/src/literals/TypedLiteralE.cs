//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Lifts an enumeration literal to a type
    /// </summary>
    public readonly struct TypedLiteral<T> : ITypedLiteral<T>
        where T : unmanaged
    {
        /// <summary>
        /// The classifying literal
        /// </summary>
        public T Class {get;}

        [MethodImpl(Inline)]
        public static implicit operator T(TypedLiteral<T> t)
            => t.Class;

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<T>(T @class)
            => new TypedLiteral<T>(@class);

        [MethodImpl(Inline)]
        public TypedLiteral(T @class)
            => Class = @class;
    }
}