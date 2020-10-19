//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Attaches a classifier to a symbol
    /// </summary>
    public readonly struct KindedSymbol<K,S,T> : IKindedSymbol<K,S,T>
        where K : unmanaged
        where S : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The symbol kind
        /// </summary>
        public readonly K Kind;

        /// <summary>
        /// The symbol value
        /// </summary>
        public readonly S Value;

        /// <summary>
        /// The symbol value, from storage cell perspective
        /// </summary>
        public T Cell
        {
            [MethodImpl(Inline)]
            get => @as<S,T>(Value);
        }

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S>(KindedSymbol<K,S,T> src)
            => new Symbol<S>(src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S,T>(KindedSymbol<K,S,T> src)
            => new Symbol<S,T>(src.Value);

        [MethodImpl(Inline)]
        public static implicit operator KindedSymbol<K,S>(KindedSymbol<K,S,T> src)
            => new KindedSymbol<K,S>(src.Kind, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator KindedSymbol<K,S,T>((K kind, S value) src)
            => new KindedSymbol<K,S,T>(src.kind, src.value);

        [MethodImpl(Inline)]
        public static implicit operator KindedSymbol<K,S,T>(Paired<K,S> src)
            => new KindedSymbol<K,S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator K(KindedSymbol<K,S,T> src)
            => src.Kind;

        [MethodImpl(Inline)]
        public KindedSymbol(K kind, S value)
        {
            Kind = kind;
            Value = value;
        }

        K IKindedSymbol<K, S>.Kind
            => Kind;

        S ISymbol<S>.Value
            => Value;
    }
}