//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Artifact<K,T>
        where K : unmanaged
        where T : unmanaged
    {
        public K Kind {get;}

        public T Locator {get;}

        [MethodImpl(Inline)]
        public Artifact(K kind, T locator)
        {
            Kind = kind;
            Locator = locator;
        }

        [MethodImpl(Inline)]
        public static implicit operator Artifact<K,T>((K kind, T locator) src)
            => new Artifact<K,T>(src.kind, src.locator);
    }
}