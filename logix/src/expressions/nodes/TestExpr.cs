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
    public sealed class UnaryTestExpr<T> : TestExpr<T, UnaryBitExpr<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public UnaryTestExpr(BinaryLogic testop, IBitExpr<T> control, UnaryBitExpr<T> expr)
            : base(testop, ExprArity.Unary, control,expr)
        {
                
        }        

    }

    /// <summary>
    /// Represents a comparison between a control expression and the result of applying a bitwise binary operator to specified operands
    /// </summary>
    public sealed class BinaryTestExpr<T> : TestExpr<T, BinaryBitExpr<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinaryTestExpr(BinaryLogic testop, IBitExpr<T> control, BinaryBitExpr<T> expr)
            : base(testop, ExprArity.Binary, control,expr)
        {
                
        }        

    }

    /// <summary>
    /// Represents a comparison between a control expression and the result of applying a mixed bitwise operator to specified operands
    /// </summary>
    public sealed class MixedTestExpr<T> : TestExpr<T, BitShiftExpr<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public MixedTestExpr(BinaryLogic testop, IBitExpr<T> control, BitShiftExpr<T> expr)
            : base(testop, ExprArity.Binary, control,expr)
        {
                
        }        

    }

    public abstract class TestExpr<T,E> : ILogicOpExpr
        where T : unmanaged
        where E : IBitOpExpr
    {

        protected TestExpr(BinaryLogic op, ExprArity arity, IBitExpr<T> control, E subject)
        {
            this.Operator = op;
            this.Arity = arity;
            this.Control = control;
            this.Subject = subject;
        }

        /// <summary>
        /// The test operator
        /// </summary>
        public BinaryLogic Operator {get;}

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