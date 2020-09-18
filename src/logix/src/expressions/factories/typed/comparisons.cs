//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static TypedLogicSpec;

    using TLS = TypedLogicSpec;
    using BCK = BinaryComparisonApiKey;

    /// <summary>
    /// Constructs type operator comparison expressions
    /// </summary>
    public static class TypedComparisonSpec
    {
        /// <summary>
        /// Defines a comparison expression of specified kind over typed expressions
        /// </summary>
        /// <param name="kind">The comparison kind</param>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> compare<T>(BCK kind, IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(kind, lhs,rhs);

        /// <summary>
        /// Defines a comparison expression of specified kind over literals
        /// </summary>
        /// <param name="kind">The comparison kind</param>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> compare<T>(BCK kind, T lhs, T rhs)
            where T : unmanaged
                => binary(kind, literal(lhs), literal(rhs));

        /// <summary>
        /// Defines an equals operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> equals<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(BCK.Eq, lhs,rhs);

        /// <summary>
        /// Defines an equals operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> equals<T>(T lhs, T rhs)
            where T : unmanaged
                => binary(BCK.Eq, TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a not equal operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> neq<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(BCK.Neq, lhs,rhs);

        /// <summary>
        /// Defines a not equal operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> neq<T>(T lhs, T rhs)
            where T : unmanaged
                => binary(BCK.Neq, TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a less than operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lt<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(BCK.Lt, lhs,rhs);

        /// <summary>
        /// Defines an less than operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lt<T>(T lhs, T rhs)
            where T : unmanaged
                => binary(BCK.Lt, TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a less than or equal operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lteq<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(BCK.LtEq, lhs,rhs);

        /// <summary>
        /// Defines an less than or equal operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lteq<T>(T lhs, T rhs)
            where T : unmanaged
                => binary(BCK.LtEq, TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a greater than operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gt<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(BCK.Gt, lhs,rhs);

        /// <summary>
        /// Defines greater than operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gt<T>(T lhs, T rhs)
            where T : unmanaged
                => binary(BCK.Gt, TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a greater than or equal operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gteq<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(BCK.GtEq, lhs,rhs);

        /// <summary>
        /// Defines a greater than or equal operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gteq<T>(T lhs, T rhs)
            where T : unmanaged
                => binary(BCK.GtEq, TLS.literal(lhs), TLS.literal(rhs));
    }
}