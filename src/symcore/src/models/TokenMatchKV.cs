//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TokenMatch<K>
        where K : unmanaged
    {
        public readonly K Kind;

        public readonly uint Key;

        [MethodImpl(Inline)]
        public TokenMatch(K kind, uint key)
        {
            Kind = kind;
            Key = key;
        }

        [MethodImpl(Inline)]
        public static implicit operator TokenMatch<K>((K kind, uint index) src)
            => new TokenMatch<K>(src.kind, src.index);
    }
}