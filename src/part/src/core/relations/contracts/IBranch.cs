//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBranch : ITree
    {

    }


    public interface IBranch<B,L> : IBranch, ITree<B,L>
        where B : IBranch
        where L : ILeaf
    {

    }
}