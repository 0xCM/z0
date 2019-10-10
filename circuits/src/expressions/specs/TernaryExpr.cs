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
        public sealed class TernaryExpr<T> : ITernaryBitwiseExpr<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public TernaryExpr(BitOpKind op, IBitwiseExpr<T> a, IBitwiseExpr<T> b, IBitwiseExpr<T> c)
            {
                this.Operator = op;
                this.First = a;
                this.Second = b;
                this.Third = c;
            }
            
            /// <summary>
            /// The operator
            /// </summary>
            public BitOpKind Operator {get;}

            /// <summary>
            /// The first operand
            /// </summary>
            public IBitwiseExpr<T> First {get;}

            /// <summary>
            /// The second operand
            /// </summary>
            public IBitwiseExpr<T> Second {get;}

            /// <summary>
            /// The third operand
            /// </summary>
            public IBitwiseExpr<T> Third {get;}

            /// <summary>
            /// The number of parameters accepted by the expression
            /// </summary>
            public ExprArity Arity => ExprArity.Ternary;     

        }

    }

}