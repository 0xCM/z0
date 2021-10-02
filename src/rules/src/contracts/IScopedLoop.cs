//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static RuleModels;

    public interface IScopedLoop : IScope, IScoped
    {
        StatementBlock Body {get;}
    }
}