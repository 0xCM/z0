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


    public interface IUnaryBitwiseOp<T> : IUnaryOp<IExpr<T>>, IOperator<T, UnaryBitLogicKind>
        where T : unmanaged
    {
        
    }

    public interface IUnaryLogicOp : IUnaryOp<ILogicExpr>, ILogicOp<UnaryBitLogicKind>
    {

    }

    public interface IUnaryLogicOp<T> :  IUnaryLogicOp, IUnaryOp<ILogicExpr<T>>, ILogicOp<T,UnaryBitLogicKind>
        where T : unmanaged
    {

    }

}