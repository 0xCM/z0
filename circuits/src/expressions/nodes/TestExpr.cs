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
    /// Represents a comparison between a control expression and the result of applying a unary binary operator to specified operands
    /// </summary>
    public sealed class UnaryTestExpr<T> : TestExpr<T, UnaryBitsExpr<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public UnaryTestExpr(LogicOpKind testop, IBitExpr<T> control, UnaryBitsExpr<T> expr)
            : base(testop, ExprArity.Unary, control,expr)
        {
                
        }        

    }

    /// <summary>
    /// Represents a comparison between a control expression and the result of applying a bitwise binary operator to specified operands
    /// </summary>
    public sealed class BinaryTestExpr<T> : TestExpr<T, BinaryBitsExpr<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinaryTestExpr(LogicOpKind testop, IBitExpr<T> control, BinaryBitsExpr<T> expr)
            : base(testop, ExprArity.Binary, control,expr)
        {
                
        }        

    }

    /// <summary>
    /// Represents a comparison between a control expression and the result of applying a mixed bitwise operator to specified operands
    /// </summary>
    public sealed class MixedTestExpr<T> : TestExpr<T, MixedBitsExpr<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public MixedTestExpr(LogicOpKind testop, IBitExpr<T> control, MixedBitsExpr<T> expr)
            : base(testop, ExprArity.Binary, control,expr)
        {
                
        }        

    }

    public abstract class TestExpr<T,E> : ILogicOpExpr
        where T : unmanaged
        where E : IBitOpExpr
    {

        protected TestExpr(LogicOpKind op, ExprArity arity, IBitExpr<T> control, E subject)
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
        public IBitExpr<T> Control {get;}
        
        /// <summary>
        /// The expression to be tested
        /// </summary>
        public E Subject {get;}
    }
}