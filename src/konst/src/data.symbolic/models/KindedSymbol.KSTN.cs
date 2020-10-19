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
    public readonly struct KindedSymbol<K,S,T,N> : IKindedSymbolic<KindedSymbol<K,S,T,N>,K,S,T,N>
        where K : unmanaged
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
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
        public KindedSymbol(K kind, S value)
        {
            Kind = kind;
            Value = value;
        }

        K IKindedSymbol<K, S>.Kind
            => Kind;

        S ISymbol<S>.Value
            => Value;

        [MethodImpl(Inline)]
        public static implicit operator KindedSymbol<K,S,T,N>((K kind, S value) src)
            => new KindedSymbol<K,S,T,N>(src.kind, src.value);

        [MethodImpl(Inline)]
        public static implicit operator KindedSymbol<K,S,T,N>(Paired<K,S> src)
            => new KindedSymbol<K,S,T,N>(src.Left, src.Right);
    }
}