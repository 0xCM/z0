//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public abstract class Terminal<T> : TreeNode<T>
        where T : TreeNode<T>, new()
    {
        public override bool IsLeaf
            => true;
    }

}