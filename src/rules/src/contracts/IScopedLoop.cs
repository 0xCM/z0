//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Rules;

    public interface IScopedLoop : IScope, IScoped
    {
        StatementBlock Body {get;}
    }
}