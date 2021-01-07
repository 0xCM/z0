//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IXedRule
    {
        XedRuleKind RuleKind {get;}
    }

    public interface IXedRule<T> : IXedRule
        where T : struct, IXedRule<T>
    {

    }
}