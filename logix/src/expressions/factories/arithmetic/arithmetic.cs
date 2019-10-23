//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    //using static TypedLogicSpec;

    public static class ArithmeticSpec
    {
        /// <summary>
        /// Creates a literal expression
        /// </summary>
        /// <param name="value">The literal value</param>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<T> literal<T>(T value)
            where T : unmanaged
                => new LiteralExpr<T>(value);

        /// <summary>
        /// Creates an arithmetic unary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> unary<T>(UnaryArithmeticOpKind op, ITypedExpr<T> operand)
            where T : unmanaged
                => new UnaryAritheticOp<T>(op,operand);

        /// <summary>
        /// Defines a unary increment expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> inc<T>(ITypedExpr<T> operand)
            where T : unmanaged
                => unary(UnaryArithmeticOpKind.Inc, operand);

        /// <summary>
        /// Defines a unary increment expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> inc<T>(T operand)
            where T : unmanaged
                => inc(literal(operand));

        /// <summary>
        /// Defines a unary decrement expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> dec<T>(ITypedExpr<T> operand)
            where T : unmanaged
                => unary(UnaryArithmeticOpKind.Dec, operand);

        /// <summary>
        /// Defines a decrement increment expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> dec<T>(T operand)
            where T : unmanaged
                => dec(literal(operand));

        /// <summary>
        /// Defines a unary decrement expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> negate<T>(ITypedExpr<T> operand)
            where T : unmanaged
                => unary(UnaryArithmeticOpKind.Negate, operand);

        /// <summary>
        /// Defines a decrement increment expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> negate<T>(T operand)
            where T : unmanaged
                => negate(literal(operand));

    }

}