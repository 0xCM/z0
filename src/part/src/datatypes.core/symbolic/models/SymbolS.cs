//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = SymbolStores;

    /// <summary>
    /// Defines a symbol, characterized by its value, that defines an atomic element in some vocabulary/grammar
    /// </summary>
    public readonly struct Symbol<S> : ISymbol<S>, IEquatable<Symbol<S>>
        where S : unmanaged
    {
        /// <summary>
        /// The symbol value
        /// </summary>
        public S Value {get;}

        [MethodImpl(Inline)]
        public Symbol(S src)
            => Value = src;

        public Identifier Name
        {
            [MethodImpl(Inline)]
            get => Value.ToString();
        }

        [MethodImpl(Inline)]
        public bool Equals(Symbol<S> src)
            => Value.Equals(src.Value);

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();

        public override string ToString()
            => Format();

        public override bool Equals(object src)
            => src is Symbol<S> x && Equals(x);

        public override int GetHashCode()
            => Value.GetHashCode();

        [MethodImpl(Inline)]
        public static explicit operator char(Symbol<S> src)
            => api.render(src);

        [MethodImpl(Inline)]
        public static implicit operator S(Symbol<S> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S>(S src)
            => new Symbol<S>(src);

        public static Symbol<S> Empty
            => default;
    }
}