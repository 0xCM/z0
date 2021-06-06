//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Relations
    {
        [MethodImpl(Inline)]
        public static Relation<K,S,T> relate<K,S,T>(K kind, in S src, in  T dst)
            => new Relation<K,S,T>(kind,src,dst);
    }
}