//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    public interface IUnaryBitwiseOp<T> : IUnaryOp<IExpr<T>>, IOperator<T, UnaryBitwiseOpKind>
        where T : unmanaged
    {
        
    }

    public interface IUnaryLogicOp : IUnaryOp<ILogicExpr>, ILogicOp<UnaryLogicOpKind>
    {

    }

    public interface IUnaryLogicOp<T> :  IUnaryLogicOp, IUnaryOp<ILogicExpr<T>>, ILogicOp<T,UnaryLogicOpKind>
        where T : unmanaged
    {

    }

}