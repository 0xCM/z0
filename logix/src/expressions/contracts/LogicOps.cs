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
    /// Characterizes an operator reified as a boolean function
    /// </summary>
    public interface ILogicOp : IOperator, ILogicExpr
    {

    }

    public interface ILogicOp<K> : ILogicOp
        where K : unmanaged, Enum
    {
        K OpKind {get;}
    }

    /// <summary>
    /// Characterizes a logic operator that varies by operator kind and is evaluated in the context of a parametric type
    /// </summary>
    /// <typeparam name="T">The context type</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
   public interface ILogicOp<T,K> :  ILogicOp<K>, IOperator<T,K>, ILogicExpr<T>
        where T : unmanaged
        where K : unmanaged, Enum
    {

    }
  
}