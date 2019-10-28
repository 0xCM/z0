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
    using TLS = TypedLogicSpec;

    /// <summary>
    /// Constructs type operator comparison expressions
    /// </summary>
    public static class TypedComparisonSpec
    {
        /// <summary>
        /// Defines an equals operator expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> equals<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => TLS.binary(ComparisonKind.Eq, lhs,rhs);

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
        public static ComparisonExpr<T> neq<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => TLS.binary(ComparisonKind.Neq, lhs,rhs);

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
        public static ComparisonExpr<T> lt<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => TLS.binary(ComparisonKind.Lt, lhs,rhs);

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
        public static ComparisonExpr<T> lteq<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => TLS.binary(ComparisonKind.LtEq, lhs,rhs);

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
        public static ComparisonExpr<T> gt<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => TLS.binary(ComparisonKind.Gt, lhs,rhs);

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
        public static ComparisonExpr<T> gteq<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => TLS.binary(ComparisonKind.GtEq, lhs,rhs);

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