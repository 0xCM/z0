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

    public interface IBinaryLogicOp : ILogicOp<BinaryLogicKind>
    {
        /// <summary>
        /// The left operand
        /// </summary>
        ILogicExpr Left {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        ILogicExpr Right {get;}

    }

    public interface IBinaryLogicOp<T> : IOpExpr<T,BinaryLogicKind>
        where T : unmanaged
    {
        /// <summary>
        /// The left operand
        /// </summary>
        IExpr<T> Left {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        IExpr<T> Right {get;}

        
    }



}