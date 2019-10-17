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
    public sealed class UnaryLogicOp<T> : IUnaryLogicOp<T>
        where T : unmanaged
    {
        public UnaryLogicOp(UnaryLogicOpKind op, IExpr<T> operand)
        {
            this.OpKind = op;
            this.Operand = operand;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public UnaryLogicOpKind OpKind {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public OpArityKind Arity => OpArityKind.Unary;

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Operand {get;}

    }


}