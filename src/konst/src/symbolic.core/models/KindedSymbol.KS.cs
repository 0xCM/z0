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
    public readonly struct KindedSymbol<K,S> : IKindedSymbol<K,S>
        where K : unmanaged
        where S : unmanaged
    {
        /// <summary>
        /// The symbol kind
        /// </summary>
        public K Kind {get;}

        /// <summary>
        /// The symbol value
        /// </summary>
        public S Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S>(KindedSymbol<K,S> src)
            => new Symbol<S>(src.Value);

        [MethodImpl(Inline)]
        public static implicit operator KindedSymbol<K,S>(Paired<K,S> src)
            => new KindedSymbol<K,S>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator KindedSymbol<K,S>((K kind, S value) src)
            => new KindedSymbol<K,S>(src.kind, src.value);

        [MethodImpl(Inline)]
        public static implicit operator K(KindedSymbol<K,S> src)
            => src.Kind;

        [MethodImpl(Inline)]
        public KindedSymbol(K kind, S value)
        {
            Kind = kind;
            Value = value;
        }
    }
}