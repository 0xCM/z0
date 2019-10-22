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
    /// Characterizes an expression
    /// </summary>
    public interface IExpr
    {
        string Format();   
    }

    /// <summary>
    /// Characterizes an expression over an unmanaged type
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IExpr<T> : IExpr
        where T : unmanaged
    {
        TypedExprKind ExprKind {get;}
    }
    
    /// <summary>
    /// Characterizes a finite sequence of terms
    /// </summary>
    /// <typeparam name="T">The term type</typeparam>
    public interface ISeqExpr<T> : IExpr
        where T : unmanaged
    {
        /// <summary>
        /// The terms in the sequence
        /// </summary>
        T[] Terms {get;}

        /// <summary>
        /// Sequence value accessor/manipulator
        /// </summary>
        T this[int index] {get;set;}

        /// <summary>
        /// The number of terms in the sequence
        /// </summary>
        int Length {get;}
    }

    /// <summary>
    /// Characterizes an expression defined via an operator
    /// </summary>
    public interface IOpExpr : IExpr
    {
        
    }

    /// <summary>
    /// Characterizes a typed expression defined via an operator
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IOpExpr<T> : IExpr<T>, IOpExpr
        where T : unmanaged
    {

    }


    /// <summary>
    /// Characterizes a typed expression defined via an operator of specified kind
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface IOpExpr<T,K> : IOpExpr<T>
        where T : unmanaged
        where K : Enum
    {
        K OpKind {get;}
    }


    /// <summary>
    /// Characterizes a logicical expression over a bit
    /// </summary>
    public interface ILogicExpr : IExpr
    {
        LogicExprKind ExprKind {get;}
    }

    public interface ILogicOpExpr : ILogicExpr, IOpExpr
    {

    }

    public interface ILogicOpExpr<K> : ILogicOpExpr, IOpExpr
        where K : Enum
    {
        K OpKind {get;}
    }

}