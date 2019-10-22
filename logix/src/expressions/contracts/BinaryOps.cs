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
    /// Characterizes a typed binary operator of specified kind
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface IBinaryOp<T,K> : IBinaryOp, IOpExpr<T,K> 
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

    public interface IBinaryOp<T> : IBinaryOp<T,BinaryLogicOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The left operand
        /// </summary>
        IExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        IExpr<T> RightArg {get;}

        
    }



}