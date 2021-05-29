//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Covers a value that can be interpreted as a compile-time literal constant
    /// </summary>
    public readonly struct LiteralValue<T> : ILiteralValue<T>
        where T : IEquatable<T>
    {
        public T Value {get;}

        public ClrLiteralKind Kind {get;}

        [MethodImpl(Inline)]
        public LiteralValue(T value, ClrLiteralKind kind)
        {
            Value = value;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public bool Equals(LiteralValue<T> src)
            => eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => Value?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Value?.GetHashCode() ?? 0;

        public override bool Equals(object src)
            => src is LiteralValue<T> v && Equals(v);

        public static LiteralValue<T> Empty
            => default;

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue<T>(T value)
            => new LiteralValue<T>(value, ClrLiteralKinds.kind<T>());

        [MethodImpl(Inline)]
        static bool eq(LiteralValue<T> a, LiteralValue<T> b)
            => a.Value?.Equals(b.Value) ?? false;
    }
}