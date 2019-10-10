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
        public sealed class UnaryBitsExpr<T> : IUnaryBitwiseExpr<T>
            where T : unmanaged
        {
            public UnaryBitsExpr(BitOpKind op, IBitwiseExpr<T> operand)
            {
                this.Operator = op;
                this.Operand = operand;
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
            public IBitwiseExpr<T> Operand {get;}

        }

    }

}