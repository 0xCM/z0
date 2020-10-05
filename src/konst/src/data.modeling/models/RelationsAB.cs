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

    public readonly struct Relations<A,B>
    {
        readonly Relation<A,B>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator Relations<A,B>(Relation<A,B>[] src)
            => new Relations<A,B>(src);

        [MethodImpl(Inline)]
        public Relations(Relation<A,B>[] src)
        {
            Data = src;
        }
    }
}