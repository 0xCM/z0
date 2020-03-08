//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Characterizes an operator reified as a boolean function
    /// </summary>
    public interface ILogicOpExpr : IOperatorExpr, ILogicExpr
    {

    }

    public interface ILogicOpExpr<K> : ILogicOpExpr
        where K : unmanaged, Enum
    {
        K OpKind {get;}
    }

    /// <summary>
    /// Characterizes a logic operator that varies by operator kind and is evaluated in the context of a parametric type
    /// </summary>
    /// <typeparam name="T">The context type</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
   public interface ILogicOpExpr<T,K> :  ILogicOpExpr<K>, IOperatorExpr<T,K>, ILogicExpr<T>
        where T : unmanaged
        where K : unmanaged, Enum
    {

    }
}