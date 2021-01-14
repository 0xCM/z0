//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Keyword<L,K> : IKeyword<L,K>
        where K : unmanaged, IKeyword<L,K>
        where L : struct, ILanguage
    {
        readonly K Source;

        [MethodImpl(Inline)]
        public Keyword(K src)
            => Source = src;

        public Name Name => Source.Name;

        public ushort Index => Source.Index;

        public K Kind => Source;

        [MethodImpl(Inline)]
        public static implicit operator Keyword<L,K>(K src)
            => new Keyword<L,K>(src);
    }
}