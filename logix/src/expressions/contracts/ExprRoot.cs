//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;

    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;


    /// <summary>
    /// Characterizes an expression
    /// </summary>
    public interface IExpr
    {
        /// <summary>
        /// Renders the expression in canonical form
        /// </summary>
        string Format();   
    }

    /// <summary>
    /// Characterizes an parametric expression
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IExpr<T> : IExpr
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a logicical expression over a bit
    /// </summary>
    public interface ILogicExpr : IExpr
    {
    
    }

    /// <summary>
    /// Characterizes a typed expression that admits logical evaluation
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface ILogicExpr<T> : ILogicExpr, IExpr<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes an expression defined via an operator
    /// </summary>
    public interface IOperator : IExpr
    {
        
    }

    /// <summary>
    /// Characterizes a parametric operator that varies over operand type
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IOperator<T> : IOperator, IExpr<T> 
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a parametric operator that varies over operator kind and operand type
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface IOperator<T,K> : IOperator<T>
        where T : unmanaged
        where K : unmanaged, Enum
    {
        /// <summary>
        /// Specifies the class to which the operator belongs
        /// </summary>
        K OpKind {get;}
    }

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
    /// Characterizes a logic operator that varies over operator kind and is evaluated in the
    /// context of a parametric type
    /// </summary>
    /// <typeparam name="T">The context type</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
   public interface ILogicOp<T,K> :  ILogicOp<K>, IOperator<T,K>, ILogicExpr<T>
        where T : unmanaged
        where K : unmanaged, Enum
    {

    }
  
}