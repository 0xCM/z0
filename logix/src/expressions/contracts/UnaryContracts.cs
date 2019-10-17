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

    public interface IUnaryLogicOp : ILogicOp<UnaryLogicOpKind>
    {
        /// <summary>
        /// The one and only operand
        /// </summary>
        ILogicExpr Operand {get;}
    }

    public interface IUnaryLogicOp<T> : IOpExpr<T,UnaryLogicOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The one and only operand
        /// </summary>
        IExpr<T> Operand {get;}


    }


}