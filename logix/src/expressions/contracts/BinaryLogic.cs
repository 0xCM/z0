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

    public interface IBinaryLogicOp : IBinaryOp, ILogicOp<BinaryLogicOpKind>
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

    public interface IBinaryLogicOp<T> : IBinaryOp<T>, IOpExpr<T,BinaryLogicOpKind>
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