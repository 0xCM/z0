//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Relations
    {
        public readonly struct Branch<B,L> : IBranch<B,L>
            where B : IBranch
            where L : ILeaf
        {
            public Index<B> Branches {get;}

            public Index<L> Leaves {get;}

            [MethodImpl(Inline)]
            public Branch(Index<B> branches, Index<L> leaves)
            {
                Branches = branches;
                Leaves = leaves;
            }
        }

        public readonly struct Branch
        {
            public Index<ILeaf> Leaves {get;}

            public Index<IBranch> Branches {get;}

            [MethodImpl(Inline)]
            public Branch(Index<ILeaf> leaves, Index<IBranch> branches)
            {
                Leaves = leaves;
                Branches = branches;
            }
        }
    }
}