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

    public readonly struct Relations<K,A>
        where K : unmanaged
        where A : struct
    {
        readonly Relation<K,A>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator Relations<K,A>(Relation<K,A>[] src)
            => new Relations<K,A>(src);

        [MethodImpl(Inline)]
        public Relations(Relation<K,A>[] src)
        {
            Data = src;
        }
    }
}