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
        public static Branch<B,L> branch<B,L>(Index<B> b, Index<L> l)
            where B : IBranch
            where L : ILeaf
                => new Branch<B,L>(b, l);
    }
}