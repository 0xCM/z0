//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IUnaryBitwiseOpExpr<T> : IUnaryOpExpr<IExpr<T>>, IOperatorExpr<T, UnaryLogicKind>
        where T : unmanaged
    {
        
    }

    public interface IUnaryLogicOpExpr : IUnaryOpExpr<ILogicExpr>, ILogicOpExpr<UnaryLogicKind>
    {

    }

    public interface IUnaryLogicOpExpr<T> :  IUnaryLogicOpExpr, IUnaryOpExpr<ILogicExpr<T>>, ILogicOpExpr<T,UnaryLogicKind>
        where T : unmanaged
    {

    }
}