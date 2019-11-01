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
    /// Characterizes a unary operator
    /// </summary>
    public interface IUnaryOp : IOperator
    {
        
    }

    /// <summary>
    /// Characterizes a unary operator parametrized by an expression type
    /// </summary>
    public interface IUnaryOp<X> : IUnaryOp
        where X : IExpr
    {
        /// <summary>
        /// The operand
        /// </summary>
        X Arg {get;}
    }


    public interface IUnaryBitwiseOp<T> : IUnaryOp<IExpr<T>>, IOperator<T, UnaryBitwiseOpKind>
        where T : unmanaged
    {
        
    }

    public interface IUnaryLogicOp : IUnaryOp<ILogicExpr>, ILogicOp<UnaryLogicOpKind>
    {

    }

    public interface IUnaryLogicOp<T> :  IUnaryLogicOp, IUnaryOp<ILogicExpr<T>>, ILogicOp<T,UnaryLogicOpKind>
        where T : unmanaged
    {

    }

}