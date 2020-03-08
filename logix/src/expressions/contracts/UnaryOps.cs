//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IUnaryBitwiseOpExpr<T> : IUnaryOpExpr<IExpr<T>>, IOperatorExpr<T, UnaryBitLogicKind>
        where T : unmanaged
    {
        
    }

    public interface IUnaryLogicOpExpr : IUnaryOpExpr<ILogicExpr>, ILogicOpExpr<UnaryBitLogicKind>
    {

    }

    public interface IUnaryLogicOpExpr<T> :  IUnaryLogicOpExpr, IUnaryOpExpr<ILogicExpr<T>>, ILogicOpExpr<T,UnaryBitLogicKind>
        where T : unmanaged
    {

    }
}