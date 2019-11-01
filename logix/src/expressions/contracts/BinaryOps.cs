//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    /// <summary>
    /// Characterizes a binary operator parametrized by expression type
    /// </summary>
    public interface IBinaryOp<X> : IOperator
        where X : IExpr
    {
        X LeftArg {get;}

        X RightArg {get;}
    }


    public interface IBinaryBitwiseOp<T> : IBinaryOp<IExpr<T>>, IOperator<T,BinaryBitwiseOpKind>
        where T : unmanaged
    {
    }

    public interface IBinaryLogicOp : IBinaryOp<ILogicExpr>, ILogicOp<BinaryLogicOpKind>
    {

    }


    public interface IBinaryLogicOp<T> : IBinaryLogicOp, IBinaryOp<ILogicExpr<T>>,  ILogicOp<T,BinaryLogicOpKind>
        where T : unmanaged
    {


    }
}