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
    public sealed class ComparisonOp<T> : IComparisonOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public ComparisonOp(ComparisonOpKind op, IArithmeticExpr<T> left, IArithmeticExpr<T> right)
        {
            this.OpKind = op;
            this.LeftArg = left;
            this.RightArg = right;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public ComparisonOpKind OpKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public IArithmeticExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IArithmeticExpr<T> RightArg {get;}

        public string Format()
            => OpKind.Format(LeftArg,RightArg);
        
        public override string ToString()
            => Format();

    }


}