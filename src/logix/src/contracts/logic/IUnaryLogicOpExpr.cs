//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    public interface IUnaryLogicOpExpr : IUnaryOpExpr<ILogicExpr>, ILogicOpExpr<UnaryBitLogic>
    {

    }

    public interface IUnaryLogicOpExpr<T> :  IUnaryLogicOpExpr, IUnaryOpExpr<ILogicExpr<T>>, ILogicOpExpr<T,UnaryBitLogic>
        where T : unmanaged
    {

    }

}