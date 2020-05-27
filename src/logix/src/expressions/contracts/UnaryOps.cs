//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IUnaryBitwiseOpExpr<T> : IUnaryOpExpr<IExpr<T>>, IOperatorExpr<T, UnaryBitLogic>
        where T : unmanaged
    {
        
    }

    public interface IUnaryLogicOpExpr : IUnaryOpExpr<ILogicExpr>, ILogicOpExpr<UnaryBitLogic>
    {

    }

    public interface IUnaryLogicOpExpr<T> :  IUnaryLogicOpExpr, IUnaryOpExpr<ILogicExpr<T>>, ILogicOpExpr<T,UnaryBitLogic>
        where T : unmanaged
    {

    }
}