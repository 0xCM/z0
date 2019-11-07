//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    partial class BitLogicSpec
    {
       /// <summary>
        /// Defines comparison expression
        /// </summary>
        /// <param name="kind">The comparisonkind</param>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr compare(ComparisonKind kind, ILogicExpr lhs, ILogicExpr rhs, params ILogicVarExpr[] variables)
            => ComparisonExpr.Define(kind, lhs,rhs,variables);

        /// <summary>
        /// Defines comparison expression
        /// </summary>
        /// <param name="kind">The comparisonkind</param>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> compare<T>(ComparisonKind kind, ILogicExpr<T> lhs, ILogicExpr<T> rhs, params IVarExpr<T>[] variables)
            where T : unmanaged
                => ComparisonExpr.Define(kind, lhs,rhs, variables);

        /// <summary>
        /// Defines an equality comparison expression
        /// </summary>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr equals(ILogicExpr lhs, ILogicExpr rhs, params ILogicVarExpr[] variables)
            => ComparisonExpr.Define(ComparisonKind.Eq, lhs,rhs,variables);

        /// <summary>
        /// Defines an equality comparison expression
        /// </summary>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> equals<T>(ILogicExpr<T> lhs, ILogicExpr<T> rhs, params IVarExpr<T>[] variables)
            where T : unmanaged
                => ComparisonExpr.Define(ComparisonKind.Eq, lhs,rhs, variables);

    }

}