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
    public sealed class BinaryBitwiseOp<T> : IBinaryBitwiseOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinaryBitwiseOp(BinaryBitwiseOpKind op, ITypedExpr<T> left, ITypedExpr<T> right)
        {
            this.OpKind = op;
            this.LeftArg = left;
            this.RightArg = right;
        }

        /// <summary>
        /// The expression classifier
        /// </summary>
        public TypedExprKind ExprKind 
            => TypedExprKind.BinaryOperator;

        /// <summary>
        /// The operator
        /// </summary>
        public BinaryBitwiseOpKind OpKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public ITypedExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ITypedExpr<T> RightArg {get;}

        public string Format()
            => OpKind.Format(LeftArg,RightArg);
        
        public override string ToString()
            => Format();
    }
}