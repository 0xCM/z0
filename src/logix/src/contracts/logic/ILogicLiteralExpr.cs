//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{    

    public interface ILogicLiteralExpr : ILogicExpr, ILiteralExpr
    {
        bit Value {get;}
    }

    public interface ILogicLiteralExpr<T> : ILogicLiteralExpr, ILogicExpr<T>
        where T : unmanaged
    {

    }

}