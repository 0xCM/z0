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

    /// <summary>
    /// Joins an operator with left and right operands
    /// </summary>
    public sealed class BinaryLogicOp<T> : IBinaryLogicOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinaryLogicOp(BinaryLogicOpKind op, IExpr<T> left, IExpr<T> right)
        {
            this.OpKind = op;
            this.LeftArg = left;
            this.RightArg = right;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public BinaryLogicOpKind OpKind {get;}

        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public OpArityKind Arity => OpArityKind.Binary;

        /// <summary>
        /// The left operand
        /// </summary>
        public IExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IExpr<T> RightArg {get;}

    }


}