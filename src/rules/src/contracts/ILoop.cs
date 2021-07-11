//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Z0.Lang;

    public interface ILoop : IScope, IScoped
    {
        StatementBlock Body {get;}
    }
}