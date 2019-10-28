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
    using static ComparisonKind;

    public static class PredicateSpec
    {
        /// <summary>
        /// Creates a literal expression
        /// </summary>
        /// <param name="value">The literal value</param>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        static TypedLiteralExpr<T> literal<T>(T value)
            where T : unmanaged
                => TypedLogicSpec.literal(value);

        [MethodImpl(Inline)]
        public static ComparisonPred<T> compare<T>(ComparisonKind kind, ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => new ComparisonPred<T>(kind,a,b);

        [MethodImpl(Inline)]
        public static ComparisonPred<T> compare<T>(ComparisonKind kind, T a, T b)
            where T : unmanaged
                => new ComparisonPred<T>(kind,literal(a),literal(b));

        /// <summary>
        /// Defines an equality comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> equals<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => compare(Eq, a, b);

        /// <summary>
        /// Defines an equality comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> equals<T>(T a, T b)
            where T : unmanaged
                => compare(Eq, a, b);

        /// <summary>
        /// Defines a less-than comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> lt<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => compare(Lt, a, b);

        /// <summary>
        /// Defines a less-than comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> lt<T>(T a, T b)
            where T : unmanaged
                => compare(Lt, literal(a), literal(b));

        /// <summary>
        /// Defines a less-than or equal comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> lteq<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => compare(LtEq, a, b);

        /// <summary>
        /// Defines a less-than or equal comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> lteq<T>(T a, T b)
            where T : unmanaged
                => compare(LtEq, literal(a), literal(b));

        /// <summary>
        /// Defines a greater-than comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> gt<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => compare(Gt, a, b);

        /// <summary>
        /// Defines a greater-than comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> gt<T>(T a, T b)
            where T : unmanaged
                => compare(Gt, literal(a), literal(b));

        /// <summary>
        /// Defines a greater-than or equal comparison expression
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> gteq<T>(ITypedExpr<T> a, ITypedExpr<T> b)
            where T : unmanaged
                => compare(GtEq, a, b);

        /// <summary>
        /// Defines a greater-than or equal comparison expression over literal operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonPred<T> gteq<T>(T a, T b)
            where T : unmanaged
                => compare(GtEq, literal(a), literal(b));
    }

}