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

    using static zfunc;

    using static OpHelpers;

    //[ApiHost("predicate.api", ApiHostKind.Generic)]
    public static class PredicateApi
    {
        /// <summary>
        /// Specifies the supported comparison predicates
        /// </summary>
        public static ReadOnlySpan<ComparisonOpKindId> ComparisonKinds
            => array(
                ComparisonOpKindId.Eq, ComparisonOpKindId.Neq, 
                ComparisonOpKindId.Lt, ComparisonOpKindId.LtEq, 
                ComparisonOpKindId.Gt, ComparisonOpKindId.GtEq );


        [Op, NumericClosures(NumericKind.Integers)]
        public static bit eval<T>(ComparisonOpKindId kind, T a, T b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonOpKindId.Eq: return gmath.eq(a,b);
                case ComparisonOpKindId.Neq: return gmath.neq(a,b);
                case ComparisonOpKindId.Lt: return gmath.lt(a,b);
                case ComparisonOpKindId.LtEq: return gmath.lteq(a,b);
                case ComparisonOpKindId.Gt: return gmath.gt(a,b);
                case ComparisonOpKindId.GtEq: return gmath.gteq(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryPred<T> lookup<T>(ComparisonOpKindId kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonOpKindId.Eq: return gmath.eq;
                case ComparisonOpKindId.Neq: return gmath.neq;
                case ComparisonOpKindId.Lt: return gmath.lt;
                case ComparisonOpKindId.LtEq: return gmath.lteq;
                case ComparisonOpKindId.Gt: return gmath.gt;
                case ComparisonOpKindId.GtEq: return gmath.gteq;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }
    }
}