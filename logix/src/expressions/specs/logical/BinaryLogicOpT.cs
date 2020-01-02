//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines a typed binary logical operator expression
    /// </summary>
    public sealed class BinaryLogicOp<T> : BinaryLogicOp, IBinaryLogicOp<T>
        where T : unmanaged
    {
        /// <summary>
        /// The left operand
        /// </summary>
        public new ILogicExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public new ILogicExpr<T> RightArg {get;}

        [MethodImpl(Inline)]
        public BinaryLogicOp(BinaryLogicOpKind op, ILogicExpr<T> left, ILogicExpr<T> right)
            : base(op,left,right)
        {
            this.LeftArg = left;
            this.RightArg = right;
        }
    }
}