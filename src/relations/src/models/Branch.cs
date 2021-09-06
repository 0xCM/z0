//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Relations
    {
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