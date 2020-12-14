//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Keyword<K> : IKeyword<K>
        where K : unmanaged
    {
        public string Name {get;}

        public K Kind {get;}

        [MethodImpl(Inline)]
        public Keyword(string src, K kind)
        {
            Name = src;
            Kind = kind;
        }
    }
}