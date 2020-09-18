//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static BinaryComparisonApiKey;
    using static TypedLogicSpec;

    public readonly struct PredicateSpec
    {
        /// <summary>
        /// Defines a typed comparison predicate over operand expressions
        /// </summary>
        /// <param name="kind">The comparison kind</param>
        /// <param name="a">The left expression</param>
        /// <param name="b">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> compare<T>(BinaryComparisonApiKey kind, IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => new ComparisonPredExpr<T>(kind,a,b);

        /// <summary>
        /// Defines a typed comparison predicate over literal operands
        /// </summary>
        /// <param name="kind">The comparison kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> compare<T>(BinaryComparisonApiKey kind, T a, T b)
            where T : unmanaged
                => new ComparisonPredExpr<T>(kind, literal(a), literal(b));

        /// <summary>
        /// Defines an equality comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> equals<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => compare(Eq, a, b);

        /// <summary>
        /// Defines an equality comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> equals<T>(T a, T b)
            where T : unmanaged
                => compare(Eq, a, b);

        /// <summary>
        /// Defines a less-than comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> lt<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => compare(Lt, a, b);

        /// <summary>
        /// Defines a less-than comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> lt<T>(T a, T b)
            where T : unmanaged
                => compare(Lt, a, b);

        /// <summary>
        /// Defines a less-than or equal comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> lteq<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => compare(LtEq, a, b);

        /// <summary>
        /// Defines a less-than or equal comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> lteq<T>(T a, T b)
            where T : unmanaged
                => compare(LtEq, a, b);

        /// <summary>
        /// Defines a greater-than comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> gt<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => compare(Gt, a, b);

        /// <summary>
        /// Defines a greater-than comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> gt<T>(T a, T b)
            where T : unmanaged
                => compare(Gt, a, b);

        /// <summary>
        /// Defines a greater-than or equal comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> gteq<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => compare(GtEq, a, b);

        /// <summary>
        /// Defines a greater-than or equal comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPredExpr<T> gteq<T>(T a, T b)
            where T : unmanaged
                => compare(GtEq, a, b);
    }
}