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



    /// <summary>
    /// Characterizes a typed ternary bitwise operator
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    public interface ITernaryBitwiseOp<T> : ITernaryOp<IExpr<T>>, IOperator<T,TernaryOpKind> 
        where T : unmanaged
    {


    }


    public interface ITernaryLogicOp :  ITernaryOp<ILogicExpr>,  ILogicOp<TernaryOpKind> 
    {

    }

    public interface ITernaryLogicOp<T> : ITernaryLogicOp, ITernaryOp<ILogicExpr<T>>,ILogicOp<T,TernaryOpKind>
        where T : unmanaged
    {

    }

}