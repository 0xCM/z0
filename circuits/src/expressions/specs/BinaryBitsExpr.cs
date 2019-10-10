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

    partial class Bitwise
    {
        /// <summary>
        /// Joins an operator with left and right operands
        /// </summary>
        public sealed class BinaryBitsExpr<T> : IBinaryBitwiseExpr<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public BinaryBitsExpr(BitOpKind op, IBitwiseExpr<T> left, IBitwiseExpr<T> right)
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
            public IBitwiseExpr<T> Left {get;}

            /// <summary>
            /// The right operand
            /// </summary>
            public IBitwiseExpr<T> Right {get;}

        }

    }

}