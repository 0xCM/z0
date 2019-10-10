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
        public sealed class UnaryLogicExpr<T> : IUnaryLogicExpr<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public UnaryLogicExpr(LogicOpKind op, IBitwiseExpr<T> operand)
            {
                this.Operator = op;
                this.Operand = operand;
            }
            
            /// <summary>
            /// The operator
            /// </summary>
            public LogicOpKind Operator {get;}

            /// <summary>
            /// The number of parameters accepted by the expression
            /// </summary>
            public ExprArity Arity => ExprArity.Unary;

            /// <summary>
            /// The left operand
            /// </summary>
            public IBitwiseExpr<T> Operand {get;}

        }
    }
}