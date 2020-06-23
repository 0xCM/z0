//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{

    public interface ITernaryLogicOpExpr :  ITernaryOpExpr<ILogicExpr>,  ILogicOpExpr<TernaryBitLogic> 
    {

    }

    public interface ITernaryLogicOpExpr<T> : ITernaryLogicOpExpr, ITernaryOpExpr<ILogicExpr<T>>,ILogicOpExpr<T,TernaryBitLogic>
        where T : unmanaged
    {

    }
}