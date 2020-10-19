//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = TypedLiterals;

    /// <summary>
    /// Covers a value that can be interpreted as a compile-time literal constant
    /// </summary>
    public readonly struct TypedLiteralType<T> : ITypedLiteralType<TypedLiteralType<T>,T>
    {
        public LiteralKind LiteralKind {get;}

        public T LiteralValue {get;}

        [MethodImpl(Inline)]
        internal TypedLiteralType(T value, LiteralKind kind)
        {
            LiteralValue = value;
            LiteralKind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteralType<T>(T value)
            => api.type(value);

        [MethodImpl(Inline)]
        public bool Equals(TypedLiteralType<T> src)
            => api.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => LiteralValue?.GetHashCode() ?? 0;

        public override bool Equals(object src)
            => src is TypedLiteralType<T> v && Equals(v);

        public static TypedLiteralType<T> Empty
            => default;
    }
}