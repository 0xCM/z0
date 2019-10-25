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
    public interface IUnaryOp : IOpExpr
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

    public interface IUnaryLogicOp : IUnaryOp<ILogicExpr>, ILogicOpExpr<UnaryLogicOpKind>
    {

    }

    /// <summary>
    /// Characterizes a typed unary operator
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface ITypedUnaryOp<T> : IUnaryOp<ITypedExpr<T>>, ITypedOpExpr<T> 
        where T : unmanaged
    {


    }

    public interface ITypedUnaryOp<T,K> :  ITypedUnaryOp<T>, ITypedOpExpr<T,K>
        where K : Enum
        where T : unmanaged
    {

    }

    public interface IUnaryBitwiseOp<T> : ITypedUnaryOp<T, UnaryBitwiseOpKind>
        where T : unmanaged
    {
        
    }


}