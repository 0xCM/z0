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

    public interface ITernaryLogicOp : ILogicOp<TernaryLogicKind>
    {

        /// <summary>
        /// The first operand
        /// </summary>
        ILogicExpr First {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        ILogicExpr Second {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        ILogicExpr Third {get;}
    }

    public interface ITernaryLogicOp<T> : IOpExpr<T,TernaryLogicKind>
        where T : unmanaged
    {
        /// <summary>
        /// The first operand
        /// </summary>
        ILogicExpr<T> First {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        ILogicExpr<T> Second {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        ILogicExpr<T> Third {get;}

    }

}