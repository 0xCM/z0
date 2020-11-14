//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISymbolicRuleSpec<H> : ISymbolicRule<H>
        where H : struct, ISymbolicRuleSpec<H>
    {
        H INode<H>.Content
            => (H)this;
    }
}