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
    /// Characterizes a binary operator
    /// </summary>
    public interface IBinaryOp : IOpExpr
    {
        
    }

    /// <summary>
    /// Characterizes a binary operator parametrized by expression type
    /// </summary>
    public interface IBinaryOp<X> : IBinaryOp
        where X : IExpr
    {
        X LeftArg {get;}

        X RightArg {get;}
    }

    /// <summary>
    /// Characterizes a binary operator parametrized by expression type and operator kind
    /// </summary>
    public interface IBinaryOp<X,K> : IBinaryOp<X>
        where X : IExpr
        where K : Enum
    {
        K OpKind {get;}
    }

    /// <summary>
    /// Characterizes a typed binary operator of specified kind
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface ITypedBinaryOp<T,K> : IBinaryOp, ITypedOpExpr<T,K> 
        where T : unmanaged
        where K : Enum
    {
        
    }

    public interface IBinaryLogicOp : IBinaryOp, ILogicOpExpr<BinaryLogicOpKind>
    {
        /// <summary>
        /// The left operand
        /// </summary>
        ILogicExpr LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        ILogicExpr RightArg {get;}

    }

    public interface IBinaryBitwiseOp<T> : ITypedBinaryOp<T,BinaryBitwiseOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The left operand
        /// </summary>
        ITypedExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        ITypedExpr<T> RightArg {get;}

        
    }



}