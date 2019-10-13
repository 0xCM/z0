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
    public sealed class UnaryBitExpr<T> : IUnaryBitExpr<T>
        where T : unmanaged
    {
        public UnaryBitExpr(BitOpKind op, IBitExpr<T> operand)
        {
            this.Operator = op;
            this.Subject = operand;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public BitOpKind Operator {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public ExprArity Arity => ExprArity.Unary;

        /// <summary>
        /// The operand
        /// </summary>
        public IBitExpr<T> Subject {get;}

    }


}