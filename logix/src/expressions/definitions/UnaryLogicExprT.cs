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
    public sealed class UnaryLogicExpr<T> : IUnaryLogicOp<T>
        where T : unmanaged
    {
        public UnaryLogicExpr(UnaryLogicKind op, IExpr<T> operand)
        {
            this.Operator = op;
            this.Operand = operand;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public UnaryLogicKind Operator {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public ArityKind Arity => ArityKind.Unary;

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Operand {get;}

    }


}