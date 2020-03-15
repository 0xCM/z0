//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IBinaryBitwiseOpExpr<T> : IBinaryOpExpr<IExpr<T>>, IOperatorExpr<T,BinaryBitLogicOpKind>
        where T : unmanaged
    {
    }

    public interface IBinaryLogicOpExpr : IBinaryOpExpr<ILogicExpr>, ILogicOpExpr<BinaryBitLogicOpKind>
    {

    }

    public interface IBinaryLogicOpExpr<T> : IBinaryLogicOpExpr, IBinaryOpExpr<ILogicExpr<T>>,  ILogicOpExpr<T,BinaryBitLogicOpKind>
        where T : unmanaged
    {

    }
}