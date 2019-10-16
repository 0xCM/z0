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
    public sealed class UnaryTestExpr<T> : TestExpr<T, UnaryLogicExpr<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public UnaryTestExpr(BinaryLogicKind testop, IExpr<T> control, UnaryLogicExpr<T> expr)
            : base(testop, ArityKind.Unary, control,expr)
        {
                
        }        

    }

    /// <summary>
    /// Represents a comparison between a control expression and the result of applying a bitwise binary operator to specified operands
    /// </summary>
    public sealed class BinaryTestExpr<T> : TestExpr<T, BinaryLogicExpr<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinaryTestExpr(BinaryLogicKind testop, IExpr<T> control, BinaryLogicExpr<T> expr)
            : base(testop, ArityKind.Binary, control,expr)
        {
                
        }        

    }

    /// <summary>
    /// Represents a comparison between a control expression and the result of applying a mixed bitwise operator to specified operands
    /// </summary>
    public sealed class ShiftTestExpr<T> : TestExpr<T, BitShiftExpr<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public ShiftTestExpr(BinaryLogicKind testop, IExpr<T> control, BitShiftExpr<T> expr)
            : base(testop, ArityKind.Binary, control,expr)
        {
                
        }        

    }

    public abstract class TestExpr<T,E> : ILogicOp
        where T : unmanaged
        where E : IExpr
    {

        protected TestExpr(BinaryLogicKind op, ArityKind arity, IExpr<T> control, E subject)
        {
            this.Operator = op;
            this.Arity = arity;
            this.Control = control;
            this.Subject = subject;
        }

        /// <summary>
        /// The test operator
        /// </summary>
        public BinaryLogicKind Operator {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public ArityKind Arity {get;}

        /// <summary>
        /// The control expression
        /// </summary>
        public IExpr<T> Control {get;}
        
        /// <summary>
        /// The expression to be tested
        /// </summary>
        public E Subject {get;}
    }
}