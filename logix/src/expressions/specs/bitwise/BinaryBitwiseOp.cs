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
    /// Captures a binary bitwise operator along with with its operands
    /// </summary>
    public sealed class BinaryBitwiseOp<T> : IBinaryBitwiseOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinaryBitwiseOp(BinaryBitwiseOpKind op, IExpr<T> left, IExpr<T> right)
        {
            this.OpKind = op;
            this.LeftArg = left;
            this.RightArg = right;
        }

        /// <summary>
        /// The operator
        /// </summary>
        public BinaryBitwiseOpKind OpKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public IExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IExpr<T> RightArg {get;}

        /// <summary>
        /// Renders the expression in canonical form
        /// </summary>
        public string Format()
            => OpKind.Format(LeftArg,RightArg);
        
        public override string ToString()
            => Format();
    }
}