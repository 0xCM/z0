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
    /// A proxy for a reified kind
    /// </summary>
    public readonly struct KindProxy<H,K> : IDirectiveKind<H,K>
        where H : struct, IDirectiveKind<H,K>
        where K : unmanaged, IDirectiveKind<K>
    {
        [MethodImpl(Inline)]
        public KindProxy(K kind)
            => Kind = kind;

        public K Kind {get;}
    }
}