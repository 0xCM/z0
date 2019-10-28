//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Captures a binary arithmetic operator along with with its operands
    /// </summary>
    public sealed class BinaryArithmeticOp<T> : IBinaryArithmeticOp<T>
        where T : unmanaged
    {
        public BinaryArithmeticOp(BinaryArithmeticOpKind op, ITypedExpr<T> lhs, ITypedExpr<T> rhs)
        {
            this.OpKind = op;
            this.LeftArg= lhs;
            this.RightArg = rhs;
        }
        
        /// <summary>
        /// The expression classifier
        /// </summary>
        public TypedExprKind ExprKind 
            => TypedExprKind.BinaryOperator;

        /// <summary>
        /// The operator
        /// </summary>
        public BinaryArithmeticOpKind OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public ITypedExpr<T> LeftArg {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public ITypedExpr<T> RightArg {get;}

        /// <summary>
        /// Renders the expression in canonical form
        /// </summary>
        public string Format()
            => OpKind.Format(LeftArg, RightArg);
        
        public override string ToString()
            => Format();

    }


}