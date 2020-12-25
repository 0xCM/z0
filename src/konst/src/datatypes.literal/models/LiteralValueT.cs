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
    /// Covers a value that can be interpreted as a compile-time literal constant
    /// </summary>
    public readonly struct LiteralValue<T> : ILiteralValue<T>
        where T : IEquatable<T>
    {
        public LiteralKind Kind {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        internal LiteralValue(T value, LiteralKind kind)
        {
            Value = value;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue<T>(T value)
            => api.value(value);

        [MethodImpl(Inline)]
        public bool Equals(LiteralValue<T> src)
            => api.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Value?.GetHashCode() ?? 0;

        public override bool Equals(object src)
            => src is LiteralValue<T> v && Equals(v);

        public static LiteralValue<T> Empty
            => default;
    }
}