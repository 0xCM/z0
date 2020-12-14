//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct BitLogicSpec
    {
        /// <summary>
        /// Defines comparison expression
        /// </summary>
        /// <param name="kind">The comparisonkind</param>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr compare(BinaryComparisonApiClass kind, ILogicExpr lhs, ILogicExpr rhs, params ILogicVarExpr[] variables)
            => Comparisons.define(kind, lhs,rhs,variables);

        /// <summary>
        /// Defines comparison expression
        /// </summary>
        /// <param name="kind">The comparisonkind</param>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> compare<T>(BinaryComparisonApiClass kind, ILogicExpr<T> lhs, ILogicExpr<T> rhs, params IVarExpr<T>[] variables)
            where T : unmanaged
                => Comparisons.define(kind, lhs,rhs, variables);

        /// <summary>
        /// Defines an equality comparison expression
        /// </summary>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr equals(ILogicExpr lhs, ILogicExpr rhs, params ILogicVarExpr[] variables)
            => Comparisons.define(BinaryComparisonApiClass.Eq, lhs,rhs,variables);

        /// <summary>
        /// Defines an equality comparison expression
        /// </summary>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> equals<T>(ILogicExpr<T> lhs, ILogicExpr<T> rhs, params IVarExpr<T>[] variables)
            where T : unmanaged
                => Comparisons.define(BinaryComparisonApiClass.Eq, lhs,rhs, variables);
    }
}