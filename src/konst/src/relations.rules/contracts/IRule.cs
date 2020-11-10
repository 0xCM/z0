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

    public interface IRule<T> : INode<T>
    {
        RuleId RuleId {get;}

        bool INode.IsNonEmpty
            => RuleId.IsEmpty;
    }

    public interface IRuleSpec<H> : IRule<H>
        where H : struct, IRuleSpec<H>
    {
        H INode<H>.Content
            => (H)this;
    }
}