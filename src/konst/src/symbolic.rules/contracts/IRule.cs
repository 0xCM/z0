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

    public interface IRule<T> :  INode
    {
        RuleId RuleId {get;}

        bool INode.IsNonEmpty
            => RuleId.IsEmpty;
    }
}