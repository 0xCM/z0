//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using TLS = TypedLogicSpec;
    using static TypedLogicSpec;

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
        public static ComparisonExpr<T> compare<T>(ComparisonOpKind kind, IExpr<T> lhs, IExpr<T> rhs)
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
        public static ComparisonExpr<T> compare<T>(ComparisonOpKind kind, T lhs, T rhs)
            where T : unmanaged
                => compare(kind, literal(lhs), literal(rhs));

        /// <summary>
        /// Defines an equals operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> equals<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(ComparisonOpKind.Eq, lhs,rhs);

        /// <summary>
        /// Defines an equals operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> equals<T>(T lhs, T rhs)
            where T : unmanaged
                => equals(TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a not equal operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> neq<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(ComparisonOpKind.Neq, lhs,rhs);

        /// <summary>
        /// Defines a not equal operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> neq<T>(T lhs, T rhs)
            where T : unmanaged
                => neq(TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a less than operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lt<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(ComparisonOpKind.Lt, lhs,rhs);

        /// <summary>
        /// Defines an less than operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lt<T>(T lhs, T rhs)
            where T : unmanaged
                => lt(TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a less than or equal operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lteq<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(ComparisonOpKind.LtEq, lhs,rhs);

        /// <summary>
        /// Defines an less than or equal operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> lteq<T>(T lhs, T rhs)
            where T : unmanaged
                => lteq(TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a greater than operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gt<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(ComparisonOpKind.Gt, lhs,rhs);

        /// <summary>
        /// Defines greater than operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gt<T>(T lhs, T rhs)
            where T : unmanaged
                => gt(TLS.literal(lhs), TLS.literal(rhs));

        /// <summary>
        /// Defines a greater than or equal operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gteq<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => compare(ComparisonOpKind.GtEq, lhs,rhs);

        /// <summary>
        /// Defines a greater than or equal operator expression over literal values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> gteq<T>(T lhs, T rhs)
            where T : unmanaged
                => gteq(TLS.literal(lhs), TLS.literal(rhs));
    }
}