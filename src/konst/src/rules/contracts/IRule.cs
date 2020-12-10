//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IRule<T> :  INode
    {
        RuleId RuleId {get;}

        bool INode.IsNonEmpty
            => RuleId.IsEmpty;
    }
}