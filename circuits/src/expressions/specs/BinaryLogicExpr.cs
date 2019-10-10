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
        /// Represents a logical operator with two bitwise expressions
        /// </summary>
        public sealed class BinaryLogicExpr<T> : IBinaryLogicExpr<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public BinaryLogicExpr(LogicOpKind op, IBitwiseExpr<T> left, IBitwiseExpr<T> right)
            {
                this.Operator = op;
                this.Left = left;
                this.Right = right;
            }
            
            /// <summary>
            /// The operator
            /// </summary>
            public LogicOpKind Operator {get;}

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