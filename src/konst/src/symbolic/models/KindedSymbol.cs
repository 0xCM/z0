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
    public readonly struct KindedSymbol<K,S> : ISymbol<S>
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
        public static implicit operator KindedSymbol<K,S>((K kind, S value) src)
            => new KindedSymbol<K,S>(src.kind, src.value);

        [MethodImpl(Inline)]
        public KindedSymbol(K kind, S value)
        {
            Kind = kind;
            Value = value;
        }
    }
}