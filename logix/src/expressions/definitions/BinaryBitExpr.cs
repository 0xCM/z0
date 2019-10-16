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
    public sealed class BinaryBitExpr<T> : IBinaryBitExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinaryBitExpr(BitOpKind op, IBitExpr<T> left, IBitExpr<T> right)
        {
            this.Operator = op;
            this.Left = left;
            this.Right = right;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public BitOpKind Operator {get;}

        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public ExprArity Arity => ExprArity.Binary;

        /// <summary>
        /// The left operand
        /// </summary>
        public IBitExpr<T> Left {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IBitExpr<T> Right {get;}

    }


}