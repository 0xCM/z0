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
    /// Joins an operator with left and right operands
    /// </summary>
    public sealed class UnaryAritheticOp<T> : IUnaryArithmeticOp<T>
        where T : unmanaged
    {
        public UnaryAritheticOp(UnaryArithmeticOpKind op, ITypedExpr<T> operand)
        {
            this.OpKind = op;
            this.Arg = operand;
        }
        
        /// <summary>
        /// The expression classifier
        /// </summary>
        public TypedExprKind ExprKind 
            => TypedExprKind.UnaryOperator;

        /// <summary>
        /// The operator
        /// </summary>
        public UnaryArithmeticOpKind OpKind {get;}


        /// <summary>
        /// The operand
        /// </summary>
        public ITypedExpr<T> Arg {get;}


        public string Format()
            => OpKind.Format(Arg);

        public override string ToString()
            => Format();

    }


}