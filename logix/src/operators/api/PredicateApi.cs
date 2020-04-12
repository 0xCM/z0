//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    using static Seed;    
    using static Memories;
    using static OpHelpers;

    //[ApiHost("predicate.api", ApiHostKind.Generic)]
    public static class PredicateApi
    {
        /// <summary>
        /// Specifies the supported comparison predicates
        /// </summary>
        public static ReadOnlySpan<BinaryComparisonKind> ComparisonKinds
            => array(
                BinaryComparisonKind.Eq, BinaryComparisonKind.Neq, 
                BinaryComparisonKind.Lt, BinaryComparisonKind.LtEq, 
                BinaryComparisonKind.Gt, BinaryComparisonKind.GtEq );


        [Op, NumericClosures(NumericKind.Integers)]
        public static bit eval<T>(BinaryComparisonKind kind, T a, T b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BinaryComparisonKind.Eq: return gmath.eq(a,b);
                case BinaryComparisonKind.Neq: return gmath.neq(a,b);
                case BinaryComparisonKind.Lt: return gmath.lt(a,b);
                case BinaryComparisonKind.LtEq: return gmath.lteq(a,b);
                case BinaryComparisonKind.Gt: return gmath.gt(a,b);
                case BinaryComparisonKind.GtEq: return gmath.gteq(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryPred<T> lookup<T>(BinaryComparisonKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BinaryComparisonKind.Eq: return gmath.eq;
                case BinaryComparisonKind.Neq: return gmath.neq;
                case BinaryComparisonKind.Lt: return gmath.lt;
                case BinaryComparisonKind.LtEq: return gmath.lteq;
                case BinaryComparisonKind.Gt: return gmath.gt;
                case BinaryComparisonKind.GtEq: return gmath.gteq;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }
    }
}