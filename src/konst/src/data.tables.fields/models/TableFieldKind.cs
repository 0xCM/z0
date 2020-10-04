//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableFieldKind<K>
        where K : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator TableFieldKind<K>(K src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator K(TableFieldKind<K> src)
            => default;

        public K Default => default;
    }
}