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
    /// Captures a comparison expression along with with its operands
    /// </summary>
    public sealed class ComparisonExpr<T> : IComparisonExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public ComparisonExpr(ComparisonOpKind op, ITypedExpr<T> left, ITypedExpr<T> right)
        {
            this.OpKind = op;
            this.LeftArg = left;
            this.RightArg = right;
        }
        
        /// <summary>
        /// The expression classifier
        /// </summary>
        public TypedExprKind ExprKind 
            => TypedExprKind.Comparison;

        /// <summary>
        /// The operator
        /// </summary>
        public ComparisonOpKind OpKind {get;}

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