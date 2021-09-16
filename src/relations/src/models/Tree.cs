//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Relations
    {
        public class Tree<T> : ITree<T>
            where T : ILeaf
        {
            public Index<IBranch> Branches {get;}

            public Index<T> Leaves {get;}
        }

        public class Tree<B,L> : ITree<B,L>
            where B : IBranch
            where L : ILeaf
        {
            public Index<B> Branches {get;}

            public Index<L> Leaves {get;}
        }
    }
}