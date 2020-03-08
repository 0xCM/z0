//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

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
    public interface IOperatorExpr : IExpr
    {
        
    }

    /// <summary>
    /// Characterizes a parametric operator that varies over operand type
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IOperatorExpr<T> : IOperatorExpr, IExpr<T> 
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a parametric operator that varies over operator kind and operand type
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface IOperatorExpr<T,K> : IOperatorExpr<T>
        where T : unmanaged
        where K : unmanaged, Enum
    {
        /// <summary>
        /// Specifies the class to which the operator belongs
        /// </summary>
        K OpKind {get;}
    }

    /// <summary>
    /// Characterizes a binary operator parametrized by expression type
    /// </summary>
    public interface IBinaryOpExpr<X> : IOperatorExpr
        where X : IExpr
    {
        X LeftArg {get;}

        X RightArg {get;}
    }

    /// <summary>
    /// Characterizes a unary operator parametrized by an expression type
    /// </summary>
    public interface IUnaryOpExpr<X> : IOperatorExpr
        where X : IExpr
    {
        /// <summary>
        /// The operand
        /// </summary>
        X Arg {get;}
    }

    /// <summary>
    /// Characterizes a ternary operator parametrized by expression type
    /// </summary>
    public interface ITernaryOpExpr<X> : IOperatorExpr
        where X : IExpr
    {
        X FirstArg {get;}

        X SecondArg {get;}

        X ThirdArg {get;}
    }
}