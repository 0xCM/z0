//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Characterizes a unary operator
    /// </summary>
    public interface IUnaryOp : IOpExpr
    {
        
    }


    public interface IUnaryLogicOp : IUnaryOp, ILogicOpExpr<UnaryLogicOpKind>
    {
        /// <summary>
        /// The one and only operand
        /// </summary>
        ILogicExpr Operand {get;}
    }

    /// <summary>
    /// Characterizes a typed unary operator
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface IUnaryOp<T> : IUnaryOp, IOpExpr<T,UnaryLogicOpKind> 
        where T : unmanaged
    {
        /// <summary>
        /// The one and only operand
        /// </summary>
        IExpr<T> Operand {get;}


    }

 
}