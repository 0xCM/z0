//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static UnaryArithmeticOpKind;
    using static BinaryArithmeticOpKind;
    using static TypedLogicSpec;

    public static class ArithmeticSpec
    {

        /// <summary>
        /// Defines an arithmetic unary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> unary<T>(UnaryArithmeticOpKind op, IExpr<T> a)
            where T : unmanaged
                => new UnaryAritheticOp<T>(op,a);

        /// <summary>
        /// Defines an arithmetic unary expression over a literal operand
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The literal value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> unary<T>(UnaryArithmeticOpKind op, T a)
            where T : unmanaged
                => new UnaryAritheticOp<T>(op, literal(a));

        /// <summary>
        /// Defines a binary arithmetic expression
        /// </summary>
        /// <param name="a">The left expression</param>
        /// <param name="b">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryArithmeticOp<T> binary<T>(BinaryArithmeticOpKind op, IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => new BinaryArithmeticOp<T>(op, a, b);

        /// <summary>
        /// Defines a binary arithmetic expression over literal operands
        /// </summary>
        /// <param name="a">The left expression</param>
        /// <param name="b">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryArithmeticOp<T> binary<T>(BinaryArithmeticOpKind op, T a, T b)
            where T : unmanaged
                => binary(op, literal(a), literal(b));

        /// <summary>
        /// Defines a unary increment expression
        /// </summary>
        /// <param name="a">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> inc<T>(IExpr<T> a)
            where T : unmanaged
                => unary(Inc, a);

        /// <summary>
        /// Defines a unary increment expression with a literal operand
        /// </summary>
        /// <param name="a">The literal value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> inc<T>(T a)
            where T : unmanaged
                => unary(Inc, a);

        /// <summary>
        /// Defines a unary decrement expression
        /// </summary>
        /// <param name="a">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> dec<T>(IExpr<T> a)
            where T : unmanaged
                => unary(Dec, a);

        /// <summary>
        /// Defines a decrement increment expression with a literal operand
        /// </summary>
        /// <param name="a">The literal value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> dec<T>(T a)
            where T : unmanaged
                => unary(Dec, a);

        /// <summary>
        /// Defines a unary decrement expression
        /// </summary>
        /// <param name="a">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> negate<T>(IExpr<T> a)
            where T : unmanaged
                => unary(Negate, a);

        /// <summary>
        /// Defines a decrement increment expression with a literal operand
        /// </summary>
        /// <param name="a">The literal value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryAritheticOp<T> negate<T>(T a)
            where T : unmanaged
                => unary(Negate, a);

        /// <summary>
        /// Defines a binary addition expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryArithmeticOp<T> add<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => binary(Add, a, b);

        /// <summary>
        /// Defines a binary addition expression over literal operands
        /// </summary>
        /// <param name="a">The left literal value</param>
        /// <param name="b">The right literal value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryArithmeticOp<T> add<T>(T a, T b)
            where T : unmanaged
                => binary(Add, a, b);

        /// <summary>
        /// Defines a binary subtraction expression
        /// </summary>
        /// <param name="a">The left expression</param>
        /// <param name="b">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryArithmeticOp<T> sub<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => binary(Sub, a, b);

        /// <summary>
        /// Defines a binary subtraction expression over literal operands
        /// </summary>
        /// <param name="a">The left literal value</param>
        /// <param name="b">The right literal value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryArithmeticOp<T> sub<T>(T a, T b)
            where T : unmanaged
                => binary(Sub, a, b);
    }
}