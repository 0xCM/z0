//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    public interface IProduction : IExpr
    {
        Label Name {get;}
    }

    public interface IProduction<T> : IProduction
        where T : IExpr
    {
        T Rhs {get;}
    }
}