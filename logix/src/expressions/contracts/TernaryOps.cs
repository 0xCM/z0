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
    /// Characterizes a ternary operator
    /// </summary>
    public interface ITernaryOp : IOpExpr
    {
        
    }

    public interface ITernaryLogicOp : ITernaryOp, ILogicOpExpr<Ternary512OpKind>
    {

        /// <summary>
        /// The first operand
        /// </summary>
        ILogicExpr FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        ILogicExpr SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        ILogicExpr ThirdArg {get;}
    }

    /// <summary>
    /// Characterizes a typed ternary operator of specified kind
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface ITernaryOp<T> : ITernaryOp, IOpExpr<T,Ternary512OpKind> 
        where T : unmanaged
    {
        /// <summary>
        /// The first operand
        /// </summary>
        ITypedExpr<T> FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        ITypedExpr<T> SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        ITypedExpr<T> ThirdArg {get;}

    }

}