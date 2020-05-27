//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Characterizes a typed ternary bitwise operator
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    public interface ITernaryBitwiseOpExpr<T> : ITernaryOpExpr<IExpr<T>>, IOperatorExpr<T,TernaryBitLogic> 
        where T : unmanaged
    {


    }

    public interface ITernaryLogicOpExpr :  ITernaryOpExpr<ILogicExpr>,  ILogicOpExpr<TernaryBitLogic> 
    {

    }

    public interface ITernaryLogicOpExpr<T> : ITernaryLogicOpExpr, ITernaryOpExpr<ILogicExpr<T>>,ILogicOpExpr<T,TernaryBitLogic>
        where T : unmanaged
    {

    }
}