//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct TokenMatch<K,V>
        where K : unmanaged
    {
        public readonly K Kind;

        public readonly V Value;

        [MethodImpl(Inline)]
        public TokenMatch(K kind, V value)
        {
            Kind = kind;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator TokenMatch<K,V>((K kind, V value) src)
            => new TokenMatch<K,V>(src.kind, src.value);
    }
}