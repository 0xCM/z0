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

    public interface ITernaryLogicOp : ITernaryOp, ILogicOp<TernaryLogicOpKind>
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

    public interface ITernaryLogicOp<T> : ITernaryOp<T>, IOpExpr<T,TernaryLogicOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The first operand
        /// </summary>
        ILogicExpr<T> FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        ILogicExpr<T> SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        ILogicExpr<T> ThirdArg {get;}

    }

}