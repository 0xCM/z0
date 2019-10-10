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
        public abstract class TestExpr<T,E> : IBitLogicExpr<T>
            where T : unmanaged
            where E : IBitwiseExpr
        {

            protected TestExpr(LogicOpKind op, ExprArity arity, Expr<T> control, E subject)
            {
                this.Operator = op;
                this.Arity = arity;
                this.Control = control;
                this.Subject = subject;
            }

            /// <summary>
            /// The test operator
            /// </summary>
            public LogicOpKind Operator {get;}

            /// <summary>
            /// The number of parameters accepted by the expression
            /// </summary>
            public ExprArity Arity {get;}

            /// <summary>
            /// The control expression
            /// </summary>
            public Expr<T> Control {get;}
            
            /// <summary>
            /// The expression to be tested
            /// </summary>
            public E Subject {get;}
        }

    }

}