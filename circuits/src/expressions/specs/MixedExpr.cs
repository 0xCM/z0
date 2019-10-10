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
        /// Joins a mixed operator with left and right operands
        /// </summary>
        public sealed class MixedBitsExpr<T> : IMixedBitwiseExpr<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public MixedBitsExpr(BitOpKind op, IBitwiseExpr<T> left, uint right)
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
            /// The number of parameters accepted by the expression
            /// </summary>
            public ExprArity Arity => ExprArity.Binary;

            /// <summary>
            /// The left operand
            /// </summary>
            public IBitwiseExpr<T> Left {get;}

            /// <summary>
            /// The right operand
            /// </summary>
            public uint Right {get;}


        }

    }

}