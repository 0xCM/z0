//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    using static OpHelpers;

    //[ApiHost("predicate.api", ApiHostKind.Generic)]
    public static class PredicateApi
    {
        /// <summary>
        /// Specifies the supported comparison predicates
        /// </summary>
        public static ReadOnlySpan<ComparisonOpKind> ComparisonKinds
            => array(
                ComparisonOpKind.Eq, ComparisonOpKind.Neq, 
                ComparisonOpKind.Lt, ComparisonOpKind.LtEq, 
                ComparisonOpKind.Gt, ComparisonOpKind.GtEq );


        [Op, NumericClosures(NumericKind.Integers)]
        public static bit eval<T>(ComparisonOpKind kind, T a, T b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonOpKind.Eq: return gmath.eq(a,b);
                case ComparisonOpKind.Neq: return gmath.neq(a,b);
                case ComparisonOpKind.Lt: return gmath.lt(a,b);
                case ComparisonOpKind.LtEq: return gmath.lteq(a,b);
                case ComparisonOpKind.Gt: return gmath.gt(a,b);
                case ComparisonOpKind.GtEq: return gmath.gteq(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryPred<T> lookup<T>(ComparisonOpKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonOpKind.Eq: return gmath.eq;
                case ComparisonOpKind.Neq: return gmath.neq;
                case ComparisonOpKind.Lt: return gmath.lt;
                case ComparisonOpKind.LtEq: return gmath.lteq;
                case ComparisonOpKind.Gt: return gmath.gt;
                case ComparisonOpKind.GtEq: return gmath.gteq;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }
    }
}