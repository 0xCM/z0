//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Literals;

    /// <summary>
    /// Lifts an enumeration literal to a type
    /// </summary>
    public readonly struct RefinedLiteral<T> : ILiteralValue<T>
        where T : unmanaged, Enum, IEquatable<T>
    {
        /// <summary>
        /// The classifying literal
        /// </summary>
        public T Value {get;}

        public LiteralKind Kind {get;}

        public Name Name => Value.ToString();

        [MethodImpl(Inline)]
        public RefinedLiteral(T @class, EnumLiteralKind kind)
        {
            Value = @class;
            Kind = (LiteralKind)kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator T(RefinedLiteral<T> t)
            => t.Value;

        [MethodImpl(Inline)]
        public static implicit operator RefinedLiteral<T>(T value)
            => api.refined(value);
    }
}