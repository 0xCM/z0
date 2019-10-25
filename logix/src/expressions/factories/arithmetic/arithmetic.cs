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
        public static TypedLiteralExpr<T> literal<T>(T value)
            where T : unmanaged
                => new TypedLiteralExpr<T>(value);

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

        /// <summary>
        /// Defines a binary addition expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryAritheticOp<T> add<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => new BinaryAritheticOp<T>(BinaryArithmeticOpKind.Add, a, b);

        /// <summary>
        /// Defines a binary addition expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryAritheticOp<T> add<T>(T a, T b)
            where T : unmanaged
                => new BinaryAritheticOp<T>(BinaryArithmeticOpKind.Add, literal(a), literal(b));

        /// <summary>
        /// Defines a binary subtraction expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryAritheticOp<T> sub<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => new BinaryAritheticOp<T>(BinaryArithmeticOpKind.Sub, a, b);

        /// <summary>
        /// Defines a binary subtraction expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryAritheticOp<T> sub<T>(T a, T b)
            where T : unmanaged
                => new BinaryAritheticOp<T>(BinaryArithmeticOpKind.Sub, literal(a), literal(b));

        /// <summary>
        /// Defines an equality comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> cmpeq<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.Eq, a, b);

        /// <summary>
        /// Defines an equality comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> cmpeq<T>(T a, T b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.Eq, literal(a), literal(b));

        /// <summary>
        /// Defines a less-than comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lt<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.Lt, a, b);

        /// <summary>
        /// Defines a less-than comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lt<T>(T a, T b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.Lt, literal(a), literal(b));

        /// <summary>
        /// Defines a less-than or equal comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lteq<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.LtEq, a, b);

        /// <summary>
        /// Defines a less-than or equal comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lteq<T>(T a, T b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.LtEq, literal(a), literal(b));

        /// <summary>
        /// Defines a greater-than comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gt<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.Gt, a, b);

        /// <summary>
        /// Defines a greater-than comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gt<T>(T a, T b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.Gt, literal(a), literal(b));

        /// <summary>
        /// Defines a greater-than or equal comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gteq<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.GtEq, a, b);

        /// <summary>
        /// Defines a greater-than or equal comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gteq<T>(T a, T b)
            where T : unmanaged
                => new ComparisonExpr<T>(ComparisonOpKind.GtEq, literal(a), literal(b));

    }

}