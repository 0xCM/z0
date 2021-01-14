//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a legal identifier
    /// </summary>
    public readonly struct Identifier<T> : IIdentifier<Identifier<T>,T>
        where T : IComparable<T>
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public Identifier(T src)
            => Value = src;

        [MethodImpl(Inline)]
        public string Format()
            => Value?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();

        public int CompareTo(Identifier<T> other)
            => Value?.CompareTo(other.Value) ?? 0;

        [MethodImpl(Inline)]
        public static implicit operator Identifier<T>(T src)
            => new Identifier<T>(src);
    }
}